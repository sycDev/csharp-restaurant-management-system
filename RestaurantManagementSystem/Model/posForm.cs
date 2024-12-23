using RestaurantManagementSystem.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace RestaurantManagementSystem.Model
{
    public partial class posForm : Form
    {
        public posForm()
        {
            InitializeComponent();
        }

        public int orderId = 0;

        public string orderType = "";

        private void powerOffBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCategory()
        {
            string qry = "SELECT * FROM category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            categoryPanel.Controls.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Button categoryBtn = new Button();
                    categoryBtn.BackColor = Color.FromArgb(50, 55, 89);
                    categoryBtn.ForeColor = Color.White;
                    categoryBtn.Size = new Size(226, 50);
                    categoryBtn.FlatStyle = FlatStyle.Flat;
                    categoryBtn.FlatAppearance.BorderSize = 0;
                    categoryBtn.Cursor = Cursors.Hand;
                    categoryBtn.Text = row["categoryName"].ToString();

                    categoryBtn.Click += new EventHandler(categoryBtn_click);

                    categoryPanel.Controls.Add(categoryBtn);
                }
            }
        }

        private void categoryBtn_click(object sender, EventArgs e)
        {
            Button categoryBtn = (Button)sender;

            if (categoryBtn.Text == "All Categories")
            {
                searchTextbox.Text = "1";
                searchTextbox.Text = "";

                return;
            }

            foreach (var item in productPanel.Controls)
            {
                var product = (productUserControl)item;
                product.Visible = product.productCategory.ToLower().Contains(categoryBtn.Text.Trim().ToLower());
            }
        }

        private void posForm_Load(object sender, EventArgs e)
        {
            AddCategory();
            productPanel.Controls.Clear();
            LoadProducts();
        }

        private void AddItem(string id, string productId, string name, string category, string price, Image image)
        {
            var w = new productUserControl()
            {
                productId = Convert.ToInt32(productId),
                productName = name,
                productCategory = category,
                productPrice = price,
                productImage = image
            };

            productPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (productUserControl)ss;

                foreach (DataGridViewRow item in orderDatagrid.Rows)
                {
                    if (Convert.ToInt32(item.Cells["productId"].Value) == wdg.productId)
                    {
                        item.Cells["orderQty"].Value = int.Parse(item.Cells["orderQty"].Value.ToString()) + 1;
                        item.Cells["orderAmount"].Value = (int.Parse(item.Cells["orderQty"].Value.ToString()) * 
                            double.Parse(item.Cells["productPrice"].Value.ToString())).ToString("N2");

                        GetTotal();

                        return;
                    }
                }

                orderDatagrid.Rows.Add(new object[] { 0, 0, wdg.productId, wdg.productName, 1, wdg.productPrice,
                        wdg.productPrice });

                GetTotal();
            };
        }

        private void LoadProducts()
        {
            string qry = "SELECT * FROM product p INNER JOIN category c ON p.categoryId = c.categoryId";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imageArray = (byte[])item["productImage"];
                byte[] imageByteArray = imageArray;

                AddItem("0", item["productId"].ToString(), item["productName"].ToString(), item["categoryName"].ToString(), 
                    item["productPrice"].ToString(), Image.FromStream(new MemoryStream(imageArray)));
            }
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in productPanel.Controls)
            {
                var product = (productUserControl)item;
                product.Visible = product.productName.ToLower().Contains(searchTextbox.Text.Trim().ToLower());
            }
        }

        private void orderDatagrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in orderDatagrid.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void GetTotal()
        {
            double total = 0;
            totalTxtLabel.Text = "";

            foreach (DataGridViewRow item in orderDatagrid.Rows)
            {
                total += double.Parse(item.Cells["orderAmount"].Value.ToString());
            }

            totalTxtLabel.Text = total.ToString("N2");
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            deliveryBtn.BackColor = Color.FromArgb(241, 85, 126);
            takeAwayBtn.BackColor = Color.FromArgb(241, 85, 126);
            dineInBtn.BackColor = Color.FromArgb(241, 85, 126);
            tableLabel.Text = "";
            waiterLabel.Text = "";
            tableLabel.Visible = false;
            waiterLabel.Visible = false;
            orderDatagrid.Rows.Clear();
            orderId = 0;
            totalTxtLabel.Text = "0.00";
            orderType = "";
        }

        private void deliveryBtn_Click(object sender, EventArgs e)
        {
            deliveryBtn.BackColor = Color.FromArgb(50, 55, 89);
            takeAwayBtn.BackColor = Color.FromArgb(241, 85, 126);
            dineInBtn.BackColor = Color.FromArgb(241, 85, 126);
            orderType = "Delivery";
            tableLabel.Text = "";
            waiterLabel.Text = "";
            tableLabel.Visible = false;
            waiterLabel.Visible = false;
        }

        private void takeAwayBtn_Click(object sender, EventArgs e)
        {
            deliveryBtn.BackColor = Color.FromArgb(241, 85, 126);
            takeAwayBtn.BackColor = Color.FromArgb(50, 55, 89);
            dineInBtn.BackColor = Color.FromArgb(241, 85, 126);
            orderType = "Take Away";
            tableLabel.Text = "";
            waiterLabel.Text = "";
            tableLabel.Visible = false;
            waiterLabel.Visible = false;
        }

        private void dineInBtn_Click(object sender, EventArgs e)
        {
            deliveryBtn.BackColor = Color.FromArgb(241, 85, 126);
            takeAwayBtn.BackColor = Color.FromArgb(241, 85, 126);
            dineInBtn.BackColor = Color.FromArgb(50, 55, 89);
            orderType = "Dine In";

            tableSelectForm tFrm = new tableSelectForm();
            MainClass.BlurBackground(tFrm);

            if (tFrm.tableName != "")
            {
                tableLabel.Text = tFrm.tableName;
                tableLabel.Visible = true;
            }
            else
            {
                tableLabel.Text = "";
                tableLabel.Visible = false;
            }

            waiterSelectForm wFrm = new waiterSelectForm();
            MainClass.BlurBackground(wFrm);

            if (wFrm.waiterName != "")
            {
                waiterLabel.Text = wFrm.waiterName;
                waiterLabel.Visible = true;
            }
            else
            {
                waiterLabel.Text = "";
                waiterLabel.Visible = false;
            }
        }

        private void kotBtn_Click(object sender, EventArgs e)
        {
            // Validation for order type selection
            if (orderType == "")
            {
                MessageBox.Show("Please select the order type by clicking button above (Delivery/Take Away/Dine In)", "KOT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            if (orderType == "Dine In")
            {
                if (tableLabel.Text == "")
                {
                    MessageBox.Show("Please select table by clicking the Dine In button again", "KOT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }

                if (waiterLabel.Text == "")
                {
                    MessageBox.Show("Please select waiter by clicking the Dine In button again", "KOT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }
            }

            // Validation for no product been added
            if (orderDatagrid.Rows.Count == 0)
            {
                MessageBox.Show("No product been added yet", "KOT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            string ordersQry = "";
            string orderDetailsQry = "";
            int orderDetailsId = 0;

            if (orderId == 0) // Insert
            {
                ordersQry = @"INSERT INTO orders VALUES(@orderDate, @orderTime, @tableName, @waiterName, @status, 
                                @orderType, @total, @received, @change);
                                SELECT SCOPE_IDENTITY()";
            }
            else // Update
            {
                orderDetailsQry = @"UPDATE orders SET status = @status, total = @total, received = @received, 
                                        change = @change WHERE orderID = @id";
            }

            SqlCommand oCmd = new SqlCommand(ordersQry, MainClass.con);
            oCmd.Parameters.AddWithValue("@id", orderId);
            oCmd.Parameters.AddWithValue("@orderDate", Convert.ToDateTime(DateTime.Now.Date));
            oCmd.Parameters.AddWithValue("@orderTime", DateTime.Now.ToShortTimeString());
            oCmd.Parameters.AddWithValue("@tableName", tableLabel.Text);
            oCmd.Parameters.AddWithValue("@waiterName", waiterLabel.Text);
            oCmd.Parameters.AddWithValue("@status", "Pending");
            oCmd.Parameters.AddWithValue("@orderType", orderType);
            oCmd.Parameters.AddWithValue("@total", Convert.ToDouble(totalTxtLabel.Text));
            // only saving data for kitchen, value will update when payment received
            oCmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            oCmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));

            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (orderId == 0) { orderId = Convert.ToInt32(oCmd.ExecuteScalar()); } else { oCmd.ExecuteNonQuery(); }
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            foreach (DataGridViewRow row in orderDatagrid.Rows)
            {
                orderDetailsId = Convert.ToInt32(row.Cells["orderDetailsId"].Value);

                if (orderDetailsId == 0) // Insert
                {
                    orderDetailsQry = @"INSERT INTO orderDetails VALUES(@orderId, @productId, @qty, @price, @amount)";
                }
                else // Update
                {
                    orderDetailsQry = @"UPDATE orderDetails SET productId = @productId, qty = @qty, price = @price,
                                        amount = @amount WHERE orderDetailsId = @id";
                }

                SqlCommand odCmd = new SqlCommand(orderDetailsQry, MainClass.con);
                odCmd.Parameters.AddWithValue("@orderId", orderId);
                odCmd.Parameters.AddWithValue("@productId", Convert.ToInt32(row.Cells["productId"].Value));
                odCmd.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["orderQty"].Value));
                odCmd.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["productPrice"].Value));
                odCmd.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["orderAmount"].Value));

                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                odCmd.ExecuteNonQuery();
                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }
            }

            MessageBox.Show("Saved Successfully...", "KOT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            orderId = 0;
            orderDatagrid.Rows.Clear();
            deliveryBtn.BackColor = Color.FromArgb(241, 85, 126);
            takeAwayBtn.BackColor = Color.FromArgb(241, 85, 126);
            dineInBtn.BackColor = Color.FromArgb(241, 85, 126);
            tableLabel.Text = "";
            waiterLabel.Text = "";
            tableLabel.Visible = false;
            waiterLabel.Visible = false;
            totalTxtLabel.Text = "0.00";
        }

        private void billListBtn_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new billListViewForm());
        }
    }
}

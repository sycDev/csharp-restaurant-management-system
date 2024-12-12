using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem.Model
{
    public partial class posForm : Form
    {
        public posForm()
        {
            InitializeComponent();
        }

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

        private void AddItem(string id, string name, string category, string price, Image image)
        {
            var w = new productUserControl()
            {
                productId = Convert.ToInt32(id),
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

                orderDatagrid.Rows.Add(new object[] { 0, wdg.productId, wdg.productName, 1, wdg.productPrice,
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

                AddItem(item["productId"].ToString(), item["productName"].ToString(), item["categoryName"].ToString(), 
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
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem.View
{
    public partial class kitchenViewForm : Form
    {
        public kitchenViewForm()
        {
            InitializeComponent();
        }

        private void kitchenViewForm_Load(object sender, EventArgs e)
        {
            GetOrders();
        }

        private void GetOrders()
        {
            mainFlowPanel.Controls.Clear();
            string qry1 = @"SELECT * FROM orders WHERE status = 'Pending'";
            SqlCommand cmd1 = new SqlCommand(qry1, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                FlowLayoutPanel productPanel = new FlowLayoutPanel();
                productPanel.AutoSize = true;
                productPanel.Size = new Size(230, 350);
                productPanel.FlowDirection = FlowDirection.TopDown;
                productPanel.BorderStyle = BorderStyle.FixedSingle;
                productPanel.Margin = new Padding(10, 10, 10, 10);

                FlowLayoutPanel orderDetailsPanel = new FlowLayoutPanel();
                orderDetailsPanel.BackColor = Color.FromArgb(50, 55, 89);
                orderDetailsPanel.AutoSize = true;
                orderDetailsPanel.Size = new Size(230, 125);
                orderDetailsPanel.FlowDirection = FlowDirection.TopDown;
                orderDetailsPanel.Margin = new Padding(0, 0, 0, 0);

                Label tableLb = new Label();
                tableLb.ForeColor = Color.White;
                tableLb.Margin = new Padding(10, 10, 3, 0);
                tableLb.AutoSize = true;

                Label waiterLb = new Label();
                waiterLb.ForeColor = Color.White;
                waiterLb.Margin = new Padding(10, 10, 3, 0);
                waiterLb.AutoSize = true;

                Label timeLb = new Label();
                timeLb.ForeColor = Color.White;
                timeLb.Margin = new Padding(10, 10, 3, 0);
                timeLb.AutoSize = true;

                Label typeLb = new Label();
                typeLb.ForeColor = Color.White;
                typeLb.Margin = new Padding(10, 10, 3, 0);
                typeLb.AutoSize = true;

                Label cusNameLb = new Label();
                cusNameLb.ForeColor = Color.White;
                cusNameLb.Margin = new Padding(10, 10, 3, 0);
                cusNameLb.AutoSize = true;

                Label cusPhoneLb = new Label();
                cusPhoneLb.ForeColor = Color.White;
                cusPhoneLb.Margin = new Padding(10, 10, 3, 0);
                cusPhoneLb.AutoSize = true;

                Label driverlb = new Label();
                driverlb.ForeColor = Color.White;
                driverlb.Margin = new Padding(10, 10, 3, 10);
                driverlb.AutoSize = true;

                if ((dt1.Rows[i]["tableName"].ToString()) == "")
                {
                    tableLb.Text = "Table: -";
                }
                else
                {
                    tableLb.Text = "Table: " + dt1.Rows[i]["tableName"].ToString();
                }

                if ((dt1.Rows[i]["waiterName"].ToString()) == "")
                {
                    waiterLb.Text = "Waiter: -";
                }
                else
                {
                    waiterLb.Text = "Waiter: " + dt1.Rows[i]["waiterName"].ToString();
                }

                if ((dt1.Rows[i]["customerName"].ToString()) == "")
                {
                    cusNameLb.Text = "Customer Name: -";
                }
                else
                {
                    cusNameLb.Text = "Customer Name: " + dt1.Rows[i]["customerName"].ToString();
                }

                if ((dt1.Rows[i]["customerPhone"].ToString()) == "")
                {
                    cusPhoneLb.Text = "Customer Phone: -";
                }
                else
                {
                    cusPhoneLb.Text = "Customer Phone: " + dt1.Rows[i]["customerPhone"].ToString();
                }

                if ((dt1.Rows[i]["driverId"].ToString()) == "0")
                {
                    driverlb.Text = "Driver ID: -";
                }
                else
                {
                    driverlb.Text = "Driver ID: " + dt1.Rows[i]["driverId"].ToString();
                }

                timeLb.Text = "Order Time: " + dt1.Rows[i]["orderTime"].ToString();
                typeLb.Text = "Order Type: " + dt1.Rows[i]["orderType"].ToString();

                orderDetailsPanel.Controls.Add(tableLb);
                orderDetailsPanel.Controls.Add(waiterLb);
                orderDetailsPanel.Controls.Add(timeLb);
                orderDetailsPanel.Controls.Add(typeLb);
                orderDetailsPanel.Controls.Add(cusNameLb);
                orderDetailsPanel.Controls.Add(cusPhoneLb);
                orderDetailsPanel.Controls.Add(driverlb);

                productPanel.Controls.Add(orderDetailsPanel);

                int orderId = 0;
                orderId = Convert.ToInt32(dt1.Rows[i]["orderId"].ToString());
                string qry2 = @"SELECT * FROM orders o INNER JOIN orderDetails d on o.orderId = d.orderId 
                                INNER JOIN product p on p.productId = d.productId WHERE o.orderId = " + orderId + "";

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);

                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    Label label = new Label();
                    label.ForeColor = Color.Black;
                    label.Margin = new Padding(10, 5, 3, 0);
                    label.AutoSize = true;

                    int no = j + 1;

                    label.Text = "" + no + ". " + dt2.Rows[j]["productName"].ToString() + " (" + dt2.Rows[j]["qty"].ToString() + ")";

                    productPanel.Controls.Add(label);
                }

                Button completeBtn = new Button();
                completeBtn.Size = new Size(100, 35);
                completeBtn.ForeColor = Color.White;
                completeBtn.BackColor = Color.FromArgb(241, 85, 126);
                completeBtn.Margin = new Padding(30, 5, 3, 10);
                completeBtn.FlatStyle = FlatStyle.Flat;
                completeBtn.FlatAppearance.BorderSize = 0;
                completeBtn.Cursor = Cursors.Hand;
                completeBtn.Text = "Complete";
                completeBtn.Tag = dt1.Rows[i]["orderId"].ToString();
                completeBtn.Click += new EventHandler(completeBtn_click);
                productPanel.Controls.Add(completeBtn);

                mainFlowPanel.Controls.Add(productPanel);
            }
        }

        private void completeBtn_click(object sender, EventArgs e)
        {
            DialogResult completeConfirmationResult = MessageBox.Show("Are you sure you want to complete this order?", 
                "Complete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (completeConfirmationResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32((sender as Button).Tag.ToString());
                string qry = "UPDATE orders SET status = 'Complete' WHERE orderId = " + id + "";
                Hashtable ht = new Hashtable();
                ht.Add("@id", id);

                if (MainClass.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Order is completed...", "Kitchen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                GetOrders();
            }
        }
    }
}

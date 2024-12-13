using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem.Model
{
    public partial class tableSelectForm : Form
    {
        public tableSelectForm()
        {
            InitializeComponent();
        }

        public string tableName;

        private void tableSelectForm_Load(object sender, EventArgs e)
        {
            string qry = "SELECT * FROM tables";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Button tableBtn = new Button();
                tableBtn.BackColor = Color.FromArgb(50, 55, 89);
                tableBtn.ForeColor = Color.White;
                tableBtn.Size = new Size(150, 50);
                tableBtn.FlatStyle = FlatStyle.Flat;
                tableBtn.FlatAppearance.BorderSize = 0;
                tableBtn.Cursor = Cursors.Hand;
                tableBtn.Text = row["tableName"].ToString();

                tableBtn.Click += new EventHandler(tableBtn_click);
                tableSelectMainPanel.Controls.Add(tableBtn);
            }
        }

        private void tableBtn_click(object sender, EventArgs e)
        {
            tableName = (sender as Button).Text.ToString();
            this.Close();
        }
    }
}

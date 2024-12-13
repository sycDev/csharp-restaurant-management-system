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
    public partial class waiterSelectForm : Form
    {
        public waiterSelectForm()
        {
            InitializeComponent();
        }

        public string waiterName;

        private void waiterSelectForm_Load(object sender, EventArgs e)
        {
            string qry = "SELECT * FROM staff WHERE staffRole = 'Waiter'";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Button waiterBtn = new Button();
                waiterBtn.BackColor = Color.FromArgb(50, 55, 89);
                waiterBtn.ForeColor = Color.White;
                waiterBtn.Size = new Size(150, 50);
                waiterBtn.FlatStyle = FlatStyle.Flat;
                waiterBtn.FlatAppearance.BorderSize = 0;
                waiterBtn.Cursor = Cursors.Hand;
                waiterBtn.Text = row["staffName"].ToString();

                waiterBtn.Click += new EventHandler(waiterBtn_click);
                waiterSelectMainPanel.Controls.Add(waiterBtn);
            }
        }
        private void waiterBtn_click(object sender, EventArgs e)
        {
            waiterName = (sender as Button).Text.ToString();
            this.Close();
        }
    }
}

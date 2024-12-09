using RestaurantManagementSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        public void AddControls(Form f)
        {
            mainPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            mainPanel.Controls.Add(f);
            f.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            AddControls(new homeForm());
        }

        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            AddControls(new categoryViewForm());
        }
    }
}

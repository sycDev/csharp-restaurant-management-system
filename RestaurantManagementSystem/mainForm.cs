using RestaurantManagementSystem.Model;
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

        static mainForm _obj;

        public static mainForm Instance
        {
            get { if (_obj == null) { _obj = new mainForm(); } return _obj; }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            _obj = this;
        }

        public void AddControls(Form f)
        {
            mainPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            mainPanel.Controls.Add(f);
            f.Show();
        }

        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            AddControls(new categoryViewForm());
        }

        private void tablesBtn_Click(object sender, EventArgs e)
        {
            AddControls(new tableViewForm());
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            AddControls(new staffViewForm());
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            AddControls(new productViewForm());
        }

        private void posBtn_Click(object sender, EventArgs e)
        {
            posForm frm = new posForm();
            frm.Show();
        }

        private void kitchenBtn_Click(object sender, EventArgs e)
        {
            AddControls(new kitchenViewForm());
        }
    }
}

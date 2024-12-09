using RestaurantManagementSystem.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem.View
{
    public partial class categoryViewForm : viewFormTemplate
    {
        public categoryViewForm()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "SELECT * FROM category WHERE categoryName LIKE '%" + searchTextbox.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(categoryId);
            lb.Items.Add(categoryName);

            MainClass.LoadData(qry, categoryDatagrid, lb);
        }

        private void categoryViewForm_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            categoryDetailsForm frm = new categoryDetailsForm();
            frm.ShowDialog();
            GetData();
        }

        public override void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}

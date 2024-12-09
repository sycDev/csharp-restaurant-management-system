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
            MainClass.BlurBackground(new categoryDetailsForm());
            GetData();
        }

        public override void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void categoryDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (categoryDatagrid.CurrentCell.OwningColumn.Name == "categoryEdit")
            {
                categoryDetailsForm frm = new categoryDetailsForm();
                frm.id = Convert.ToInt32(categoryDatagrid.CurrentRow.Cells["categoryId"].Value);
                frm.categoryNameTextbox.Text = Convert.ToString(categoryDatagrid.CurrentRow.Cells["categoryName"].Value);
                MainClass.BlurBackground(frm);
                GetData();
            }

            if (categoryDatagrid.CurrentCell.OwningColumn.Name == "categoryDelete")
            {
                DialogResult deleteConfirmationResult = MessageBox.Show("Are you sure you want to delete this category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteConfirmationResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(categoryDatagrid.CurrentRow.Cells["categoryId"].Value);
                    string qry = "DELETE FROM category WHERE categoryId = " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(qry, ht);
                    MessageBox.Show("Deleted Successfully...", "Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetData();
                }
            }
        }
    }
}

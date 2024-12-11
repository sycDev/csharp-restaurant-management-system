using RestaurantManagementSystem.Model;
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
using System.Windows.Forms;

namespace RestaurantManagementSystem.View
{
    public partial class productViewForm : viewFormTemplate
    {
        public productViewForm()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "SELECT p.productId, p.productName, p.productPrice, p.categoryId, c.categoryName, p.productImage FROM product p INNER JOIN category c ON c.categoryId = p.categoryId WHERE p.productName LIKE '%" + searchTextbox.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(productId);
            lb.Items.Add(productName);
            lb.Items.Add(productPrice);
            lb.Items.Add(productCategoryId);
            lb.Items.Add(productCategory);
            lb.Items.Add(productImage);

            MainClass.LoadData(qry, productDatagrid, lb);
        }

        private void productViewForm_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new productDetailsForm());
            GetData();
        }

        public override void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void productDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productDatagrid.CurrentCell.OwningColumn.Name == "productEdit")
            {
                productDetailsForm frm = new productDetailsForm();
                frm.id = Convert.ToInt32(productDatagrid.CurrentRow.Cells["productId"].Value);
                frm.categoryId = Convert.ToInt32(productDatagrid.CurrentRow.Cells["productCategoryId"].Value);
                frm.productNameTextbox.Text = Convert.ToString(productDatagrid.CurrentRow.Cells["productName"].Value);
                frm.productPriceTextbox.Text = Convert.ToString(productDatagrid.CurrentRow.Cells["productPrice"].Value);
                MemoryStream ms = new MemoryStream((byte[])productDatagrid.CurrentRow.Cells["productImage"].Value‌​);
                frm.imagePlaceholder.Image = Image.FromStream(ms);

                MainClass.BlurBackground(frm);
                GetData();
            }

            if (productDatagrid.CurrentCell.OwningColumn.Name == "productDelete")
            {
                DialogResult deleteConfirmationResult = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteConfirmationResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(productDatagrid.CurrentRow.Cells["productId"].Value);
                    string qry = "DELETE FROM product WHERE productId = " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(qry, ht);
                    MessageBox.Show("Deleted Successfully...", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetData();
                }
            }
        }
    }
}

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
    public partial class tableViewForm : viewFormTemplate
    {
        public tableViewForm()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "SELECT * FROM tables WHERE tableName LIKE '%" + searchTextbox.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(tableId);
            lb.Items.Add(tableName);

            MainClass.LoadData(qry, tableDatagrid, lb);
        }

        private void tableViewForm_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new tableDetailsForm());
            GetData();
        }

        public override void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void tableDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableDatagrid.CurrentCell.OwningColumn.Name == "tableEdit")
            {
                tableDetailsForm frm = new tableDetailsForm();
                frm.id = Convert.ToInt32(tableDatagrid.CurrentRow.Cells["tableId"].Value);
                frm.tableNameTextbox.Text = Convert.ToString(tableDatagrid.CurrentRow.Cells["tableName"].Value);
                MainClass.BlurBackground(frm);
                GetData();
            }

            if (tableDatagrid.CurrentCell.OwningColumn.Name == "tableDelete")
            {
                DialogResult deleteConfirmationResult = MessageBox.Show("Are you sure you want to delete this table?", "Delete Table", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteConfirmationResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(tableDatagrid.CurrentRow.Cells["tableId"].Value);
                    string qry = "DELETE FROM tables WHERE tableId = " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(qry, ht);
                    MessageBox.Show("Deleted Successfully...", "Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetData();
                }
            }
        }
    }
}

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
    public partial class staffViewForm : viewFormTemplate
    {
        public staffViewForm()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "SELECT * FROM staff WHERE staffName LIKE '%" + searchTextbox.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(staffId);
            lb.Items.Add(staffName);
            lb.Items.Add(staffPhone);
            lb.Items.Add(staffRole);

            MainClass.LoadData(qry, staffDatagrid, lb);
        }

        private void staffViewForm_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new staffDetailsForm());
            GetData();
        }

        public override void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void staffDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (staffDatagrid.CurrentCell.OwningColumn.Name == "staffEdit")
            {
                staffDetailsForm frm = new staffDetailsForm();
                frm.id = Convert.ToInt32(staffDatagrid.CurrentRow.Cells["staffId"].Value);
                frm.staffNameTextbox.Text = Convert.ToString(staffDatagrid.CurrentRow.Cells["staffName"].Value);
                frm.staffPhoneTextbox.Text = Convert.ToString(staffDatagrid.CurrentRow.Cells["staffPhone"].Value);
                frm.staffRoleCombobox.Text = Convert.ToString(staffDatagrid.CurrentRow.Cells["staffRole"].Value);
                MainClass.BlurBackground(frm);
                GetData();
            }

            if (staffDatagrid.CurrentCell.OwningColumn.Name == "staffDelete")
            {
                DialogResult deleteConfirmationResult = MessageBox.Show("Are you sure you want to delete this staff?", "Delete Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteConfirmationResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(staffDatagrid.CurrentRow.Cells["staffId"].Value);
                    string qry = "DELETE FROM staff WHERE staffId = " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(qry, ht);
                    MessageBox.Show("Deleted Successfully...", "Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetData();
                }
            }
        }
    }
}

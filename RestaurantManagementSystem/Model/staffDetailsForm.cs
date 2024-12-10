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

namespace RestaurantManagementSystem.Model
{
    public partial class staffDetailsForm : detailsFormTemplate
    {
        public staffDetailsForm()
        {
            InitializeComponent();
        }

        public int id = 0;

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0) // Insert
            {
                qry = "INSERT INTO staff VALUES(@Name, @Phone, @Role)";
            }
            else // Update
            {
                qry = "UPDATE staff SET staffName = @Name, staffPhone = @Phone, staffRole = @Role WHERE staffId = @ID";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@ID", id);
            ht.Add("@Name", staffNameTextbox.Text);
            ht.Add("@Phone", staffPhoneTextbox.Text);
            ht.Add("@Role", staffRoleCombobox.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved Successfully...", "Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = 0;
                this.Close();
            }
        }
    }
}

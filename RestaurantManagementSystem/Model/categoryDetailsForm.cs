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
    public partial class categoryDetailsForm : detailsFormTemplate
    {
        public categoryDetailsForm()
        {
            InitializeComponent();
        }

        public int id = 0;

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0) // Insert
            {
                qry = "INSERT INTO category VALUES(@Name)";
            }
            else // Update
            {
                qry = "UPDATE category SET categoryName = @Name WHERE categoryId = @ID";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@ID", id);
            ht.Add("@Name", categoryNameTextbox.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved Successfully...", "Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = 0;
                this.Close();
            }
        }
    }
}

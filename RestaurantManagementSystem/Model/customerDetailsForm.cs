using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RestaurantManagementSystem.Model
{
    public partial class customerDetailsForm : detailsFormTemplate
    {
        public customerDetailsForm()
        {
            InitializeComponent();
        }

        public string orderType = "";

        public int orderId = 0;

        public int driverId = 0;

        public string cusName = "";

        public string cusPhone = "";

        private void customerDetailsForm_Load(object sender, EventArgs e)
        {
            if (orderType == "Take Away")
            {
                driverLabel.Visible = false;
                driverCombobox.Visible = false;
            }

            string qry = "SELECT staffId 'id', staffName 'name' FROM staff WHERE staffRole = 'Driver'";
            MainClass.comboboxFill(qry, driverCombobox);

            if (orderId > 0)
            {
                driverCombobox.SelectedValue = driverId;
            }
        }

        private void driverCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            driverId = Convert.ToInt32(driverCombobox.SelectedValue);
        }
    }
}

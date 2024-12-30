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
    public partial class checkoutDetailsForm : detailsFormTemplate
    {
        public checkoutDetailsForm()
        {
            InitializeComponent();
        }

        public double amount;

        public int orderId = 0;

        public event EventHandler ProcessSuccessful;

        private void receivedTextbox_TextChanged(object sender, EventArgs e)
        {
            double amt = 0;
            double received = 0;
            double change = 0;

            double.TryParse(amountTextbox.Text, out amt);
            double.TryParse(receivedTextbox.Text, out received);

            change = received - amt;
            changeTextbox.Text = change.ToString("N2");
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            string qry = @"UPDATE orders SET total = @total, received = @received, change = @change, status = 'Paid' WHERE orderId = @id";
            Hashtable ht = new Hashtable();
            ht.Add("@id", orderId);
            ht.Add("@total", amountTextbox.Text);
            ht.Add("@received", receivedTextbox.Text);
            ht.Add("@change", changeTextbox.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                OnProcessSuccessful();
                this.Close();
            }
            else
            {
                MessageBox.Show("An error occurred during the checkout process", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void OnProcessSuccessful()
        {
            ProcessSuccessful?.Invoke(this, EventArgs.Empty);
        }

        private void checkoutDetailsForm_Load(object sender, EventArgs e)
        {
            amountTextbox.Text = amount.ToString("N2");
        }
    }
}

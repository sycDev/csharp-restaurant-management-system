using System;
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
    public partial class billListViewForm : Form
    {
        public billListViewForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void billListViewForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string qry = @"SELECT orderId, tableName, waiterName, orderType, status, total FROM orders WHERE status <> 'Pending'";
            ListBox lb = new ListBox();
            lb.Items.Add(orderId);
            lb.Items.Add(tableName);
            lb.Items.Add(waiterName);
            lb.Items.Add(orderType);
            lb.Items.Add(orderStatus);
            lb.Items.Add(orderTotal);

            MainClass.LoadData(qry, orderDatagrid, lb);
        }
    }
}

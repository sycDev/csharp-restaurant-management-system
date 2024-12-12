using System;
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
    public partial class productUserControl : UserControl
    {
        public productUserControl()
        {
            InitializeComponent();
        }

        public event EventHandler onSelect = null;

        public int productId { get; set; }

        public string productPrice { get; set; }

        public string productCategory { get; set; }

        public string productName
        {
            get { return pNameLabel.Text; }
            set { pNameLabel.Text = value; }
        }

        public Image productImage
        {
            get { return pImage.Image; }
            set { pImage.Image = value; }
        }

        private void pImage_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}

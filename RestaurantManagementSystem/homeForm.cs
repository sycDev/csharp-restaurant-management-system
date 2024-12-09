using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        private void homeForm_Load(object sender, EventArgs e)
        {
            unameDisplayLabel.Text = MainClass.USER;
        }
    }
}

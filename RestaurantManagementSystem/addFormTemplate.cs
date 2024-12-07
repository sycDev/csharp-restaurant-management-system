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
    public partial class addFormTemplate : Form
    {
        public addFormTemplate()
        {
            InitializeComponent();
        }

        public virtual void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

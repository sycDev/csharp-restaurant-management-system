using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem.Model
{
    public partial class productDetailsForm : detailsFormTemplate
    {
        public productDetailsForm()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int categoryId = 0;
        string filePath;
        Byte[] imageByteArray;

        private void productDetailsForm_Load(object sender, EventArgs e)
        {
            string qry = "SELECT categoryId 'id', categoryName 'name' FROM category";

            MainClass.comboboxFill(qry, productCategoryCombobox);

            if (categoryId > 0)
            {
                productCategoryCombobox.SelectedValue = categoryId;
            }
        }

        private void browseImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)|* .png; *.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                imagePlaceholder.Image = new Bitmap(filePath);
            }
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0) // Insert
            {
                qry = "INSERT INTO product VALUES(@Name, @Price, @Category, @Image)";
            }
            else // Update
            {
                qry = "UPDATE product SET productName = @Name, productPrice = @Price, categoryId = @Category, productImage = @Image WHERE productId = @ID";
            }

            Image temp = new Bitmap(imagePlaceholder.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@ID", id);
            ht.Add("@Name", productNameTextbox.Text);
            ht.Add("@Price", productPriceTextbox.Text);
            ht.Add("@Category", Convert.ToInt32(productCategoryCombobox.SelectedValue));
            ht.Add("@Image", imageByteArray);

            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved Successfully...", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = 0;
                this.Close();
            }
        }
    }
}

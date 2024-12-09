using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    internal class MainClass
    {
        public static readonly string con_string = "Data Source=DESKTOP-IFSOD3D; Initial Catalog=db_irestaurant; Integrated Security=True;";
        public static SqlConnection con = new SqlConnection(con_string);

        // Method for checking user validation
        public static bool IsValidUser(string user, string password)
        {
            bool isValid = false;
            string qry = @"SELECT * FROM users WHERE username = '" + user + "' and password = '" + password + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                USER = dt.Rows[0]["username"].ToString();
            }

            return isValid;
        }

        public static string user;

        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }

        // Method for CURD operation
        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }

                if (con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close();  }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

            return res;
        }

        // For loading data from database
        public static void LoadData(string qry, DataGridView dgv, ListBox lb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colName1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    dgv.Columns[colName1].DataPropertyName = dt.Columns[i].ToString();
                }

                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
    }
}

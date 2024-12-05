using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            }

            return isValid;
        }
    }
}

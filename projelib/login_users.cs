using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace projelib
{
    class login_users
    {
        string password = "", username = "", user_type = "";

        public string passwordsg
        {
            set { password = value; }
            get { return password; }
        }



        public string usernamesg
        {
            set { username = value; }
            get { return  username; }
        }

        public string user_typesg
        {
            set { user_type = value; }
            get { return user_type; }
        }

        public DataTable search()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|datadirectory|\\msvlibdb1.mdf;Integrated Security=True");
            SqlDataAdapter adap1 = new SqlDataAdapter("search_users", con);
            adap1.SelectCommand.CommandType = CommandType.StoredProcedure;

            adap1.SelectCommand.Parameters.AddWithValue("@password", password);
            adap1.SelectCommand.Parameters.AddWithValue("@username", username);

            DataTable dtb = new DataTable();
            adap1.Fill(dtb);

            return dtb;


        }


        

    }
}

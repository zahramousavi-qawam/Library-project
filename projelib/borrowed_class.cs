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
    class borrowed_class
    {


        private string stu_code = "", bk_code = "", date_borrowed = "", date_back = "";




        public string stu_codesg
        {
            set { stu_code = value; }
            get { return stu_code; }
        }

        public string bk_codesg
        {
            set { bk_code = value; }
            get { return bk_code; }
        }


        public string date_borrowesg
        {
            set { date_borrowed = value; }
            get { return date_borrowed; }
        }

        public string date_backsg
        {
            set { date_back = value; }
            get { return date_back; }
        }




        public void insert_borrowed_book()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|datadirectory|\\msvlibdb1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("borrowed",con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@stu_code", stu_code);
            cmd.Parameters.AddWithValue("@bk_code", bk_code);
            cmd.Parameters.AddWithValue("@date_borrowed", date_borrowed);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("BORROWED");
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }



        }





        public void update_back_book()
        {
            SqlConnection con2 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|datadirectory|\\msvlibdb1.mdf;Integrated Security=True");
            SqlCommand com2 = new SqlCommand("back_book_borrowed",con2);
            com2.CommandType = CommandType.StoredProcedure;

            com2.Parameters.AddWithValue("@bk_code", bk_code);
            com2.Parameters.AddWithValue("@stu_code", stu_code);
            com2.Parameters.AddWithValue("@date_back", date_back);

            try
            {
                con2.Open();
                com2.ExecuteNonQuery();
                con2.Close();
                MessageBox.Show("The BOOK Was Returned *SUCCESSFULLY*");
            }
            
            catch (SqlException er)
            {
                MessageBox.Show(er.Message);
            }

        }








    }
}

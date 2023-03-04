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
    class book_insert_class
    {
        private string bk_code = "", bk_name = "", bk_writer = "", bk_publication = "", bk_topic = "", bk_circulation = "", bk_price = "", bk_artist = "", bk_translator = "", bk_numberbook = "";


        public string bk_codesg
        {
            set { bk_code = value; }
            get { return bk_code; }
        }
        public string bk_namesg
        {
            set { bk_name = value; }
            get { return bk_name; }
        }
        public string bk_writersg
        {
            set { bk_writer = value; }
            get { return bk_writer; }
        }
        public string bk_publicationsg
        {
            set { bk_publication = value; }
            get { return bk_publication; }
        }
        public string bk_topicsg
        {
            set { bk_topic = value; }
            get { return bk_topic; }
        }
        public string bk_circulationsg
        {
            set { bk_circulation = value; }
            get { return bk_circulation; }
        }
        public string bk_pricesg
        {
            set { bk_price = value; }
            get { return bk_price; }
        }
        public string bk_artistsg
        {
            set { bk_artist = value; }
            get { return bk_artist; }
        }
        public string bk_translatorsg
        {
            set { bk_translator = value; }
            get { return bk_translator; }
        }
        public string bk_numberbooksg
        {
            set { bk_numberbook = value; }
            get { return bk_numberbook; }
        }


        public void insert_books()
        {
            SqlConnection con1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|datadirectory|\\msvlibdb1.mdf;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand("insert_book", con1);
            cmd1.CommandType = CommandType.StoredProcedure;

            cmd1.Parameters.AddWithValue("@bk_code", bk_code);
            cmd1.Parameters.AddWithValue("@bk_name", bk_name);
            cmd1.Parameters.AddWithValue("@bk_writer", bk_writer);
            cmd1.Parameters.AddWithValue("@bk_publication", bk_publication);
            cmd1.Parameters.AddWithValue("@bk_topic", bk_topic);
            cmd1.Parameters.AddWithValue("@bk_circulation", bk_circulation);
            cmd1.Parameters.AddWithValue("@bk_price", bk_price);
            cmd1.Parameters.AddWithValue("@bk_artist", bk_artist);
            cmd1.Parameters.AddWithValue("@bk_translator", bk_translator);
            cmd1.Parameters.AddWithValue("@bk_numberbook", bk_numberbook);


            try
            {
                con1.Open();
                cmd1.ExecuteNonQuery();
                con1.Close();
                MessageBox.Show("Book Information Entered In The System :)");
            }
            catch (SqlException )
            {
                MessageBox.Show("tekraaari ast");
            }


        }




        public DataTable search_book_code()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|datadirectory|\\msvlibdb1.mdf;Integrated Security=True");
            SqlDataAdapter adap1 = new SqlDataAdapter("search_by_code_book", con);
            adap1.SelectCommand.CommandType = CommandType.StoredProcedure;

            adap1.SelectCommand.Parameters.AddWithValue("@bkcode", bk_code);

            DataTable dt = new DataTable();
            adap1.Fill(dt);

            return dt;



        }


        public DataSet search_book_name()
        {
            SqlConnection s1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|datadirectory|\\msvlibdb1.mdf;Integrated Security=True");
            SqlDataAdapter adap2 = new SqlDataAdapter("search_book_by_name", s1);
            adap2.SelectCommand.CommandType = CommandType.StoredProcedure;

            adap2.SelectCommand.Parameters.AddWithValue("@bkname", bk_name);
            adap2.SelectCommand.Parameters.AddWithValue("@bkwriter", bk_writer);

            DataSet ds = new DataSet();
            adap2.Fill(ds, "tbl_book");

            return ds;


        }

        public void books_edit()
        {
            SqlConnection b1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|datadirectory|\\msvlibdb1.mdf;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand("book_edit", b1);
            cmd1.CommandType = CommandType.StoredProcedure;

            cmd1.Parameters.AddWithValue("@bk_code", bk_code);
            cmd1.Parameters.AddWithValue("@bk_name", bk_name);
            cmd1.Parameters.AddWithValue("@bk_writer", bk_writer);
            cmd1.Parameters.AddWithValue("@bk_publication", bk_publication);
            cmd1.Parameters.AddWithValue("@bk_topic", bk_topic);
            cmd1.Parameters.AddWithValue("@bk_circulation", bk_circulation);
            cmd1.Parameters.AddWithValue("@bk_price", bk_price);
            cmd1.Parameters.AddWithValue("@bk_artist", bk_artist);
            cmd1.Parameters.AddWithValue("@bk_translator", bk_translator);
            cmd1.Parameters.AddWithValue("@bk_numberbook", bk_numberbook);


            try
            {
                b1.Open();
                cmd1.ExecuteNonQuery();
                b1.Close();
                MessageBox.Show("Books Information UPDATE.......");
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }



        public void update_book_borrowed()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|datadirectory|\\msvlibdb1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("bk_update_borrowed", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bk_code", bk_code);
            cmd.Parameters.AddWithValue("@bk_numberbook", bk_numberbook);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                //  MessageBox.Show("booooooooooooooooooooooook update ...");
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }

        }


        public void delete_bookk()
        {
            SqlConnection con1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|datadirectory|\\msvlibdb1.mdf;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand("delete_book", con1);
            cmd1.CommandType = CommandType.StoredProcedure;

            cmd1.Parameters.AddWithValue("@bk_code", bk_code);
            //cmd1.Parameters.AddWithValue("@bk_name", bk_name);
            //cmd1.Parameters.AddWithValue("@bk_writer", bk_writer);
            //cmd1.Parameters.AddWithValue("@bk_publication", bk_publication);
            //cmd1.Parameters.AddWithValue("@bk_topic", bk_topic);
            //cmd1.Parameters.AddWithValue("@bk_circulation", bk_circulation);
            //cmd1.Parameters.AddWithValue("@bk_price", bk_price);
            //cmd1.Parameters.AddWithValue("@bk_artist", bk_artist);
            //cmd1.Parameters.AddWithValue("@bk_translator", bk_translator);
            //cmd1.Parameters.AddWithValue("@bk_numberbook", bk_numberbook);


            try
            {
                con1.Open();
                cmd1.ExecuteNonQuery();
                con1.Close();
                MessageBox.Show("Book Information DELETE");
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }


        }



    }
}

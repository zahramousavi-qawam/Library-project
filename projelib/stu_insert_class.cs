
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
    class stu_insert_class
    {

        private string stu_number = "", stu_name = "", stu_lname = "", stu_study = "", stu_birth = "", stu_sex = "", stu_status = "", stu_address = "", stu_phone = "", stu_membership = "", stu_favorite = "", stu_reason = "", stu_owned = "", stu_borrowed = "";




        public string stu_numbersg
        {
            set { stu_number = value; }
            get { return stu_number; }
        }
        public string stu_namesg
        {
            set { stu_name = value; }
            get { return stu_name; }
        }

        public string stu_lnamesg
        {
            set { stu_lname = value; }
            get { return stu_lname; }
        }
        public string stu_studysg
        {
            set { stu_study = value; }
            get { return stu_study; }
        }
        public string stu_birthsg
        {
            set { stu_birth = value; }
            get { return stu_birth; }
        }
        public string stu_sexsg
        {
            set { stu_sex = value; }
            get { return stu_sex; }
        }
        public string stu_statussg
        {
            set { stu_status = value; }
            get { return stu_status; }
        }
        public string stu_addresssg
        {
            set { stu_address = value; }
            get { return stu_address; }
        }
        public string stu_phonesg
        {
            set { stu_phone = value; }
            get { return stu_phone; }
        }
        public string stu_membershipsg
        {
            set { stu_membership = value; }
            get { return stu_membership; }
        }
        public string stu_favoritesg
        {
            set { stu_favorite = value; }
            get { return stu_favorite; }
        }
        public string stu_reasonsg
        {
            set { stu_reason = value; }
            get { return stu_reason; }
        }
        public string stu_ownedsg
        {
            set { stu_owned = value; }
            get { return stu_owned; }
        }
        public string stu_borrowedsg
        {
            set { stu_borrowed = value; }
            get { return stu_borrowed; }
        }

        public void insert_student()
        {
            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = |datadirectory|\\msvlibdb1.mdf; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("insert_stu", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@stu_number", stu_number);
            cmd.Parameters.AddWithValue("@stu_name", stu_name);
            cmd.Parameters.AddWithValue("@stu_lname", stu_lname);
            cmd.Parameters.AddWithValue("@stu_study", stu_study);
            cmd.Parameters.AddWithValue("@stu_birth", stu_birth);
            cmd.Parameters.AddWithValue("@stu_sex", stu_sex);
            cmd.Parameters.AddWithValue("@stu_status", stu_status);
            cmd.Parameters.AddWithValue("@stu_address", stu_address);
            cmd.Parameters.AddWithValue("@stu_phone", stu_phone);
            cmd.Parameters.AddWithValue("@stu_membership", stu_membership);
            cmd.Parameters.AddWithValue("@stu_favorite", stu_favorite);
            cmd.Parameters.AddWithValue("@stu_reason", stu_reason);
            cmd.Parameters.AddWithValue("@stu_owned", stu_owned);
            cmd.Parameters.AddWithValue("@stu_borrowed", stu_borrowed);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Information Entered In The System :)");
            }
            catch (SqlException )
            {
                MessageBox.Show("tekrariiiii");
            }



        }


        public DataTable search_student_id()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|datadirectory|\\msvlibdb1.mdf;Integrated Security=True");
            SqlDataAdapter adap1 = new SqlDataAdapter("search_by_ID_student", con);
            adap1.SelectCommand.CommandType = CommandType.StoredProcedure;

            adap1.SelectCommand.Parameters.AddWithValue("@stu_number", stu_number);

            DataTable datatbl1 = new DataTable();
            adap1.Fill(datatbl1);

            return datatbl1;

        }





        public void student_edit()
        {

            SqlConnection zz = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|datadirectory|\\msvlibdb1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("stu_edit", zz);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@stu_number", stu_number);
            cmd.Parameters.AddWithValue("@stu_name", stu_name);
            cmd.Parameters.AddWithValue("@stu_lname", stu_lname);
            cmd.Parameters.AddWithValue("@stu_study", stu_study);
            cmd.Parameters.AddWithValue("@stu_birth", stu_birth);
            cmd.Parameters.AddWithValue("@stu_sex", stu_sex);
            cmd.Parameters.AddWithValue("@stu_status", stu_status);
            cmd.Parameters.AddWithValue("@stu_address", stu_address);
            cmd.Parameters.AddWithValue("@stu_phone", stu_phone);
            cmd.Parameters.AddWithValue("@stu_membership", stu_membership);
            cmd.Parameters.AddWithValue("@stu_favorite", stu_favorite);
            cmd.Parameters.AddWithValue("@stu_reason", stu_reason);
            cmd.Parameters.AddWithValue("@stu_owned", stu_owned);
            cmd.Parameters.AddWithValue("@stu_borrowed", stu_borrowed);

            try
            {
                zz.Open();
                cmd.ExecuteNonQuery();
                zz.Close();
                MessageBox.Show("Student Information Update..........");
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }



        public void update_numbers_borrowed()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|datadirectory|\\msvlibdb1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("borrowedd",con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@stu_number", stu_number);
            cmd.Parameters.AddWithValue("@stu_borrowed", stu_borrowed);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ADD NUMBWERS BORROWED");
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void update_student_borrowed()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|datadirectory|\\msvlibdb1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("stu_update_borrowed",con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@stu_number",stu_number);
            cmd.Parameters.AddWithValue("@stu_borrowed",stu_borrowed);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("student update ...");
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        


    }

        public void delete_studentt()
        {
            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = |datadirectory|\\msvlibdb1.mdf; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("delete_student", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@stu_number", stu_number);
           // cmd.Parameters.AddWithValue("@stu_name", stu_name);
         //   cmd.Parameters.AddWithValue("@stu_lname", stu_lname);
         //   cmd.Parameters.AddWithValue("@stu_study", stu_study);
           // cmd.Parameters.AddWithValue("@stu_birth", stu_birth);
          //  cmd.Parameters.AddWithValue("@stu_sex", stu_sex);
          //  cmd.Parameters.AddWithValue("@stu_status", stu_status);
           // cmd.Parameters.AddWithValue("@stu_address", stu_address);
           // cmd.Parameters.AddWithValue("@stu_phone", stu_phone);
           // cmd.Parameters.AddWithValue("@stu_membership", stu_membership);
          //  cmd.Parameters.AddWithValue("@stu_favorite", stu_favorite);
           // cmd.Parameters.AddWithValue("@stu_reason", stu_reason);
           // cmd.Parameters.AddWithValue("@stu_owned", stu_owned);
       //     cmd.Parameters.AddWithValue("@stu_borrowed", stu_borrowed);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Information DELETE");
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }


        }









    }

}


        




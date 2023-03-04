using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projelib
{
    public partial class stupage : Form
    {
        string student_id_sarasari;
        public stupage(string student_id)
        {
            InitializeComponent();
            student_id_sarasari = student_id;
        }

        private void stupage_Load(object sender, EventArgs e)
        {
            stu_insert_class w = new stu_insert_class();
            w.stu_numbersg = student_id_sarasari;
            DataTable dtb = w.search_student_id();

            if (dtb.Rows[0]["stu_sex"].ToString() == "female")
                this.Text = "MISS" + dtb.Rows[0]["stu_name"].ToString() + "" + dtb.Rows[0]["stu_lname"].ToString() + "*WELL COOOOOME*";
            else
                this.Text= "SIR" + dtb.Rows[0]["stu_name"].ToString() + "" + dtb.Rows[0]["stu_lname"].ToString() + "*WELL COOOOOME*";
        }

        private void stupagebtnsearch_Click(object sender, EventArgs e)
        {
            book_insert_class book1 = new book_insert_class();

            book1.bk_namesg = stupagetextname.Text;
            book1.bk_writersg = stupagetextauthor.Text;
            if (stupagetextname.Text!="" && stupagetextauthor.Text!="")
            {
                DataSet ds = book1.search_book_name();
                dataGridbook.AutoGenerateColumns = true;
                dataGridbook.DataSource = ds.Tables["tbl_book"];
            }
        }
    }
}

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
    public partial class logpage : Form
    {
        public logpage()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            login_users z = new login_users();
            z.usernamesg = logintextuser.Text;
            z.passwordsg = logintextpassword.Text;

            DataTable dtb = z.search();

            if (dtb.Rows.Count == 0)
                MessageBox.Show("ESHTEBAAAAAAH");
            else if (dtb.Rows[0]["user_type"].ToString() == "student")
            {
                stupage p = new stupage(logintextuser.Text);
                p.Show();
            }
            else if (dtb.Rows[0]["user_type"].ToString() == "masoollib")
            {
                masoollib p = new masoollib();
                p.Show();
            }
        }
    }
}

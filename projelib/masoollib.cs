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
    public partial class masoollib : Form
    {
        public masoollib()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tb1insertstu_Click(object sender, EventArgs e)
        {
            stu_insert_class z = new stu_insert_class();
            z.stu_numbersg = tb1textnumber.Text;
            z.stu_namesg = tb1textname.Text;
            z.stu_lnamesg = tb1textlname.Text;
            z.stu_studysg = tb1combostudy.Text;
            z.stu_birthsg = tb1comboyear.Text + "/" + tb1combomonth.Text + "/" + tb1comboday.Text;
            if (radiofemale.Checked == true)
                z.stu_sexsg = "female";
            else if (radioman.Checked == true)
                z.stu_sexsg = "Man";

            if (radiosingle.Checked == true)
                z.stu_statussg = "Single";
            else if (radiomarried.Checked == true)
                z.stu_statussg = "Married";
            z.stu_addresssg = tb1textaddress.Text;
            z.stu_phonesg = tb1textphone.Text;
            z.stu_membershipsg = tb1textmembership.Text;
            z.stu_favoritesg = tb1textfavorite.Text;
            z.stu_reasonsg = tb1comboreason.Text;
            z.stu_ownedsg = tb1textowned.Text;
            z.stu_borrowedsg = "0";

            z.insert_student();

            tb1textnumber.Text = "";
            tb1textname.Text = "";
            tb1textlname.Text = "";
            tb1combostudy.Text = "";
            tb1comboday.Text = "";
            tb1combomonth.Text = "";
            tb1comboyear.Text = "";
            radiofemale.Checked = false;
            radioman.Checked = false;
            radiomarried.Checked= false;
            radiosingle.Checked = false;
            tb1textaddress.Text = "";
            tb1textphone.Text = "";
            tb1textmembership.Text = "";
            tb1textfavorite.Text = "";
            tb1comboreason.Text = "";
            tb1textowned.Text = "";
            





        }

        private void tb3insertbook_Click(object sender, EventArgs e)
        {
            book_insert_class b = new book_insert_class();
            b.bk_codesg = tb3textcode.Text;
            b.bk_namesg = tb3textname.Text;
            b.bk_writersg = tb3textwriter.Text;
            b.bk_publicationsg = tb3textpublication.Text;
            b.bk_topicsg = tb3texttopic.Text;
            b.bk_circulationsg = tb3textcirculation.Text;
            b.bk_pricesg = tb3textprice.Text;
            b.bk_artistsg = tb3textartist.Text;
            b.bk_translatorsg = tb3texttranslator.Text;
            b.bk_numberbooksg = tb3textnumber.Text;

            b.insert_books();

            tb3textcode.Text = "";
            tb3textname.Text = "";
            tb3textwriter.Text = "";
            tb3textpublication.Text = "";
            tb3texttopic.Text = "";
            tb3textcirculation.Text = "";
            tb3textprice.Text = "";
            tb3textartist.Text = "";
            tb3texttranslator.Text = "";
            tb3textnumber.Text = "";
        }

        private void tb2btnsearch_Click(object sender, EventArgs e)
        {
            stu_insert_class k1 = new stu_insert_class();
            k1.stu_numbersg = tb2textsearch.Text;
            DataTable datatbl1 = k1.search_student_id();

            if (datatbl1.Rows.Count == 0)
                MessageBox.Show("Does Not Exist ... !");
            else
            {
                panel1.Enabled = true;

                tb2textname.Text = datatbl1.Rows[0]["stu_name"].ToString();
                tb2textlname.Text = datatbl1.Rows[0]["stu_lname"].ToString();
                tb2combostudy.Text = datatbl1.Rows[0]["stu_study"].ToString();

                string[] bd = datatbl1.Rows[0]["stu_birth"].ToString().Split('/');
                tb2comboyear.Text = bd[0];
                tb2combomonth.Text = bd[1];
                tb2comboday.Text = bd[2];


                if (datatbl1.Rows[0]["stu_sex"].ToString() == "female")
                    tb2radiofemale.Checked = true;
                else if (datatbl1.Rows[0]["stu_sex"].ToString() == "man")
                    tb2radioman.Checked = true;

                if (datatbl1.Rows[0]["stu_status"].ToString() == "single")
                    tb2radiosingle.Checked = true;
                else if (datatbl1.Rows[0]["stu_status"].ToString() == "Married")
                    tb2radiomarried.Checked = true;

                tb2textaddress.Text = datatbl1.Rows[0]["stu_address"].ToString();
                tb2textphone.Text = datatbl1.Rows[0]["stu_phone"].ToString();
                tb2textmembership.Text = datatbl1.Rows[0]["stu_membership"].ToString();
                tb2textfavorite.Text = datatbl1.Rows[0]["stu_favorite"].ToString();
                tb2comboreason.Text = datatbl1.Rows[0]["stu_reason"].ToString();

                tb2textowned.Text = datatbl1.Rows[0]["stu_owned"].ToString();
                tb2textborrowed.Text = datatbl1.Rows[0]["stu_borrowed"].ToString();



            }





        }

        private void tb2textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb4btnSearch_Click(object sender, EventArgs e)
        {
            book_insert_class s1 = new book_insert_class();
            s1.bk_codesg = tb4textsearch.Text;
            DataTable dt = s1.search_book_code();

            if (dt.Rows.Count == 0)
                MessageBox.Show("Does Not Exist ... !");
            else
            {
                panel2.Enabled = true;

                tb4textname.Text = dt.Rows[0]["bk_name"].ToString();
                tb4textwriter.Text = dt.Rows[0]["bk_writer"].ToString();
                tb4textpublication.Text = dt.Rows[0]["bk_publication"].ToString();
                tb4texttopic.Text = dt.Rows[0]["bk_topic"].ToString();
                tb4textcirculation.Text = dt.Rows[0]["bk_circulation"].ToString();
                tb4textprice.Text = dt.Rows[0]["bk_price"].ToString();
                tb4textartist.Text = dt.Rows[0]["bk_artist"].ToString();
                tb4texttranslator.Text = dt.Rows[0]["bk_translator"].ToString();
                tb4textnumberbook.Text = dt.Rows[0]["bk_numberbook"].ToString();
                
            }
           
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            
        }

        private void tb2btnedit_Click(object sender, EventArgs e)
        {
            stu_insert_class edit = new stu_insert_class();

           edit.stu_numbersg = tb2textsearch.Text;
            edit.stu_namesg = tb2textname.Text;
            edit.stu_lnamesg = tb2textlname.Text;
            edit.stu_studysg = tb2combostudy.Text;
            edit.stu_birthsg = tb2comboyear.Text + "/" + tb2combomonth.Text + "/" + tb2comboday.Text;
            if (tb2radiofemale.Checked == true)
                edit.stu_sexsg = "female";
            else if (tb2radioman.Checked == true)
                edit.stu_sexsg = "Man";

            if (tb2radiosingle.Checked == true)
                edit.stu_statussg = "Single";
            else if (tb2radiomarried.Checked == true)
                edit.stu_statussg = "Married";
            edit.stu_addresssg = tb2textaddress.Text;
            edit.stu_phonesg = tb2textphone.Text;
            edit.stu_membershipsg = tb2textmembership.Text;
            edit.stu_favoritesg = tb2textfavorite.Text;
            edit.stu_reasonsg = tb2comboreason.Text;
            edit.stu_ownedsg = tb2textowned.Text;
            edit.stu_borrowedsg = tb2textborrowed.Text;

            edit.student_edit();

            tb2textsearch.Text = "";
            tb2textname.Text = "";
            tb2textlname.Text = "";
            tb2combostudy.Text = "";
            tb2radiofemale.Checked = false;
            tb2radioman.Checked = false;
            tb2radiomarried.Checked = false;
            tb2radiomarried.Checked = false;
            tb2comboyear.Text = "";
            tb2combomonth.Text = "";
            tb2comboday.Text = "";
            tb2textaddress.Text = "";
            tb2textphone.Text = "";
            tb2textmembership.Text = "";
            tb2textfavorite.Text = "";
            tb2comboreason.Text = "";
            tb2textowned.Text = "";
            tb2textborrowed.Text = "";








        }

        private void tb4btnedit_Click(object sender, EventArgs e)
        {
            book_insert_class c = new book_insert_class();
            c.bk_codesg = tb4textsearch.Text;
            c.bk_namesg = tb4textname.Text;
            c.bk_writersg = tb4textwriter.Text;
            c.bk_publicationsg = tb4textpublication.Text;
            c.bk_topicsg = tb4texttopic.Text;
            c.bk_circulationsg = tb4textcirculation.Text;
            c.bk_pricesg = tb4textprice.Text;
            c.bk_artistsg = tb4textartist.Text;
            c.bk_translatorsg = tb4texttranslator.Text;
            c.bk_numberbooksg = tb4textnumberbook.Text;

            c.books_edit();
            tb4textsearch.Text = "";
            tb4textname.Text = "";
            tb4textwriter.Text = "";
            tb4textpublication.Text = "";
            tb4texttopic.Text = "";
            tb4textcirculation.Text = "";
            tb4textprice.Text = "";
            tb4textartist.Text = "";
            tb4texttranslator.Text = "";
            tb4textnumberbook.Text  = "";


        }

        private void tb5btnlending_Click(object sender, EventArgs e)
        {
            int tka = 0;
            stu_insert_class k = new stu_insert_class();
            k.stu_numbersg = tb5textstu_number1.Text;

            DataTable dts = k.search_student_id();
            if (dts.Rows.Count == 0)
         
                MessageBox.Show("STUDENT NOT EXIST...!");
            
            else
           
                tka = Convert.ToInt32(dts.Rows[0]["stu_borrowed"].ToString());
           
           


            int akm = 0;
            book_insert_class kk = new book_insert_class();
            kk.bk_codesg = tb5textbk_code1.Text;

            DataTable dtb = kk.search_book_code();
            if (dtb.Rows.Count == 0)
            
                MessageBox.Show("BOOK NOT EXIST...!");
            
            else
            
                akm = Convert.ToInt32(dtb.Rows[0]["bk_code"].ToString());



            //=========================================================

            if (tka < 3 && akm > 0)
            {
                k.stu_numbersg = tb5textstu_number1.Text;
                k.stu_borrowedsg = Convert.ToString(tka + 1);
                k.update_student_borrowed();


                kk.bk_codesg = tb5textbk_code1.Text;
                kk.bk_numberbooksg = Convert.ToString(akm - 1);
                kk.update_book_borrowed();





                borrowed_class z = new borrowed_class();
                z.stu_codesg = tb5textstu_number1.Text;
                z.bk_codesg = tb5textbk_code1.Text;
                z.date_borrowesg = tb5textdate_borrow.Text;
                z.insert_borrowed_book();


            }

            else
            { MessageBox.Show("OverFlow"); }



        }

        private void tb2btndelete_Click(object sender, EventArgs e)
        {
            stu_insert_class del = new stu_insert_class();

            del.stu_numbersg = tb2textsearch.Text;
            del.stu_namesg = tb2textname.Text;
            del.stu_lnamesg = tb2textlname.Text;
            del.stu_studysg = tb2combostudy.Text;
            del.stu_birthsg = tb2comboyear.Text + "/" + tb2combomonth.Text + "/" + tb2comboday.Text;
            if (tb2radiofemale.Checked == true)
                del.stu_sexsg = "female";
            else if (tb2radioman.Checked == true)
                del.stu_sexsg = "Man";

            if (tb2radiosingle.Checked == true)
                del.stu_statussg = "Single";
            else if (tb2radiomarried.Checked == true)
                del.stu_statussg = "Married";
            del.stu_addresssg = tb2textaddress.Text;
            del.stu_phonesg = tb2textphone.Text;
            del.stu_membershipsg = tb2textmembership.Text;
            del.stu_favoritesg = tb2textfavorite.Text;
            del.stu_reasonsg = tb2comboreason.Text;
            del.stu_ownedsg = tb2textowned.Text;
            del.stu_borrowedsg = "0";

            del.delete_studentt();

            tb2textsearch.Text = "";
            tb2textname.Text = "";
            tb2textlname.Text = "";
            //tb2combostudy = "";
            tb2comboyear.Text = "";
            tb2combomonth.Text = "";
            tb2comboday.Text = "";
            tb2textaddress.Text = "";
            tb2textphone.Text = "";
            tb2textmembership.Text = "";
            tb2textfavorite.Text = "";
            tb2comboreason.Text = "";
            tb2textowned.Text = "";





        }

        private void tb5btnreturn_Click(object sender, EventArgs e)
        {
            int tka = 0;
            stu_insert_class k = new stu_insert_class();
            k.stu_numbersg = tb5textstu_number2.Text;

            DataTable dts = k.search_student_id();
            if (dts.Rows.Count == 0)

                MessageBox.Show("STUDENT NOT EXIST...!");

            else

                tka = Convert.ToInt32(dts.Rows[0]["stu_borrowed"].ToString());




            int akm = 0;
            book_insert_class kk = new book_insert_class();
            kk.bk_codesg = tb5textbk_code2.Text;

            DataTable dtb = kk.search_book_code();
            if (dtb.Rows.Count == 0)

                MessageBox.Show("BOOK NOT EXIST...!");

            else

                akm = Convert.ToInt32(dtb.Rows[0]["bk_code"].ToString());



            //=========================================================

        
                k.stu_numbersg = tb5textstu_number2.Text;
                k.stu_borrowedsg = Convert.ToString(tka - 1);
                k.update_student_borrowed();


                kk.bk_codesg = tb5textbk_code2.Text;
                kk.bk_numberbooksg = Convert.ToString(akm + 1);
                kk.update_book_borrowed();

            
                borrowed_class z = new borrowed_class();
                z.stu_codesg = tb5textstu_number2.Text;
                z.bk_codesg = tb5textbk_code2.Text;
                z.date_borrowesg = tb5textreturn.Text;
                z.update_back_book();

            tb5textstu_number2.Text = "";
            tb5textbk_code2.Text = "";
            tb5textreturn.Text = "";
            }

        private void tb4btndelete_Click(object sender, EventArgs e)
        {
            book_insert_class b = new book_insert_class();
            b.bk_codesg = tb4textsearch.Text;
            b.bk_namesg = tb4textname.Text;
            b.bk_writersg = tb4textwriter.Text;
            b.bk_publicationsg = tb4textpublication.Text;
            b.bk_topicsg = tb4texttopic.Text;
            b.bk_circulationsg = tb4textcirculation.Text;
            b.bk_pricesg = tb4textprice.Text;
            b.bk_artistsg = tb4textartist.Text;
            b.bk_translatorsg = tb4texttranslator.Text;
            b.bk_numberbooksg = tb4textnumberbook.Text;

            b.delete_bookk();

            tb4textsearch.Text = "";
            tb4textname.Text = "";
            tb4textwriter.Text = "";
            tb4textpublication.Text = "";
            tb4texttopic.Text = "";
            tb4textcirculation.Text = "";
            tb4textprice.Text = "";
            tb4textartist.Text = "";
            tb4texttranslator.Text = "";
            tb4textnumberbook.Text = "";
        }
    }
    }
    

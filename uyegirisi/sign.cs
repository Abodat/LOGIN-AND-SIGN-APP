using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace uyegirisi
{
    public partial class sign : Form
    {
        OleDbConnection veri = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =veritabani.mdb");
        public sign()
        {
            InitializeComponent();
        }
        public string eml { get; set; }
    
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void sign_Load(object sender, EventArgs e)
        {
            eml = mailtxt.Text.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
           

            if (nametxt.Text!=""  &&  pastxt.Text!=""  &&  passrtxt.Text!=""  &&  mailtxt.Text!="")
            {

                if (pastxt.Text == passrtxt.Text)
                {

                    kontrol kntrl = new kontrol();
                                     
                    //kntrl.Show();
                    //if(kntrl.ktest==true)           
                    veri.Open();

                    OleDbCommand komut = new OleDbCommand("insert into veritabani(ad,şifre,email) values ('" + nametxt.Text.ToString() + "','" + pastxt.Text.ToString() + "','" + mailtxt.Text.ToString() + "')", veri);

                   komut.ExecuteNonQuery();

                   veri.Close();
                  this.Close();
                }
                else
                {
                    MessageBox.Show("Şifreler Uyuşmuyor");
                }
                
            }

            else
            {
                MessageBox.Show("Boş Alanları Doldulurunuz.");
            }

            

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

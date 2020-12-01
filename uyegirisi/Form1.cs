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
    public partial class login : Form
    {
        OleDbConnection veri = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =veritabani.mdb");

        public login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sign signup = new sign();

            signup.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            veri.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = veri;
            komut.CommandText= ("Select * From veritabani");
            OleDbDataReader oku = komut.ExecuteReader();
            Boolean test = false;

            while(oku.Read())
            {
                if(oku["ad"].ToString() == nametxt.Text.ToString() && oku["şifre"].ToString() == passtxt.Text.ToString())
                {
                    test = true;
                }

            }

            if(test == false)
            {
                MessageBox.Show("Kulanıcı adı veya şifre Yanlış");
                this.Close();
            }

            else
            {
                MessageBox.Show("Hoşgeldiniz");
                this.Close();
            }
        }
    }
}

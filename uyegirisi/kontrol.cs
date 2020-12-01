using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace uyegirisi
{
    public partial class kontrol : Form
    {
        public kontrol()
        {
            InitializeComponent();
        }
        public string  onayislemi()
        {
            String karakterler = "0123456789ABCDEFGHIJKLMNOPRSTUVYZ";

            Random rnd = new Random();
            String rkod = "";
            for (int i = 0; i < 5; i++){
                rkod += karakterler[rnd.Next(karakterler.Length)];
            }
            return rkod;
        }
        
        private void kontrol_Load(object sender, EventArgs e)
        {

            //Onaylama Kodu Gönderme
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("giriskontroldenemesi@hotmail.com", "Deneme1234");
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;

            mesaj.To.Add("giriskontroldenemesi@hotmail.com");

            mesaj.From = new MailAddress("giriskontroldenemesi@hotmail.com");
            mesaj.Subject = "Doğrulama kodu. ";
            mesaj.Body = onayislemi();
            istemci.Send(mesaj);
        }
        public Boolean ktest = false;
      
    public void onay_Click(object sender, EventArgs e)
        {
                 

            if (kod.Text == onayislemi())
            {
                MessageBox.Show("kod doğru Başarıyla Kayıt Olunmuştur.");

                ktest = true;
            }
            else
            {
                MessageBox.Show("kod yanlış lütfen tekrar deneyin");
            }
        }
    }
}

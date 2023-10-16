using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ulkeler_ve_baskentleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;
        int puan = 0;
        int sure = 60;

        private void btnSoru_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac <= 10)
            {
                btnSoru.Text = "Sonraki";

                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnSoru.Enabled = false;
                timer1.Start();

            }
            else
            {
                btnSoru.Text = "Yeniden Oyna";

                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSoru.Enabled = true;


            }




            btnA.BackColor = Color.LightGray;
            btnB.BackColor = Color.LightGray;
            btnC.BackColor = Color.LightGray;
            btnD.BackColor = Color.LightGray;




            if (sayac == 1)
            {
                label1.Text = "Türkiye";
                btnA.Text = "İstanbul";
                btnB.Text = "İzmir";
                btnC.Text = "Ankara";
                btnD.Text = "Adana";
                label2.Text = "Ankara";
                pictureBox1.ImageLocation = @"C:\Users\Mikail Gezer\Desktop\c#_dersler\43\resimler\ankara.jpg";
            }

            if (sayac == 2)
            {
                label1.Text = "Almanya";
                btnA.Text = "Köln";
                btnB.Text = "Frankurt";
                btnC.Text = "Stungart";
                btnD.Text = "Berlin";
                label2.Text = "Berlin";
                pictureBox1.ImageLocation = @"C:\Users\Mikail Gezer\Desktop\c#_dersler\43\resimler\berlin.jpeg";
            }

            if (sayac == 3)
            {
                label1.Text = "Mısır";
                btnA.Text = "Kahire";
                btnB.Text = "Dimyat";
                btnC.Text = "İskenderiye";
                btnD.Text = "Süveyş";
                label2.Text = "Kahire";
                pictureBox1.ImageLocation = @"C:\Users\Mikail Gezer\Desktop\c#_dersler\43\resimler\kahire.jpg";
            }

            if (sayac == 4)
            {
                label1.Text = "İspanya";
                btnA.Text = "Madrid";
                btnB.Text = "Barcelona";
                btnC.Text = "Malaga";
                btnD.Text = "Kurtuba";
                label2.Text = "Madrid";
                pictureBox1.ImageLocation = @"C:\Users\Mikail Gezer\Desktop\c#_dersler\43\resimler\madrid.jpg";
            }

            if (sayac == 5)
            {
                label1.Text = "Rusya";
                btnA.Text = "Kazan";
                btnB.Text = "Moskova";
                btnC.Text = "Rostov";
                btnD.Text = "Petersburg";
                label2.Text = "Moskova";
                pictureBox1.ImageLocation = @"C:\Users\Mikail Gezer\Desktop\c#_dersler\43\resimler\moskova.jpg";
            }

            if (sayac == 6)
            {
                label1.Text = "Fransa";
                btnA.Text = "Lyon";
                btnB.Text = "Lille";
                btnC.Text = "Marsilya";
                btnD.Text = "Paris";
                label2.Text = "Paris";
                pictureBox1.ImageLocation = @"C:\Users\Mikail Gezer\Desktop\c#_dersler\43\resimler\paris.jpg";
            }

            if (sayac == 7)
            {
                label1.Text = "Çin";
                btnA.Text = "Makao";
                btnB.Text = "Pekin";
                btnC.Text = "Honk Kong";
                btnD.Text = "Altay";
                label2.Text = "Pekin";
                pictureBox1.ImageLocation = @"C:\Users\Mikail Gezer\Desktop\c#_dersler\43\resimler\pekin.jpg";
            }

            if (sayac == 8)
            {
                label1.Text = "Arabistan";
                btnA.Text = "Mekke";
                btnB.Text = "Medine";
                btnC.Text = "Riyad";
                btnD.Text = "Cidde";
                label2.Text = "Riyad";
                pictureBox1.ImageLocation = @"C:\Users\Mikail Gezer\Desktop\c#_dersler\43\resimler\riyad.jpg";
            }

            if (sayac == 9)
            {
                label1.Text = "İtalya";
                btnA.Text = "Venedik";
                btnB.Text = "Roma";
                btnC.Text = "Floransa";
                btnD.Text = "Milano";
                label2.Text = "Roma";
                pictureBox1.ImageLocation = @"C:\Users\Mikail Gezer\Desktop\c#_dersler\43\resimler\roma.jpg";
            }

            if (sayac == 10)
            {
                label1.Text = "Japonya";
                btnA.Text = "Tokyo";
                btnB.Text = "Hiroshima";
                btnC.Text = "Osaka";
                btnD.Text = "Fukusima";
                label2.Text = "Tokyo";
                pictureBox1.ImageLocation = @"C:\Users\Mikail Gezer\Desktop\c#_dersler\43\resimler\tokyo.jpg";
            }

            if (sayac == 11)
            {
                puan = puan + Convert.ToInt32(lblKalanSure.Text );
                lblpuan.Text = puan.ToString();
                timer1.Stop();
                MessageBox.Show("Puanınız: " + puan.ToString());
                btnSoru.Text = "Yeniden Oyna";

                sayac = 0;
                puan = 0;
                lblpuan.Text = puan.ToString();
                sure = 60;
                lblKalanSure.Text = sure.ToString();

                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSoru.Enabled = true;

            }

                    
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            label3.Text = btnA.Text;
            if (label3 .Text == label2 .Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                btnA.BackColor = Color.Green;
            }
            else
            {
                btnA.BackColor = Color.Red;
            }

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSoru.Enabled = true ;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            label3.Text = btnB.Text;
            if (label3.Text == label2.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                btnB.BackColor = Color.Green;
            }
            else
            {
                btnB.BackColor = Color.Red ;
            }

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSoru.Enabled = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            label3.Text = btnC.Text;
            if (label3.Text == label2.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                btnC.BackColor = Color.Green;
            }
            else
            {
                btnC.BackColor = Color.Red;
            }

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSoru.Enabled = true;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            label3.Text = btnD.Text;
            if (label3.Text == label2.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                btnD.BackColor = Color.Green;
            }
            else
            {
                btnD.BackColor = Color.Red;
            }

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSoru.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Mikail Gezer\Desktop\c#_dersler\43\resimler\duncan.mp3";
            btnA.BackColor = Color.LightGray;
            btnB.BackColor = Color.LightGray;
            btnC.BackColor = Color.LightGray;
            btnD.BackColor = Color.LightGray;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblKalanSure.Text = sure.ToString();

            if (sure == 0)
            {
                timer1.Stop();
                MessageBox.Show("Süreniz bitti");
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSoru.Enabled = true;
                MessageBox.Show("Puanınız: " + puan.ToString());
                btnSoru.Text = "Yeniden Oyna";

                sayac = 0;
                puan = 0;
                lblpuan.Text = puan.ToString();
                sure = 60;
                lblKalanSure.Text = sure.ToString();

                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSoru.Enabled = true;


            }

        }
    }
    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _145_Araba_Yaris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kazanilanPuan = 0;
        int yolHizi = 80;
        int arabaHizi = 100; // benim arabamın hızı

        bool solYon = false;
        bool sagYon = false;
        int digerArabaHizi = 150; // diğer araba hızları

        Random rnd = new Random();


        public void oyunuBaslat()
        {
            btn_oyunuBaslat.Enabled = false;
            carpma.Visible = false;

            lbl_yuksekSkor.Text = Settings1.Default.yuksekSkor.ToString();

            arabaHizi = 50;
            digerArabaHizi = 20;
            kazanilanPuan = 0;

            // arabanın koordinatı - Kendi arabam

            bizimaraba.Left = 220;
            bizimaraba.Top = 350;

            // diğer arabaların başlangıctaki koordinatları.

            araba1.Left = 30;
            araba1.Top = 50;

            araba2.Left = 400;
            araba2.Top = 100;


            solYon = false;
            sagYon = false;


            carpma.Left = 165;
            carpma.Top = 294;


            timer1.Start();

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            oyunuBaslat();
            sesAc();
        }
        private void sesAc()
        {
            SoundPlayer ses = new SoundPlayer();
            string sesYol = Application.StartupPath + "\\getfunky.wav";
            ses.SoundLocation = sesYol;
            ses.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kazanilanPuan++;
            lbl_puan.Text = kazanilanPuan.ToString();

            yol.Top += yolHizi;
            if (yol.Top > 170) { yol.Top = -400; }

            if (solYon) { bizimaraba.Left -= arabaHizi; }
            if (sagYon) { bizimaraba.Left += arabaHizi; }

            if (bizimaraba.Left < 5) { solYon = false; }
            else if (bizimaraba.Left + bizimaraba.Width > 500) { sagYon = false; }


            araba1.Top += arabaHizi;
            araba2.Top += arabaHizi;

            if (araba1.Top > panel1.Height)
            {
                araba1Degistir();
                araba1.Left = rnd.Next(20, 350);
                araba1.Top = rnd.Next(1, 200) * -1;
            }

            if (araba2.Top > panel1.Height)
            {
                araba2Degistir();
                araba2.Left = rnd.Next(400, 750);
                araba2.Top = rnd.Next(1, 200) * -1;

            }
            if (kazanilanPuan > 20) 
            {
                yolHizi = 80; arabaHizi = 75; digerArabaHizi = 30; 
                 
                if (kazanilanPuan > 30) 
                { 
                    yolHizi = 100; arabaHizi = 90; digerArabaHizi = 45; 
                    
                    if (kazanilanPuan > 80) 
                    {
                        yolHizi = 130; arabaHizi = 110; digerArabaHizi = 50;
                    }
                }
            }
            
         


            if (bizimaraba.Bounds.IntersectsWith(araba1.Bounds) || bizimaraba.Bounds.IntersectsWith(araba2.Bounds))
            {
                oyunBitti();

            }
        }
        private void araba1Degistir()
        {
            int sira = rnd.Next(1, 7);

            switch (sira)
            {
                case 1:
                    araba1.Image = Properties.Resources.araba5;
                    break;
                case 2:
                    araba1.Image = Properties.Resources.araba7;
                    break;
                case 3:
                    araba1.Image = Properties.Resources.araba3;
                    break;
                case 4:
                    araba1.Image = Properties.Resources.araba4;
                    break;
                case 5:
                    araba1.Image = Properties.Resources.araba5;
                    break;
                case 6:
                    araba1.Image = Properties.Resources.araba6;
                    break;
                case 7:
                    araba1.Image = Properties.Resources.araba7;
                    break;


            }



        }


        private void araba2Degistir()
        {
            int sira = rnd.Next(1, 7);

            switch (sira)
            {
                case 1:
                    araba2.Image = Properties.Resources.araba5;
                    break;
                case 2:
                    araba2.Image = Properties.Resources.araba7;
                    break;
                case 3:
                    araba2.Image = Properties.Resources.araba3;
                    break;
                case 4:
                    araba2.Image = Properties.Resources.araba4;
                    break;
                case 5:
                    araba2.Image = Properties.Resources.araba5;
                    break;
                case 6:
                    araba2.Image = Properties.Resources.araba6;
                    break;
                case 7:
                    araba2.Image = Properties.Resources.araba7;
                    break;


            }


        }


        private void oyunBitti()
        {
            timer1.Stop();

            if (Convert.ToInt32(lbl_puan.Text) > Convert.ToInt32(Settings1.Default.yuksekSkor.ToString()))
            {
                Settings1.Default.yuksekSkor = lbl_puan.Text;
            }



            btn_oyunuBaslat.Enabled = true;
            carpma.Visible = true;
            bizimaraba.Controls.Add(carpma);
            carpma.Location = new Point(7, -5);
            carpma.BringToFront();
            carpma.BackColor = Color.Transparent;
            MessageBox.Show("Tebrikler kazandığınız puan : " + lbl_puan.Text, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && bizimaraba.Left > 0) { solYon = true; }
            if (e.KeyCode == Keys.Right && bizimaraba.Left + bizimaraba.Width < panel1.Width) { sagYon = true; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left){ solYon = false; }
            if (e.KeyCode == Keys.Right) { sagYon = false; }

        }

        private void btn_oyunuBaslat_Click(object sender, EventArgs e)
        {
            oyunuBaslat();
        }
    }
}

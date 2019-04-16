using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
namespace ajans
{
    public partial class Form1 : Form
    {
        string[] Veriler = new string[100];
        bool GirişKontrol = false;
        bool Kontrol = false;
        int i = 0;
        public string Okuma = @"C:\Users\Ege\Desktop\Desler\1.Sınıf\ajans\Dosya\ege.txt";
        public string Duyuru = @"C:\Users\Ege\Desktop\Desler\1.Sınıf\ajans\Dosya\Duyuru.txt";
        string[] DuyuruDizisi = new string[10];
        string Yazı;
        string []DiziSon = new string[10];
        public Form1()
        {
            InitializeComponent();


            if (File.Exists(Duyuru))
            {
                using (StreamReader DuyuruOku = new StreamReader(Duyuru))
                {
                    string Satır = String.Empty;
                    while ((Satır = DuyuruOku.ReadLine()) != null)
                    {
                        Yazı += Satır;
                    }
                    richTextBox1.Text = Yazı;                                 
                }
            }
            else
            {
                File.Create(Duyuru);
            }
        }

        private void BtnKaydol_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        Random Sayı = new Random();
        public int Taşıma;
        private void BtnGiriş_Click(object sender, EventArgs e)
        {
            for (int c = 0; c < 100; c++)
            {
                if (Kontrol != true)
                {
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                    {

                        using (StreamReader Oku = new StreamReader(Okuma))
                        {
                            string Line = String.Empty;
                            while ((Line = Oku.ReadLine()) != null && i < 100)
                            {
                                Veriler[i] = Line;
                                i++;
                                if (GirişKontrol != true)
                                {
                                    if (Veriler[2] == textBox1.Text && Veriler[3] == textBox2.Text
                                          && Taşıma.ToString()==textBox3.Text)
                                    {
                                        MessageBox.Show("Giriş başarılı");
                                        Form3 form3 = new Form3();
                                        form3.Show();
                                        GirişKontrol = true;
                                        Kontrol = true;
                                    }
                                }
                                if (i == 4)
                                {
                                    i = 0;
                                }
                            }
                        }

                    }
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics PictureBoxSilme = pictureBox1.CreateGraphics();
            PictureBoxSilme.Clear(pictureBox1.BackColor);

            string SayıÜreim = Sayı.Next(1265, 9587).ToString();
            Taşıma = Int16.Parse(SayıÜreim);
            Graphics RobotKontrol = pictureBox1.CreateGraphics();
            Font myfont = new Font(FontFamily.Families[Sayı.Next(100)], 20, FontStyle.Bold);
            SolidBrush fırça = new SolidBrush(Color.FromArgb(Sayı.Next(255), Sayı.Next(255), Sayı.Next(255)));
            RobotKontrol.DrawString(SayıÜreim, myfont, fırça, Sayı.Next(0, 110), Sayı.Next(15));

            /*Graphics Çizgi = this.CreateGraphics();
            Pen Kalem = new Pen(Color.FromArgb(Sayı.Next(255), Sayı.Next(255), Sayı.Next(255)), 3);
            Çizgi.DrawLine(Kalem, 20, 20, 20, 20);*/
            //burda picture box içine nasıl çizgi çekebiliriz

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ajans
{
    public partial class Günlük : Form
    {
        public Günlük()
        {
            InitializeComponent();
        }
        string DosyaYolu = @"C:\Users\egeer\source\repos\ajans\Dosya\Günlük.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            char[] karakterler = veri.ToCharArray();
            foreach (char eleman in karakterler)
            {
                textBox2.Text += Convert.ToChar(eleman + 7).ToString();
                veri = textBox2.Text;
            }
            using (StreamWriter Yaz = File.AppendText(DosyaYolu))
            {
                Yaz.Write(textBox2.Text);
            }
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            using (StreamReader Oku = new StreamReader(DosyaYolu))
            {
                string Boş = String.Empty;
                while ((Boş = Oku.ReadLine()) != null)
                {
                    textBox2.Text = Boş;
                }
            }
            string Sifre = textBox2.Text;
            char[] karakterler2 = Sifre.ToCharArray();
            foreach (char eleman2 in karakterler2)
            {
                textBox3.Text += Convert.ToChar(eleman2 - 7).ToString();
            }
            // texbox2 yi temizletmek istersen burayha bunu yaza bilirsin
            

        }
    }
}

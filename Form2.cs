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

namespace ajans
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //file.exits ile dosyanın var olup olmadığını kontrol ettik ardında ise dosya yok ise file.create ile dosyamızı oluştırduk
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != ""
                && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                if (textBox4.Text == textBox5.Text)
                {
                    string Ad = textBox1.Text;
                    string Soyad = textBox2.Text;
                    string Mail = textBox3.Text;
                    string Şifre = textBox4.Text;
                    string Şifre2 = textBox5.Text;
                    string DoğumTarihi = textBox6.Text;
                    string DosyaPath = @"C:\Users\Ege\Desktop\Desler\1.Sınıf\ajans\Dosya\ege.txt";
                    using (StreamWriter KullanıcıKayıt = File.AppendText(DosyaPath))
                    {
                        KullanıcıKayıt.Write(Ad + " ");
                        KullanıcıKayıt.WriteLine(Soyad);
                        KullanıcıKayıt.WriteLine(DoğumTarihi);
                        KullanıcıKayıt.WriteLine(Mail);
                        KullanıcıKayıt.WriteLine(Şifre + Environment.NewLine);
                    }

                }
                else
                    MessageBox.Show("Şifreler aynı değil");
            }
            else
                MessageBox.Show("Bilgileri tamamlayınız");

        }
    }
}

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
    public partial class İngilizce : Form
    {
        public İngilizce()
        {
            InitializeComponent();
            Kelimeler.Add("");

        }
        List<string> Kelimeler = new List<string>();
        string Englishs = @"C:\Users\Ege\Desktop\Desler\1.Sınıf\ajans\Dosya\İngilizce.txt";
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int Konum = this.listBox1.IndexFromPoint(e.Location);
            if (Konum != System.Windows.Forms.ListBox.NoMatches)
            {

            }
        }
        int i = 0;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            using (StreamWriter KelimeYaz = File.AppendText(Englishs))
            {
                KelimeYaz.Write(textBox2.Text + "- ");
                KelimeYaz.WriteLine(textBox3.Text);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (StreamReader KelimeOku = new StreamReader(Englishs))
            {
                string Değer = String.Empty;
                while ((Değer = KelimeOku.ReadLine()) != null)
                {
                    string[] Ayırma = Değer.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
                    foreach (string Kelime in Ayırma)
                    {
                        if (Kelime.ToLower().Contains(textBox1.Text.ToLower()))
                        {
                            Kelime.Trim();
                            listBox1.Items.Add(Kelime);
                        }
                    }

                }

            }

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {//burada çift tıklanan itemi silmek için kod yazmayı denedim
            if (listBox1.SelectedItem != null)
            {
                using (StreamReader Sil=new StreamReader(Englishs))
                {
                    string Bosmu = String.Empty;
                    if ((Bosmu = Sil.ReadLine()) != null)
                    {
                        for (int i = 0; i < 10; i++)
                        {//ama burada ki if içinde sıkıntı çıktı
                            if (listBox1.SelectedItem.ToString() == Bosmu.ToString())
                            {
                            }
                        }
                    }
                }
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

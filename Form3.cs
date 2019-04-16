using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ajans
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //yeni form oluştur burada
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Radyo radyo = new Radyo();
            radyo.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Günlük günlük = new Günlük();
            günlük.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            İngilizce ing = new İngilizce();
            ing.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

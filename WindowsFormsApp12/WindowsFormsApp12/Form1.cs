using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad,soyad;
            double ort;
            double s1, s2, vize;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            s1 = Convert.ToDouble(textBox3.Text);
            s2 = Convert.ToDouble(textBox4.Text);
            vize = Convert.ToDouble(textBox5.Text);
            ort = (s1 + s2 + vize) / 3;
            listBox1.Items.Add("ad = " + ad + " Soyad = " + soyad + " Ortalama = " + ort);

        }
    }
}

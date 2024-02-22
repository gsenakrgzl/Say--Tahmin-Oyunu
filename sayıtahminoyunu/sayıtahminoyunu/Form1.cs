 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayıtahminoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgelesayi = new Random();
        int sayi, tahminisayi, hak = 3;

        private void button1_Click(object sender, EventArgs e)
        {
            
            int tahminisayi = int.Parse(textBox1.Text);


                if (tahminisayi < sayi)
            {
                hak--;
                MessageBox.Show("Sayıyı bilemediniz.Arttırın.", "ÜZGÜNÜZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label3.Text = "Kalan Hak:" + hak;


            }
            else if(tahminisayi > sayi)
            {
                hak--;
                MessageBox.Show("Sayıyı bilemediniz.Azaltın.", "ÜZGÜNÜZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label3.Text = "Kalan Hak:" + hak;
            }
            else
            {
                MessageBox.Show("Sayıyı bildiniz.", "TEBRİKLER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label3.Text = "Kalan Hak:" + hak;
            }
            if (hak == 0)
            {
                MessageBox.Show("Hakkınız Kalmadı.", "ÜZGÜNÜZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label3.Text = "Kalan Hak:" + hak;
            }
             
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sayi = rastgelesayi.Next(0, 10);
        }
    }
}

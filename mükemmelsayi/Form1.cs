using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mükemmelsayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        int toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(textBox1.Text);
            
            for (int i = 1; i <=sayi/2 ; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }

            }
            if (toplam == sayi)
            {
                MessageBox.Show("GİRİLEN SAYI MÜKEMMEL SAYIDIR.");
            }
            else {
                MessageBox.Show("GİRİLEN SAYI MÜKEMMEL SAYI DEĞİLDİR.");
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            sayi = Convert.ToInt32(textBox1.Text);
            for(int a = 1; a <= sayi; a++)
            {
                if (sayi % a == 0)
                {
                    listBox1.Items.Add(a);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           
            sayi = Convert.ToInt32(textBox1.Text);
            for (int k = 2; k <= sayi; k++)
            {
                toplam = 0;
                for (int j = 1; j <k ; j++)
                {
                    if (k % j == 0)
                    {
                        toplam = toplam + j;
                    }
                }

                if (k == toplam)
                {
                    listBox1.Items.Add(k);
                }
            }
        }
    }
    }


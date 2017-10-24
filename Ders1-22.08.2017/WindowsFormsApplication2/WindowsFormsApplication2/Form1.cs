using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        int salise=0, saniye=0;
        Random rnd = new Random();
        int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = rnd.Next(0, 9).ToString();
            textBox2.Text = rnd.Next(10, 100).ToString();
            timer1.Interval = 10; 
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                if (saniye != 60)
                {
                    if (salise != 30)
                    {
                        salise += 1;
                        label2.Text = salise.ToString();
                    }
                    else if (salise == 30)
                    {
                        salise = 0;
                        saniye++;
                        label1.Text = saniye.ToString();
                    }
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Süreniz doldu");
                }
            }
            else {
                if (saniye != 60)
                {
                    if (salise != 30)
                    {
                        salise += 1;
                        label4.Text = salise.ToString();
                    }
                    else if (salise == 30)
                    {
                        salise = 0;
                        saniye++;
                        label3.Text = saniye.ToString();
                    }
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Süreniz doldu");
                }
            
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                int toplam = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
                if (Convert.ToInt32(textBox3.Text) == toplam)
                    e.Handled = true;
                textBox4.Text = Convert.ToInt32(textBox3.Text).ToString();
                textBox5.Text = rnd.Next(100, 300).ToString();
                saniye = 0;
                salise = 0;
                sayac = 1;
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                int toplam = Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text);
                if (Convert.ToInt32(textBox6.Text) == toplam){
                    timer1.Stop();
                    e.Handled = true;  }
                int t = Convert.ToInt32(label1.Text) + Convert.ToInt32(label3.Text);
                label5.Text = t.ToString();
                int s = Convert.ToInt32(label2.Text) + Convert.ToInt32(label4.Text);
                label6.Text = s.ToString();

            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tekciftsayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            int tekCift = 0, basamakHandler = 0;

            if (radioButton1.Checked)
            {
                tekCift = 1;
            }
            else
            {
                tekCift = 0;
            }

            if (radioButton4.Checked)
            {
                basamakHandler = 1;
            }
            else if (radioButton4.Checked)
            {
                basamakHandler = 10;
            }
            else
            {
                basamakHandler = 100;
            }

            List<int> sayilar = new List<int>();
            Random ran = new Random();
            int ranGelen = 0;
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    do
                    {
                        ranGelen = ran.Next((1 * basamakHandler) - 1, (10 * basamakHandler));
                    } while (ranGelen % 2 != tekCift || ranGelen < basamakHandler);

                } while (checkBox2.Checked && sayilar.Contains(ranGelen));
                sayilar.Add(ranGelen);
            }

            if (checkBox1.Checked)
            {
                sayilar.Sort();
            }

            for (int i = 0; i < sayilar.Count; i++)
            {
                textBox1.Text += sayilar[i] + " ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton4.Checked = true;
        }
    }
}

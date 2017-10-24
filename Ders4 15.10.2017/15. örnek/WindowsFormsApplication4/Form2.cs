using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.toplam_adet.ToString();
            textBox2.Text = Form1.toplam_fiyat.ToString();
        }

        private void Form2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        string param = "";

        private void Form2_DragDrop(object sender, DragEventArgs e)
        {
            string[] veriler = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            StreamReader aktar = new StreamReader(veriler[0]);
            param = aktar.ReadToEnd();

            timer1.Interval = 1000;
            timer1.Start();
        }

        int sayi = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi += 20;
            progressBar1.Value = sayi;

            if (sayi == 100)//progressBar1.Value==100
            {
                timer1.Stop();

                if (Convert.ToInt16(param) > Form1.toplam_fiyat)
                    MessageBox.Show("ödeme gerçekleşti");
                else
                    MessageBox.Show("ödeme gerçekleşemedi !!!!!!");

                
            }
        }
    }
}

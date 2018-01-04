using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ekranayazdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Programı çalıştırdığımız anda ekranda gözükmesini istediğimiz içerikleri Form'a yazarız
            label2.Text = "En Büyük GALATASARAY";
            textBox1.Text = "CİMBOM";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;//label3 e textboxdaki bilgiyi aktarıyor
            for (int i = 0; i < 9; i++) //0-9 arasında bir döngü oluşturuyor
            {
                textBox2.Text += i + " "; //Sayıları 1 boşluk bırakarak yan yana yazdırıyor
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ikisayiarasiniyazdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = ""; //'label5' in Textindeki '...'yı Temizler
            int a = 0, b = 0;
            a = Convert.ToInt16(textBox1.Text); //Sayı Türüne Dönüştürülüyor
            b = Convert.ToInt16(textBox2.Text); //Sayı Türüne Dönüştürülüyor
            for (int i = a+1; i < b; i++) //İki Sayı Arasındaki Sayıları Yazdırmak İçin Döngü Oluşturuluyor
            //İki Sayı Arasındaki Sayılar Yazdırılacağı İçin Döngü Sayının Bir Fazlasından Başlatılıyor
            {
                label5.Text += i+"\n" ; //Sayılar Alt Alta Yazdırılıyor
            }
        }
    }
}

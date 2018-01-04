using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rastgelesayiüretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            Random rastgele = new Random(); //Rastgele Sayı Üretmek İçin Yazılması Gereken Format
            sayi = rastgele.Next(10, 150); //Üretilecek Sayının Kaç ile Kaç Arasında Olması Gerektiği Belirtilir
            label2.Text = sayi.ToString(); //C# da Değişkenler Metin Olarak Algılandığı İçin Sayı Tipine Dönüştürülür
        }
    }
}

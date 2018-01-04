using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ikisayiarasindakitekciftsayilar
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
            int bas = int.Parse(textBox1.Text); //Sayı Türüne Dönüştürülüyor
            int son = int.Parse(textBox2.Text); //Sayı Türüne Dönüştürülüyor
            Random rastgele = new Random(); //Rastgele Sayı Üretmek İçin Yazılması Gereken Format
            for (int i = 0; i < 10; i++) // Rastgele 10 Sayı Üretmek İçin For Döngüsü Kuruluyor
            {
                sayi = rastgele.Next(bas, son); //Üretilecek Sayının Kaç ile Kaç Arasında Olması Gerektiği Belirtilir
                if (sayi % 2 == 0) //Sayının Çift Olup Olmadığı Kontrol Ediliyor
                {
                    label6.Text +=  sayi.ToString() +"\n" ; //Çift Olan Sayılar Alt Alta Yazdırılıyor
                }
                else
                {
                    label7.Text += sayi.ToString() + "\n" ; //Tek Olan Sayılar Alt Alta Yazdırılıyor
                }

            }
        }

    }
}

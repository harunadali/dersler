using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rastgeleciftsayilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Program çalıştığı anda listboxa sayılar eklenir
            int sayi;
            Random rastgele = new Random(); //Rastgele Sayı Üretmek İçin Kullanılması Gerekli
            for (int i = 0; i < 10; i++) //10 Sayı Üretmek İçin Döngü Kuruluyor
            {
                sayi = rastgele.Next(10, 100); //10 ile 100 Arasında Sayı Üretiliyor
                listBox1.Items.Add(sayi); //Sayılar listboxa ekleniyor
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listboxun selectedının içine yazıyoruz. Çünkü seçildiği anda işlem yapması gerek.
            int a;
            a = Convert.ToInt16(listBox1.SelectedItem.ToString()); //Seçili Olan Sayıyı Çeviriyoruz
            if (a % 2 == 0)//Sayının Çift Olup Olmadığı Kontrol Ediliyor
            {
                listBox2.Items.Add(a); //Çift sayılar ikinci listboxa ekleniyor
            }
        }
    }
}

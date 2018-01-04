using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dizilersiralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayilar = new int[10]; //10 elemanlı sayı türünde dizi oluşturulur
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); //rastgele sayılar üretmek için kullanılması gereken kalıp
            int sayi = 0;
            for (int i = 0; i < 10; i++) //10 tane rastgele sayı oluşturmak için döngü oluşturuluyor
            {
                sayi = rnd.Next(int.Parse(textBox1.Text), int.Parse(textBox2.Text));//başlangıç-bitiş girişine göre rastgele sayı üretiyor
                listBox1.Items.Add(sayi);//girilen sayılar arası 10 sayıyı listboxa ekliyor
            }

            for (int i = 0; i < listBox1.Items.Count; i++) //listbox1'in sayısı kadar döngü oluşturuluyor
            {
                sayilar[i] = int.Parse(listBox1.Items[i].ToString()); //sayilar dizisine listboxtaki elemanlar aktarılıyor
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Sort(sayilar); //sayilar dizisi küçükten büyüğe sıralanıyır
            //Array.Reverse(sayilar)-->sayilar dizisi büyükten küçüğe sıralanır
            foreach (var aktarilan in sayilar) //dizi eleman sayısına göre döngü oluşturulur
            {
                listBox2.Items.Add(aktarilan); //listbox2a sıralanan dizi aktarılır
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var aktarilan in listBox2.Items) //listbox2deki elemanları aktarmak için döngü oluşturuluyor
            {
                listBox3.Items.Add(aktarilan); //listbox3e listbox2deki elemanlar aktarılıyor
            }
        }
    }
}

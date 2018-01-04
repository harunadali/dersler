using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kelimeseçmevesayisinibulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0; //başlangıç değeri için değişken tanımlanıyor
            int a = 0; //aranan kelime sayısını bulmak için değişken tanımlanıyor
            while (index < richTextBox1.Text.LastIndexOf(textBox1.Text)) //0-richtextbox uzunluğuna kadar döngü oluşturuluyor
            {
                richTextBox1.Find(textBox1.Text, index, richTextBox1.TextLength, RichTextBoxFinds.None);//textboxa girilen metni arıyor
                richTextBox1.SelectionBackColor = Color.Green; //seçili metinlerin arka planını yeşil yapıyor
                richTextBox1.SelectionColor = Color.White; //seçili metinlerin yazı rengini beyaz yapıyor
                index = richTextBox1.Text.IndexOf(textBox1.Text, index) + 1; //index i kelimeden bir sonraki index yapıyor
                a++; //seçilen kelime sayısını artırıyor
            }
            richTextBox1.AppendText("\n" + a.ToString()); //AppendText Komutu richtextboxa ekleme yapar (Kelime sayısını ekliyor)
        }
    }
}

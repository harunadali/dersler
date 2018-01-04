using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace listboxkomutları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = textBox1.Text;
            listBox1.Items.Add(cumle.Substring(4)); // Girilen cümleyi 4.indisten itibaren listboxa aktarır.
            listBox1.Items.Add(cumle.Length); // Girilen cümlenin uzunluğunu listboxa aktarır.
            listBox1.Items.Add(cumle.ToLower()); // Girlen cümleyi küçük harfe dönüştürerek listboxa aktarır.
            listBox1.Items.Add(cumle.ToUpper()); // Girlen cümleyi büyük harfe dönüştürerek listboxa aktarır.
            listBox1.Items.Add(cumle.IndexOf('Ü')); // Girilen cümlede 'Ü' harfini arar. Varsa indis numarasını,yoksa -1'i listboxa aktarır.
            listBox1.Items.Add(cumle.Remove(5)); // Girilen cümlenin 5.indisinden itibaren harflerini siler,listboxa aktarır.
            listBox1.Items.Add(cumle.Remove(5, 4)); // Girilen cümlede 5.indisten başlayarak 4 harf siler,listboxa aktarır.
            listBox1.Items.Add(cumle.IndexOf("Üniversitesi")); // Girilen cümlede "Üniversitesi" kelimesini arar,başlangıç indisini listboxa aktarır.
            listBox1.Items.Add(cumle.Replace('a', 'z')); // Girlen cümledeki 'a' harflerini 'z' harfine döndürür, listboxa dönüşmüş halini aktarır.
            listBox1.Items.Add(cumle.Insert(10, "FATİH")); // Girilen cümleye 10.indisinden başlayarak "FATİH" kelimesi eklenerek listboxa aktarılır.
            listBox1.Items.Add(cumle.Substring(8, 12)); // Girilen cümlede 8.indisten başlayarak 12 karater alır ve listboxa aktarır.
            listBox1.Items.Add(cumle.Trim()); // Girilen cümlenin sonundaki boşlukları temizler ve listboxa aktarır.
            listBox1.Items.Add(cumle.TrimStart()); // Girilen cümlenin başındaki boşlukları temizler ve listboxa aktarır.
        }
    }
}

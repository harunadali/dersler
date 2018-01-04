using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace listboxileislemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("ÇANAKKALE"); //listboxa yazıyı ekler
            listBox1.Items.Add(textBox1.Text); //textteki yazıyı listboxa ekler
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = listBox1.Items.Count.ToString(); //listboxtaki elemanları sayar
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = listBox1.Items[3].ToString(); //listboxtaki 3 indisteki elemanı yazar
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //listboxu temizler
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = listBox1.Items.IndexOf(textBox3.Text).ToString();//textbox3teki elemanın indisini yazdırır
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)//Seçilen elemanların sayısı kadar döngü döndürür
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);//Elemanları diğer listboxa ekler
                                    //listBox1.Items[i];
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Text = listBox1.SelectedItem.ToString();//Seçili elemanı yazar
            textBox6.Text = listBox1.SelectedIndex.ToString();//Seçili elemanın indisini yazar
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(textBox3.Text);//metine göre siler
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(int.Parse(textBox4.Text)); //indis e göre siler
        }


    }
}

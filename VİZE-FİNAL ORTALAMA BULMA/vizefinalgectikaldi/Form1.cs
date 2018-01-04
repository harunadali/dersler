using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vizefinalgectikaldi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text); //textboxlara girilen bilgiler datagride ekleniyor.
            textBox1.Text = ""; //veri girişi gerçekleştikten sonra textboxları temizler.
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double vize = 0, final = 0;
            double ortalama = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) //Girilen satır sayısına kadar döngü oluşturuluyor
            {
                vize = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value); //vize değişkenine datagridin 3.sütunu aktarılıyor.
                final = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value); //final değişkenine datagridin 4.sütunu aktarılıyor.
                ortalama = (vize * 0.4) + (final * 0.6); //vizenin %40'ı,finalin %60'ı alınarak ortalama bulunuyor.
                dataGridView1.Rows[i].Cells[4].Value = ortalama.ToString(); //bulunan ortalamlar datagridin 5.sütununa aktarılıyor.
                if (ortalama < Convert.ToDouble(textBox5.Text)) //ortalamanın geçiş notundan küçük olup olmadığına bakılıyor.
                {
                    dataGridView1.Rows[i].Cells[5].Value = "KALDI"; //Ortalama geçiş notundan küçük olduğu için 6.sütuna KALDI yazılıyor.
                    dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Red; //Arka plan kırmızı yapılıyor.
                }
                else
                {
                    dataGridView1.Rows[i].Cells[5].Value = "GEÇTİ"; //Ortalama geçiş notundan yüksek olduğu için 6.sütuna GEÇTİ yazılıyor.
                    dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Green; //Arka plan yeşil yapılıyor.
                }
            }
        }
    }
}

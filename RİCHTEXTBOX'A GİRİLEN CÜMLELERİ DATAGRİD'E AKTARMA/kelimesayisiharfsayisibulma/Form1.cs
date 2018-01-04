using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kelimesayisiharfsayisibulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); //datagrid1'in satırlarını temizler
            dataGridView2.Rows.Clear(); //datagrid2'nin satırlarını temizler

            for (int i = 0; i < richTextBox1.Lines.Count(); i++) //richtextbox'ın satır sayısına kadar döngü oluşturulur
            {
                int sayac = 0;
                int sayisayar = 0;
                string metin=richTextBox1.Lines[i]; //metin değişkenine richtextbox'ın satırı aktarılıyor
                for (int j = 0; j < metin.Length; j++) //satırın uzunluğuna kadar döngü oluşturuluyor
                {
                    if (metin[j] == ' ')//satırdaki boşluk sayısı bulunuyor
                        sayac++;
                    if (metin[j] == '1' || metin[j] == '2' || metin[j] == '3' || metin[j] == '4' || metin[j] == '5' || metin[j] == '6' || metin[j] == '7' || metin[j] == '8' || metin[j] == '9' || metin[j] == '0')
                        //sayırdaki rakam sayısı bulunuyor
                        sayisayar++;
                }
                dataGridView1.Rows.Add(i + 1 + ". Satır", richTextBox1.Lines[i], richTextBox1.Lines[i].Length - sayac, sayac + 1);
                //datagrid1'e satır sayısı,satırın kendisi,toplam harf sayısı (satırın uzunluğundan boşluk sayısı çıkarılıyor), kelime sayısı ekleniyor.
                dataGridView2.Rows.Add(i + 1 + ". Satır", richTextBox1.Lines[i], sayisayar);
                //datagrid2'ye satır sayısı,satırın kendisi ve satırdaki rakam sayısı ekleniyor
            }
          
        }


    }
}

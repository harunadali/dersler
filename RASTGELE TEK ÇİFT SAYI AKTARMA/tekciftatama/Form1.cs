using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tekciftatama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(4); //datagrid1'e 4 satır ekler
            dataGridView3.Rows.Add(4); //datagrid3'e 4 satır ekler

            Random rastgele = new Random(); //rastgele sayı üretme kalıbı
            int sayi = 0;
            for (int i = 0; i < 5; i++) //5 satır oluşturma
            {
                for (int j = 0; j < 5; j++) //5 sütun oluşturma
                {
                    sayi = rastgele.Next(0, 100); //0-100 arası 25 sayı oluşturma
                    dataGridView1.Rows[i].Cells[j].Value = sayi; //datagrid1'e sayıları ekler
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(4);
            int sayi1 = 0;
            int satir = 0;
            int sutun = 0;
            for (int i = 0; i < 5; i++) //5 satır oluşturulur
            {
                for (int j = 0; j < 5; j++) //5 sütun oluşturulur
                {
                    sayi1 = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value); //sayi değişkenine rastgele sayılar atanıyor
                    if (sayi1 % 2 == 1) //Sayının tek olup olmadığı sorgulanıyor
                    {
                        dataGridView2.Rows[satir].Cells[sutun].Value = sayi1.ToString(); //datagrid2'ye sırasıyla sayıları aktarıyor
                        dataGridView2.Rows[satir].Cells[sutun].Style.BackColor = Color.Red; //arka planı kırmızı yapar
                        dataGridView2.Rows[satir].Cells[sutun].Style.ForeColor = Color.Yellow; //yazı rengini sarı yapar
                        if (sutun == 4) //sütunun 4 olup olmadığını sorgular
                        {
                            //dataGridView2.Rows.Add();
                            satir++; //eğer 4 ise yani toplam 5 sütun var ise alt satıra iner
                            sutun = 0; //alt satıra indiği için sütunu sıfırlar
                        }
                        else
                        {
                            sutun++; //sütun 4 olmadığı için sütun sayısını artırır
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            for (int i = 0; i < 5; i++) //5 satır oluşturma
            {
                for (int a = 0; a < 5; a++) //5 sütun oluşturma
                {
                    sayi = Convert.ToInt32(dataGridView1.Rows[i].Cells[a].Value); //sayıları sayi değişkenine atama
                    if (sayi % 2 == 0) //çift olup olmadığını sorgulama
                    {
                        dataGridView3.Rows[i].Cells[a].Value = sayi.ToString(); //çift olan sayıları konumlarıyla datagrid'e aktarma
                    }
                }
            }
        }
    }
}

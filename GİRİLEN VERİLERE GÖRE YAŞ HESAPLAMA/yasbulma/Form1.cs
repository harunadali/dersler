using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yasbulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text); //textbox'a girilen isim listbox'a aktarılır
            listBox2.Items.Add(DateTime.Now.Year - dateTimePicker1.Value.Year); 
            //bulunduğumuz yıldan datetimepickerdan seçilen yıl çıkarılır ve yaş bulunarak listbox2'ye aktarılır
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int adet = 0;
            adet = listBox2.Items.Count; //adet değişkenine yaşların sayısı atanır
            string[,] veriler = new string[adet, 2]; //yaş sayısı-2 matris dizi oluşturulur

            for (int i = 0; i < adet; i++) //yaş sayısına kadar döngü oluşturulur
            {
                veriler[i, 0] = listBox1.Items[i].ToString(); //ad bilgisi eklenir
                veriler[i, 1] = listBox2.Items[i].ToString(); //yaş bilgisi eklenir
            }

            string gecici1 = "", gecici2 = "";


            for (int i = 0; i < adet; i++) //yaş sayısına kadar döngü oluşturulur
            {
                for (int a = 0; a < adet; a++) //yaş sayısına kadar döngü oluşturulur
                {
                    if (Convert.ToInt16(veriler[i, 1]) < Convert.ToInt16(veriler[a, 1])) //yaşlar karşılaştırılıyor
                    {
                        gecici1 = veriler[i, 1]; //yaş bilgili gecici1 e atanır
                        gecici2 = veriler[i, 0]; //ad bilgisi gecici2 ye atanır

                        veriler[i, 1] = veriler[a, 1];
                        veriler[i, 0] = veriler[a, 0];

                        veriler[a, 1] = gecici1;
                        veriler[a, 0] = gecici2;

                        //sıralama işlemleri //ezberle
                    }
                }
            }
            for (int i = 0; i < adet; i++)
                comboBox1.Items.Add(veriler[i, 0] + " " + veriler[i, 1] + " yaşında"); //combobox'a isim-yaş sıralı olarak aktarılır
        }
    }
}

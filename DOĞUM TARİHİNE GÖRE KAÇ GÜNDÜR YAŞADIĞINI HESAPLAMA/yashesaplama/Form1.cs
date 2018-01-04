using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yashesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gun1 = 0; int gun2 = 0;
            gun1 = DateTime.Now.DayOfYear; //gun1 değişkenine şuanki tarih atanır.
            gun2 = dateTimePicker1.Value.DayOfYear; //gun2 değişkenine seçilen tarih atanır.
            string sonuc = "";
            sonuc = (DateTime.Now.Year - dateTimePicker1.Value.Year - 1).ToString() + " yıl "; //Bulunduğumuz yıldan,seçilen yıl çıkartılır.
            if (gun2 < gun1)
                sonuc += (gun1 - gun2).ToString() + " gün "; //seçilen tarih ile bulunduğumuz günün farkı bulunur.
            else
                sonuc += (gun1 + 365 - gun2).ToString() + " gün "; //bulunduğumuz yıla 1 yıl eklenerek seçilen tarih çıkartılıyor.
            textBox1.Text = sonuc += "'den beri yaşıyorsun"; //bulunan gün yazdırılıyor.
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tarihileilgiliislemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string tarih = "";
            //bugünün tarihini yazar
            tarih = DateTime.Today.ToString(); 
            listBox1.Items.Add(tarih);
            //bugünün tarih ve saat bilgisini yazar
            tarih = DateTime.Now.ToString();
            listBox1.Items.Add(tarih);
            //bulunduğumuz günün yıl bilgisini yazar
            tarih = DateTime.Today.Year.ToString();
            listBox1.Items.Add(tarih);
            //bulunduğumuz günün ay bilgisini yazar
            tarih = DateTime.Today.Month.ToString();
            listBox1.Items.Add(tarih);
            //bulunduğumuz günün gün bilgisini yazar
            tarih = DateTime.Today.Day.ToString();
            listBox1.Items.Add(tarih);
            //bulunduğumuz günün saat bilgisini yazar
            tarih = DateTime.Today.Hour.ToString();
            listBox1.Items.Add(tarih);
            //bulunduğumuz anın saat bilgisini yazar
            tarih = DateTime.Now.Hour.ToString();
            listBox1.Items.Add(tarih);
            //bulunduğumuz güne 12 gün ekler
            tarih = DateTime.Today.AddDays(12).ToString();
            listBox1.Items.Add(tarih);
            textBox1.Text = dateTimePicker1.Value.AddDays(9).ToString(); //datetimepickerdaki güne 9 gün ekler
            textBox1.Text = dateTimePicker1.Value.ToString(); //datetimepickerdaki tarihi ve saati yazar
            textBox1.Text = dateTimePicker1.Value.Year.ToString(); //datetimepickerdaki yılı yazar
        }
    }
}

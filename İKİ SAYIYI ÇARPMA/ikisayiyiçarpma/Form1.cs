using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ikisayiyiçarpma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            a = Convert.ToInt16(textBox1.Text); //1. integera çevirme yolu
            b = int.Parse(textBox2.Text); //2. integera çevirme yolu
            textBox3.Text = (a * b).ToString(); //Çarpma işlemini sayısal ifade olarak algılar(1.yol)
            //textBox3.Text = Convert.ToString(a * b); (2.yol)
        }
    }
}

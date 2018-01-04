using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string harf = "abcçdefgğhıijklmnoöprsştuüvyz";
            int sayi;
            Random rnd = new Random();
            string kelime = "";
            Random harfler=new Random();
            for (int i = 0; i < 5; i++)
            {
                
                sayi = rnd.Next(6, 14);
                    kelime+=harf;
                listBox1.Items.Add(kelime);
            }

           }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        }
        
    }


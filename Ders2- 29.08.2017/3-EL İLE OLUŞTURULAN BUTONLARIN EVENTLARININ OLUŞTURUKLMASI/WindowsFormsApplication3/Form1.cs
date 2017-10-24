using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Button> butonlar = new List<Button>(); 
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i= 1; i <= 5; i++)
            {
                Button btn = new Button();
                btn.Name = "Buton" + i.ToString();
                btn.Text=btn.Name.ToString(); 
                btn.SetBounds(20,70*i,60,30);
                this.Controls.Add(btn);
                butonlar.Add(btn);
                btn.Click += btn_Click;

            }
        }
        int sayi = 0; 
        void btn_Click(object sender, EventArgs e)
        {
            Button butonTexti = (sender as Button);
            butonTexti.Visible = false;
            sayi++; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayi == 5){
                timer1.Stop();
                MessageBox.Show("Oyun bitti");
                
            }
          

            else
            {
                Random rnd = new Random();
                for (int i = 0; i < butonlar.Count; i++) {
                    butonlar[i].Location = new Point(rnd.Next(50, 250), rnd.Next(50, 250));
            }

            }
        }
    }
}

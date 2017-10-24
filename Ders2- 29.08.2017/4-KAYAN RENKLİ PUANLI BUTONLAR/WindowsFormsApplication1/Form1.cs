using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button btn = new Button();
        Random rnd = new Random();
        int puan = 0; 
        private void Form1_Load(object sender, EventArgs e)
        {
            btn.SetBounds(50, 50, 60, 50);
            this.Controls.Add(btn); 
            timer1.Interval = 1000;
            timer1.Start();
            btn.Click += btn_Click;
        }

        void btn_Click(object sender, EventArgs e)
        { 
            Button btn = (sender as Button);
            if (btn.ForeColor == Color.Red)
            {
               
                puan += Convert.ToInt16(btn.Text);
            }
            else {

                puan -= Convert.ToInt16(btn.Text);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            int x = rnd.Next(1, 600);
            btn.SetBounds(x, rnd.Next(1, 350), 60, 50);
            btn.Text = rnd.Next(1, 10).ToString();
            if (x > 100 && x < 300)
            {
                btn.ForeColor = Color.Red;

            }
            else
                btn.ForeColor = Color.Black;

            label1.Text = puan.ToString();

        }
    }
}

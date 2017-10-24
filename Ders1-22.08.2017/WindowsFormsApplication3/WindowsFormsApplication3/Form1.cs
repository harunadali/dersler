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

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random ras = new Random();
            button1.Location = new Point(ras.Next(1, 500), ras.Next(1, 500)); 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tıkladın"); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.SetBounds(5, 5, 120, 120);
            btn.Text = "tıkla";
            this.Controls.Add(btn);
            

            Label lbl = new Label();
            lbl.SetBounds(5, 150, 180, 20);
            lbl.ForeColor = Color.Blue;
            lbl.Text = "MELİH KAÇAMAN";
            this.Controls.Add(lbl);
        }
    }
}

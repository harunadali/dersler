using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gruopbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 60, y = 20, ls = 1, lx = 0;
            for (int i = 0; i < 24; i++) {
                if (i % 3 == 0 || i == 0) {
                    y += 30;
                    x = 100;
                    lx = x;
                    Label lbl = new Label();
                    Point lblYer = new Point(lx - 50, y + 5);
                    lbl.Location = lblYer;
                    lbl.Width = 40;
                    lbl.Text = ls.ToString() + " .Ders";
                    ls++;
                    groupBox1.Controls.Add(lbl);
                    lx += 20; 
                }
                MaskedTextBox txt = new MaskedTextBox();
                Point yer = new Point(x,y);
                txt.Name = "txt" + i.ToString();
                txt.Location = yer;
                txt.Width = 35; txt.Height = 25;
                txt.Mask = "00:00";
                this.Controls.Add(txt);
                groupBox1.Controls.Add(txt);
                x += 60; 
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

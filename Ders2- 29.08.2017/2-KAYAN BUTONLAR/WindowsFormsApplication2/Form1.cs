using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button btn1 = new Button();
        Button btn2 = new Button();
        Button btn3 = new Button();
        Button btn4 = new Button();
        bool bayrak = true;
        int sayac = 0; 
        int sayaca=0;
        Point size = new Point(140, 103);
        private void Form1_Load(object sender, EventArgs e)
        {
            btn1.SetBounds(140, 103, 62, 50);
            this.Controls.Add(btn1);
            
            btn2.SetBounds(209, 103, 62, 50);
            this.Controls.Add(btn2);

            btn3.SetBounds(141, 159, 62, 50);
            this.Controls.Add(btn3);
            
            btn4.SetBounds(209, 159, 62, 50);
            this.Controls.Add(btn4);

            timer1.Interval =100;
            timer1.Start(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn1.Location = new Point(12, 12);
            btn2.Location = new Point(300, 12);
            btn3.Location = new Point(12, 262);
            btn4.Location = new Point(300, 262); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btn1.Location= new Point(140 - sayac, 103 - sayac);
            btn2.Location = new Point(209-sayac, 103-sayac);
            btn3.Location = new Point(12-sayac, 262-sayac);
            btn4.Location = new Point(300-sayac, 262-sayac); 
            sayac += 20;

        }
    }
}

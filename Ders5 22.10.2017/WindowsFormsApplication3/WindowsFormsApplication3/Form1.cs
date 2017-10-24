using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int uretilen_sayi = 0;
        List<Button> butonlar = new List<Button>();

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                uretilen_sayi = rnd.Next(1, 100);
                btn.Text = uretilen_sayi.ToString();
                btn.SetBounds(rnd.Next(10, 350), rnd.Next(10, 350), 40, 40);
                this.Controls.Add(btn);
                butonlar.Add(btn);
                btn.AllowDrop = true;
                btn.MouseDown += new MouseEventHandler(btn_MouseDown);

            }

            timer1.Interval = 2000;
            timer1.Start();
        }

        void btn_MouseDown(object sender, MouseEventArgs e)
        {
            Button butons = (sender as Button);
            butons.DoDragDrop(butons.Text, DragDropEffects.All);
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < butonlar.Count; i++)
            {
                butonlar[i].SetBounds(rnd.Next(10, 350), rnd.Next(10, 350), 40, 40);
            }
            
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            Button butons = (sender as Button);
            if (Convert.ToInt16(e.Data.GetData(DataFormats.Text)) < 50)
            {
                listBox1.Items.Add(e.Data.GetData(DataFormats.Text));
            }
            
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}

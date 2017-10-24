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
        ListBox listbox = new ListBox();
        private void Form1_Load(object sender, EventArgs e)
        {
            listbox.SetBounds(325, 50, 100, 125);
            this.Controls.Add(listbox); 

        }
        List<TextBox> TextBoxlar = new List<TextBox>();
        int sayac = 0; 
        private void button1_Click(object sender, EventArgs e)
        {
            TextBox text = new TextBox();
            sayac++;
            text.Location = new System.Drawing.Point(20, 30 * sayac);
            
            text.Size = new System.Drawing.Size(125, 25);
            
            this.Controls.Add(text);
            TextBoxlar.Add(text); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (TextBox tx in TextBoxlar)
            {
                string value = tx.Text.ToString();
                listbox.Items.Add(value); 
            }

            /*
             *Bu şekilde de olabilir.
             * 
             * 
             * foreach (TextBox value in textler)
            {
                listbox.Items.Add(value.Text);
            }
             * 
             * 
             * 
             * */
        }
    }
}

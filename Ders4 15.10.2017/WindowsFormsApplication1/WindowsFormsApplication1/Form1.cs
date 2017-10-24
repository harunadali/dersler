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
        int toplam = 0; 
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.All);
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.Text);
            string stData = data.ToString();
            string[] bolunmus = stData.Split(' ');
            int bol2 = Convert.ToInt32(bolunmus[1]);
           
            toplam += bol2;
            if (listBox1.Items.Count < 5 && toplam < 5000)
            {
                


                listBox1.Items.Add(bolunmus[0].ToString());
                
                listBox2.Items.Add(bol2);
                
                textBox3.Text = toplam.ToString();
                textBox2.Text = listBox1.Items.Count.ToString();

            }
            else {

                MessageBox.Show("fiyat sınırın yada adet sınırını geçezmessinz"); 
            }
 

        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {

                e.Effect = DragDropEffects.Copy;
                

            }
        }


    }
}

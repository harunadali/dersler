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

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.All);
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {

            if (Convert.ToInt16(e.Data.GetData(DataFormats.Text))<2500)
            {
                listBox2.Items.Add(e.Data.GetData(DataFormats.Text));
            }
        }

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState==1)
            {
                e.Effect=DragDropEffects.Move;
            }

            else
            {
                e.Effect = DragDropEffects.None;
            }
        }





    }
}

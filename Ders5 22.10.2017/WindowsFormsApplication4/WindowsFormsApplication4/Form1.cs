using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("urun", "urun");
            dataGridView1.Columns.Add("fiyat", "fiyat");
            dataGridView1.Columns.Add("adet", "adet");
        }
        string urun = "";
        private void checkedListBox1_MouseDown(object sender, MouseEventArgs e)
        {
            urun = checkedListBox1.SelectedItem.ToString() +" "+ checkedListBox2.SelectedItem.ToString();
            checkedListBox1.DoDragDrop(urun, DragDropEffects.All);
        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] kelimeler = urun.Split(' ');
            dataGridView1.Rows.Add(kelimeler[0], kelimeler[1]);
        }

        public static int toplam_fiyat = 0, toplam_adet = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplam_adet += Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value);
                toplam_fiyat += Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value) 
                               *Convert.ToInt16(dataGridView1.Rows[i].Cells[1].Value);
             }
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Hide();
            }
        }

    }



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            List<string> degerler = new List<string>();
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                degerler.Add(cell.Value.ToString());
            }
            if (degerler.Count > 2)
                return;
            degerler.Reverse();
            for (int i = 0; i < degerler.Count; i++)
            {
                dataGridView1.SelectedCells[i].Value = degerler[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*string[] dizi = new string[dataGridView1.SelectedCells.Count];
            for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
            {
                dizi[i] += dataGridView1.SelectedCells[i].Value;
            }
            string uzunkelime = "";
            int uzunluk = 0;
            foreach (string eleman in dizi)
            {
                if (eleman.Length > uzunluk)
                {
                    uzunluk = eleman.Length;
                    uzunkelime = eleman;
                }
            }
            dataGridView2.Rows.Add(uzunkelime);*/

            List<string> degerler = new List<string>();
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                degerler.Add(cell.Value.ToString());
            }
            int enUzunKarakter = 0;
            for (int i = 0; i < degerler.Count; i++)
            {
                if (degerler[i].Length > enUzunKarakter)
                    enUzunKarakter = degerler[i].Length;
            }
            foreach (string veri in degerler)
            {
                if (veri.Length == enUzunKarakter)
                    dataGridView2.Rows.Add(veri, "", "");
            }


        }
    }
}

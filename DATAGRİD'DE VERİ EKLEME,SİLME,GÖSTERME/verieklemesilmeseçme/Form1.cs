using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace verieklemesilmeseçme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox2.Text, textBox3.Text, textBox4.Text); //datagrid e bilgileri ekleme
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(400, 200); //datagridin boyutunu ayarlar
            dataGridView1.Columns.Add("adi", "Adı"); //adi adında sütun ekler
            dataGridView1.Columns.Add("soyadi", "Soyadı"); //soyadi adında sütun ekler
            dataGridView1.Columns.Add("tel", "Tel"); //tel adında sütun ekler
            dataGridView1.Columns["adi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //adi sütununu girilen veriye göre büyültür
            dataGridView1.Rows.Add("Fatih", "Kazdal", "1235433"); //bilgileri satır olarak ekler
            dataGridView1.Rows.Add("Kemal", "Gül", "224324"); //bilgileri satır olarak ekler
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.CurrentCell.Value.ToString()); //Seçili olan hücrenin bilgisini messagebox da gösterir.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(Convert.ToInt32(textBox1.Text)); //Girilen indis numarasına göre satırı siler.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = ""; //Seçili hücreyi siler.
            //dataGridView1.CurrentCell.Value = string.Empty; //Seçili hücreyi temizler.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(Convert.ToInt32(dataGridView1.CurrentRow.Index));//Seçili olan hücrenin bulunduğu satırı temizler.
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder(); //str adında string dizi oluşturulur
            for (int i = 0; i < dataGridView1.ColumnCount; i++) //sütün sayısı kadar döngü oluşturulur
            {
                //diziye seçili olan satırın bulunduğu hücreler eklenir
                str.Append(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[i].Value.ToString());
                str.Append(" "); //hücreler arasına boşluk eklenir
            }
            MessageBox.Show(str.ToString());//MessageBox'ta satır gösterilir
        }
    }
}

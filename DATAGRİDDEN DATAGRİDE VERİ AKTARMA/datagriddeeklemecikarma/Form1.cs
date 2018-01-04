using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace datagriddeeklemecikarma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("adi", "Adı"); //adi sütununu ekleme
            dataGridView1.Columns.Add("soyad", "Soyadı"); //soyad sütununu ekleme
            dataGridView1.Columns.Add("yas", "Yaşı"); //yas sütununu ekleme
            dataGridView1.Rows.Add("Fatih", "Kazdal", 28); //verileri satıra ekleme
            dataGridView1.Rows.Add("Gamze", "Yıldırım", 32); //verileri satıra ekleme
            dataGridView1.Rows.Add("Bilal", "Kazdal", 2); //verileri satıra ekleme
            dataGridView1.Rows.Add("Samet", "Kazdal", 18); //verileri satıra ekleme
            dataGridView1.Rows.Add("Rıdvan", "Pınar", 29); //verileri satıra ekleme
            dataGridView2.Columns.Add("adi", "Adı"); //datagrid2 ye adi sütununu ekleme
            dataGridView2.Columns.Add("soyadi", "Soyadı"); //datagrid2 ye soyadi sütununu ekleme
            dataGridView2.Columns.Add("tel", "Tel"); //datagrid2 ye tel sütununu ekleme
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString(),
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString(),
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString());
            //Seçili olan satırın indexini alarak sütunlara tek tek verileri ekler
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString(),
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString(),
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString());
            //Seçili olan satırın indexini alarak sütunlara tek tek verileri ekler
            dataGridView1.Rows.RemoveAt(Convert.ToInt32(dataGridView1.CurrentRow.Index));
            //Aktarılan satırın indexini alarak satırı datagrid1 den siler
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(dataGridView1.CurrentCell.Value.ToString()); //datagrid2 ye seçili olan hücreyi ekler
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int topla = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++) //datagrid1 in satır sayısı kadar döngü oluşturulur
            {
                topla += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value); //topla değişkenine 3.sütundaki yaşların toplamı aktarılır
            }
            textBox1.Text = topla.ToString(); //textboxa topla değişkeni yazdırılır.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int topla = 0;
            for (int i = 0; i < dataGridView1.SelectedCells.Count; i++) //Seçili olan hücre sayısı kadar döngü oluşturulur
            {
                topla += Convert.ToInt32(dataGridView1.SelectedCells[i].Value); //Seçili olan hücreleri sırasıyla toplar ve topla değişkenine atar
            }
            textBox2.Text = (topla / dataGridView1.SelectedCells.Count).ToString(); //Hücrelerin toplamını seçili hücre sayısına böler ve textboxa yazar
        }
    }
}

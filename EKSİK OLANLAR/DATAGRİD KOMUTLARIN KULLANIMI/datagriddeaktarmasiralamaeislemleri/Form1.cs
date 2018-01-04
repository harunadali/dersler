using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace datagriddeaktarmasiralamaeislemleri
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
            dataGridView1.Columns.Add("soyad", "Soyadı"); //soyadi sütununu ekleme
            dataGridView1.Columns.Add("yas", "Yaşı"); //yas sütununu ekleme
            dataGridView1.Rows.Add("Fatih", "Kazdal", 28); //verieri satıra ekleme
            dataGridView1.Rows.Add("Gamze", "Yıldırım", 32); //verieri satıra ekleme
            dataGridView1.Rows.Add("Bilal", "Kazdal", 2); //verieri satıra ekleme
            dataGridView1.Rows.Add("Samet", "Kazdal", 18); //verieri satıra ekleme
            dataGridView1.Rows.Add("Rıdvan", "Pınar", 29); //verieri satıra ekleme
            dataGridView1.Rows.Add("Yılmaz", "Kalay", 5); //verieri satıra ekleme
            dataGridView2.Columns.Add("adi", "kolon1"); //Datagrid2 ye adi sütununu ekleme
            dataGridView2.Columns.Add("soyadi", "kolon2"); //Datagrid2 ye soyadi sütununu ekleme
            dataGridView2.Columns.Add("tel", "kolon3"); //Datagrid2 ye tel sütununu ekleme
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString(),
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString(),
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            //Seçili olan satırın indexini alır, 0 ve 2. sütunu yer değiştirir ve satırı ters olarak aktarmış olur.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++) //Seçili olan satır sayısına kadar döngü oluşturulur
            {
                // dataGridView2.Rows.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                dataGridView2.Rows.Add(dataGridView1.SelectedRows[i].Cells[0].Value.ToString(),
                    dataGridView1.SelectedRows[i].Cells[1].Value.ToString(),
                    dataGridView1.SelectedRows[i].Cells[2].Value.ToString());
                //Seçili olan satırın indexinden başlayarak sırayla satırları ekler(selectedrows[i])
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++) //datagrid1'in satır sayısına kadar döngü oluşturuluyor
            {
                dataGridView2.Rows.Add(dataGridView1.Rows[i].Cells[0].Value,
                    dataGridView1.Rows[i].Cells[1].Value,
                    dataGridView1.Rows[i].Cells[2].Value);
                //datagrid2'ye satırlar sırasıyla aktarılır
            }
            dataGridView2.Sort(dataGridView2.Columns[0], ListSortDirection.Ascending);//datagrid2'yi adi sütununa göre sıralar
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);//datagrid1'i yas sütununa göre sıralar
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

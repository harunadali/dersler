using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace richtextboxileilgiliislemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = richTextBox1.Lines.Count().ToString(); // richtextbox'ın kaç satırdan oluştuğunu yazar.
            //richTextBox1.SelectionBackColor = Color.Red; //Seçili kısmın arka planını kırmızı yapar.
            //richTextBox1.SelectionColor = Color.Yellow; //Seçili kısmın yazı rengini sarı yapar.
            //richTextBox1.AppendText(textBox1.Text); //textbox'a girilen bilgiyi richtextbox'a ekler.
            //richTextBox1.Font = new Font("Concolas", 18f, FontStyle.Bold); //richtextbox'ın yazı stilini,boyutunu ve kalınlığını değiştirir.
            //textBox1.Text = richTextBox1.Find("fatih").ToString(); //'fatih' kelimesini arar ve başlangıç indisini textbox'a yazar.
            //textBox1.Text = richTextBox1.Text; //richtextbox'daki metni textbox'a aktarır.
            //textBox1.Text = richTextBox1.SelectionLength.ToString(); //Seçili kısmın uzunluğunu yazar.
            //textBox1.Text = richTextBox1.SelectedText.Insert(3, "fatih"); //Seçili kısmın 3.indisine 'fatih' ekleyerek textboxa aktarır.
            //textBox1.Text = richTextBox1.SelectedText.Count().ToString(); //Seçili kısmın uzunluğunu yazar.
            //textBox1.Text = richTextBox1.SelectedText.Remove(4); //Seçili kısmın 4.indisinden itibaren siler ve textbox'a yazar.
            //textBox1.Text = richTextBox1.SelectedText.Replace('q', 'e'); //Seçili kısımdaki 'q' harflerini 'e' harfine dönüştürür ve textbox'a yazar.
            //textBox1.Text = richTextBox1.SelectedText.Remove(4, 3); //Seçili kısımdan 4.indisten başlayarak 3 harf siler ve textbox'a yazar.
            //textBox1.Text = richTextBox1.SelectedText.IndexOf('a').ToString(); //Seçili kısımda 'a' harfini arar ve indisini yazar.
            //saveFileDialog1.ShowDialog(); //Dosyayı kaydetmeye yarar.
            //richTextBox1.SaveFile(saveFileDialog1.FileName); //Dosyaya isim verilir ve kaydeder.
            //fontDialog1.ShowDialog(); //Dosyanın stil ayarlarını değiştirmeye yarar.
            //richTextBox1.SelectionFont = fontDialog1.Font; //Seçili olan metnin stil ayarlarını değiştirir.
            //colorDialog1.ShowDialog(); //Yazı rengini değiştirmeye yarar.
            //richTextBox1.SelectionColor = colorDialog1.Color; //Seçili alanın rengini değiştirir.
            //richTextBox1.Select(0, richTextBox1.Lines[0].Length); //1.satırın seçildiğini varsayar.
            //textBox1.Text = richTextBox1.Size.Height.ToString(); //richtextbox'ın yüksekliğini yazar.
        }
    }
}

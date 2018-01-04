using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace radiocombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 3; //combobox'ın 4.elemanı seçili olarak gelir
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) //checkBox1 işaretlenmiş mi diye soruyor
            {
                textBox1.Text = checkBox1.Text; //işaretlenmişse textbox'a checkbox'ın textini yazıyor
            }
            checkedListBox1.Items.Add(textBox1.Text); //textbox1'in textini checkedlisbox'a ekliyor
            comboBox1.Items.Add(textBox1.Text); //combobox'a textbox1'in textini ekliyor
        }
    }
}

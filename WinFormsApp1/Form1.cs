using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota:" + comboBox1.Text + " - " + comboBox2.Text + " Tarih: " + dateTimePicker1.Text + " Saat " + maskedTextBox1.Text + " Yolcu Bilgileri ~ Ad: " + textBox1.Text + " Soyad: " + textBox2.Text + " T.C: " + maskedTextBox2.Text + " Tel No: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydı Yapılmıştır. Simurg Turizm İyi Yolculuklar Diler");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label12.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label12.Text;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }
    }
}

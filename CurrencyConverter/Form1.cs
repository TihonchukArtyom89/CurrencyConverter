using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class main_win_form : Form
    {
        public main_win_form()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string from, to;
            from = listBox1.SelectedItem.ToString();
            to = listBox2.SelectedItem.ToString();
            if(from==to)
            {
                MessageBox.Show("Одинаковые валюты!", "Внимание!");
            }
            else if(textBox1.Text==String.Empty)
            {
                MessageBox.Show("Введите количество денег для конвертации!", "Внимание!");
            }
            else
            {
                webBrowser1.Navigate("https://www.google.ru/search?q=" + textBox1.Text + " " + from + " %D0%B2 " + to);
            }
        }
    }
}

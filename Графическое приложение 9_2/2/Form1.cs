using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        private char ch;
        private int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void res_Button_Click(object sender, EventArgs e)
        {
            if (ch_TextBox.Text == "")
            {
                MessageBox.Show("Введены не все значения!!!");
            }
            else
            {
                res_TextBox.Text = "";
                try
                {
                    ch = Convert.ToChar(ch_TextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод данных");
                    return;
                }
                const string path = "text.txt";
                res_TextBox.Text += "Найденные строки по критерию: \n";
                foreach (var str in File.ReadAllLines(path))
                {
                    if (str.StartsWith(ch.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        res_TextBox.Text += str+"\n";
                        a++;
                        continue;
                    }
                }
                if (a >= 1)
                {
                    return;
                }
                else
                {
                    res_TextBox.Text += "Строка не найдена";
                }
            }
        }
    }
}


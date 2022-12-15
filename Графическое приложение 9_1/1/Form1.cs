using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _1
{
    public partial class Form1 : Form
    {
        private int n;
        private int[] arr;
        private int a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void res_button_Click(object sender, EventArgs e)
        {
            if (n_textBox.Text == "" || start_textBox.Text == "" || finish_textBox.Text == "" || mas_textBox.Text == "")
            {
                MessageBox.Show("Введены не все данные!!!");
                return;
            }
            else
            {
                res_textBox.Text = "";
                try
                {
                    n = int.Parse(n_textBox.Text);
                    if (n <= 0)
                    {
                        MessageBox.Show("Минимальное число 1");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод");
                    return;
                }
                arr = new int[n];
                try
                {
                    var digits = mas_textBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (digits.Length > n)
                    {
                        MessageBox.Show("Число введенных элементов больше, чем количество элементов массива!");
                        return;
                    }
                    else if (digits.Length < n)
                    {
                        MessageBox.Show("Число введенных элементов меньше, чем количество элементов массива!");
                        return;
                    }
                    for (int i = 0; i < n; ++i)
                    {
                        arr[i] = int.Parse(digits[i]);
                    }
                }

                catch
                {
                    MessageBox.Show("В поле элементов массива введены неверные значения! Введите заново, используя только цифры, точку и знак \"минус\"");
                    return;
                }

                try
                {
                    a = int.Parse(start_textBox.Text);
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод!");
                    return;
                }
                try
                {
                    b = int.Parse(finish_textBox.Text);
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод!");
                    return;
                }
                if (a > b)
                {
                    MessageBox.Show("Начальная точка диапазона не может быть больше конечной точки");
                    return;
                }
                FileStream f = new FileStream("text.dat", FileMode.Create);
                BinaryWriter fOut = new BinaryWriter(f);
                for (int i = 0; i < n; ++i)
                {
                    fOut.Write(arr[i]);
                }
                fOut.Close();
                f.Close();
                f = new FileStream("text.dat", FileMode.Open);
                BinaryReader fIn = new BinaryReader(f);
                long m = f.Length;
                int am;
                for (long i = 0; i < m; i += 4)
                {
                    f.Seek(i, SeekOrigin.Begin);
                    am = fIn.ReadInt32();
                    if ((am >= a) && (am <= b))
                    {
                        res_textBox.Text += am + " ";
                    }
                }
                fIn.Close();
                f.Close();
            }
        }
    }
}

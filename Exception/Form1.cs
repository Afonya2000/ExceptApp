using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Введите значение для a: ");
            MessageBox.Show("Введите значение для b: ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, S;
            string input, input2;
            input = textBox1.Text;
            input2 = textBox2.Text;
            if (Int32.TryParse(input, out (a)) && Int32.TryParse(input2, out (b)))
            {
                S = a + b;
                MessageBox.Show($"Результат сложения a + b: {S}");
            }
            else
            {
                MessageBox.Show("Некорректный ввод");
            }
        }
    }
}

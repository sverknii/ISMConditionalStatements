using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double x, y, z, result;
            double numerator1, numerator2, denominator1, denominator2;
            double pow_y;

            if (double.TryParse(textBox_x.Text, out x) && double.TryParse(textBox_y.Text, out y) && double.TryParse(textBox_z.Text, out z))
            {
                if (y == 0 && z > 2)
                {
                    MessageBox.Show("Недопустимое значение у", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    pow_y = Math.Pow(y, (2 - z));
                    numerator1 = 2 * Math.Cos(x * x) - (1.0 / 2.0);
                    denominator1 = (1.0 / 2.0) + Math.Sin(pow_y);
                    numerator2 = z * z;
                    denominator2 = 7 - (z / 3.0);
                    result = (numerator1 / denominator1) + (numerator2 / denominator2);
                    textBox_r.Text = result.ToString("F2");
                }
            }
            else
            {
                MessageBox.Show("Ошибка преобразования чисел", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_x_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double x1, x2, result;

            if (double.TryParse(tbX1.Text, out x1) && double.TryParse(tbX2.Text, out x2))
            {
                result = x1 * x2;
                tbY.Text = result.ToString("E");

                string largerValue = x1 > x2 ? $"Більше значення: X1 = {x1}" : $"Більше значення: X2 = {x2}";
                MessageBox.Show(largerValue, "Результат");
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть числові значення для X1 та X2.", "Помилка вводу");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Text = "";
            tbX2.Text = "";
            tbY.Text = "";
        }
    }
}

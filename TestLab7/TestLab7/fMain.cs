using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLab7
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void lab07y2_Load(object sender, EventArgs e)
        {

        }

        private void e(object sender, KeyPressEventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbX1.Text) || (String.IsNullOrEmpty(tbX2.Text)))
            {
                tbY.Text = "No Data!";
                tbAvg.Text = "No Data!";
                return;
            }
            int x1 = 0;
            int x2 = 0;
            try
            {
               x1 = int.Parse(tbX1.Text);
            }
            catch(Exception ex)
            {
                string err = string.Format("Erroe first number {0}", ex.Message);
                MessageBox.Show(err, "Converison error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                x2 = int.Parse(tbX2.Text);
            }
            catch(Exception ex)
            { 
                string err = string.Format("Erroe second number {0}", ex.Message);
                MessageBox.Show(err, "Converison error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                double y = (Math.Pow(Math.Sin(x1), 3) + 45 + x2) / (2 * (x1 * x1 * x1 * x1) + 4 * x2);
            tbY.Text = y.ToString("0.####");
            int avg = (x1 + x2) / 2;
            tbAvg.Text = avg.ToString("0.####");
            }

        private void btnClear_ClientSizeChanged(object sender, EventArgs e)
            {

            }

            private void btnClear_Click(object sender, EventArgs e)
            {
                tbX1.Text = string.Empty;
                tbX2.Text = string.Empty;
                tbY.Text = string.Empty;
                tbAvg.Text = string.Empty;
            }

            private void btnExit_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

        private void tbAvg_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

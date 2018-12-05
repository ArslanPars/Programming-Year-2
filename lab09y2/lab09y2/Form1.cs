using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab09y2
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double x1min = 0;
            double x2min = 0;
            double dx1 = 0;
            double x1max = 0;
            double x2max = 0;
            double dx2 = 0;
            try
            {
                x1min = double.Parse(tbx1min.Text);
            }
            catch (Exception ex)
            {
                string err = string.Format("Erroe X1min {0}", ex.Message);
                MessageBox.Show(err, "Converison error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbx1min.Text = tbx1min.Text.Remove(tbx1min.Text.Length - tbx1min.Text.Length);
            }
            try
            {
                x2min = double.Parse(tbx2min.Text);
            }
            catch (Exception ex)
            {
                string err = string.Format("Erroe x2mix {0}", ex.Message);
                MessageBox.Show(err, "Converison error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbx2min.Text = tbx2min.Text.Remove(tbx2min.Text.Length - tbx2min.Text.Length);
            }
            try
            {
                dx1 = double.Parse(tbdx1.Text);
            }
            catch (Exception ex)
            {
                string err = string.Format("Erroe dX1 {0}", ex.Message);
                MessageBox.Show(err, "Converison error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbdx1.Text = tbdx1.Text.Remove(tbdx1.Text.Length - tbdx1.Text.Length);
            }
            try
            {
                x1max = double.Parse(tbx1max.Text);
            }
            catch (Exception ex)
            {
                string err = string.Format("Erroe X1max {0}", ex.Message);
                MessageBox.Show(err, "Converison error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbx1max.Text = tbx1max.Text.Remove(tbx1max.Text.Length - 12);
            }
            try
            {
                x2max = double.Parse(tbx2max.Text);
            }
            catch (Exception ex)
            {
                string err = string.Format("Erroe X2max {0}", ex.Message);
                MessageBox.Show(err, "Converison error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbx2max.Text = tbx2max.Text.Remove(tbx2max.Text.Length - tbx2max.Text.Length);
            }
            try
            {
                dx2 = double.Parse(tbdx2.Text);
            }
            catch (Exception ex)
            {
                string err = string.Format("Erroe dX2 {0}", ex.Message);
                MessageBox.Show(err, "Converison error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbdx2.Text = tbdx2.Text.Remove(tbdx2.Text.Length - tbdx2.Text.Length);
            }

            gv.ColumnCount = (int)Math.Truncate((x2max - x2min) / dx2) + 1;
            gv.RowCount = (int)Math.Truncate((x1max - x1min) / dx1) + 1;
            for (int i = 0; i < gv.RowCount; i++)
                gv.Rows[i].HeaderCell.Value = (x1min + i * dx1).ToString("0.000");
            gv.RowHeadersWidth = 80;
            for (int i = 0; i < gv.ColumnCount; i++)
            {
                gv.Columns[i].HeaderCell.Value = (x2min + i * dx2).ToString("0.000");
                gv.Columns[i].Width = 60;
            }
            int cl, rw;
            double x1, x2, y;
            rw = 0;
            x1 = x1min;
            while (x1 <= x1max)
            {
                x2 = x2min;
                cl = 0;
                while (x2 <= x2max)
                {
                    y = (Math.Pow(Math.Sin(x1), 3) + 45 + x2) / 2 * Math.Pow(x1, 4) + 4 * x2;
                    gv.Rows[rw].Cells[cl].Value = y.ToString("#.####");
                    x2 += dx2; cl++;
                }
                x1 += dx1;
                rw++;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbx1min.Text = "";
            tbx1max.Text = "";
            tbx2min.Text = "";
            tbx2max.Text = "";
            tbdx1.Text = "";
            tbdx2.Text = "";
            gv.Rows.Clear();
            for (int Cl = 0; Cl < gv.ColumnCount; Cl++)
                gv.Columns[Cl].HeaderCell.Value = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити програму?", "Вихід з програми", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void tbx1min_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

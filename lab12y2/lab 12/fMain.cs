using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_12
{
    public partial class fMain : Form
    {
        CFigure[] figures;
        int FiguresCount = 0;
        int CurrentFigureIndex;

        public fMain()
        {
            InitializeComponent();
            figures = new CFigure[100];
            cbFigureType.SelectedIndex = 0;
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (FiguresCount >= 99)
            {
                MessageBox.Show("The limit of the number of objects was reached!!");
                return;
            }

            Graphics graphics = pnMain.CreateGraphics();
            CurrentFigureIndex = FiguresCount;

            if (cbFigureType.SelectedIndex == 0)
            {
                figures[CurrentFigureIndex] =
                    new CCircle(graphics, pnMain.Width / 2, pnMain.Height / 2,
                    50);
                cbCircle.Items.Add("Figure №" + (FiguresCount).ToString() +
                    " [Circle]");
            }

            else if (cbFigureType.SelectedIndex == 1)
            {
                figures[CurrentFigureIndex] = new CRectangle(graphics,
                pnMain.Width / 2, pnMain.Height / 2, 100, 50);
                cbCircle.Items.Add("Figure №" + (FiguresCount).ToString() +
                    " [Rectengle]");
            }
            else if (cbFigureType.SelectedIndex == 2)
            {
                figures[CurrentFigureIndex] = new CTriangle(graphics, 
                    pnMain.Width / 2, pnMain.Height / 2, 100);
                cbCircle.Items.Add("Figure №" + (FiguresCount).ToString() + 
                    " [Triangle]");
            }
            figures[CurrentFigureIndex].Show();
            FiguresCount++;
            cbFigureType.SelectedIndex = FiguresCount - 1;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbCircle.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;
    
            figures[CurrentFigureIndex].Hide();    
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbCircle.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;

            figures[CurrentFigureIndex].Show();     
           
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbCircle.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;          
            figures[CurrentFigureIndex].Expand(5);
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbCircle.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;
     
            figures[CurrentFigureIndex].Collapse(5);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbCircle.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;

            figures[CurrentFigureIndex].Move(0, -10);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbCircle.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;

            figures[CurrentFigureIndex].Move(0, 10);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbCircle.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;

            figures[CurrentFigureIndex].Move(10, 0);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbCircle.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;

            figures[CurrentFigureIndex].Move(-10, 0);
        }

        private void btnRightFar_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbCircle.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;

            for (int i = 0; i < 100; i++)
            {
                figures[CurrentFigureIndex].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnLeftFar_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbCircle.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;

            for (int i = 0; i < 100; i++)
            {
                figures[CurrentFigureIndex].Move(-1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnUpFar_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbCircle.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;

            for (int i = 0; i < 100; i++)
            {
                figures[CurrentFigureIndex].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnDownFar_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbCircle.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;

            for (int i = 0; i < 100; i++)
            {
                figures[CurrentFigureIndex].Move(0, 1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void cbFigureType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

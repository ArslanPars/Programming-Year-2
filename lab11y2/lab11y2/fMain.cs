using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11y2
{
    public partial class Lab11 : Form
    {
        public Lab11()
        {
            InitializeComponent();
            emblems = new CEmblem[100];
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (EmblemCount >= 99)
            {
                MessageBox.Show("The limit of the number of objects was reached!");
                return;
            }
            Graphics graphics = pnMain.CreateGraphics();
            CurrentEmblemIndex = EmblemCount;
            emblems[CurrentEmblemIndex] = new CEmblem(graphics, 250, 250);
            emblems[CurrentEmblemIndex].Show();
            EmblemCount++;
            cbEmblems.Items.Add("Emblem № " + (EmblemCount - 1).ToString());
            cbEmblems.SelectedIndex = EmblemCount - 1;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            emblems[CurrentEmblemIndex].Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            emblems[CurrentEmblemIndex].Show();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            emblems[CurrentEmblemIndex].Expand(5);
        }


        private void btnDown_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            emblems[CurrentEmblemIndex].Collapse(5);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            emblems[CurrentEmblemIndex].Move(0, -10);
        }

        private void dtnDown_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            emblems[CurrentEmblemIndex].Move(0, 10);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            emblems[CurrentEmblemIndex].Move(10, 0);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            emblems[CurrentEmblemIndex].Move(-10, 0);
        }

        private void btnUpFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(0 , -1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnDownFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(0, 1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnRightFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnLeftFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(-1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }
    }
}

namespace lab09y2
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.X1min = new System.Windows.Forms.Label();
            this.X1max = new System.Windows.Forms.Label();
            this.dX1 = new System.Windows.Forms.Label();
            this.X2min = new System.Windows.Forms.Label();
            this.X2max = new System.Windows.Forms.Label();
            this.dX2 = new System.Windows.Forms.Label();
            this.gv = new System.Windows.Forms.DataGridView();
            this.tbx1min = new System.Windows.Forms.TextBox();
            this.tbdx2 = new System.Windows.Forms.TextBox();
            this.tbdx1 = new System.Windows.Forms.TextBox();
            this.tbx2max = new System.Windows.Forms.TextBox();
            this.tbx2min = new System.Windows.Forms.TextBox();
            this.tbx1max = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbs = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // X1min
            // 
            this.X1min.AutoSize = true;
            this.X1min.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X1min.Location = new System.Drawing.Point(24, 29);
            this.X1min.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.X1min.Name = "X1min";
            this.X1min.Size = new System.Drawing.Size(57, 20);
            this.X1min.TabIndex = 0;
            this.X1min.Text = "X1min";
            // 
            // X1max
            // 
            this.X1max.AutoSize = true;
            this.X1max.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X1max.Location = new System.Drawing.Point(193, 29);
            this.X1max.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.X1max.Name = "X1max";
            this.X1max.Size = new System.Drawing.Size(57, 20);
            this.X1max.TabIndex = 1;
            this.X1max.Text = "X1max";
            // 
            // dX1
            // 
            this.dX1.AutoSize = true;
            this.dX1.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dX1.Location = new System.Drawing.Point(363, 29);
            this.dX1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dX1.Name = "dX1";
            this.dX1.Size = new System.Drawing.Size(39, 20);
            this.dX1.TabIndex = 2;
            this.dX1.Text = "dX1";
            // 
            // X2min
            // 
            this.X2min.AutoSize = true;
            this.X2min.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X2min.Location = new System.Drawing.Point(31, 86);
            this.X2min.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.X2min.Name = "X2min";
            this.X2min.Size = new System.Drawing.Size(57, 20);
            this.X2min.TabIndex = 3;
            this.X2min.Text = "X2min";
            // 
            // X2max
            // 
            this.X2max.AutoSize = true;
            this.X2max.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X2max.Location = new System.Drawing.Point(200, 86);
            this.X2max.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.X2max.Name = "X2max";
            this.X2max.Size = new System.Drawing.Size(57, 20);
            this.X2max.TabIndex = 4;
            this.X2max.Text = "X2max";
            // 
            // dX2
            // 
            this.dX2.AutoSize = true;
            this.dX2.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dX2.Location = new System.Drawing.Point(363, 86);
            this.dX2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dX2.Name = "dX2";
            this.dX2.Size = new System.Drawing.Size(39, 20);
            this.dX2.TabIndex = 5;
            this.dX2.Text = "dX2";
            // 
            // gv
            // 
            this.gv.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(28, 129);
            this.gv.Name = "gv";
            this.gv.ReadOnly = true;
            this.gv.RowHeadersWidth = 100;
            this.gv.Size = new System.Drawing.Size(489, 254);
            this.gv.TabIndex = 6;
            // 
            // tbx1min
            // 
            this.tbx1min.Location = new System.Drawing.Point(89, 26);
            this.tbx1min.MaxLength = 13;
            this.tbx1min.Name = "tbx1min";
            this.tbx1min.Size = new System.Drawing.Size(96, 28);
            this.tbx1min.TabIndex = 7;
            // 
            // tbdx2
            // 
            this.tbdx2.Location = new System.Drawing.Point(421, 83);
            this.tbdx2.MaxLength = 13;
            this.tbdx2.Name = "tbdx2";
            this.tbdx2.Size = new System.Drawing.Size(96, 28);
            this.tbdx2.TabIndex = 8;
            // 
            // tbdx1
            // 
            this.tbdx1.Location = new System.Drawing.Point(421, 26);
            this.tbdx1.MaxLength = 13;
            this.tbdx1.Name = "tbdx1";
            this.tbdx1.Size = new System.Drawing.Size(96, 28);
            this.tbdx1.TabIndex = 9;
            // 
            // tbx2max
            // 
            this.tbx2max.Location = new System.Drawing.Point(258, 83);
            this.tbx2max.MaxLength = 13;
            this.tbx2max.Name = "tbx2max";
            this.tbx2max.Size = new System.Drawing.Size(96, 28);
            this.tbx2max.TabIndex = 10;
            // 
            // tbx2min
            // 
            this.tbx2min.Location = new System.Drawing.Point(89, 83);
            this.tbx2min.MaxLength = 13;
            this.tbx2min.Name = "tbx2min";
            this.tbx2min.Size = new System.Drawing.Size(96, 28);
            this.tbx2min.TabIndex = 11;
            // 
            // tbx1max
            // 
            this.tbx1max.Location = new System.Drawing.Point(258, 26);
            this.tbx1max.MaxLength = 13;
            this.tbx1max.Name = "tbx1max";
            this.tbx1max.Size = new System.Drawing.Size(96, 28);
            this.tbx1max.TabIndex = 12;
            // 
            // btnCalc
            // 
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalc.Location = new System.Drawing.Point(558, 129);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(138, 34);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Calculet";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(558, 169);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 34);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(558, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 34);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbs
            // 
            this.tbs.Location = new System.Drawing.Point(605, 26);
            this.tbs.Name = "tbs";
            this.tbs.Size = new System.Drawing.Size(91, 28);
            this.tbs.TabIndex = 16;
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(554, 29);
            this.sum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(43, 20);
            this.sum.TabIndex = 17;
            this.sum.Text = "Sum";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(734, 395);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.tbs);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbx1max);
            this.Controls.Add(this.tbx2min);
            this.Controls.Add(this.tbx2max);
            this.Controls.Add(this.tbdx1);
            this.Controls.Add(this.tbdx2);
            this.Controls.Add(this.tbx1min);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.dX2);
            this.Controls.Add(this.X2max);
            this.Controls.Add(this.X2min);
            this.Controls.Add(this.dX1);
            this.Controls.Add(this.X1max);
            this.Controls.Add(this.X1min);
            this.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab09";
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label X1min;
        private System.Windows.Forms.Label X1max;
        private System.Windows.Forms.Label dX1;
        private System.Windows.Forms.Label X2min;
        private System.Windows.Forms.Label X2max;
        private System.Windows.Forms.Label dX2;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.TextBox tbx1min;
        private System.Windows.Forms.TextBox tbdx2;
        private System.Windows.Forms.TextBox tbdx1;
        private System.Windows.Forms.TextBox tbx2max;
        private System.Windows.Forms.TextBox tbx2min;
        private System.Windows.Forms.TextBox tbx1max;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbs;
        private System.Windows.Forms.Label sum;
    }
}


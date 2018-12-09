namespace lab11y2
{
    partial class Lab11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab11));
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnTools = new System.Windows.Forms.Panel();
            this.btnRightFar = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeftFar = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDownFar = new System.Windows.Forms.Button();
            this.dtnDown = new System.Windows.Forms.Button();
            this.btnUpFar = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.cbEmblems = new System.Windows.Forms.ComboBox();
            this.pnTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.AutoSize = true;
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(796, 475);
            this.pnMain.TabIndex = 0;
            // 
            // pnTools
            // 
            this.pnTools.Controls.Add(this.btnRightFar);
            this.pnTools.Controls.Add(this.btnRight);
            this.pnTools.Controls.Add(this.btnLeftFar);
            this.pnTools.Controls.Add(this.btnLeft);
            this.pnTools.Controls.Add(this.btnDownFar);
            this.pnTools.Controls.Add(this.dtnDown);
            this.pnTools.Controls.Add(this.btnUpFar);
            this.pnTools.Controls.Add(this.btnUp);
            this.pnTools.Controls.Add(this.btnDown);
            this.pnTools.Controls.Add(this.btnExpand);
            this.pnTools.Controls.Add(this.label1);
            this.pnTools.Controls.Add(this.btnShow);
            this.pnTools.Controls.Add(this.btnHide);
            this.pnTools.Controls.Add(this.btnCreateNew);
            this.pnTools.Controls.Add(this.cbEmblems);
            this.pnTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTools.Location = new System.Drawing.Point(453, 0);
            this.pnTools.Name = "pnTools";
            this.pnTools.Size = new System.Drawing.Size(343, 475);
            this.pnTools.TabIndex = 2;
            // 
            // btnRightFar
            // 
            this.btnRightFar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRightFar.Image = ((System.Drawing.Image)(resources.GetObject("btnRightFar.Image")));
            this.btnRightFar.Location = new System.Drawing.Point(264, 296);
            this.btnRightFar.Name = "btnRightFar";
            this.btnRightFar.Size = new System.Drawing.Size(41, 71);
            this.btnRightFar.TabIndex = 14;
            this.btnRightFar.UseVisualStyleBackColor = true;
            this.btnRightFar.Click += new System.EventHandler(this.btnRightFar_Click);
            // 
            // btnRight
            // 
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.Location = new System.Drawing.Point(220, 296);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(35, 71);
            this.btnRight.TabIndex = 13;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeftFar
            // 
            this.btnLeftFar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeftFar.Image = ((System.Drawing.Image)(resources.GetObject("btnLeftFar.Image")));
            this.btnLeftFar.Location = new System.Drawing.Point(43, 296);
            this.btnLeftFar.Name = "btnLeftFar";
            this.btnLeftFar.Size = new System.Drawing.Size(41, 71);
            this.btnLeftFar.TabIndex = 12;
            this.btnLeftFar.UseVisualStyleBackColor = true;
            this.btnLeftFar.Click += new System.EventHandler(this.btnLeftFar_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.Location = new System.Drawing.Point(91, 296);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(35, 71);
            this.btnLeft.TabIndex = 11;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDownFar
            // 
            this.btnDownFar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownFar.Image = global::lab11y2.Properties.Resources.down_down;
            this.btnDownFar.Location = new System.Drawing.Point(134, 412);
            this.btnDownFar.Name = "btnDownFar";
            this.btnDownFar.Size = new System.Drawing.Size(79, 38);
            this.btnDownFar.TabIndex = 10;
            this.btnDownFar.UseVisualStyleBackColor = true;
            this.btnDownFar.Click += new System.EventHandler(this.btnDownFar_Click);
            // 
            // dtnDown
            // 
            this.dtnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtnDown.Image = global::lab11y2.Properties.Resources.down;
            this.dtnDown.Location = new System.Drawing.Point(134, 374);
            this.dtnDown.Name = "dtnDown";
            this.dtnDown.Size = new System.Drawing.Size(79, 32);
            this.dtnDown.TabIndex = 9;
            this.dtnDown.UseVisualStyleBackColor = true;
            this.dtnDown.Click += new System.EventHandler(this.dtnDown_Click);
            // 
            // btnUpFar
            // 
            this.btnUpFar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpFar.Image = global::lab11y2.Properties.Resources.up_up;
            this.btnUpFar.Location = new System.Drawing.Point(134, 213);
            this.btnUpFar.Name = "btnUpFar";
            this.btnUpFar.Size = new System.Drawing.Size(79, 38);
            this.btnUpFar.TabIndex = 8;
            this.btnUpFar.UseVisualStyleBackColor = true;
            this.btnUpFar.Click += new System.EventHandler(this.btnUpFar_Click);
            // 
            // btnUp
            // 
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.Image = global::lab11y2.Properties.Resources.up;
            this.btnUp.Location = new System.Drawing.Point(134, 257);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(79, 32);
            this.btnUp.TabIndex = 7;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(134, 335);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(79, 32);
            this.btnDown.TabIndex = 6;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpand.Image = ((System.Drawing.Image)(resources.GetObject("btnExpand.Image")));
            this.btnExpand.Location = new System.Drawing.Point(134, 296);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(79, 32);
            this.btnExpand.TabIndex = 5;
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "List of objects";
            // 
            // btnShow
            // 
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(43, 162);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(253, 29);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show object";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHide
            // 
            this.btnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHide.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.Location = new System.Drawing.Point(43, 126);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(253, 29);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "Hide object";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateNew.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNew.Location = new System.Drawing.Point(43, 90);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(253, 29);
            this.btnCreateNew.TabIndex = 1;
            this.btnCreateNew.Text = "Create new object";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // cbEmblems
            // 
            this.cbEmblems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEmblems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmblems.FormattingEnabled = true;
            this.cbEmblems.Location = new System.Drawing.Point(21, 42);
            this.cbEmblems.Name = "cbEmblems";
            this.cbEmblems.Size = new System.Drawing.Size(301, 22);
            this.cbEmblems.TabIndex = 0;
            // 
            // Lab11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 475);
            this.Controls.Add(this.pnTools);
            this.Controls.Add(this.pnMain);
            this.Font = new System.Drawing.Font("Harlow Solid Italic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Lab11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab11";
            this.pnTools.ResumeLayout(false);
            this.pnTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnTools;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.ComboBox cbEmblems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnRightFar;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeftFar;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDownFar;
        private System.Windows.Forms.Button dtnDown;
        private System.Windows.Forms.Button btnUpFar;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnExpand;
        CEmblem[] emblems;
        int EmblemCount = 0;
        int CurrentEmblemIndex;
    }
}


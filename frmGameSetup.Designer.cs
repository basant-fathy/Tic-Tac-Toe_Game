namespace Tic_Tac_Toe
{
    partial class frmGameSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameSetup));
            this.button1 = new System.Windows.Forms.Button();
            this.txbPlayr1 = new System.Windows.Forms.TextBox();
            this.chkVSPC = new System.Windows.Forms.CheckBox();
            this.txbPlayr2 = new System.Windows.Forms.TextBox();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.rbMed = new System.Windows.Forms.RadioButton();
            this.ebHard = new System.Windows.Forms.RadioButton();
            this.pnlDiff = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pnlDiff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(504, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbPlayr1
            // 
            this.txbPlayr1.BackColor = System.Drawing.Color.Lavender;
            this.txbPlayr1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPlayr1.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPlayr1.ForeColor = System.Drawing.Color.BlueViolet;
            this.txbPlayr1.Location = new System.Drawing.Point(303, 269);
            this.txbPlayr1.Name = "txbPlayr1";
            this.txbPlayr1.Size = new System.Drawing.Size(323, 47);
            this.txbPlayr1.TabIndex = 0;
            this.txbPlayr1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirstPlayer_KeyDown);
            // 
            // chkVSPC
            // 
            this.chkVSPC.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkVSPC.BackColor = System.Drawing.Color.Transparent;
            this.chkVSPC.FlatAppearance.CheckedBackColor = System.Drawing.Color.IndianRed;
            this.chkVSPC.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVSPC.ForeColor = System.Drawing.Color.BlueViolet;
            this.chkVSPC.Location = new System.Drawing.Point(407, 344);
            this.chkVSPC.Name = "chkVSPC";
            this.chkVSPC.Size = new System.Drawing.Size(104, 38);
            this.chkVSPC.TabIndex = 3;
            this.chkVSPC.Text = "VS PC";
            this.chkVSPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkVSPC.UseVisualStyleBackColor = false;
            this.chkVSPC.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txbPlayr2
            // 
            this.txbPlayr2.BackColor = System.Drawing.Color.Lavender;
            this.txbPlayr2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPlayr2.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPlayr2.ForeColor = System.Drawing.Color.BlueViolet;
            this.txbPlayr2.Location = new System.Drawing.Point(303, 445);
            this.txbPlayr2.Name = "txbPlayr2";
            this.txbPlayr2.Size = new System.Drawing.Size(323, 47);
            this.txbPlayr2.TabIndex = 4;
            this.txbPlayr2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSecondPlayer_KeyDown);
            // 
            // rbEasy
            // 
            this.rbEasy.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbEasy.BackColor = System.Drawing.Color.PaleGreen;
            this.rbEasy.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEasy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rbEasy.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold);
            this.rbEasy.ForeColor = System.Drawing.Color.Indigo;
            this.rbEasy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbEasy.Location = new System.Drawing.Point(0, 3);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(166, 36);
            this.rbEasy.TabIndex = 5;
            this.rbEasy.TabStop = true;
            this.rbEasy.Tag = "1";
            this.rbEasy.Text = "Easy";
            this.rbEasy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEasy.UseVisualStyleBackColor = false;
            // 
            // rbMed
            // 
            this.rbMed.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMed.BackColor = System.Drawing.Color.Khaki;
            this.rbMed.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbMed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rbMed.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold);
            this.rbMed.ForeColor = System.Drawing.Color.Indigo;
            this.rbMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbMed.Location = new System.Drawing.Point(0, 49);
            this.rbMed.Name = "rbMed";
            this.rbMed.Size = new System.Drawing.Size(166, 36);
            this.rbMed.TabIndex = 6;
            this.rbMed.TabStop = true;
            this.rbMed.Tag = "2";
            this.rbMed.Text = "Medium";
            this.rbMed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbMed.UseVisualStyleBackColor = false;
            // 
            // ebHard
            // 
            this.ebHard.Appearance = System.Windows.Forms.Appearance.Button;
            this.ebHard.BackColor = System.Drawing.Color.Salmon;
            this.ebHard.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ebHard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ebHard.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold);
            this.ebHard.ForeColor = System.Drawing.Color.Indigo;
            this.ebHard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ebHard.Location = new System.Drawing.Point(0, 95);
            this.ebHard.Name = "ebHard";
            this.ebHard.Size = new System.Drawing.Size(166, 36);
            this.ebHard.TabIndex = 7;
            this.ebHard.TabStop = true;
            this.ebHard.Tag = "3";
            this.ebHard.Text = "Hard";
            this.ebHard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ebHard.UseVisualStyleBackColor = false;
            // 
            // pnlDiff
            // 
            this.pnlDiff.BackColor = System.Drawing.Color.Transparent;
            this.pnlDiff.Controls.Add(this.ebHard);
            this.pnlDiff.Controls.Add(this.rbEasy);
            this.pnlDiff.Controls.Add(this.rbMed);
            this.pnlDiff.Location = new System.Drawing.Point(799, 193);
            this.pnlDiff.Name = "pnlDiff";
            this.pnlDiff.Size = new System.Drawing.Size(166, 135);
            this.pnlDiff.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Lavender;
            this.numericUpDown1.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.BlueViolet;
            this.numericUpDown1.Location = new System.Drawing.Point(799, 417);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(166, 56);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyDown);
            // 
            // frmGameSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pnlDiff);
            this.Controls.Add(this.txbPlayr2);
            this.Controls.Add(this.chkVSPC);
            this.Controls.Add(this.txbPlayr1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGameSetup";
            this.Text = "GameSetup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGameSetup_FormClosed);
            this.Load += new System.EventHandler(this.frmGameSetup_Load);
            this.pnlDiff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbPlayr1;
        private System.Windows.Forms.CheckBox chkVSPC;
        private System.Windows.Forms.TextBox txbPlayr2;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.RadioButton rbMed;
        private System.Windows.Forms.RadioButton ebHard;
        private System.Windows.Forms.Panel pnlDiff;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
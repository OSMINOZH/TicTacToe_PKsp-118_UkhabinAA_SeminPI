namespace TicTacToe
{
    partial class PregameSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregameSetup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_regime = new System.Windows.Forms.Panel();
            this.regime_PvE = new System.Windows.Forms.RadioButton();
            this.regime_PvP = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_size = new System.Windows.Forms.Panel();
            this.size_5x5 = new System.Windows.Forms.RadioButton();
            this.size_4x4 = new System.Windows.Forms.RadioButton();
            this.size_3x3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.delimeter_1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.delimeter_2 = new System.Windows.Forms.Panel();
            this.panel_difficulty = new System.Windows.Forms.Panel();
            this.difficulty_hard = new System.Windows.Forms.RadioButton();
            this.difficulty_medium = new System.Windows.Forms.RadioButton();
            this.diffuculty_easy = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_regime.SuspendLayout();
            this.panel_size.SuspendLayout();
            this.panel_difficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 39);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(550, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // panel_regime
            // 
            this.panel_regime.Controls.Add(this.regime_PvE);
            this.panel_regime.Controls.Add(this.regime_PvP);
            this.panel_regime.Controls.Add(this.label2);
            this.panel_regime.Location = new System.Drawing.Point(0, 41);
            this.panel_regime.Name = "panel_regime";
            this.panel_regime.Size = new System.Drawing.Size(580, 91);
            this.panel_regime.TabIndex = 1;
            // 
            // regime_PvE
            // 
            this.regime_PvE.AutoSize = true;
            this.regime_PvE.Checked = true;
            this.regime_PvE.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regime_PvE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.regime_PvE.Location = new System.Drawing.Point(36, 50);
            this.regime_PvE.Name = "regime_PvE";
            this.regime_PvE.Size = new System.Drawing.Size(203, 28);
            this.regime_PvE.TabIndex = 5;
            this.regime_PvE.TabStop = true;
            this.regime_PvE.Text = "С компьютером";
            this.regime_PvE.UseVisualStyleBackColor = true;
            this.regime_PvE.MouseClick += new System.Windows.Forms.MouseEventHandler(this.regime_PvE_MouseClick);
            // 
            // regime_PvP
            // 
            this.regime_PvP.AutoSize = true;
            this.regime_PvP.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regime_PvP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.regime_PvP.Location = new System.Drawing.Point(416, 50);
            this.regime_PvP.Name = "regime_PvP";
            this.regime_PvP.Size = new System.Drawing.Size(129, 28);
            this.regime_PvP.TabIndex = 5;
            this.regime_PvP.TabStop = true;
            this.regime_PvP.Text = "С другом";
            this.regime_PvP.UseVisualStyleBackColor = true;
            this.regime_PvP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.regime_PvP_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.label2.Location = new System.Drawing.Point(219, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Режим игры:";
            // 
            // panel_size
            // 
            this.panel_size.Controls.Add(this.size_5x5);
            this.panel_size.Controls.Add(this.size_4x4);
            this.panel_size.Controls.Add(this.size_3x3);
            this.panel_size.Controls.Add(this.label1);
            this.panel_size.Location = new System.Drawing.Point(0, 149);
            this.panel_size.Name = "panel_size";
            this.panel_size.Size = new System.Drawing.Size(580, 104);
            this.panel_size.TabIndex = 1;
            // 
            // size_5x5
            // 
            this.size_5x5.AutoSize = true;
            this.size_5x5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size_5x5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.size_5x5.Location = new System.Drawing.Point(482, 62);
            this.size_5x5.Name = "size_5x5";
            this.size_5x5.Size = new System.Drawing.Size(62, 28);
            this.size_5x5.TabIndex = 8;
            this.size_5x5.TabStop = true;
            this.size_5x5.Text = "5x5";
            this.size_5x5.UseVisualStyleBackColor = true;
            this.size_5x5.Visible = false;
            this.size_5x5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.size_5x5_MouseClick);
            // 
            // size_4x4
            // 
            this.size_4x4.AutoSize = true;
            this.size_4x4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size_4x4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.size_4x4.Location = new System.Drawing.Point(259, 62);
            this.size_4x4.Name = "size_4x4";
            this.size_4x4.Size = new System.Drawing.Size(62, 28);
            this.size_4x4.TabIndex = 7;
            this.size_4x4.TabStop = true;
            this.size_4x4.Text = "4x4";
            this.size_4x4.UseVisualStyleBackColor = true;
            this.size_4x4.Visible = false;
            this.size_4x4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.size_4x4_MouseClick);
            // 
            // size_3x3
            // 
            this.size_3x3.AutoSize = true;
            this.size_3x3.Checked = true;
            this.size_3x3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size_3x3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.size_3x3.Location = new System.Drawing.Point(36, 62);
            this.size_3x3.Name = "size_3x3";
            this.size_3x3.Size = new System.Drawing.Size(62, 28);
            this.size_3x3.TabIndex = 6;
            this.size_3x3.TabStop = true;
            this.size_3x3.Text = "3x3";
            this.size_3x3.UseVisualStyleBackColor = true;
            this.size_3x3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.size_3x3_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.label1.Location = new System.Drawing.Point(215, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Размер поля:";
            // 
            // delimeter_1
            // 
            this.delimeter_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(33)))));
            this.delimeter_1.Location = new System.Drawing.Point(0, 138);
            this.delimeter_1.Name = "delimeter_1";
            this.delimeter_1.Size = new System.Drawing.Size(580, 5);
            this.delimeter_1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(33)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Fira Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(233, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Начать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delimeter_2
            // 
            this.delimeter_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(33)))));
            this.delimeter_2.Location = new System.Drawing.Point(0, 259);
            this.delimeter_2.Name = "delimeter_2";
            this.delimeter_2.Size = new System.Drawing.Size(580, 5);
            this.delimeter_2.TabIndex = 4;
            // 
            // panel_difficulty
            // 
            this.panel_difficulty.Controls.Add(this.difficulty_hard);
            this.panel_difficulty.Controls.Add(this.difficulty_medium);
            this.panel_difficulty.Controls.Add(this.diffuculty_easy);
            this.panel_difficulty.Controls.Add(this.label5);
            this.panel_difficulty.Location = new System.Drawing.Point(0, 270);
            this.panel_difficulty.Name = "panel_difficulty";
            this.panel_difficulty.Size = new System.Drawing.Size(580, 104);
            this.panel_difficulty.TabIndex = 3;
            // 
            // difficulty_hard
            // 
            this.difficulty_hard.AutoSize = true;
            this.difficulty_hard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.difficulty_hard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.difficulty_hard.Location = new System.Drawing.Point(431, 62);
            this.difficulty_hard.Name = "difficulty_hard";
            this.difficulty_hard.Size = new System.Drawing.Size(114, 28);
            this.difficulty_hard.TabIndex = 7;
            this.difficulty_hard.TabStop = true;
            this.difficulty_hard.Text = "Сложно";
            this.difficulty_hard.UseVisualStyleBackColor = true;
            this.difficulty_hard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.difficulty_hard_MouseClick);
            // 
            // difficulty_medium
            // 
            this.difficulty_medium.AutoSize = true;
            this.difficulty_medium.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.difficulty_medium.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.difficulty_medium.Location = new System.Drawing.Point(222, 62);
            this.difficulty_medium.Name = "difficulty_medium";
            this.difficulty_medium.Size = new System.Drawing.Size(113, 28);
            this.difficulty_medium.TabIndex = 7;
            this.difficulty_medium.TabStop = true;
            this.difficulty_medium.Text = "Средне";
            this.difficulty_medium.UseVisualStyleBackColor = true;
            this.difficulty_medium.MouseClick += new System.Windows.Forms.MouseEventHandler(this.difficulty_medium_MouseClick);
            // 
            // diffuculty_easy
            // 
            this.diffuculty_easy.AutoSize = true;
            this.diffuculty_easy.Checked = true;
            this.diffuculty_easy.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diffuculty_easy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.diffuculty_easy.Location = new System.Drawing.Point(36, 62);
            this.diffuculty_easy.Name = "diffuculty_easy";
            this.diffuculty_easy.Size = new System.Drawing.Size(90, 28);
            this.diffuculty_easy.TabIndex = 6;
            this.diffuculty_easy.TabStop = true;
            this.diffuculty_easy.Text = "Легко";
            this.diffuculty_easy.UseVisualStyleBackColor = true;
            this.diffuculty_easy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.diffuculty_easy_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.label5.Location = new System.Drawing.Point(224, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Сложность:";
            // 
            // PregameSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(580, 440);
            this.ControlBox = false;
            this.Controls.Add(this.delimeter_2);
            this.Controls.Add(this.panel_difficulty);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delimeter_1);
            this.Controls.Add(this.panel_size);
            this.Controls.Add(this.panel_regime);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PregameSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_regime.ResumeLayout(false);
            this.panel_regime.PerformLayout();
            this.panel_size.ResumeLayout(false);
            this.panel_size.PerformLayout();
            this.panel_difficulty.ResumeLayout(false);
            this.panel_difficulty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_regime;
        private System.Windows.Forms.Panel panel_size;
        private System.Windows.Forms.Panel delimeter_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton regime_PvE;
        private System.Windows.Forms.RadioButton regime_PvP;
        private System.Windows.Forms.RadioButton size_5x5;
        private System.Windows.Forms.RadioButton size_4x4;
        private System.Windows.Forms.RadioButton size_3x3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel delimeter_2;
        private System.Windows.Forms.Panel panel_difficulty;
        private System.Windows.Forms.RadioButton difficulty_hard;
        private System.Windows.Forms.RadioButton difficulty_medium;
        private System.Windows.Forms.RadioButton diffuculty_easy;
        private System.Windows.Forms.Label label5;
    }
}
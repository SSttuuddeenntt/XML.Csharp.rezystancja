namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.b_LoadK = new System.Windows.Forms.Button();
            this.tb_source = new System.Windows.Forms.TextBox();
            this.R_R_Label = new System.Windows.Forms.Label();
            this.R_L_Label = new System.Windows.Forms.Label();
            this.R_C_Label = new System.Windows.Forms.Label();
            this.Menu_tytul = new System.Windows.Forms.Label();
            this.b_R = new System.Windows.Forms.Button();
            this.b_L = new System.Windows.Forms.Button();
            this.b_dir = new System.Windows.Forms.Button();
            this.tytul = new System.Windows.Forms.Label();
            this.b_LoadC = new System.Windows.Forms.Button();
            this.b_LoadR = new System.Windows.Forms.Button();
            this.PB = new System.Windows.Forms.PictureBox();
            this.L_L_Label = new System.Windows.Forms.Label();
            this.L_R_Label = new System.Windows.Forms.Label();
            this.L_C_Label = new System.Windows.Forms.Label();
            this.C_RC_Label = new System.Windows.Forms.Label();
            this.C_C_Label = new System.Windows.Forms.Label();
            this.C_L_Label = new System.Windows.Forms.Label();
            this.C_RS_Label = new System.Windows.Forms.Label();
            this.b_back = new System.Windows.Forms.Button();
            this.LB_Dane = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // b_LoadK
            // 
            this.b_LoadK.Location = new System.Drawing.Point(24, 92);
            this.b_LoadK.Margin = new System.Windows.Forms.Padding(2);
            this.b_LoadK.Name = "b_LoadK";
            this.b_LoadK.Size = new System.Drawing.Size(80, 40);
            this.b_LoadK.TabIndex = 0;
            this.b_LoadK.Text = "Kondensator";
            this.b_LoadK.UseVisualStyleBackColor = true;
            this.b_LoadK.Click += new System.EventHandler(this.b_LoadK_Click);
            // 
            // tb_source
            // 
            this.tb_source.Location = new System.Drawing.Point(50, 51);
            this.tb_source.Margin = new System.Windows.Forms.Padding(2);
            this.tb_source.Name = "tb_source";
            this.tb_source.Size = new System.Drawing.Size(241, 20);
            this.tb_source.TabIndex = 1;
            // 
            // R_R_Label
            // 
            this.R_R_Label.AutoSize = true;
            this.R_R_Label.BackColor = System.Drawing.SystemColors.Window;
            this.R_R_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.R_R_Label.Location = new System.Drawing.Point(172, 150);
            this.R_R_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.R_R_Label.Name = "R_R_Label";
            this.R_R_Label.Size = new System.Drawing.Size(46, 17);
            this.R_R_Label.TabIndex = 3;
            this.R_R_Label.Text = "label1";
            this.R_R_Label.Visible = false;
            // 
            // R_L_Label
            // 
            this.R_L_Label.AutoSize = true;
            this.R_L_Label.BackColor = System.Drawing.SystemColors.Window;
            this.R_L_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.R_L_Label.Location = new System.Drawing.Point(287, 141);
            this.R_L_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.R_L_Label.Name = "R_L_Label";
            this.R_L_Label.Size = new System.Drawing.Size(46, 17);
            this.R_L_Label.TabIndex = 4;
            this.R_L_Label.Text = "label1";
            this.R_L_Label.Visible = false;
            // 
            // R_C_Label
            // 
            this.R_C_Label.AutoSize = true;
            this.R_C_Label.BackColor = System.Drawing.SystemColors.Window;
            this.R_C_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_C_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.R_C_Label.Location = new System.Drawing.Point(241, 229);
            this.R_C_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.R_C_Label.Name = "R_C_Label";
            this.R_C_Label.Size = new System.Drawing.Size(46, 17);
            this.R_C_Label.TabIndex = 5;
            this.R_C_Label.Text = "label1";
            this.R_C_Label.Visible = false;
            // 
            // Menu_tytul
            // 
            this.Menu_tytul.AutoSize = true;
            this.Menu_tytul.Font = new System.Drawing.Font("Arial", 12.2F);
            this.Menu_tytul.Location = new System.Drawing.Point(88, 17);
            this.Menu_tytul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Menu_tytul.Name = "Menu_tytul";
            this.Menu_tytul.Size = new System.Drawing.Size(171, 19);
            this.Menu_tytul.TabIndex = 6;
            this.Menu_tytul.Text = "Wybierz plik z danymi";
            // 
            // b_R
            // 
            this.b_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_R.Location = new System.Drawing.Point(446, 150);
            this.b_R.Margin = new System.Windows.Forms.Padding(2);
            this.b_R.Name = "b_R";
            this.b_R.Size = new System.Drawing.Size(30, 24);
            this.b_R.TabIndex = 7;
            this.b_R.Text = "→";
            this.b_R.UseVisualStyleBackColor = true;
            this.b_R.Visible = false;
            this.b_R.Click += new System.EventHandler(this.b_R_Click);
            // 
            // b_L
            // 
            this.b_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_L.Location = new System.Drawing.Point(26, 150);
            this.b_L.Margin = new System.Windows.Forms.Padding(2);
            this.b_L.Name = "b_L";
            this.b_L.Size = new System.Drawing.Size(30, 24);
            this.b_L.TabIndex = 8;
            this.b_L.Text = "←";
            this.b_L.UseVisualStyleBackColor = true;
            this.b_L.Visible = false;
            this.b_L.Click += new System.EventHandler(this.b_L_Click);
            // 
            // b_dir
            // 
            this.b_dir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.b_dir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_dir.Location = new System.Drawing.Point(268, 52);
            this.b_dir.Margin = new System.Windows.Forms.Padding(0);
            this.b_dir.Name = "b_dir";
            this.b_dir.Size = new System.Drawing.Size(22, 18);
            this.b_dir.TabIndex = 9;
            this.b_dir.Text = "...";
            this.b_dir.UseVisualStyleBackColor = true;
            this.b_dir.Click += new System.EventHandler(this.b_dir_Click);
            // 
            // tytul
            // 
            this.tytul.AutoSize = true;
            this.tytul.Font = new System.Drawing.Font("Arial", 14F);
            this.tytul.Location = new System.Drawing.Point(150, 28);
            this.tytul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(61, 22);
            this.tytul.TabIndex = 10;
            this.tytul.Text = "label1";
            this.tytul.Visible = false;
            // 
            // b_LoadC
            // 
            this.b_LoadC.Location = new System.Drawing.Point(128, 92);
            this.b_LoadC.Margin = new System.Windows.Forms.Padding(2);
            this.b_LoadC.Name = "b_LoadC";
            this.b_LoadC.Size = new System.Drawing.Size(80, 40);
            this.b_LoadC.TabIndex = 11;
            this.b_LoadC.Text = "Cewka";
            this.b_LoadC.UseVisualStyleBackColor = true;
            this.b_LoadC.Click += new System.EventHandler(this.b_LoadC_Click);
            // 
            // b_LoadR
            // 
            this.b_LoadR.Location = new System.Drawing.Point(232, 92);
            this.b_LoadR.Margin = new System.Windows.Forms.Padding(2);
            this.b_LoadR.Name = "b_LoadR";
            this.b_LoadR.Size = new System.Drawing.Size(80, 40);
            this.b_LoadR.TabIndex = 12;
            this.b_LoadR.Text = "Rezystor";
            this.b_LoadR.UseVisualStyleBackColor = true;
            this.b_LoadR.Click += new System.EventHandler(this.b_LoadR_Click);
            // 
            // PB
            // 
            this.PB.Cursor = System.Windows.Forms.Cursors.Default;
            this.PB.Image = global::WindowsFormsApp1.Properties.Resources.Schemat_kondensatora;
            this.PB.Location = new System.Drawing.Point(82, 74);
            this.PB.Margin = new System.Windows.Forms.Padding(2);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(338, 179);
            this.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB.TabIndex = 2;
            this.PB.TabStop = false;
            this.PB.Visible = false;
            // 
            // L_L_Label
            // 
            this.L_L_Label.AutoSize = true;
            this.L_L_Label.BackColor = System.Drawing.SystemColors.Window;
            this.L_L_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.L_L_Label.Location = new System.Drawing.Point(172, 150);
            this.L_L_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_L_Label.Name = "L_L_Label";
            this.L_L_Label.Size = new System.Drawing.Size(46, 17);
            this.L_L_Label.TabIndex = 13;
            this.L_L_Label.Text = "label1";
            this.L_L_Label.Visible = false;
            // 
            // L_R_Label
            // 
            this.L_R_Label.AutoSize = true;
            this.L_R_Label.BackColor = System.Drawing.SystemColors.Window;
            this.L_R_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.L_R_Label.Location = new System.Drawing.Point(287, 141);
            this.L_R_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_R_Label.Name = "L_R_Label";
            this.L_R_Label.Size = new System.Drawing.Size(46, 17);
            this.L_R_Label.TabIndex = 14;
            this.L_R_Label.Text = "label1";
            this.L_R_Label.Visible = false;
            // 
            // L_C_Label
            // 
            this.L_C_Label.AutoSize = true;
            this.L_C_Label.BackColor = System.Drawing.SystemColors.Window;
            this.L_C_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.L_C_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.L_C_Label.Location = new System.Drawing.Point(241, 229);
            this.L_C_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_C_Label.Name = "L_C_Label";
            this.L_C_Label.Size = new System.Drawing.Size(46, 17);
            this.L_C_Label.TabIndex = 15;
            this.L_C_Label.Text = "label1";
            this.L_C_Label.Visible = false;
            // 
            // C_RC_Label
            // 
            this.C_RC_Label.AutoSize = true;
            this.C_RC_Label.BackColor = System.Drawing.SystemColors.Window;
            this.C_RC_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C_RC_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.C_RC_Label.Location = new System.Drawing.Point(326, 210);
            this.C_RC_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.C_RC_Label.Name = "C_RC_Label";
            this.C_RC_Label.Size = new System.Drawing.Size(46, 17);
            this.C_RC_Label.TabIndex = 18;
            this.C_RC_Label.Text = "label1";
            this.C_RC_Label.Visible = false;
            // 
            // C_C_Label
            // 
            this.C_C_Label.AutoSize = true;
            this.C_C_Label.BackColor = System.Drawing.SystemColors.Window;
            this.C_C_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.C_C_Label.Location = new System.Drawing.Point(326, 104);
            this.C_C_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.C_C_Label.Name = "C_C_Label";
            this.C_C_Label.Size = new System.Drawing.Size(46, 17);
            this.C_C_Label.TabIndex = 17;
            this.C_C_Label.Text = "label1";
            this.C_C_Label.Visible = false;
            // 
            // C_L_Label
            // 
            this.C_L_Label.AutoSize = true;
            this.C_L_Label.BackColor = System.Drawing.SystemColors.Window;
            this.C_L_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.C_L_Label.Location = new System.Drawing.Point(199, 167);
            this.C_L_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.C_L_Label.Name = "C_L_Label";
            this.C_L_Label.Size = new System.Drawing.Size(46, 17);
            this.C_L_Label.TabIndex = 16;
            this.C_L_Label.Text = "label1";
            this.C_L_Label.Visible = false;
            // 
            // C_RS_Label
            // 
            this.C_RS_Label.AutoSize = true;
            this.C_RS_Label.BackColor = System.Drawing.SystemColors.Window;
            this.C_RS_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C_RS_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.C_RS_Label.Location = new System.Drawing.Point(115, 176);
            this.C_RS_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.C_RS_Label.Name = "C_RS_Label";
            this.C_RS_Label.Size = new System.Drawing.Size(46, 17);
            this.C_RS_Label.TabIndex = 19;
            this.C_RS_Label.Text = "label1";
            this.C_RS_Label.Visible = false;
            // 
            // b_back
            // 
            this.b_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_back.Location = new System.Drawing.Point(13, 13);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(30, 30);
            this.b_back.TabIndex = 20;
            this.b_back.Text = "↩";
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Visible = false;
            this.b_back.Click += new System.EventHandler(this.b_back_Click);
            // 
            // LB_Dane
            // 
            this.LB_Dane.FormattingEnabled = true;
            this.LB_Dane.Location = new System.Drawing.Point(338, 24);
            this.LB_Dane.Name = "LB_Dane";
            this.LB_Dane.Size = new System.Drawing.Size(130, 108);
            this.LB_Dane.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(723, 264);
            this.Controls.Add(this.LB_Dane);
            this.Controls.Add(this.b_back);
            this.Controls.Add(this.C_RS_Label);
            this.Controls.Add(this.C_RC_Label);
            this.Controls.Add(this.C_C_Label);
            this.Controls.Add(this.C_L_Label);
            this.Controls.Add(this.L_C_Label);
            this.Controls.Add(this.L_R_Label);
            this.Controls.Add(this.L_L_Label);
            this.Controls.Add(this.b_LoadR);
            this.Controls.Add(this.b_LoadC);
            this.Controls.Add(this.tytul);
            this.Controls.Add(this.b_dir);
            this.Controls.Add(this.b_L);
            this.Controls.Add(this.b_R);
            this.Controls.Add(this.Menu_tytul);
            this.Controls.Add(this.R_C_Label);
            this.Controls.Add(this.R_L_Label);
            this.Controls.Add(this.R_R_Label);
            this.Controls.Add(this.tb_source);
            this.Controls.Add(this.b_LoadK);
            this.Controls.Add(this.PB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Czytnik";
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_LoadK;
        private System.Windows.Forms.TextBox tb_source;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.Label R_R_Label;
        private System.Windows.Forms.Label R_L_Label;
        private System.Windows.Forms.Label R_C_Label;
        private System.Windows.Forms.Label Menu_tytul;
        private System.Windows.Forms.Button b_R;
        private System.Windows.Forms.Button b_L;
        private System.Windows.Forms.Button b_dir;
        private System.Windows.Forms.Label tytul;
        private System.Windows.Forms.Button b_LoadC;
        private System.Windows.Forms.Button b_LoadR;
        private System.Windows.Forms.Label L_L_Label;
        private System.Windows.Forms.Label L_R_Label;
        private System.Windows.Forms.Label L_C_Label;
        private System.Windows.Forms.Label C_RC_Label;
        private System.Windows.Forms.Label C_C_Label;
        private System.Windows.Forms.Label C_L_Label;
        private System.Windows.Forms.Label C_RS_Label;
        private System.Windows.Forms.Button b_back;
        private System.Windows.Forms.ListBox LB_Dane;
    }
}


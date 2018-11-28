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
            this.b_Load = new System.Windows.Forms.Button();
            this.tb_source = new System.Windows.Forms.TextBox();
            this.PB = new System.Windows.Forms.PictureBox();
            this.R_Label = new System.Windows.Forms.Label();
            this.L_Label = new System.Windows.Forms.Label();
            this.C_Label = new System.Windows.Forms.Label();
            this.Menu_tytul = new System.Windows.Forms.Label();
            this.b_R = new System.Windows.Forms.Button();
            this.b_L = new System.Windows.Forms.Button();
            this.b_dir = new System.Windows.Forms.Button();
            this.tytul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // b_Load
            // 
            this.b_Load.Location = new System.Drawing.Point(73, 87);
            this.b_Load.Margin = new System.Windows.Forms.Padding(2);
            this.b_Load.Name = "b_Load";
            this.b_Load.Size = new System.Drawing.Size(192, 60);
            this.b_Load.TabIndex = 0;
            this.b_Load.Text = "Wczytaj plik XML";
            this.b_Load.UseVisualStyleBackColor = true;
            this.b_Load.Click += new System.EventHandler(this.b_Load_Click);
            // 
            // tb_source
            // 
            this.tb_source.Location = new System.Drawing.Point(50, 51);
            this.tb_source.Margin = new System.Windows.Forms.Padding(2);
            this.tb_source.Name = "tb_source";
            this.tb_source.Size = new System.Drawing.Size(241, 20);
            this.tb_source.TabIndex = 1;
            // 
            // PB
            // 
            this.PB.Cursor = System.Windows.Forms.Cursors.Default;
            this.PB.Image = global::WindowsFormsApp1.Properties.Resources.Schemat_rezystora;
            this.PB.Location = new System.Drawing.Point(82, 74);
            this.PB.Margin = new System.Windows.Forms.Padding(2);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(338, 179);
            this.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB.TabIndex = 2;
            this.PB.TabStop = false;
            this.PB.Visible = false;
            // 
            // R_Label
            // 
            this.R_Label.AutoSize = true;
            this.R_Label.BackColor = System.Drawing.SystemColors.Window;
            this.R_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.R_Label.Location = new System.Drawing.Point(172, 150);
            this.R_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.R_Label.Name = "R_Label";
            this.R_Label.Size = new System.Drawing.Size(46, 17);
            this.R_Label.TabIndex = 3;
            this.R_Label.Text = "label1";
            this.R_Label.Visible = false;
            // 
            // L_Label
            // 
            this.L_Label.AutoSize = true;
            this.L_Label.BackColor = System.Drawing.SystemColors.Window;
            this.L_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.L_Label.Location = new System.Drawing.Point(287, 141);
            this.L_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Label.Name = "L_Label";
            this.L_Label.Size = new System.Drawing.Size(46, 17);
            this.L_Label.TabIndex = 4;
            this.L_Label.Text = "label1";
            this.L_Label.Visible = false;
            // 
            // C_Label
            // 
            this.C_Label.AutoSize = true;
            this.C_Label.BackColor = System.Drawing.SystemColors.Window;
            this.C_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.C_Label.Location = new System.Drawing.Point(241, 229);
            this.C_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.C_Label.Name = "C_Label";
            this.C_Label.Size = new System.Drawing.Size(46, 17);
            this.C_Label.TabIndex = 5;
            this.C_Label.Text = "label1";
            this.C_Label.Visible = false;
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
            this.tytul.Location = new System.Drawing.Point(198, 28);
            this.tytul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(61, 22);
            this.tytul.TabIndex = 10;
            this.tytul.Text = "label1";
            this.tytul.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(346, 170);
            this.Controls.Add(this.tytul);
            this.Controls.Add(this.b_dir);
            this.Controls.Add(this.b_L);
            this.Controls.Add(this.b_R);
            this.Controls.Add(this.Menu_tytul);
            this.Controls.Add(this.C_Label);
            this.Controls.Add(this.L_Label);
            this.Controls.Add(this.R_Label);
            this.Controls.Add(this.tb_source);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.b_Load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Czytnik";
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Load;
        private System.Windows.Forms.TextBox tb_source;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.Label R_Label;
        private System.Windows.Forms.Label L_Label;
        private System.Windows.Forms.Label C_Label;
        private System.Windows.Forms.Label Menu_tytul;
        private System.Windows.Forms.Button b_R;
        private System.Windows.Forms.Button b_L;
        private System.Windows.Forms.Button b_dir;
        private System.Windows.Forms.Label tytul;
    }
}


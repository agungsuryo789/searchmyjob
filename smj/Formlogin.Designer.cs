namespace smj
{
    partial class Formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            this.tblogin = new System.Windows.Forms.TextBox();
            this.tbloginpw = new System.Windows.Forms.TextBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbmin = new System.Windows.Forms.PictureBox();
            this.pbclose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblogin
            // 
            this.tblogin.BackColor = System.Drawing.SystemColors.Window;
            this.tblogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblogin.Location = new System.Drawing.Point(158, 191);
            this.tblogin.Multiline = true;
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(114, 20);
            this.tblogin.TabIndex = 2;
            this.tblogin.Text = "Username";
            this.tblogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tblogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tblogin_MouseClick);
            // 
            // tbloginpw
            // 
            this.tbloginpw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbloginpw.Location = new System.Drawing.Point(158, 261);
            this.tbloginpw.Multiline = true;
            this.tbloginpw.Name = "tbloginpw";
            this.tbloginpw.PasswordChar = '*';
            this.tbloginpw.Size = new System.Drawing.Size(114, 20);
            this.tbloginpw.TabIndex = 3;
            this.tbloginpw.Text = "Password";
            this.tbloginpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbloginpw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbloginpw_MouseClick);
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.Transparent;
            this.btlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btlogin.BackgroundImage")));
            this.btlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btlogin.Location = new System.Drawing.Point(190, 301);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(49, 47);
            this.btlogin.TabIndex = 4;
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pbmin);
            this.panel1.Controls.Add(this.pbclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 38);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pbmin
            // 
            this.pbmin.Image = ((System.Drawing.Image)(resources.GetObject("pbmin.Image")));
            this.pbmin.Location = new System.Drawing.Point(341, 0);
            this.pbmin.Name = "pbmin";
            this.pbmin.Size = new System.Drawing.Size(35, 36);
            this.pbmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmin.TabIndex = 7;
            this.pbmin.TabStop = false;
            // 
            // pbclose
            // 
            this.pbclose.Image = ((System.Drawing.Image)(resources.GetObject("pbclose.Image")));
            this.pbclose.Location = new System.Drawing.Point(382, 0);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(37, 36);
            this.pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbclose.TabIndex = 6;
            this.pbclose.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(158, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 118);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.tbloginpw);
            this.Controls.Add(this.tblogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formlogin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbloginpw;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.TextBox tblogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbmin;
        private System.Windows.Forms.PictureBox pbclose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
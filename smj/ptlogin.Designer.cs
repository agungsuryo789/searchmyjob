namespace smj
{
    partial class ptlogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ptlogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.tbloginpw = new System.Windows.Forms.TextBox();
            this.tblogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(160, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 118);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.Transparent;
            this.btlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btlogin.BackgroundImage")));
            this.btlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btlogin.Location = new System.Drawing.Point(192, 320);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(49, 47);
            this.btlogin.TabIndex = 9;
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // tbloginpw
            // 
            this.tbloginpw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbloginpw.Location = new System.Drawing.Point(160, 280);
            this.tbloginpw.Multiline = true;
            this.tbloginpw.Name = "tbloginpw";
            this.tbloginpw.PasswordChar = '*';
            this.tbloginpw.Size = new System.Drawing.Size(114, 20);
            this.tbloginpw.TabIndex = 8;
            this.tbloginpw.Text = "Password";
            this.tbloginpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbloginpw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbloginpw_MouseClick);
            // 
            // tblogin
            // 
            this.tblogin.BackColor = System.Drawing.SystemColors.Window;
            this.tblogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblogin.Location = new System.Drawing.Point(160, 210);
            this.tblogin.Multiline = true;
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(114, 20);
            this.tblogin.TabIndex = 7;
            this.tblogin.Text = "Username";
            this.tblogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tblogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tblogin_MouseClick);
            // 
            // ptlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.tbloginpw);
            this.Controls.Add(this.tblogin);
            this.Name = "ptlogin";
            this.Size = new System.Drawing.Size(421, 509);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.TextBox tbloginpw;
        private System.Windows.Forms.TextBox tblogin;
    }
}

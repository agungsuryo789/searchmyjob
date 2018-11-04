namespace smj
{
    partial class fpthome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fpthome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbmin = new System.Windows.Forms.PictureBox();
            this.pbclose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbnamapt = new System.Windows.Forms.Label();
            this.lbemailpt = new System.Windows.Forms.Label();
            this.lbkotapt = new System.Windows.Forms.Label();
            this.lbnotept = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pndelete = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pndelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pbmin);
            this.panel1.Controls.Add(this.pbclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 38);
            this.panel1.TabIndex = 0;
            // 
            // pbmin
            // 
            this.pbmin.Image = ((System.Drawing.Image)(resources.GetObject("pbmin.Image")));
            this.pbmin.Location = new System.Drawing.Point(512, 0);
            this.pbmin.Name = "pbmin";
            this.pbmin.Size = new System.Drawing.Size(35, 36);
            this.pbmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmin.TabIndex = 9;
            this.pbmin.TabStop = false;
            this.pbmin.Click += new System.EventHandler(this.pbmin_Click);
            // 
            // pbclose
            // 
            this.pbclose.Image = ((System.Drawing.Image)(resources.GetObject("pbclose.Image")));
            this.pbclose.Location = new System.Drawing.Point(553, 0);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(37, 36);
            this.pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbclose.TabIndex = 8;
            this.pbclose.TabStop = false;
            this.pbclose.Click += new System.EventHandler(this.pbclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account Setting";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbnamapt
            // 
            this.lbnamapt.AutoSize = true;
            this.lbnamapt.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnamapt.Location = new System.Drawing.Point(193, 142);
            this.lbnamapt.Name = "lbnamapt";
            this.lbnamapt.Size = new System.Drawing.Size(40, 15);
            this.lbnamapt.TabIndex = 4;
            this.lbnamapt.Text = "label2";
            // 
            // lbemailpt
            // 
            this.lbemailpt.AutoSize = true;
            this.lbemailpt.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemailpt.Location = new System.Drawing.Point(193, 197);
            this.lbemailpt.Name = "lbemailpt";
            this.lbemailpt.Size = new System.Drawing.Size(40, 15);
            this.lbemailpt.TabIndex = 5;
            this.lbemailpt.Text = "label2";
            // 
            // lbkotapt
            // 
            this.lbkotapt.AutoSize = true;
            this.lbkotapt.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkotapt.Location = new System.Drawing.Point(193, 260);
            this.lbkotapt.Name = "lbkotapt";
            this.lbkotapt.Size = new System.Drawing.Size(40, 15);
            this.lbkotapt.TabIndex = 6;
            this.lbkotapt.Text = "label2";
            // 
            // lbnotept
            // 
            this.lbnotept.AutoSize = true;
            this.lbnotept.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnotept.Location = new System.Drawing.Point(193, 334);
            this.lbnotept.Name = "lbnotept";
            this.lbnotept.Size = new System.Drawing.Size(40, 15);
            this.lbnotept.TabIndex = 7;
            this.lbnotept.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Stop Recruiting";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pndelete
            // 
            this.pndelete.Controls.Add(this.button2);
            this.pndelete.Controls.Add(this.textBox2);
            this.pndelete.Controls.Add(this.textBox1);
            this.pndelete.Location = new System.Drawing.Point(12, 462);
            this.pndelete.Name = "pndelete";
            this.pndelete.Size = new System.Drawing.Size(255, 108);
            this.pndelete.TabIndex = 9;
            this.pndelete.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(9, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Username";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(10, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(162, 21);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Password";
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(9, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fpthome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 582);
            this.Controls.Add(this.pndelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbnotept);
            this.Controls.Add(this.lbkotapt);
            this.Controls.Add(this.lbemailpt);
            this.Controls.Add(this.lbnamapt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fpthome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fpthome";
            this.Load += new System.EventHandler(this.fpthome_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pndelete.ResumeLayout(false);
            this.pndelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbmin;
        private System.Windows.Forms.PictureBox pbclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbnamapt;
        private System.Windows.Forms.Label lbemailpt;
        private System.Windows.Forms.Label lbkotapt;
        private System.Windows.Forms.Label lbnotept;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pndelete;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}
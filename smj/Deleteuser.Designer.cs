namespace smj
{
    partial class Deleteuser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btdelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbdeluser = new System.Windows.Forms.TextBox();
            this.tbdelpw = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btdelete);
            this.panel1.Location = new System.Drawing.Point(123, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 196);
            this.panel1.TabIndex = 0;
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btdelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btdelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.Location = new System.Drawing.Point(74, 56);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(156, 60);
            this.btdelete.TabIndex = 0;
            this.btdelete.Text = "Delete my account";
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tbdelpw);
            this.panel2.Controls.Add(this.tbdeluser);
            this.panel2.Location = new System.Drawing.Point(75, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 193);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // tbdeluser
            // 
            this.tbdeluser.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdeluser.Location = new System.Drawing.Point(28, 20);
            this.tbdeluser.Name = "tbdeluser";
            this.tbdeluser.Size = new System.Drawing.Size(250, 22);
            this.tbdeluser.TabIndex = 0;
            this.tbdeluser.Text = "Username";
            // 
            // tbdelpw
            // 
            this.tbdelpw.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdelpw.Location = new System.Drawing.Point(28, 73);
            this.tbdelpw.Name = "tbdelpw";
            this.tbdelpw.PasswordChar = '*';
            this.tbdelpw.Size = new System.Drawing.Size(250, 23);
            this.tbdelpw.TabIndex = 1;
            this.tbdelpw.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete my account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deleteuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Deleteuser";
            this.Size = new System.Drawing.Size(542, 589);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbdelpw;
        private System.Windows.Forms.TextBox tbdeluser;
    }
}

namespace smj
{
    partial class cvcv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cvcv));
            this.pbfotocv = new System.Windows.Forms.PictureBox();
            this.lbgender = new System.Windows.Forms.Label();
            this.lbumur = new System.Windows.Forms.Label();
            this.lbkota = new System.Windows.Forms.Label();
            this.lbjurusan = new System.Windows.Forms.Label();
            this.lbstrata = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbnama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbfotocv)).BeginInit();
            this.SuspendLayout();
            // 
            // pbfotocv
            // 
            this.pbfotocv.Location = new System.Drawing.Point(79, 28);
            this.pbfotocv.Name = "pbfotocv";
            this.pbfotocv.Size = new System.Drawing.Size(144, 150);
            this.pbfotocv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbfotocv.TabIndex = 17;
            this.pbfotocv.TabStop = false;
            // 
            // lbgender
            // 
            this.lbgender.AutoSize = true;
            this.lbgender.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgender.Location = new System.Drawing.Point(149, 545);
            this.lbgender.Name = "lbgender";
            this.lbgender.Size = new System.Drawing.Size(60, 17);
            this.lbgender.TabIndex = 16;
            this.lbgender.Text = "Gender";
            // 
            // lbumur
            // 
            this.lbumur.AutoSize = true;
            this.lbumur.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbumur.Location = new System.Drawing.Point(126, 504);
            this.lbumur.Name = "lbumur";
            this.lbumur.Size = new System.Drawing.Size(47, 17);
            this.lbumur.TabIndex = 15;
            this.lbumur.Text = "Umur";
            // 
            // lbkota
            // 
            this.lbkota.AutoSize = true;
            this.lbkota.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkota.Location = new System.Drawing.Point(60, 412);
            this.lbkota.Name = "lbkota";
            this.lbkota.Size = new System.Drawing.Size(43, 18);
            this.lbkota.TabIndex = 14;
            this.lbkota.Text = "Kota";
            // 
            // lbjurusan
            // 
            this.lbjurusan.AutoSize = true;
            this.lbjurusan.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbjurusan.Location = new System.Drawing.Point(301, 473);
            this.lbjurusan.Name = "lbjurusan";
            this.lbjurusan.Size = new System.Drawing.Size(62, 18);
            this.lbjurusan.TabIndex = 13;
            this.lbjurusan.Text = "Jurusan";
            // 
            // lbstrata
            // 
            this.lbstrata.AutoSize = true;
            this.lbstrata.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstrata.Location = new System.Drawing.Point(301, 412);
            this.lbstrata.Name = "lbstrata";
            this.lbstrata.Size = new System.Drawing.Size(50, 18);
            this.lbstrata.TabIndex = 12;
            this.lbstrata.Text = "Strata";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(60, 275);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(49, 18);
            this.lbemail.TabIndex = 11;
            this.lbemail.Text = "Email";
            // 
            // lbnama
            // 
            this.lbnama.AutoSize = true;
            this.lbnama.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnama.ForeColor = System.Drawing.Color.White;
            this.lbnama.Location = new System.Drawing.Point(328, 139);
            this.lbnama.Name = "lbnama";
            this.lbnama.Size = new System.Drawing.Size(56, 19);
            this.lbnama.TabIndex = 10;
            this.lbnama.Text = "Nama";
            // 
            // cvcv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pbfotocv);
            this.Controls.Add(this.lbgender);
            this.Controls.Add(this.lbumur);
            this.Controls.Add(this.lbkota);
            this.Controls.Add(this.lbjurusan);
            this.Controls.Add(this.lbstrata);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbnama);
            this.Name = "cvcv";
            this.Size = new System.Drawing.Size(509, 654);
            this.Load += new System.EventHandler(this.cvcv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbfotocv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbfotocv;
        private System.Windows.Forms.Label lbgender;
        private System.Windows.Forms.Label lbumur;
        private System.Windows.Forms.Label lbkota;
        private System.Windows.Forms.Label lbjurusan;
        private System.Windows.Forms.Label lbstrata;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbnama;
    }
}

namespace smj
{
    partial class Result
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smjdtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smjdt = new smj.smjdt();
            this.employerTableAdapter = new smj.smjdtTableAdapters.employerTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbpt = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.namaptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kotaptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strataptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurusanptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umurptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catatanptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smjdtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smjdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaptDataGridViewTextBoxColumn,
            this.emailptDataGridViewTextBoxColumn,
            this.kotaptDataGridViewTextBoxColumn,
            this.strataptDataGridViewTextBoxColumn,
            this.jurusanptDataGridViewTextBoxColumn,
            this.umurptDataGridViewTextBoxColumn,
            this.genderptDataGridViewTextBoxColumn,
            this.catatanptDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employerBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(16, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(903, 519);
            this.dataGridView1.TabIndex = 0;
            // 
            // employerBindingSource
            // 
            this.employerBindingSource.DataMember = "employer";
            this.employerBindingSource.DataSource = this.smjdtBindingSource;
            // 
            // smjdtBindingSource
            // 
            this.smjdtBindingSource.DataSource = this.smjdt;
            this.smjdtBindingSource.Position = 0;
            // 
            // smjdt
            // 
            this.smjdt.DataSetName = "smjdt";
            this.smjdt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employerTableAdapter
            // 
            this.employerTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cbpt
            // 
            this.cbpt.FormattingEnabled = true;
            this.cbpt.Items.AddRange(new object[] {
            "jurusanpt",
            "kotapt",
            "umurpt",
            "stratapt"});
            this.cbpt.Location = new System.Drawing.Point(217, 14);
            this.cbpt.Name = "cbpt";
            this.cbpt.Size = new System.Drawing.Size(114, 21);
            this.cbpt.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(386, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(337, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // namaptDataGridViewTextBoxColumn
            // 
            this.namaptDataGridViewTextBoxColumn.DataPropertyName = "namapt";
            this.namaptDataGridViewTextBoxColumn.HeaderText = "Perusahaan/Instansi";
            this.namaptDataGridViewTextBoxColumn.Name = "namaptDataGridViewTextBoxColumn";
            this.namaptDataGridViewTextBoxColumn.ReadOnly = true;
            this.namaptDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // emailptDataGridViewTextBoxColumn
            // 
            this.emailptDataGridViewTextBoxColumn.DataPropertyName = "emailpt";
            this.emailptDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.emailptDataGridViewTextBoxColumn.Name = "emailptDataGridViewTextBoxColumn";
            this.emailptDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kotaptDataGridViewTextBoxColumn
            // 
            this.kotaptDataGridViewTextBoxColumn.DataPropertyName = "kotapt";
            this.kotaptDataGridViewTextBoxColumn.HeaderText = "Domisili";
            this.kotaptDataGridViewTextBoxColumn.Name = "kotaptDataGridViewTextBoxColumn";
            this.kotaptDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strataptDataGridViewTextBoxColumn
            // 
            this.strataptDataGridViewTextBoxColumn.DataPropertyName = "stratapt";
            this.strataptDataGridViewTextBoxColumn.HeaderText = "Jenjang dicari";
            this.strataptDataGridViewTextBoxColumn.Name = "strataptDataGridViewTextBoxColumn";
            this.strataptDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jurusanptDataGridViewTextBoxColumn
            // 
            this.jurusanptDataGridViewTextBoxColumn.DataPropertyName = "jurusanpt";
            this.jurusanptDataGridViewTextBoxColumn.HeaderText = "Jurusan dicari";
            this.jurusanptDataGridViewTextBoxColumn.Name = "jurusanptDataGridViewTextBoxColumn";
            this.jurusanptDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // umurptDataGridViewTextBoxColumn
            // 
            this.umurptDataGridViewTextBoxColumn.DataPropertyName = "umurpt";
            this.umurptDataGridViewTextBoxColumn.HeaderText = "Umur min";
            this.umurptDataGridViewTextBoxColumn.Name = "umurptDataGridViewTextBoxColumn";
            this.umurptDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderptDataGridViewTextBoxColumn
            // 
            this.genderptDataGridViewTextBoxColumn.DataPropertyName = "genderpt";
            this.genderptDataGridViewTextBoxColumn.HeaderText = "Jenis kelamin dicari";
            this.genderptDataGridViewTextBoxColumn.Name = "genderptDataGridViewTextBoxColumn";
            this.genderptDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // catatanptDataGridViewTextBoxColumn
            // 
            this.catatanptDataGridViewTextBoxColumn.DataPropertyName = "catatanpt";
            this.catatanptDataGridViewTextBoxColumn.FillWeight = 200F;
            this.catatanptDataGridViewTextBoxColumn.HeaderText = "Catatan tambahan";
            this.catatanptDataGridViewTextBoxColumn.Name = "catatanptDataGridViewTextBoxColumn";
            this.catatanptDataGridViewTextBoxColumn.ReadOnly = true;
            this.catatanptDataGridViewTextBoxColumn.Width = 200;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbpt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Result";
            this.Size = new System.Drawing.Size(981, 612);
            this.Load += new System.EventHandler(this.Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smjdtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smjdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource employerBindingSource;
        private System.Windows.Forms.BindingSource smjdtBindingSource;
        private smjdt smjdt;
        private smjdtTableAdapters.employerTableAdapter employerTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbpt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kotaptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strataptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurusanptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umurptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catatanptDataGridViewTextBoxColumn;
    }
}

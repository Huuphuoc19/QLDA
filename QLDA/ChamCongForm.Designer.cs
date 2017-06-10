namespace QLDA
{
    partial class ChamCongForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pHANCONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new QLDA.DataSet4();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.duyệtĐềÁnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chấmCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet1 = new QLDA.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHANCONGTableAdapter = new QLDA.DataSet4TableAdapters.PHANCONGTableAdapter();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHOIGIANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUYETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANCONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANVDataGridViewTextBoxColumn,
            this.mADADataGridViewTextBoxColumn,
            this.tHOIGIANDataGridViewTextBoxColumn,
            this.dUYETDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pHANCONGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(125, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 138);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // pHANCONGBindingSource
            // 
            this.pHANCONGBindingSource.DataMember = "PHANCONG";
            this.pHANCONGBindingSource.DataSource = this.dataSet4;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duyệtĐềÁnToolStripMenuItem,
            this.chấmCôngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // duyệtĐềÁnToolStripMenuItem
            // 
            this.duyệtĐềÁnToolStripMenuItem.Name = "duyệtĐềÁnToolStripMenuItem";
            this.duyệtĐềÁnToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.duyệtĐềÁnToolStripMenuItem.Text = "Duyệt đề án";
            this.duyệtĐềÁnToolStripMenuItem.Click += new System.EventHandler(this.duyệtĐềÁnToolStripMenuItem_Click);
            // 
            // chấmCôngToolStripMenuItem
            // 
            this.chấmCôngToolStripMenuItem.Name = "chấmCôngToolStripMenuItem";
            this.chấmCôngToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.chấmCôngToolStripMenuItem.Text = "Chấm công";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // pHANCONGTableAdapter
            // 
            this.pHANCONGTableAdapter.ClearBeforeFill = true;
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.FillWeight = 65.65144F;
            this.mANVDataGridViewTextBoxColumn.HeaderText = "MANV";
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            this.mANVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mADADataGridViewTextBoxColumn
            // 
            this.mADADataGridViewTextBoxColumn.DataPropertyName = "MADA";
            this.mADADataGridViewTextBoxColumn.FillWeight = 65.65144F;
            this.mADADataGridViewTextBoxColumn.HeaderText = "MADA";
            this.mADADataGridViewTextBoxColumn.Name = "mADADataGridViewTextBoxColumn";
            this.mADADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tHOIGIANDataGridViewTextBoxColumn
            // 
            this.tHOIGIANDataGridViewTextBoxColumn.DataPropertyName = "THOIGIAN";
            dataGridViewCellStyle1.Format = "d";
            this.tHOIGIANDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.tHOIGIANDataGridViewTextBoxColumn.FillWeight = 203.0457F;
            this.tHOIGIANDataGridViewTextBoxColumn.HeaderText = "THOIGIAN";
            this.tHOIGIANDataGridViewTextBoxColumn.Name = "tHOIGIANDataGridViewTextBoxColumn";
            // 
            // dUYETDataGridViewTextBoxColumn
            // 
            this.dUYETDataGridViewTextBoxColumn.DataPropertyName = "DUYET";
            this.dUYETDataGridViewTextBoxColumn.FillWeight = 65.65144F;
            this.dUYETDataGridViewTextBoxColumn.HeaderText = "DUYET";
            this.dUYETDataGridViewTextBoxColumn.Name = "dUYETDataGridViewTextBoxColumn";
            this.dUYETDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ChamCongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ChamCongForm";
            this.Text = "TruongPhongThucHienDeAn";
            this.Load += new System.EventHandler(this.ChamCongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANCONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem duyệtĐềÁnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chấmCôngToolStripMenuItem;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource pHANCONGBindingSource;
        private DataSet4TableAdapters.PHANCONGTableAdapter pHANCONGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHOIGIANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUYETDataGridViewTextBoxColumn;
    }
}

namespace QLDA
{
    partial class NhanVienPNS1aForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienPNSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thucHienDeAnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nHANVIENVIEWNSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QLDA.DataSet1();
            this.nHANVIEN_VIEW_NSTableAdapter = new QLDA.DataSet1TableAdapters.NHANVIEN_VIEW_NSTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hONVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENLOTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANQLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHUCAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nHANVIENVIEWNSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new QLDA.DataSet3();
            this.nHANVIEN_VIEW_NSTableAdapter1 = new QLDA.DataSet3TableAdapters.NHANVIEN_VIEW_NSTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENVIEWNSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENVIEWNSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanVienToolStripMenuItem,
            this.nhanVienPNSToolStripMenuItem,
            this.thucHienDeAnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1240, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhanVienToolStripMenuItem
            // 
            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.nhanVienToolStripMenuItem.Text = "Nhan vien";
            this.nhanVienToolStripMenuItem.Click += new System.EventHandler(this.nhanVienToolStripMenuItem_Click);
            // 
            // nhanVienPNSToolStripMenuItem
            // 
            this.nhanVienPNSToolStripMenuItem.Name = "nhanVienPNSToolStripMenuItem";
            this.nhanVienPNSToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.nhanVienPNSToolStripMenuItem.Text = "Nhan vien PNS";
            // 
            // thucHienDeAnToolStripMenuItem
            // 
            this.thucHienDeAnToolStripMenuItem.Name = "thucHienDeAnToolStripMenuItem";
            this.thucHienDeAnToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.thucHienDeAnToolStripMenuItem.Text = "Thuc hien de an";
            this.thucHienDeAnToolStripMenuItem.Click += new System.EventHandler(this.thucHienDeAnToolStripMenuItem_Click);
            // 
            // nHANVIENVIEWNSBindingSource
            // 
            this.nHANVIENVIEWNSBindingSource.DataMember = "NHANVIEN_VIEW_NS";
            this.nHANVIENVIEWNSBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIEN_VIEW_NSTableAdapter
            // 
            this.nHANVIEN_VIEW_NSTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANVDataGridViewTextBoxColumn,
            this.hONVDataGridViewTextBoxColumn,
            this.tENLOTDataGridViewTextBoxColumn,
            this.tENNVDataGridViewTextBoxColumn,
            this.pHAIDataGridViewTextBoxColumn,
            this.lUONGDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.nGAYSINHDataGridViewTextBoxColumn,
            this.mANQLDataGridViewTextBoxColumn,
            this.pHGDataGridViewTextBoxColumn,
            this.pHUCAPDataGridViewTextBoxColumn,
            this.editCol});
            this.dataGridView1.DataSource = this.nHANVIENVIEWNSBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(9, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1231, 303);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "MANV";
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            this.mANVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hONVDataGridViewTextBoxColumn
            // 
            this.hONVDataGridViewTextBoxColumn.DataPropertyName = "HONV";
            this.hONVDataGridViewTextBoxColumn.HeaderText = "HONV";
            this.hONVDataGridViewTextBoxColumn.Name = "hONVDataGridViewTextBoxColumn";
            this.hONVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tENLOTDataGridViewTextBoxColumn
            // 
            this.tENLOTDataGridViewTextBoxColumn.DataPropertyName = "TENLOT";
            this.tENLOTDataGridViewTextBoxColumn.HeaderText = "TENLOT";
            this.tENLOTDataGridViewTextBoxColumn.Name = "tENLOTDataGridViewTextBoxColumn";
            this.tENLOTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tENNVDataGridViewTextBoxColumn
            // 
            this.tENNVDataGridViewTextBoxColumn.DataPropertyName = "TENNV";
            this.tENNVDataGridViewTextBoxColumn.HeaderText = "TENNV";
            this.tENNVDataGridViewTextBoxColumn.Name = "tENNVDataGridViewTextBoxColumn";
            this.tENNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pHAIDataGridViewTextBoxColumn
            // 
            this.pHAIDataGridViewTextBoxColumn.DataPropertyName = "PHAI";
            this.pHAIDataGridViewTextBoxColumn.HeaderText = "PHAI";
            this.pHAIDataGridViewTextBoxColumn.Name = "pHAIDataGridViewTextBoxColumn";
            this.pHAIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lUONGDataGridViewTextBoxColumn
            // 
            this.lUONGDataGridViewTextBoxColumn.DataPropertyName = "LUONG";
            this.lUONGDataGridViewTextBoxColumn.HeaderText = "LUONG";
            this.lUONGDataGridViewTextBoxColumn.Name = "lUONGDataGridViewTextBoxColumn";
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            this.dIACHIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGAYSINHDataGridViewTextBoxColumn
            // 
            this.nGAYSINHDataGridViewTextBoxColumn.DataPropertyName = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.HeaderText = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.Name = "nGAYSINHDataGridViewTextBoxColumn";
            this.nGAYSINHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mANQLDataGridViewTextBoxColumn
            // 
            this.mANQLDataGridViewTextBoxColumn.DataPropertyName = "MANQL";
            this.mANQLDataGridViewTextBoxColumn.HeaderText = "MANQL";
            this.mANQLDataGridViewTextBoxColumn.Name = "mANQLDataGridViewTextBoxColumn";
            this.mANQLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pHGDataGridViewTextBoxColumn
            // 
            this.pHGDataGridViewTextBoxColumn.DataPropertyName = "PHG";
            this.pHGDataGridViewTextBoxColumn.HeaderText = "PHG";
            this.pHGDataGridViewTextBoxColumn.Name = "pHGDataGridViewTextBoxColumn";
            // 
            // pHUCAPDataGridViewTextBoxColumn
            // 
            this.pHUCAPDataGridViewTextBoxColumn.DataPropertyName = "PHUCAP";
            this.pHUCAPDataGridViewTextBoxColumn.HeaderText = "PHUCAP";
            this.pHUCAPDataGridViewTextBoxColumn.Name = "pHUCAPDataGridViewTextBoxColumn";
            // 
            // editCol
            // 
            this.editCol.HeaderText = "Edit";
            this.editCol.Name = "editCol";
            this.editCol.Text = "Update";
            this.editCol.UseColumnTextForButtonValue = true;
            // 
            // nHANVIENVIEWNSBindingSource1
            // 
            this.nHANVIENVIEWNSBindingSource1.DataMember = "NHANVIEN_VIEW_NS";
            this.nHANVIENVIEWNSBindingSource1.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIEN_VIEW_NSTableAdapter1
            // 
            this.nHANVIEN_VIEW_NSTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // NhanVienPNS1aForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1240, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "NhanVienPNS1aForm";
            this.Load += new System.EventHandler(this.NhanVienPNS1aForm_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENVIEWNSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENVIEWNSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanVienPNSToolStripMenuItem;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nHANVIENVIEWNSBindingSource;
        private DataSet1TableAdapters.NHANVIEN_VIEW_NSTableAdapter nHANVIEN_VIEW_NSTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource nHANVIENVIEWNSBindingSource1;
        private DataSet3TableAdapters.NHANVIEN_VIEW_NSTableAdapter nHANVIEN_VIEW_NSTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hONVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENLOTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANQLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHUCAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editCol;
        private System.Windows.Forms.ToolStripMenuItem thucHienDeAnToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

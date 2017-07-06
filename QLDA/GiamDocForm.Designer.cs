namespace QLDA
{
    partial class GiamDocForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGV_GD = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nHANVIENVIEWNSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QLDA.DataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGV_DA = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.nHANVIENVIEWNSBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENVIEWNSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENVIEWNSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.nHANVIEN_VIEW_NSTableAdapter = new QLDA.DataSet1TableAdapters.NHANVIEN_VIEW_NSTableAdapter();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HONV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHUCAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditPNS = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_GD)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENVIEWNSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENVIEWNSBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENVIEWNSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENVIEWNSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 358);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_update);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGV_GD);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(987, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin cá nhân";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(582, 203);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 33);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin cá nhân";
            // 
            // dataGV_GD
            // 
            this.dataGV_GD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_GD.Location = new System.Drawing.Point(20, 72);
            this.dataGV_GD.Name = "dataGV_GD";
            this.dataGV_GD.Size = new System.Drawing.Size(682, 105);
            this.dataGV_GD.TabIndex = 0;
            this.dataGV_GD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_GD_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(765, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin nhân viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.HONV,
            this.TENLOT,
            this.TENNV,
            this.PHAI,
            this.LUONG,
            this.DIACHI,
            this.NGAYSINH,
            this.MANQL,
            this.PHG,
            this.PHUCAP,
            this.btnEditPNS});
            this.dataGridView1.DataSource = this.nHANVIENVIEWNSBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(20, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 130);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nHANVIENVIEWNSBindingSource2
            // 
            this.nHANVIENVIEWNSBindingSource2.DataMember = "NHANVIEN_VIEW_NS";
            this.nHANVIENVIEWNSBindingSource2.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin nhân viên";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGV_DA);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(765, 324);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thông tin đề án";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGV_DA
            // 
            this.dataGV_DA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_DA.Location = new System.Drawing.Point(9, 92);
            this.dataGV_DA.Name = "dataGV_DA";
            this.dataGV_DA.Size = new System.Drawing.Size(693, 220);
            this.dataGV_DA.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông tin đề án";
            // 
            // nHANVIENVIEWNSBindingSource5
            // 
            this.nHANVIENVIEWNSBindingSource5.DataMember = "NHANVIEN_VIEW_NS";
            this.nHANVIENVIEWNSBindingSource5.DataSource = this.dataSet1;
            // 
            // nHANVIEN_VIEW_NSTableAdapter
            // 
            this.nHANVIEN_VIEW_NSTableAdapter.ClearBeforeFill = true;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "MANV";
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            // 
            // HONV
            // 
            this.HONV.DataPropertyName = "HONV";
            this.HONV.HeaderText = "HONV";
            this.HONV.Name = "HONV";
            this.HONV.ReadOnly = true;
            // 
            // TENLOT
            // 
            this.TENLOT.DataPropertyName = "TENLOT";
            this.TENLOT.HeaderText = "TENLOT";
            this.TENLOT.Name = "TENLOT";
            this.TENLOT.ReadOnly = true;
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "TENNV";
            this.TENNV.Name = "TENNV";
            this.TENNV.ReadOnly = true;
            // 
            // PHAI
            // 
            this.PHAI.DataPropertyName = "PHAI";
            this.PHAI.HeaderText = "PHAI";
            this.PHAI.Name = "PHAI";
            this.PHAI.ReadOnly = true;
            // 
            // LUONG
            // 
            this.LUONG.DataPropertyName = "LUONG";
            this.LUONG.HeaderText = "LUONG";
            this.LUONG.Name = "LUONG";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "DIACHI";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "NGAYSINH";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            // 
            // MANQL
            // 
            this.MANQL.DataPropertyName = "MANQL";
            this.MANQL.HeaderText = "MANQL";
            this.MANQL.Name = "MANQL";
            this.MANQL.ReadOnly = true;
            // 
            // PHG
            // 
            this.PHG.DataPropertyName = "PHG";
            this.PHG.HeaderText = "PHG";
            this.PHG.Name = "PHG";
            // 
            // PHUCAP
            // 
            this.PHUCAP.DataPropertyName = "PHUCAP";
            this.PHUCAP.HeaderText = "PHUCAP";
            this.PHUCAP.Name = "PHUCAP";
            // 
            // btnEditPNS
            // 
            this.btnEditPNS.HeaderText = "EDIT";
            this.btnEditPNS.Name = "btnEditPNS";
            this.btnEditPNS.Text = "Update";
            this.btnEditPNS.UseColumnTextForButtonValue = true;
            // 
            // GiamDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(711, 355);
            this.Controls.Add(this.tabControl1);
            this.Name = "GiamDocForm";
            this.Text = "Giám Đốc";
            this.Load += new System.EventHandler(this.GiamDocForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_GD)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENVIEWNSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENVIEWNSBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENVIEWNSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENVIEWNSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGV_GD;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGV_DA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_update;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nHANVIENVIEWNSBindingSource;
        private DataSet1TableAdapters.NHANVIEN_VIEW_NSTableAdapter nHANVIEN_VIEW_NSTableAdapter;
        private System.Windows.Forms.BindingSource nHANVIENVIEWNSBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource nHANVIENVIEWNSBindingSource5;
        private System.Windows.Forms.BindingSource nHANVIENVIEWNSBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HONV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHG;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHUCAP;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditPNS;
    }
}

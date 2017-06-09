namespace QLDA
{
    partial class NhanVienPNSForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienPNSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridThongTinNhanVien = new System.Windows.Forms.DataGridView();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridThongTinNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanVienToolStripMenuItem,
            this.nhanVienPNSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhanVienToolStripMenuItem
            // 
            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.nhanVienToolStripMenuItem.Text = "Nhan vien";
            // 
            // nhanVienPNSToolStripMenuItem
            // 
            this.nhanVienPNSToolStripMenuItem.Name = "nhanVienPNSToolStripMenuItem";
            this.nhanVienPNSToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.nhanVienPNSToolStripMenuItem.Text = "Nhan vien PNS";
            this.nhanVienPNSToolStripMenuItem.Click += new System.EventHandler(this.nhanVienPNSToolStripMenuItem_Click);
            // 
            // gridThongTinNhanVien
            // 
            this.gridThongTinNhanVien.AllowUserToAddRows = false;
            this.gridThongTinNhanVien.AllowUserToDeleteRows = false;
            this.gridThongTinNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridThongTinNhanVien.Location = new System.Drawing.Point(12, 128);
            this.gridThongTinNhanVien.Name = "gridThongTinNhanVien";
            this.gridThongTinNhanVien.Size = new System.Drawing.Size(710, 86);
            this.gridThongTinNhanVien.TabIndex = 1;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(286, 71);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(148, 21);
            this.lblNhanVien.TabIndex = 2;
            this.lblNhanVien.Text = "Thông tin nhân viên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NhanVienPNSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.gridThongTinNhanVien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NhanVienPNSForm";
            this.Text = "Nhan vien PNS";
            this.Load += new System.EventHandler(this.NhanVienPNSForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridThongTinNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanVienPNSToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridThongTinNhanVien;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Button button1;
    }
}

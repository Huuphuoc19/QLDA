namespace QLDA
{
    partial class NhanVienForm
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
            this.gridThongTinNhanVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridThongTinNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // gridThongTinNhanVien
            // 
            this.gridThongTinNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridThongTinNhanVien.Location = new System.Drawing.Point(12, 93);
            this.gridThongTinNhanVien.Name = "gridThongTinNhanVien";
            this.gridThongTinNhanVien.Size = new System.Drawing.Size(710, 81);
            this.gridThongTinNhanVien.TabIndex = 0;
            // 
            // NhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.Controls.Add(this.gridThongTinNhanVien);
            this.Name = "NhanVienForm";
            this.Load += new System.EventHandler(this.NhanVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridThongTinNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridThongTinNhanVien;
    }
}

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
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridThongTinNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // gridThongTinNhanVien
            // 
            this.gridThongTinNhanVien.AllowUserToAddRows = false;
            this.gridThongTinNhanVien.AllowUserToDeleteRows = false;
            this.gridThongTinNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridThongTinNhanVien.Location = new System.Drawing.Point(12, 115);
            this.gridThongTinNhanVien.Name = "gridThongTinNhanVien";
            this.gridThongTinNhanVien.Size = new System.Drawing.Size(710, 86);
            this.gridThongTinNhanVien.TabIndex = 0;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(275, 29);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(148, 21);
            this.lblNhanVien.TabIndex = 1;
            this.lblNhanVien.Text = "Thông tin nhân viên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.gridThongTinNhanVien);
            this.Name = "NhanVienForm";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridThongTinNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridThongTinNhanVien;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Button button1;
    }
}

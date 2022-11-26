
namespace PhongKhamSan
{
    partial class MainForm
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
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLBệnhNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDSBN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThemBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.qLKhámBệnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mLapPhieuKham = new System.Windows.Forms.ToolStripMenuItem();
            this.qLThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhapThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchToaThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.qLBệnhNhânToolStripMenuItem,
            this.qLKhámBệnhToolStripMenuItem,
            this.qLThuốcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcNgườiDùngToolStripMenuItem,
            this.phânQuyềnToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.hệThốngToolStripMenuItem.Text = "Quản Trị Hệ Thống";
            // 
            // qLBệnhNhânToolStripMenuItem
            // 
            this.qLBệnhNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDSBN,
            this.menuThemBenhNhan});
            this.qLBệnhNhânToolStripMenuItem.Name = "qLBệnhNhânToolStripMenuItem";
            this.qLBệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.qLBệnhNhânToolStripMenuItem.Text = "QL Bệnh Nhân";
            // 
            // menuDSBN
            // 
            this.menuDSBN.Name = "menuDSBN";
            this.menuDSBN.Size = new System.Drawing.Size(192, 22);
            this.menuDSBN.Text = "Danh Sách Bệnh Nhân";
            this.menuDSBN.Click += new System.EventHandler(this.menuDSBN_Click);
            // 
            // menuThemBenhNhan
            // 
            this.menuThemBenhNhan.Name = "menuThemBenhNhan";
            this.menuThemBenhNhan.Size = new System.Drawing.Size(192, 22);
            this.menuThemBenhNhan.Text = "Thêm Bệnh Nhân";
            this.menuThemBenhNhan.Click += new System.EventHandler(this.menuThemBenhNhan_Click);
            // 
            // qLKhámBệnhToolStripMenuItem
            // 
            this.qLKhámBệnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mLapPhieuKham});
            this.qLKhámBệnhToolStripMenuItem.Name = "qLKhámBệnhToolStripMenuItem";
            this.qLKhámBệnhToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.qLKhámBệnhToolStripMenuItem.Text = "QL Khám Bệnh";
            // 
            // mLapPhieuKham
            // 
            this.mLapPhieuKham.Name = "mLapPhieuKham";
            this.mLapPhieuKham.Size = new System.Drawing.Size(180, 22);
            this.mLapPhieuKham.Text = "Lập Phiếu Khám";
            this.mLapPhieuKham.Click += new System.EventHandler(this.mLapPhieuKham_Click);
            // 
            // qLThuốcToolStripMenuItem
            // 
            this.qLThuốcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhapThuoc,
            this.danhSáchToaThuốcToolStripMenuItem});
            this.qLThuốcToolStripMenuItem.Name = "qLThuốcToolStripMenuItem";
            this.qLThuốcToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.qLThuốcToolStripMenuItem.Text = "QL Thuốc";
            // 
            // menuNhapThuoc
            // 
            this.menuNhapThuoc.Name = "menuNhapThuoc";
            this.menuNhapThuoc.Size = new System.Drawing.Size(187, 22);
            this.menuNhapThuoc.Text = "Nhập Thuốc";
            this.menuNhapThuoc.Click += new System.EventHandler(this.menuNhapThuoc_Click);
            // 
            // danhSáchToaThuốcToolStripMenuItem
            // 
            this.danhSáchToaThuốcToolStripMenuItem.Name = "danhSáchToaThuốcToolStripMenuItem";
            this.danhSáchToaThuốcToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.danhSáchToaThuốcToolStripMenuItem.Text = "Danh Sách Toa Thuốc";
            // 
            // danhMụcNgườiDùngToolStripMenuItem
            // 
            this.danhMụcNgườiDùngToolStripMenuItem.Name = "danhMụcNgườiDùngToolStripMenuItem";
            this.danhMụcNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.danhMụcNgườiDùngToolStripMenuItem.Text = "Danh Mục Người Dùng";
            // 
            // phânQuyềnToolStripMenuItem
            // 
            this.phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            this.phânQuyềnToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.phânQuyềnToolStripMenuItem.Text = "Phân Quyền";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLKhámBệnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mLapPhieuKham;
        private System.Windows.Forms.ToolStripMenuItem qLBệnhNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDSBN;
        private System.Windows.Forms.ToolStripMenuItem menuThemBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem danhMụcNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânQuyềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNhapThuoc;
        private System.Windows.Forms.ToolStripMenuItem danhSáchToaThuốcToolStripMenuItem;
    }
}


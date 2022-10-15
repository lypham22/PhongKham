
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
            this.qLKhámBệnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mLapPhieuKham = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThemBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.qLBệnhNhânToolStripMenuItem,
            this.qLKhámBệnhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
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
            // menuThemBenhNhan
            // 
            this.menuThemBenhNhan.Name = "menuThemBenhNhan";
            this.menuThemBenhNhan.Size = new System.Drawing.Size(192, 22);
            this.menuThemBenhNhan.Text = "Thêm Bệnh Nhân";
            this.menuThemBenhNhan.Click += new System.EventHandler(this.menuThemBenhNhan_Click);
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
    }
}


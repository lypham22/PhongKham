
namespace PhongKhamSan
{
    partial class DanhSachBN
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemBN = new System.Windows.Forms.Button();
            this.grvBenhNhan = new System.Windows.Forms.DataGridView();
            this.MaBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDuSanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPhieuKham = new System.Windows.Forms.Button();
            this.btnXoaBN = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaBN);
            this.groupBox2.Controls.Add(this.btnPhieuKham);
            this.groupBox2.Controls.Add(this.btnThemBN);
            this.groupBox2.Controls.Add(this.grvBenhNhan);
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.txtSoDT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(22, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 400);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Bệnh Nhân";
            // 
            // btnThemBN
            // 
            this.btnThemBN.Location = new System.Drawing.Point(24, 268);
            this.btnThemBN.Name = "btnThemBN";
            this.btnThemBN.Size = new System.Drawing.Size(111, 23);
            this.btnThemBN.TabIndex = 4;
            this.btnThemBN.Text = "Thêm Bệnh Nhân";
            this.btnThemBN.UseVisualStyleBackColor = true;
            this.btnThemBN.Click += new System.EventHandler(this.btnThemBN_Click);
            // 
            // grvBenhNhan
            // 
            this.grvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBenhNhan,
            this.HoVaTen,
            this.NgayDuSanh,
            this.DiaChi,
            this.NgayTao});
            this.grvBenhNhan.Location = new System.Drawing.Point(19, 88);
            this.grvBenhNhan.Name = "grvBenhNhan";
            this.grvBenhNhan.Size = new System.Drawing.Size(517, 150);
            this.grvBenhNhan.TabIndex = 3;
            this.grvBenhNhan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvBenhNhan_CellDoubleClick);
            // 
            // MaBenhNhan
            // 
            this.MaBenhNhan.DataPropertyName = "MaBenhNhan";
            this.MaBenhNhan.HeaderText = "Mã BN";
            this.MaBenhNhan.Name = "MaBenhNhan";
            this.MaBenhNhan.Width = 70;
            // 
            // HoVaTen
            // 
            this.HoVaTen.DataPropertyName = "HoVaTen";
            this.HoVaTen.HeaderText = "Họ Và Tên";
            this.HoVaTen.Name = "HoVaTen";
            // 
            // NgayDuSanh
            // 
            this.NgayDuSanh.DataPropertyName = "NgayDuSanh";
            this.NgayDuSanh.HeaderText = "Ngày Dự Sanh";
            this.NgayDuSanh.Name = "NgayDuSanh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // NgayTao
            // 
            this.NgayTao.DataPropertyName = "NgayTao";
            this.NgayTao.HeaderText = "Ngày Tạo";
            this.NgayTao.Name = "NgayTao";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(303, 26);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(117, 28);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(148, 20);
            this.txtSoDT.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Điện Thoại:";
            // 
            // btnPhieuKham
            // 
            this.btnPhieuKham.Location = new System.Drawing.Point(243, 268);
            this.btnPhieuKham.Name = "btnPhieuKham";
            this.btnPhieuKham.Size = new System.Drawing.Size(135, 23);
            this.btnPhieuKham.TabIndex = 5;
            this.btnPhieuKham.Text = "Tạo Phiếu Khám";
            this.btnPhieuKham.UseVisualStyleBackColor = true;
            this.btnPhieuKham.Click += new System.EventHandler(this.btnPhieuKham_Click);
            // 
            // btnXoaBN
            // 
            this.btnXoaBN.Location = new System.Drawing.Point(153, 268);
            this.btnXoaBN.Name = "btnXoaBN";
            this.btnXoaBN.Size = new System.Drawing.Size(75, 23);
            this.btnXoaBN.TabIndex = 6;
            this.btnXoaBN.Text = "Xóa Bệnh Nhân";
            this.btnXoaBN.UseVisualStyleBackColor = true;
            this.btnXoaBN.Click += new System.EventHandler(this.btnXoaBN_Click);
            // 
            // DanhSachBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "DanhSachBN";
            this.Text = "DanhSachBN";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBenhNhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grvBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDuSanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemBN;
        private System.Windows.Forms.Button btnPhieuKham;
        private System.Windows.Forms.Button btnXoaBN;
    }
}
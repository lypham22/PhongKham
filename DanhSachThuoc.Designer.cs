
namespace PhongKhamSan
{
    partial class DanhSachThuoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thuốc: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(305, 22);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThuoc,
            this.tenThuoc,
            this.soLuong,
            this.donGia,
            this.hanSuDung,
            this.btnXoa});
            this.dataGridView1.Location = new System.Drawing.Point(40, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(647, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // maThuoc
            // 
            this.maThuoc.HeaderText = "Mã Thuốc";
            this.maThuoc.Name = "maThuoc";
            this.maThuoc.ReadOnly = true;
            // 
            // tenThuoc
            // 
            this.tenThuoc.HeaderText = "Tên Thuốc";
            this.tenThuoc.Name = "tenThuoc";
            this.tenThuoc.ReadOnly = true;
            // 
            // soLuong
            // 
            this.soLuong.HeaderText = "Số Lượng";
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            // 
            // donGia
            // 
            this.donGia.HeaderText = "Đơn Giá";
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            // 
            // hanSuDung
            // 
            this.hanSuDung.HeaderText = "Hạn Sử Dụng";
            this.hanSuDung.Name = "hanSuDung";
            this.hanSuDung.ReadOnly = true;
            // 
            // btnXoa
            // 
            this.btnXoa.HeaderText = "Xóa";
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ReadOnly = true;
            // 
            // DanhSachThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "DanhSachThuoc";
            this.Text = "DanhSachThuoc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnXoa;
    }
}
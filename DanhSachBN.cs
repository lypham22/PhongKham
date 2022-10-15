using PhongKhamSan.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongKhamSan
{
    public partial class DanhSachBN : Form
    {
        BenhNhanDAL benhNhanDAL;

        public DanhSachBN()
        {
            InitializeComponent();

            benhNhanDAL = new BenhNhanDAL();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadBenhNhan();
        }

        private void btnThemBN_Click(object sender, EventArgs e)
        {
            ThemBenhNhan themBenhNhan = new ThemBenhNhan(string.Empty);
            themBenhNhan.Show();
        }

        private void btnPhieuKham_Click(object sender, EventArgs e)
        {
            if (!CheckSelectedRow()) return;

            var maBenhNhan = grvBenhNhan.SelectedRows[0].Cells["MaBenhNhan"].Value.ToString();
            if (string.IsNullOrEmpty(maBenhNhan))
            {
                MessageBox.Show("Chọn Bệnh Nhân", "Thông báo");
                return;
            }

            PhieuKham phieuKham = new PhieuKham(maBenhNhan);
            phieuKham.Show();
        }

        private void grvBenhNhan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string maBenhNhan = grvBenhNhan.CurrentRow.Cells["MaBenhNhan"].Value.ToString();

                ThemBenhNhan themBenhNhan = new ThemBenhNhan(maBenhNhan);
                themBenhNhan.Show();
            }
            catch (Exception p)
            {

                MessageBox.Show(p.ToString());
            }
        }

        private void btnXoaBN_Click(object sender, EventArgs e)
        {
            if(!CheckSelectedRow()) return;

            DialogResult dlr = MessageBox.Show("Bạn muốn xóa bệnh nhân", "Thông Báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                var maBenhNhan = grvBenhNhan.SelectedRows[0].Cells["MaBenhNhan"].Value.ToString();
                if (string.IsNullOrEmpty(maBenhNhan))
                {
                    MessageBox.Show("Chọn Bệnh Nhân", "Thông báo");
                    return;
                }

                // Xóa Bệnh Nhân
                if (benhNhanDAL.XoaBenhNhan(maBenhNhan))
                    LoadBenhNhan();
            }
            else
            {
                return;
            }
        }

        private void LoadBenhNhan()
        {
            grvBenhNhan.DataSource = benhNhanDAL.DanhSachBenhNhan(txtSoDT.Text);
        }

        private bool CheckSelectedRow()
        {
            if(grvBenhNhan.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân", "Thông báo");
                return false;
            }

            return true;
        }
    }
}

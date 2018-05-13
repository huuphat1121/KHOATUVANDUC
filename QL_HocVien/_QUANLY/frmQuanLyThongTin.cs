using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace QL_HocVien._QUANLY
{
    public partial class frmQuanLyThongTin : FormCommon
    {
        bll_hocvien_infomation bll_hhv = new bll_hocvien_infomation();
        bll_search_hocvien bll_sear_hv = new bll_search_hocvien();
        public static int hocvien_id_;
        public static string namsinh_;
        public static string phapdanh_;
        public static string thedanh_;
        public static string phone_;
        public static string phone_nguoithan_;
        public static string diachi_;
        public static string cmnd_;
        public static string cmnd_note_;
        public static string khu_;
        public static string vitri_;
        public static string caniemphat_;
        public static DateTime ngayden_;
        public static DateTime ngaydi_;
        public static string ghichu_;
        public frmQuanLyThongTin()
        {
            InitializeComponent();
            initForm();
        }

        private void initForm()
        {
            txtPhapdanh.Select();
            dgvHocVien.DataSource = bll_hhv.loadAllInfo_HocVien();
        }

        private void isDgvEmpty()
        {
            if (dgvHocVien.RowCount.Equals(0))
                MessageBox.Show("Không có thông tin phù hợp, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPhapDanh_Click(object sender, EventArgs e)
        {
            dgvHocVien.DataSource = bll_sear_hv.searchPhapDanh(txtPhapdanh.Text);
            isDgvEmpty();
        }

        private void btnCMND_Click(object sender, EventArgs e)
        {
            dgvHocVien.DataSource = bll_sear_hv.searchCMND(txtCMND.Text);
            isDgvEmpty();
        }

        private void txtPhapdanh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPhapDanh.PerformClick();
        }

        private void txtCMND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCMND.PerformClick();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _ADD.frmAdd_HocVien fAddHV = new _ADD.frmAdd_HocVien();
            fAddHV.ShowDialog();
            initForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                hocvien_id_ = int.Parse(dgvHocVien.CurrentRow.Cells["hocvien_id"].Value.ToString());

                phapdanh_ = dgvHocVien.CurrentRow.Cells["phapdanh"].Value.ToString();
                thedanh_ = dgvHocVien.CurrentRow.Cells["thedanh"].Value.ToString();
                phone_ = dgvHocVien.CurrentRow.Cells["phone"].Value.ToString();
                phone_nguoithan_ = dgvHocVien.CurrentRow.Cells["nguoithan_phone"].Value.ToString();
                cmnd_ = dgvHocVien.CurrentRow.Cells["cmnd"].Value.ToString();
                cmnd_note_ = dgvHocVien.CurrentRow.Cells["cmnd_note"].Value.ToString();
                diachi_ = dgvHocVien.CurrentRow.Cells["hocvien_diachi"].Value.ToString();
                    namsinh_ = dgvHocVien.CurrentRow.Cells["namsinh"].Value.ToString();
                khu_ = dgvHocVien.CurrentRow.Cells["khu_id"].Value.ToString();
                vitri_ = dgvHocVien.CurrentRow.Cells["vitri"].Value.ToString();
                caniemphat_ = dgvHocVien.CurrentRow.Cells["caniemphat"].Value.ToString();
                ghichu_= dgvHocVien.CurrentRow.Cells["ghichu"].Value.ToString();
                ngayden_ = (dgvHocVien.CurrentRow.Cells["ngayden"].Value.ToString().Equals("")) ? DateTime.Today:DateTime.Parse(dgvHocVien.CurrentRow.Cells["ngayden"].Value.ToString());
                ngaydi_= (dgvHocVien.CurrentRow.Cells["ngayve"].Value.ToString().Equals("")) ? DateTime.Today : DateTime.Parse(dgvHocVien.CurrentRow.Cells["ngayve"].Value.ToString());

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
            _EDIT.frmEditHocVien fEdithv = new _EDIT.frmEditHocVien();
            fEdithv.ShowDialog();
            initForm();
        }

        private void dgvHocVien_DoubleClick(object sender, EventArgs e)
        {
            btnSua.PerformClick();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Chắc chắn xóa dữ liệu đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int hocvien_id_ = int.Parse(dgvHocVien.CurrentRow.Cells["hocvien_id"].Value.ToString());
                MessageBox.Show(bll_hhv.DeleteHocVien(hocvien_id_));
                initForm();
            }
        }

        private void btnSTT_Click(object sender, EventArgs e)
        {
            dgvHocVien.DataSource = bll_sear_hv.searchSTT(int.Parse(txtSTT.Text));
            isDgvEmpty();
        }

        private void txtSTT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSTT.PerformClick();
        }

        private void txtTheDanh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTheDanh.PerformClick();
        }

        private void btnTheDanh_Click(object sender, EventArgs e)
        {
            dgvHocVien.DataSource = bll_sear_hv.searchTheDanh(txtTheDanh.Text);
            isDgvEmpty();
        }
    }
}

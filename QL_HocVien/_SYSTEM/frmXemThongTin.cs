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
namespace QL_HocVien._SYSTEM
{
    public partial class frmXemThongTin : FormCommon
    {
        bll_hocvien_infomation bll_hhv = new bll_hocvien_infomation();
        bll_search_hocvien bll_sear_hv = new bll_search_hocvien();
        public frmXemThongTin()
        {
            InitializeComponent();
            initForm();
        }

        private void initForm()
        {
            txtSTT.Select();
            cbbKhu.DisplayMember = "khu_id";
            cbbKhu.DataSource = bll_hhv.loadCbbKhu();
            cbbCaNiem.DisplayMember = "ca_niem";
            cbbCaNiem.DataSource = bll_hhv.loadCbbCaNiem();
            dgvHocVien.DataSource = bll_hhv.loadAllInfo_HocVien();
        }

        private void isDgvEmpty()
        {
            if (dgvHocVien.RowCount.Equals(0))
                MessageBox.Show("Không có thông tin phù hợp, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPhapdanh_Click(object sender, EventArgs e)
        {

            dgvHocVien.DataSource = bll_sear_hv.searchPhapDanh(txtPhapdanh.Text);
            isDgvEmpty();
        }

        private void btnThedanh_Click(object sender, EventArgs e)
        {
            dgvHocVien.DataSource = bll_sear_hv.searchTheDanh(txtThedanh.Text);
            isDgvEmpty();
        }

        private void btnCMND_Click(object sender, EventArgs e)
        {
            dgvHocVien.DataSource = bll_sear_hv.searchCMND(txtCMND.Text);
            isDgvEmpty();
        }

        private void btnKhu_Click(object sender, EventArgs e)
        {
            dgvHocVien.DataSource = bll_sear_hv.searchKhu(cbbKhu.Text);
            isDgvEmpty();
        }

        private void btnCaNiem_Click(object sender, EventArgs e)
        {
            dgvHocVien.DataSource = bll_sear_hv.searchCaNiem(cbbCaNiem.Text);
            isDgvEmpty();
        }

        private void btnNgayDen_Click(object sender, EventArgs e)
        {
            DateTime timeTemp = dtpNgayDen.Value;
            DateTime.Parse(timeTemp.ToString()).ToShortDateString();
            dgvHocVien.DataSource = bll_sear_hv.searchNgayDen(timeTemp);
            isDgvEmpty();
        }

        private void btnNgayDi_Click(object sender, EventArgs e)
        {
            DateTime timeTemp = dtpNgayDi.Value;
            DateTime.Parse(timeTemp.ToString()).ToShortDateString();
            dgvHocVien.DataSource = bll_sear_hv.searchNgayDen(timeTemp);
            isDgvEmpty();
        }

        private void txtPhapdanh_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
                btnPhapdanh.PerformClick();
        }

        private void txtThedanh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnThedanh.PerformClick();
        }

        private void txtCMND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCMND.PerformClick();
        }

        private void cbbKhu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnKhu.PerformClick();
        }

        private void cbbCaNiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCaNiem.PerformClick();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExportExcel excel = new ExportExcel();
            // Lấy về nguồn dữ liệu cần Export là 1 DataTable
            DataTable dt = bll_hhv.loadAllInfo_HocVien();
            excel.Export(dt, "Danh sach tham gia khoa tu", "DANH SÁCH THAM GIA KHÓA TU VẠN ĐỨC TỰ");

        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            initForm();
        }

        private void txtSTT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSTT.PerformClick();
        }

        private void btnSTT_Click(object sender, EventArgs e)
        {
            dgvHocVien.DataSource = bll_sear_hv.searchSTT(int.Parse(txtSTT.Text));
            isDgvEmpty();
        }
    }
}

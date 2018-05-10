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
using BLL.BOT;
namespace QL_HocVien._EDIT
{
    public partial class frmEditHocVien : FormCommon
    {
        bll_hocvien_infomation _bll_hv = new bll_hocvien_infomation();
        bot_hocvien_infomation _bot_hv = new bot_hocvien_infomation();
        bot_vitri_khu _botvt = new bot_vitri_khu();
        string oldVitri;
        public frmEditHocVien()
        {
            InitializeComponent();
            initForm();
        }

        private void initForm()
        {
            txtSTT.Select();

            cbbKhu.DisplayMember = "khu_id";
            cbbKhu.DataSource = _bll_hv.loadCbbKhu();
            cbbCaNiemPhat.DataSource = _bll_hv.loadCbbCaNiem();
            cbbCaNiemPhat.DisplayMember = "ca_niem";

            txtCMND.Text = _QUANLY.frmQuanLyThongTin.cmnd_;
            txtDiaChi.Text = _QUANLY.frmQuanLyThongTin.diachi_;
            txtDienThoai.Text = _QUANLY.frmQuanLyThongTin.phone_;
            txtDTNguoiThan.Text = _QUANLY.frmQuanLyThongTin.phone_nguoithan_;
            txtGhiChu.Text = _QUANLY.frmQuanLyThongTin.ghichu_;
            txtLoaiCMND.Text = _QUANLY.frmQuanLyThongTin.cmnd_note_;
            txtNamSinh.Text = _QUANLY.frmQuanLyThongTin.namsinh_.ToString();
            txtPhapDanh.Text = _QUANLY.frmQuanLyThongTin.phapdanh_;
            txtSTT.Text = _QUANLY.frmQuanLyThongTin.hocvien_id_.ToString();
            txtTheDanh.Text = _QUANLY.frmQuanLyThongTin.thedanh_;
            cbbCaNiemPhat.Text = _QUANLY.frmQuanLyThongTin.caniemphat_;
            cbbKhu.Text = _QUANLY.frmQuanLyThongTin.khu_;
            cbbViTri.Text = _QUANLY.frmQuanLyThongTin.vitri_;
            dtpNgayDen.Value = _QUANLY.frmQuanLyThongTin.ngayden_;
            dtpNgayDi.Value = _QUANLY.frmQuanLyThongTin.ngaydi_;
            oldVitri = cbbViTri.Text;

        }

        private void reloadInitForm()
        {
            txtSTT.Select();
            cbbKhu.DisplayMember = "khu_id";
            cbbKhu.DataSource = _bll_hv.loadCbbKhu();
            
            cbbCaNiemPhat.DataSource = _bll_hv.loadCbbCaNiem();
            cbbCaNiemPhat.DisplayMember = "ca_niem";
            oldVitri = cbbViTri.Text;
        }

        private bool isEmpty(string _text)
        {
            return (_text.Equals("")) ? true : false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isEmpty(txtCMND.Text) || isEmpty(txtSTT.Text) || isEmpty(txtDienThoai.Text) || isEmpty(txtDTNguoiThan.Text) || isEmpty(txtPhapDanh.Text) || isEmpty(txtTheDanh.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ các thông tin có đánh dấu (*)", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    _bot_hv.hocvien_id = int.Parse(txtSTT.Text);
                    
                        _bot_hv.phapdanh = txtPhapDanh.Text;
                        _bot_hv.thedanh = txtTheDanh.Text;
                        _bot_hv.phone = txtDienThoai.Text;
                        _bot_hv.nguoithan_phone = txtDTNguoiThan.Text;
                        _bot_hv.namsinh = int.Parse(txtNamSinh.Text);
                        _bot_hv.hocvien_diachi = txtDiaChi.Text;
                        _bot_hv.cmnd_note = txtLoaiCMND.Text;
                        _bot_hv.cmnd = txtCMND.Text;
                        _bot_hv.khu_id = cbbKhu.Text;
                        _bot_hv.vitri = cbbViTri.Text;
                        _bot_hv.caniemphat = cbbCaNiemPhat.Text;
                        _bot_hv.ngayden = dtpNgayDen.Value;
                        DateTime.Parse(_bot_hv.ngayden.ToString()).ToShortDateString();
                        _bot_hv.ngayve = dtpNgayDi.Value;
                        DateTime.Parse(_bot_hv.ngayve.ToString()).ToShortDateString();
                        _bot_hv.ghichu = txtGhiChu.Text;
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show("Nhấn Yes để thực hiện lưu tất cả thông tin, Nhấn No nếu không muốn lưu thông tin Khu và Vị trí, Nhấn Cancel để hủy bỏ!", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        MessageBox.Show(_bll_hv.UpdateHocVienAll(_bot_hv, oldVitri), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadInitForm();
                    }
                    else if (dr == DialogResult.No)
                    {
                        MessageBox.Show(_bll_hv.UpdateHocVien_(_bot_hv, oldVitri), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadInitForm();
                    }
                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception");
                }


            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Dừng chỉnh sửa thông tin học viên?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
                this.Close();
        }

        private void cbbKhu_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbViTri.DataSource = _bll_hv.loadCbbViTri(cbbKhu.Text);
            cbbViTri.DisplayMember = "vitri";

        }
    }
}

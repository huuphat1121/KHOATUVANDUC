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
namespace QL_HocVien._ADD
{
    public partial class frmAdd_HocVien : FormCommon
    {
        bll_hocvien_infomation _bll_hv = new bll_hocvien_infomation();
        bot_hocvien_infomation _bot_hv = new bot_hocvien_infomation();
        bot_vitri_khu _botvt = new bot_vitri_khu();
        public frmAdd_HocVien()
        {
            InitializeComponent();
            initForm();
        }

        private void initForm()
        {
            txtSTT.Select();
            cbbKhu.DisplayMember = "khu_id";
            cbbKhu.DataSource = _bll_hv.loadCbbKhu();
            cbbKhu.DisplayMember = "khu_id";
            cbbCaNiemPhat.DisplayMember = "ca_niem";
            cbbCaNiemPhat.DataSource = _bll_hv.loadCbbCaNiem();
            cbbCaNiemPhat.DisplayMember = "ca_niem";
            txtSTT.Text = (_bll_hv.loadSTTMax() + 1).ToString();
        }

        private void reloadInitForm(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        private bool isEmpty(string _text)
        {
            return (_text.Equals("")) ? true : false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Dừng thao tác thêm Phật Tử?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr==DialogResult.OK)
                this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(isEmpty(txtCMND.Text) || isEmpty(txtSTT.Text) || isEmpty(txtDienThoai.Text) || isEmpty(txtDTNguoiThan.Text) || isEmpty(txtPhapDanh.Text) || isEmpty(txtTheDanh.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ các thông tin có đánh dấu (*)", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    _bot_hv.hocvien_id = int.Parse(txtSTT.Text);
                    if (_bll_hv.checkID(_bot_hv).Equals(0))
                    {
                        MessageBox.Show("Số thứ tự vừa nhập đã được đăng ký, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _bot_hv.phapdanh = txtPhapDanh.Text;
                        _bot_hv.thedanh = txtTheDanh.Text;
                        _bot_hv.phone = txtDienThoai.Text;
                        _bot_hv.nguoithan_phone = txtDTNguoiThan.Text;
                        _bot_hv.namsinh = txtNamSinh.Text;
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
                        _bot_hv.thoigian = DateTime.Now;
                        MessageBox.Show(_bll_hv.AddHocVien(_bot_hv), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadInitForm(this);
                        initForm();
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception");
                }
                

            }
        }

        private void txtSTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)46 && e.KeyChar != (char)8)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                {
                    e.Handled = true;
                    MessageBox.Show("Vui lòng chỉ nhập số!");
                }
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)46 && e.KeyChar != (char)8)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                {
                    e.Handled = true;
                    MessageBox.Show("Vui lòng chỉ nhập số!");
                }
            }
        }

        private void txtDTNguoiThan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)46 && e.KeyChar != (char)8)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                {
                    e.Handled = true;
                    MessageBox.Show("Vui lòng chỉ nhập số!");
                }
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)46 && e.KeyChar != (char)8)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                {
                    e.Handled = true;
                    MessageBox.Show("Vui lòng chỉ nhập số!");
                }
            }
        }

        private void txtNamSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)46 && e.KeyChar != (char)8)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                {
                    e.Handled = true;
                    MessageBox.Show("Vui lòng chỉ nhập số!");
                }
            }
        }

        private void cbbKhu_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbViTri.DataSource = _bll_hv.loadCbbViTri(cbbKhu.Text);
            cbbViTri.DisplayMember = "vitri";

        }
    }
}

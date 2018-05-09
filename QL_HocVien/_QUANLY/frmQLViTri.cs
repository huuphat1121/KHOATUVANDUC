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
namespace QL_HocVien._QUANLY
{
    public partial class frmQLViTri : FormCommon
    {
        bll_hocvien_infomation _bll_hv = new bll_hocvien_infomation();
        bll_vitri _bll_vt = new bll_vitri();
        bot_vitri_khu _bot_vt = new bot_vitri_khu();
        public frmQLViTri()
        {
            InitializeComponent();
            initForm();
        }

        private void initForm()
        {
            cbbKhu.DisplayMember = "khu_id";
            cbbKhu.DataSource = _bll_vt.loadCbbKhu();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Thêm vị trí đã nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                _bot_vt.khu_id = cbbKhu.Text;
                _bot_vt.vitri = txtVitri.Text;
                if (_bll_vt.checkViTri(_bot_vt).Equals(0))
                {
                    MessageBox.Show("Vị trí này đã tồn tại, vui lòng kiểm tra và nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(_bll_vt.AddViTri(_bot_vt), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    initForm();
                }
                
            }
        }

        private void txtVitri_TextChanged(object sender, EventArgs e)
        {
            if (!btnThem.Enabled && !txtVitri.Text.Equals(""))
            {
                btnThem.Enabled = true;
            }
            else
            {
                if (txtVitri.Text.Equals(""))
                    btnThem.Enabled = false;
            }
        }

        private void cbbKhu_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvViTri.DataSource = _bll_vt.loadDgvViTri(cbbKhu.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Xóa vị trí đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                _bot_vt.khu_id = dgvViTri.CurrentRow.Cells["khu_id"].Value.ToString();
                _bot_vt.vitri = dgvViTri.CurrentRow.Cells["vitri"].Value.ToString();
                MessageBox.Show(_bll_vt.DeleteViTri(_bot_vt), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                initForm();
            }
        }

        private void dgvViTri_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void dgvViTri_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _bot_vt.status = bool.Parse(dgvViTri.CurrentRow.Cells["status"].Value.ToString());
            _bot_vt.khu_id = dgvViTri.CurrentRow.Cells["khu_id"].Value.ToString();
            _bot_vt.vitri = dgvViTri.CurrentRow.Cells["vitri"].Value.ToString();
            _bll_vt.UpdateViTri(_bot_vt);
        }
    }
}

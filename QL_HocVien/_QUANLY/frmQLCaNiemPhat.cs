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
    public partial class frmQLCaNiemPhat : FormCommon
    {
        bot_caniemphat _bot_ca = new bot_caniemphat();
        bll_caniemphat _bll_ca = new bll_caniemphat();
        public frmQLCaNiemPhat()
        {
            InitializeComponent();
            initForm();
        }

        private void initForm()
        {
            txtCaNiemPhat.Select();
            dgvCaNiemPhat.DataSource = _bll_ca.loadCaNiemPhat();
            btnThem.Enabled = false;
        }

        private void txtCaNiemPhat_TextChanged(object sender, EventArgs e)
        {
            if (!btnThem.Enabled && !txtCaNiemPhat.Text.Equals(""))
            {
                btnThem.Enabled = true;
            }
            else
            {
                if (txtCaNiemPhat.Text.Equals(""))
                    btnThem.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Thêm ca niệm phật đã nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                _bot_ca.ca_niem = txtCaNiemPhat.Text;
                if (_bll_ca.checkCaNiem(_bot_ca).Equals(0))
                {
                    MessageBox.Show("Ca này đã tồn tại, vui lòng kiểm tra và nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(_bll_ca.AddCaNiem(_bot_ca), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    initForm();
                }

            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Xóa Ca đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                _bot_ca.ca_niem = dgvCaNiemPhat.CurrentRow.Cells["ca_niem"].Value.ToString();
                MessageBox.Show(_bll_ca.DeleteCaNiem(_bot_ca), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                initForm();
            }
        }
    }
}

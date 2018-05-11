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
namespace QL_HocVien._EDIT
{
    public partial class frmEditCaNiemPhat : Form
    {
        bll_caniemphat _bll_ca = new bll_caniemphat();
        int ca_id;
        public frmEditCaNiemPhat()
        {
            InitializeComponent();
            initForm();
        }

        private void initForm()
        {
            txtCaNiemPhat.Text = _QUANLY.frmQLCaNiemPhat.caniemphat_;
            ca_id = _QUANLY.frmQLCaNiemPhat.ca_id_;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_bll_ca.UpdateCaNiem(txtCaNiemPhat.Text,ca_id ), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

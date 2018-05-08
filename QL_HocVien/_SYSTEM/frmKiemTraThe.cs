﻿using System;
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
namespace QL_HocVien._SYSTEM
{
    public partial class frmKiemTraThe : FormCommon
    {
        bll_hocvien_infomation bll_hv = new bll_hocvien_infomation();
        bot_hocvien_infomation bot_hv = new bot_hocvien_infomation();
        bot_vitri_khu bot_vt = new bot_vitri_khu();
        public frmKiemTraThe()
        {
            InitializeComponent();
            txtMaHocVien.Select();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaHocVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txtMaHocVien.Text.Equals(""))
                {
                    
                    bot_hv.hocvien_id = int.Parse(txtMaHocVien.Text);
                    if (bll_hv.checkID(bot_hv) == 1)
                    {
                        MessageBox.Show("Học viên chưa đăng ký trong danh sách, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        bll_hv.loadInfoHocVien(bot_hv);
                        lblPhapDanh.Text = bot_hv.phapdanh;
                        lblTheDanh.Text = bot_hv.thedanh;
                        lblNamSinh.Text = bot_hv.namsinh.ToString();
                        lblDienThoai.Text = bot_hv.phone;
                        lblViTri.Text = bot_hv.vitri;
                        lblCaNiemPhat.Text = bot_hv.caniemphat;
                    }
                    
                }
            }
            if (e.KeyCode == Keys.Back)
            {
                txtMaHocVien.Text = "";
                txtMaHocVien.Select(); 
            }
        }

        private void frmKiemTraThe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
    }
}

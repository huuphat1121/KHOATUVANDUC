using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL.BOT;
using DAL;
namespace BLL
{
    public class bll_hocvien_infomation
    {
        Connection cn = new Connection();
        BOT.bot_hocvien_infomation bot_hv = new BOT.bot_hocvien_infomation();
        BOT.bot_vitri_khu bot_vt = new BOT.bot_vitri_khu();

        /*
         * Fuction Check Info
         */

        public int checkID(bot_hocvien_infomation bot_hv)
        {
            string sqlTemp = "select count(*) from hocvien_info where hocvien_id = '" + bot_hv.hocvien_id + "'";
            int count = int.Parse(cn.GetValue(sqlTemp).ToString());
            return (count == 0) ? 1 : 0;
        }

        public int checkName(bot_hocvien_infomation bot_hv)
        {
            string sqlTemp = "select count(*) from hocvien_info where thedanh = N'" + bot_hv.thedanh + "'";
            int count = int.Parse(cn.GetValue(sqlTemp).ToString());
            return (count == 0) ? 1 : 0;
        }

        public int checkCMND(bot_hocvien_infomation bot_hv)
        {
            string sqlTemp = "select count(*) from hocvien_info where cmnd = '" + bot_hv.cmnd + "'";
            int count = int.Parse(cn.GetValue(sqlTemp).ToString());
            return (count == 0) ? 1 : 0;
        }

        /*
         * Fuction Load Information
         * */
        public void loadInfoHocVien(bot_hocvien_infomation bot_hv)
        {
            DataTable dt = new DataTable();
            string sql_ = "select phapdanh, thedanh, namsinh, phone, vitri, caniemphat from hocvien_info where hocvien_id='" + bot_hv.hocvien_id + "'";
            dt = cn.GetAllValue(sql_);
            bot_hv.phapdanh = dt.Rows[0][0].ToString();
            bot_hv.thedanh = dt.Rows[0][1].ToString();
            bot_hv.phone = dt.Rows[0][3].ToString();
            if (!dt.Rows[0][2].ToString().Equals(""))
                bot_hv.namsinh = int.Parse(dt.Rows[0][2].ToString());
            else bot_hv.namsinh = -1;
            bot_hv.vitri = dt.Rows[0][4].ToString();
            bot_hv.caniemphat = dt.Rows[0][5].ToString();
        }

        public void loadInfoHocVienCMND(bot_hocvien_infomation bot_hv)
        {
            DataTable dt = new DataTable();
            string sql_ = "select phapdanh, thedanh, namsinh, phone, vitri, caniemphat from hocvien_info where cmnd='" + bot_hv.cmnd + "'";
            dt = cn.GetAllValue(sql_);
            bot_hv.phapdanh = dt.Rows[0][0].ToString();
            bot_hv.thedanh = dt.Rows[0][1].ToString();
            bot_hv.phone = dt.Rows[0][3].ToString();
            if (!dt.Rows[0][2].ToString().Equals(""))
                bot_hv.namsinh = int.Parse(dt.Rows[0][2].ToString());
            else bot_hv.namsinh = -1;
            bot_hv.vitri = dt.Rows[0][4].ToString();
            bot_hv.caniemphat = dt.Rows[0][5].ToString();
        }

        public void loadInfoHocVienTheDanh(bot_hocvien_infomation bot_hv)
        {
            DataTable dt = new DataTable();
            string sql_ = "select phapdanh, thedanh, namsinh, phone, vitri, caniemphat from hocvien_info where thedanh='" + bot_hv.thedanh + "'";
            dt = cn.GetAllValue(sql_);
            bot_hv.phapdanh = dt.Rows[0][0].ToString();
            bot_hv.thedanh = dt.Rows[0][1].ToString();
            bot_hv.phone = dt.Rows[0][3].ToString();
            if (!dt.Rows[0][2].ToString().Equals(""))
                bot_hv.namsinh = int.Parse(dt.Rows[0][2].ToString());
            else bot_hv.namsinh = -1;
            bot_hv.vitri = dt.Rows[0][4].ToString();
            bot_hv.caniemphat = dt.Rows[0][5].ToString();
        }

        public DataTable loadInfoHocVien_PrintAll()
        {
            string sql_ = "select phapdanh, thedanh, namsinh, vitri, caniemphat,hocvien_id from hocvien_info order by hocvien_id";
            return cn.GetAllValue(sql_);
        }
        public DataTable loadAllInfo_HocVien()
        {
            string sql_ = "select hocvien_id,phapdanh,thedanh,namsinh,phone,nguoithan_phone,cmnd,cmnd_note,hocvien_diachi,khu_id,vitri,caniemphat,ngayden,ngayve,ghichu from hocvien_info order by hocvien_id";
            return cn.GetAllValue(sql_);
        }

        public DataTable loadCbbKhu()
        {
            string sql_="select distinct khu_id from vitri_khu where status = true";
            return cn.GetAllValue(sql_);
        }

        public DataTable loadCbbViTri(string khu_id_)
        {
            string sql_ = "select distinct vitri from vitri_khu where khu_id='"+khu_id_+"' and status=true";
            return cn.GetAllValue(sql_);
        }

        public DataTable loadCbbCaNiem()
        {
            string sql_ = "select distinct ca_niem from ca_niem_phat";
            return cn.GetAllValue(sql_);
        }

        /*
         * Function Update Data
         */
         public string AddHocVien(bot_hocvien_infomation _bot_hv)
        {
            string sql_ = "insert into hocvien_info (hocvien_id,phapdanh,thedanh, phone, nguoithan_phone, cmnd, cmnd_note, hocvien_diachi, namsinh, vitri, ngayden, ngayve, ghichu, caniemphat, khu_id) values ('"+_bot_hv.hocvien_id+"','"+_bot_hv.phapdanh+"','"+_bot_hv.thedanh+"','"+_bot_hv.phone+"','"+_bot_hv.nguoithan_phone+"','"+_bot_hv.cmnd+"','"+_bot_hv.cmnd_note+"','"+_bot_hv.hocvien_diachi+"','"+_bot_hv.namsinh+"','"+_bot_hv.vitri+"','"+_bot_hv.ngayden+"','"+_bot_hv.ngayve+"','"+_bot_hv.ghichu+"','"+_bot_hv.caniemphat+"','"+_bot_hv.khu_id+"')";
            cn.Update(sql_);
            sql_ = "update vitri_khu set status=false where vitri='" + _bot_hv.vitri + "'";
            cn.Update(sql_);
            return "Thêm thông tin học viên thành công!";
        }

        public string UpdateHocVienAll(bot_hocvien_infomation _bot_hv, string oldViTri)
        {
            string sql_ = "update hocvien_info set phapdanh='"+_bot_hv.phapdanh+ "',thedanh='" + _bot_hv.thedanh + "',phone='" + _bot_hv.phone + "',nguoithan_phone='" + _bot_hv.nguoithan_phone + "',cmnd='" + _bot_hv.cmnd + "',cmnd_note='" + _bot_hv.cmnd_note + "',hocvien_diachi='" + _bot_hv.hocvien_diachi + "',namsinh='" + _bot_hv.namsinh + "',vitri='" + _bot_hv.vitri + "',ngayden='" + _bot_hv.ngayden + "',ngayve='" + _bot_hv.ngayve + "',ghichu='" + _bot_hv.ghichu + "',caniemphat='" + _bot_hv.caniemphat + "', khu_id='"+_bot_hv.khu_id+"'where hocvien_id='" + _bot_hv.hocvien_id+"'";
            cn.Update(sql_);
            sql_ = "update vitri_khu set status=true where vitri='" + oldViTri + "'";
            cn.Update(sql_);
            sql_ = "update vitri_khu set status=false where vitri='" + _bot_hv.vitri + "'";
            cn.Update(sql_);
            
            return "Chỉnh sửa thông tin học viên thành công!";
        }

        public string UpdateHocVien_(bot_hocvien_infomation _bot_hv, string oldViTri)
        {
            string sql_ = "update hocvien_info set phapdanh='" + _bot_hv.phapdanh + "',thedanh='" + _bot_hv.thedanh + "',phone='" + _bot_hv.phone + "',nguoithan_phone='" + _bot_hv.nguoithan_phone + "',cmnd='" + _bot_hv.cmnd + "',cmnd_note='" + _bot_hv.cmnd_note + "',hocvien_diachi='" + _bot_hv.hocvien_diachi + "',namsinh='" + _bot_hv.namsinh + "',ngayden='" + _bot_hv.ngayden + "',ngayve='" + _bot_hv.ngayve + "',ghichu='" + _bot_hv.ghichu + "',caniemphat='" + _bot_hv.caniemphat + "'where hocvien_id='" + _bot_hv.hocvien_id + "'";
            cn.Update(sql_);
            sql_ = "update vitri_khu set status=true where vitri='" + oldViTri + "'";
            cn.Update(sql_);
            sql_ = "update vitri_khu set status=false where vitri='" + _bot_hv.vitri + "'";
            cn.Update(sql_);

            return "Chỉnh sửa thông tin học viên thành công!";
        }

        public string DeleteHocVien(int hocvien_id)
        {
            string sql_ = "delete from hocvien_info where hocvien_id='"+hocvien_id+"' ";
            cn.Update(sql_);
            return "Xóa thông tin học viên thành công!";
        }
    }
}

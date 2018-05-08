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

        public void loadInfoHocVien(bot_hocvien_infomation bot_hv)
        {
            DataTable dt = new DataTable();
            string sql_ = "select phapdanh, thedanh, namsinh, phone, vitri, caniemphat from hocvien_info where hocvien_id='"+bot_hv.hocvien_id+"'";
            dt = cn.GetAllValue(sql_);
            bot_hv.phapdanh = dt.Rows[0][0].ToString();
            bot_hv.thedanh= dt.Rows[0][1].ToString();
            bot_hv.phone = dt.Rows[0][3].ToString();
            bot_hv.namsinh = int.Parse(dt.Rows[0][2].ToString());
            bot_hv.vitri = dt.Rows[0][4].ToString();
            bot_hv.caniemphat = dt.Rows[0][5].ToString();
        }

        public int checkID(bot_hocvien_infomation bot_hv)
        {
            string sqlTemp = "select count(*) from hocvien_info where hocvien_id = '" + bot_hv.hocvien_id + "'";
            int count = int.Parse(cn.GetValue(sqlTemp).ToString());
            return (count == 0) ? 1 : 0;
        }

        public DataTable loadAllInfo_HocVien()
        {
            string sql_ = "select * from hocvien_info";
            return cn.GetAllValue(sql_);
        }

        public DataTable loadCbbKhu()
        {
            string sql_="select distinct khu_id from vitri_khu";
            return cn.GetAllValue(sql_);
        }

        public DataTable loadCbbCaNiem()
        {
            string sql_ = "select distinct ca_niem from ca_niem_phat";
            return cn.GetAllValue(sql_);
        }
    }
}

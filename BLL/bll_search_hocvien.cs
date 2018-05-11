using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public class bll_search_hocvien
    {
        BOT.bot_hocvien_infomation hhv_bot = new BOT.bot_hocvien_infomation();
        Connection cn = new Connection();

        public DataTable searchPhapDanh(string phapdanh_)
        {
            string sql_ = "select * from hocvien_info where phapdanh='" + phapdanh_ + "'";
            return cn.GetAllValue(sql_);
        }

        public DataTable searchTheDanh(string thedanh_)
        {
            string sql_ = "select * from hocvien_info where thedanh='" + thedanh_ + "'";
            return cn.GetAllValue(sql_);
        }

        public DataTable searchCMND(string CMND_)
        {
            string sql_ = "select * from hocvien_info where cmnd='" + CMND_ + "'";
            return cn.GetAllValue(sql_);
        }

        public DataTable searchKhu(string khu_)
        {
            string sql_ = "select * from hocvien_info where khu_id='" + khu_ + "'";
            return cn.GetAllValue(sql_);
        }

        public DataTable searchCaNiem(string caniem_)
        {
            string sql_ = "select * from hocvien_info where caniemphat='" + caniem_ + "'";
            return cn.GetAllValue(sql_);
        }

        public DataTable searchNgayDen(DateTime ngayden_)
        {
            string sql_ = "select * from hocvien_info where ngayden='" + ngayden_ + "'";
            return cn.GetAllValue(sql_);
        }

        public DataTable searchNgayVe(DateTime ngayve_)
        {
            string sql_ = "select * from hocvien_info where ngayve='" + ngayve_ + "'";
            return cn.GetAllValue(sql_);
        }

        public DataTable searchSTT(int stt_)
        {
            string sql_ = "select * from hocvien_info where hocvien_id='" + stt_ + "'";
            return cn.GetAllValue(sql_);
        }

    }
}

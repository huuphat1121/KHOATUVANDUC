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
    public class bll_caniemphat
    {
        Connection cn = new Connection();

        public DataTable loadCaNiemPhat()
        {
            string sql_ = "Select * from ca_niem_phat";
            return cn.GetAllValue(sql_);
        }


        public int checkCaNiem(bot_caniemphat _bot_ca)
        {
            string sqlTemp = "select count(*) from ca_niem_phat where ca_niem = '" + _bot_ca.ca_niem + "'";
            int count = int.Parse(cn.GetValue(sqlTemp).ToString());
            return (count == 0) ? 1 : 0;
        }

        public string AddCaNiem(bot_caniemphat _bot_ca)
        {
            string sql_ = "insert into ca_niem_phat (ca_niem) values ('" + _bot_ca.ca_niem + "')";
            cn.Update(sql_);
            return "Thêm Ca niệm phật thành công!";
        }

        public string UpdateCaNiem(string text, int ca_id_)
        {
            string sql_ = "update ca_niem_phat set ca_niem='" + text + "' where ca_id='" + ca_id_ + "'";
            cn.Update(sql_);
            return "Chỉnh sửa ca niệm phật thành công!";
        }

        public string DeleteCaNiem(bot_caniemphat _bot_ca)
        {
            string sql_ = "delete from ca_niem_phat where ca_niem='" + _bot_ca.ca_niem + "'";
            cn.Update(sql_);
            return "Xóa Ca niệm phật thành công!";
        }
    }
}

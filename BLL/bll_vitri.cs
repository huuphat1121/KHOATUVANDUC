using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using BLL.BOT;

namespace BLL
{
    public class bll_vitri
    {
        Connection cn = new Connection();

        public DataTable loadCbbKhu()
        {
            string sql_ = "select distinct khu_id from vitri_khu";
            return cn.GetAllValue(sql_);
        }

        public DataTable loadDgvViTri(string text)
        {
            string sql_ = "select * from vitri_khu where khu_id='"+text+"' order by vitri";
            return cn.GetAllValue(sql_);
        }

        public string AddViTri(bot_vitri_khu _bot_vt)
        {
            string sql_ = "insert into vitri_khu (khu_id,vitri) values ('"+_bot_vt.khu_id+"','"+_bot_vt.vitri+"')";
            cn.Update(sql_);
            return "Thêm vị trí mới thành công!";
        }

        public int checkViTri(bot_vitri_khu _bot_vt)
        {
            string sqlTemp = "select count(*) from vitri_khu where khu_id = '" + _bot_vt.khu_id + "' and vitri='"+_bot_vt.vitri+"'";
            int count = int.Parse(cn.GetValue(sqlTemp).ToString());
            return (count == 0) ? 1 : 0;
        }

        public string DeleteViTri(bot_vitri_khu _bot_vt)
        {
            string sql_ = "delete from vitri_khu where khu_id='" + _bot_vt.khu_id + "' and vitri='" + _bot_vt.vitri + "'";
            cn.Update(sql_);
            return "Xóa vị trí đã chọn thành công!";
        }

        public void UpdateViTri(bot_vitri_khu _bot_vt)
        {
            string sql_ = "update vitri_khu set status='"+_bot_vt.status+"' where khu_id='" + _bot_vt.khu_id + "' and vitri='" + _bot_vt.vitri + "'";
            cn.Update(sql_);
        }
    }
}

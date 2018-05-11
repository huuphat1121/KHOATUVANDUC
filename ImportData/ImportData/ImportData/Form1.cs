using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
namespace ImportData
{
    public partial class Form1 : Form
    {
        string khu_id_;
        string vitri_;
        public  int hocvien_id_;
        public  string namsinh_;
        public  string phapdanh_;
        public  string thedanh_;
        public  string phone_nguoithan_;
        public  string diachi_;
        public  string cmnd_;
        
        Connection cn = new Connection();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            OpenFileDialog fopen = new OpenFileDialog();
            fopen.Filter = "(Tất cả các file)|*.*|(File Excel)|*.xlsx;*.xls";
            fopen.ShowDialog();
            if (fopen.FileName != "")
            {
                txtfilepath.Text = fopen.FileName;

            }
            else
            {
                MessageBox.Show("Không có file được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtfilepath.Text = "";
            }
        }

        private void btnVitri_Click(object sender, EventArgs e)
        {
            string sql_;
            int count = 0;
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Open(txtfilepath.Text);
            try
            {
                Microsoft.Office.Interop.Excel._Worksheet sheet = wb.Sheets[1];
                Microsoft.Office.Interop.Excel.Range range = sheet.UsedRange;
                int rows = range.Rows.Count;
                int cols = range.Columns.Count;
                for (int i = 1; i <= rows; i++)
                {
                    khu_id_ = range.Cells[i, 1].Value.ToString();
                    vitri_ = range.Cells[i, 2].Value.ToString();
                    //MessageBox.Show(khu_id_, rows.ToString());
                    sql_ = "insert into vitri_khu(khu_id,vitri) values('" + khu_id_ + "','" + vitri_ + "')";
                    cn.Update(sql_);
                    count++;
                }
                MessageBox.Show(count.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtfilepath.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHocVien_Click(object sender, EventArgs e)
        {
            string sql_;
            string checkSql;
            int count = 0;
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Open(txtfilepath.Text);
            try
            {
                Microsoft.Office.Interop.Excel._Worksheet sheet = wb.Sheets[1];
                Microsoft.Office.Interop.Excel.Range range = sheet.UsedRange;
                int rows = range.Rows.Count;
                int cols = range.Columns.Count;
                //MessageBox.Show(rows.ToString());
                for (int i = 2; i <= rows; i++)
                {
                    hocvien_id_ = int.Parse(range.Cells[i, 1].Value.ToString());
                    checkSql = "select count(*) from hocvien_info where hocvien_id='" + hocvien_id_ + "'";
                    if (!int.Parse(cn.GetValue(checkSql).ToString()).Equals(0))
                    {
                        continue;
                    }else
                    {
                        //hocvien_id_ = int.Parse(range.Cells[i, 1].Value.ToString());
                        if (!range.Cells[i, 3].Value.ToString().Equals(null) && !range.Cells[i, 3].Value.ToString().Equals(" "))
                            phapdanh_ = range.Cells[i, 3].Value.ToString();
                        else phapdanh_ = "";
                        if (!range.Cells[i, 2].Value.ToString().Equals(null) && !range.Cells[i, 2].Value.ToString().Equals(" "))
                            thedanh_ = range.Cells[i, 2].Value.ToString();
                        else thedanh_ = "";
                        if (!range.Cells[i, 4].Value.ToString().Equals(null) && !range.Cells[i, 4].Value.ToString().Equals(" "))
                            namsinh_ = range.Cells[i, 4].Value.ToString();
                        else namsinh_ = "";
                        if (!range.Cells[i, 5].Value.ToString().Equals(null) && !range.Cells[i, 5].Value.ToString().Equals(" "))
                            cmnd_ = range.Cells[i, 5].Value.ToString();
                        else cmnd_ = "";
                        if (!range.Cells[i, 6].Value.ToString().Equals(null) && !range.Cells[i, 6].Value.ToString().Equals(" "))
                            phone_nguoithan_ = range.Cells[i, 6].Value.ToString();
                        else phone_nguoithan_ = "";
                        if (!range.Cells[i, 7].Value.ToString().Equals(null) && !range.Cells[i, 7].Value.ToString().Equals(" "))
                            diachi_ = range.Cells[i, 7].Value.ToString();
                        else diachi_ = "";
                        sql_ = "insert into hocvien_info(hocvien_id,phapdanh,thedanh,namsinh,cmnd,nguoithan_phone,hocvien_diachi) values('" + hocvien_id_ + "','" + phapdanh_ + "','" + thedanh_ + "','" + namsinh_ + "','" + cmnd_ + "','" + phone_nguoithan_ + "','" + diachi_ + "')";
                        cn.Update(sql_);
                        count++;
                    }
                    
                    
                    
                }
                MessageBox.Show(count.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtfilepath.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

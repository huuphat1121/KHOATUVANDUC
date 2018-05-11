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
using KeepAutomation.Barcode.Bean;
using System.IO;
namespace QL_HocVien._SYSTEM
{
    public partial class InThe_ : Form
    {
        bll_hocvien_infomation bll_hv = new bll_hocvien_infomation();
        bot_hocvien_infomation bot_hv = new bot_hocvien_infomation();
        bot_vitri_khu bot_vt = new bot_vitri_khu();
        static string stt_;
        public InThe_()
        {
            InitializeComponent();
            btnKiemTra.Enabled = false;
            btnXuatAnh.Enabled = false;
            btnXuatAnhCu.Enabled = false;
            txtSTT.Select();
        }

        private void InThe__Load(object sender, EventArgs e)
        {

        }


        void ControlToBitmap(Control ctrol,string fileName)
        {
            Size ctrlSize = ctrol.Size;
            Rectangle rect = new Rectangle(new Point(0, 0), ctrlSize);
            Bitmap bitmap = new Bitmap(ctrlSize.Width, ctrlSize.Height);
            ctrol.DrawToBitmap(bitmap, rect);
            Bitmap result = new Bitmap(ctrlSize.Width, ctrlSize.Height);
            Graphics g = Graphics.FromImage(result);
            rect.Size = ctrlSize;
            g.DrawImage(bitmap, rect);
            pictureBox1.Image = result;
            System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Icon;
            pictureBox1.Image.Save(fileName, format);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)46 && e.KeyChar != (char)8)
            //{
            //    if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
            //    {
            //        e.Handled = true;
            //        MessageBox.Show("Vui lòng chỉ nhập số!");
            //    }
            //}
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            //string fileName;
            bot_hv.hocvien_id = int.Parse(txtSTT.Text);
            if (bll_hv.checkID(bot_hv) == 1)
            {
                MessageBox.Show("Học viên chưa đăng ký trong danh sách, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                    }
                    if (picResult.Image != null)
                    {
                        picResult.Image.Dispose();
                        picResult.Image = null;
                    }
                    if (picResult1.Image != null)
                    {
                        picResult1.Image.Dispose();
                        picResult1.Image = null;
                    }
                    bll_hv.loadInfoHocVien(bot_hv);
                    lblPhapDanh.Text = bot_hv.phapdanh;
                    lblTheDanh.Text = bot_hv.thedanh;
                    if (!bot_hv.namsinh.Equals(-1))
                        lblNgaySinh.Text = bot_hv.namsinh.ToString();
                    else lblNgaySinh.Text = "";
                    lblVitri.Text = bot_hv.vitri;
                    lblCaNiemPhat.Text = bot_hv.caniemphat;
                    lblPhapDanh1.Text = bot_hv.phapdanh;
                    lblTheDanh1.Text = bot_hv.thedanh;
                    if (!bot_hv.namsinh.Equals(-1))
                        lblNgaySinh1.Text = bot_hv.namsinh.ToString();
                    else lblNgaySinh1.Text = "";
                    createBarcode(txtSTT.Text);
                    //barCodeControl1.CreateGraphics();
                    

                    btnXuatAnh.Enabled = true;
                    btnXuatAnhCu.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message");
                }
                
            }
        }


        private void createBarcode(string stt_)
        {
            string fileName;
            BarCode barcode = new BarCode();
            barcode.DisplayChecksum = false;
            barcode.TildeEnabled = false;
            barcode.Symbology = KeepAutomation.Barcode.Symbology.Code93;
            barcode.CodeToEncode = stt_;
            barcode.X = 1;
            barcode.Y = 30;
            barcode.BarCodeWidth = 100;
            barcode.BarCodeHeight = 53;
            barcode.DisplayText = true;
            barcode.DisplayStartStop = true;
            barcode.BarcodeUnit = KeepAutomation.Barcode.BarcodeUnit.Pixel;
            barcode.Orientation = KeepAutomation.Barcode.Orientation.Degree0;
            barcode.DPI = 400;
            fileName = stt_ + ".ico";
            barcode.ImageFormat = System.Drawing.Imaging.ImageFormat.Png;
            barcode.generateBarcodeToImageFile(fileName);
            picResult.Image = Image.FromFile(fileName);
            picResult1.Image = Image.FromFile(fileName);

        }
        private void btnXuatAnh_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists("D://The Chua Van Duc"))
            {
                Directory.CreateDirectory("D://The Chua Van Duc");
            }
            string fileName= "D://The Chua Van Duc/"+txtSTT.Text + ".ico";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            ControlToBitmap(panel1, fileName);
            MessageBox.Show("Xuất file thành công! Vui lòng kiểm tra theo đường dẫn D:/The Chua Van Duc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnXuatAnh.Enabled = false;
            btnXuatAnhCu.Enabled = false;
            txtSTT.Text = "";

        }

        //private void btnXuatTatCa_Click(object sender, EventArgs e)
        //{
        //    string fileName;
        //    DialogResult dr = new DialogResult();
        //    dr = MessageBox.Show("Xuất tất cả các thẻ hiện có trong danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (dr == DialogResult.Yes)
        //    {

        //        DataTable dt = bll_hv.loadInfoHocVien_PrintAll();
        //        int rows=dt.Rows.Count;
        //        for(int i = 0; i < rows; ++i)
        //        {
        //            try
        //            {
        //                lblPhapDanh.Text = dt.Rows[i][0].ToString();
        //                lblTheDanh.Text = dt.Rows[i][1].ToString();
        //                lblNgaySinh.Text = dt.Rows[i][2].ToString();
        //                lblVitri.Text = dt.Rows[i][3].ToString();
        //                lblCaNiemPhat.Text = dt.Rows[i][4].ToString();
        //                stt_ = dt.Rows[i][5].ToString();
        //                createBarcode(stt_);
        //                fileName = "D://The Chua Van Duc/" + stt_ + ".jpg";
        //                if (File.Exists(fileName))
        //                {
        //                    File.Delete(fileName);
        //                }
        //                ControlToBitmap(panel1, fileName);
        //            }
        //            catch(Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //            }
                    
        //        }
        //    }
        //}

        private void txtSTT_TextChanged(object sender, EventArgs e)
        {
            if (!btnKiemTra.Enabled && !txtSTT.Text.Equals(""))
            {
                btnKiemTra.Enabled = true;
            }
            else
            {
                if (txtSTT.Text.Equals(""))
                {
                    btnKiemTra.Enabled = false;
                    btnXuatAnh.Enabled = false;
                    btnXuatAnhCu.Enabled = false;
                }
                    
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InThe__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(btnKiemTra.Enabled)
                btnKiemTra.PerformClick();
            }
            if (e.KeyCode == Keys.F1)
            {
                if(btnKiemTra.Enabled)
                    btnKiemTra.PerformClick();
            }
            if (e.KeyCode ==Keys.P)
            {
                if(btnXuatAnh.Enabled)
                    btnXuatAnh.PerformClick();
            }
        }

        private void txtSTT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btnKiemTra.Enabled)
                    btnKiemTra.PerformClick();
            }
            if (e.KeyCode == Keys.Back)
            {
                txtSTT.Text = "";
            }
            if (e.KeyCode == Keys.P)
            {
                if (btnXuatAnh.Enabled)
                    btnXuatAnh.PerformClick();
            }
        }

        private void btnXuatAll_Click(object sender, EventArgs e)
        {
            string fileName;
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Xuất tất cả các thẻ hiện có trong danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                DataTable dt = new DataTable();
                dt=bll_hv.loadInfoHocVien_PrintAll();
                int rows = dt.Rows.Count;
                int count_ = 0;
                //MessageBox.Show(rows.ToString());
                for (int i = 0; i < rows; i+=1)
                {
                    try
                    {
                        if (pictureBox1.Image != null)
                        {
                            pictureBox1.Image.Dispose();
                            pictureBox1.Image = null;
                        }
                        if (picResult.Image != null)
                        {
                            picResult.Image.Dispose();
                            picResult.Image = null;
                        }
                        lblPhapDanh.Text = dt.Rows[i][0].ToString();
                        lblTheDanh.Text = dt.Rows[i][1].ToString();
                        lblNgaySinh.Text = dt.Rows[i][2].ToString();
                        lblVitri.Text = dt.Rows[i][3].ToString();
                        lblCaNiemPhat.Text = dt.Rows[i][4].ToString();
                        stt_ = dt.Rows[i][5].ToString();
                        createBarcode(stt_);
                        //MessageBox.Show(stt_);
                        fileName = "D://The Chua Van Duc/" + stt_ + ".ico";
                        if (File.Exists(fileName))
                        {
                            File.Delete(fileName);
                        }
                        ControlToBitmap(panel1, fileName);
                        count_++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (count_ == rows)
                {
                    MessageBox.Show("In tất cả các thẻ thành công! Vui lòng kiểm tra file theo đường dấn (D://The Chua Van Duc)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("In không thành công! Vui lòng kiểm tra file theo đường dấn (D://The Chua Van Duc) và thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXuatAnhCu_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("D://The Chua Van Duc/The Cu"))
            {
                Directory.CreateDirectory("D://The Chua Van Duc/The Cu");
            }
            string fileName = "D://The Chua Van Duc/The Cu/" + txtSTT.Text + ".ico";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            ControlToBitmap(panel2, fileName);
            MessageBox.Show("Xuất file thành công! Vui lòng kiểm tra theo đường dẫn D:/The Chua Van Duc/The Cu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnXuatAnh.Enabled = false;
            btnXuatAnhCu.Enabled = false;
            txtSTT.Text = "";
        }
    }
}

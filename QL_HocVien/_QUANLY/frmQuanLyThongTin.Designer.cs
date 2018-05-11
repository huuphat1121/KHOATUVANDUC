namespace QL_HocVien._QUANLY
{
    partial class frmQuanLyThongTin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCMND = new System.Windows.Forms.Button();
            this.btnSTT = new System.Windows.Forms.Button();
            this.btnPhapDanh = new System.Windows.Forms.Button();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhapdanh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHocVien = new System.Windows.Forms.DataGridView();
            this.hocvien_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phapdanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thedanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoithan_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocvien_diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khu_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caniemphat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnQuayLai);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnCMND);
            this.groupBox1.Controls.Add(this.btnSTT);
            this.groupBox1.Controls.Add(this.btnPhapDanh);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSTT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPhapdanh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 119);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.AutoSize = true;
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(318, 87);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 26);
            this.btnQuayLai.TabIndex = 9;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(215, 87);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 26);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(114, 87);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 26);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(9, 87);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 26);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCMND
            // 
            this.btnCMND.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCMND.Location = new System.Drawing.Point(195, 54);
            this.btnCMND.Name = "btnCMND";
            this.btnCMND.Size = new System.Drawing.Size(58, 23);
            this.btnCMND.TabIndex = 5;
            this.btnCMND.Text = "Lọc";
            this.btnCMND.UseVisualStyleBackColor = true;
            this.btnCMND.Click += new System.EventHandler(this.btnCMND_Click);
            // 
            // btnSTT
            // 
            this.btnSTT.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTT.Location = new System.Drawing.Point(195, 22);
            this.btnSTT.Name = "btnSTT";
            this.btnSTT.Size = new System.Drawing.Size(58, 23);
            this.btnSTT.TabIndex = 1;
            this.btnSTT.Text = "Lọc";
            this.btnSTT.UseVisualStyleBackColor = true;
            this.btnSTT.Click += new System.EventHandler(this.btnSTT_Click);
            // 
            // btnPhapDanh
            // 
            this.btnPhapDanh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhapDanh.Location = new System.Drawing.Point(472, 22);
            this.btnPhapDanh.Name = "btnPhapDanh";
            this.btnPhapDanh.Size = new System.Drawing.Size(58, 23);
            this.btnPhapDanh.TabIndex = 3;
            this.btnPhapDanh.Text = "Lọc";
            this.btnPhapDanh.UseVisualStyleBackColor = true;
            this.btnPhapDanh.Click += new System.EventHandler(this.btnPhapDanh_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(89, 54);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(100, 23);
            this.txtCMND.TabIndex = 4;
            this.txtCMND.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCMND_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "CMND:";
            // 
            // txtSTT
            // 
            this.txtSTT.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTT.Location = new System.Drawing.Point(89, 22);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(100, 23);
            this.txtSTT.TabIndex = 0;
            this.txtSTT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSTT_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "STT:";
            // 
            // txtPhapdanh
            // 
            this.txtPhapdanh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhapdanh.Location = new System.Drawing.Point(366, 22);
            this.txtPhapdanh.Name = "txtPhapdanh";
            this.txtPhapdanh.Size = new System.Drawing.Size(100, 23);
            this.txtPhapdanh.TabIndex = 2;
            this.txtPhapdanh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhapdanh_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pháp danh:";
            // 
            // dgvHocVien
            // 
            this.dgvHocVien.AllowUserToAddRows = false;
            this.dgvHocVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHocVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHocVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHocVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hocvien_id,
            this.phapdanh,
            this.thedanh,
            this.phone,
            this.nguoithan_phone,
            this.cmnd,
            this.cmnd_note,
            this.hocvien_diachi,
            this.namsinh,
            this.khu_id,
            this.vitri,
            this.caniemphat,
            this.ngayden,
            this.ngayve,
            this.ghichu});
            this.dgvHocVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvHocVien.GridColor = System.Drawing.SystemColors.Control;
            this.dgvHocVien.Location = new System.Drawing.Point(12, 343);
            this.dgvHocVien.Name = "dgvHocVien";
            this.dgvHocVien.ReadOnly = true;
            this.dgvHocVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocVien.Size = new System.Drawing.Size(712, 257);
            this.dgvHocVien.TabIndex = 102;
            this.dgvHocVien.DoubleClick += new System.EventHandler(this.dgvHocVien_DoubleClick);
            // 
            // hocvien_id
            // 
            this.hocvien_id.DataPropertyName = "hocvien_id";
            this.hocvien_id.HeaderText = "STT";
            this.hocvien_id.Name = "hocvien_id";
            this.hocvien_id.ReadOnly = true;
            this.hocvien_id.Width = 53;
            // 
            // phapdanh
            // 
            this.phapdanh.DataPropertyName = "phapdanh";
            this.phapdanh.HeaderText = "Pháp danh";
            this.phapdanh.Name = "phapdanh";
            this.phapdanh.ReadOnly = true;
            this.phapdanh.Width = 78;
            // 
            // thedanh
            // 
            this.thedanh.DataPropertyName = "thedanh";
            this.thedanh.HeaderText = "Thế danh";
            this.thedanh.Name = "thedanh";
            this.thedanh.ReadOnly = true;
            this.thedanh.Width = 72;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Điện thoại";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 74;
            // 
            // nguoithan_phone
            // 
            this.nguoithan_phone.DataPropertyName = "nguoithan_phone";
            this.nguoithan_phone.HeaderText = "ĐT Người thân";
            this.nguoithan_phone.Name = "nguoithan_phone";
            this.nguoithan_phone.ReadOnly = true;
            this.nguoithan_phone.Width = 94;
            // 
            // cmnd
            // 
            this.cmnd.DataPropertyName = "cmnd";
            this.cmnd.HeaderText = "CMND";
            this.cmnd.Name = "cmnd";
            this.cmnd.ReadOnly = true;
            this.cmnd.Width = 64;
            // 
            // cmnd_note
            // 
            this.cmnd_note.DataPropertyName = "cmnd_note";
            this.cmnd_note.HeaderText = "Tình trạng CMND";
            this.cmnd_note.Name = "cmnd_note";
            this.cmnd_note.ReadOnly = true;
            this.cmnd_note.Width = 105;
            // 
            // hocvien_diachi
            // 
            this.hocvien_diachi.DataPropertyName = "hocvien_diachi";
            this.hocvien_diachi.HeaderText = "Địa chỉ";
            this.hocvien_diachi.Name = "hocvien_diachi";
            this.hocvien_diachi.ReadOnly = true;
            this.hocvien_diachi.Width = 48;
            // 
            // namsinh
            // 
            this.namsinh.DataPropertyName = "namsinh";
            this.namsinh.HeaderText = "Năm sinh";
            this.namsinh.Name = "namsinh";
            this.namsinh.ReadOnly = true;
            this.namsinh.Width = 70;
            // 
            // khu_id
            // 
            this.khu_id.DataPropertyName = "khu_id";
            this.khu_id.HeaderText = "Khu";
            this.khu_id.Name = "khu_id";
            this.khu_id.ReadOnly = true;
            this.khu_id.Width = 51;
            // 
            // vitri
            // 
            this.vitri.DataPropertyName = "vitri";
            this.vitri.HeaderText = "Vị trí";
            this.vitri.Name = "vitri";
            this.vitri.ReadOnly = true;
            this.vitri.Width = 42;
            // 
            // caniemphat
            // 
            this.caniemphat.DataPropertyName = "caniemphat";
            this.caniemphat.HeaderText = "Ca niệm Phật";
            this.caniemphat.Name = "caniemphat";
            this.caniemphat.ReadOnly = true;
            this.caniemphat.Width = 87;
            // 
            // ngayden
            // 
            this.ngayden.DataPropertyName = "ngayden";
            this.ngayden.HeaderText = "Ngày đến";
            this.ngayden.Name = "ngayden";
            this.ngayden.ReadOnly = true;
            this.ngayden.ToolTipText = "Ngày học viên bắt đầu khóa tu";
            this.ngayden.Width = 73;
            // 
            // ngayve
            // 
            this.ngayve.DataPropertyName = "ngayve";
            this.ngayve.HeaderText = "Ngày về";
            this.ngayve.Name = "ngayve";
            this.ngayve.ReadOnly = true;
            this.ngayve.ToolTipText = "Ngày học viên rời khỏi khóa tu, có thể rời trước khi khóa tu kết thúc";
            this.ngayve.Width = 67;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.Name = "ghichu";
            this.ghichu.ReadOnly = true;
            this.ghichu.Width = 64;
            // 
            // frmQuanLyThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 612);
            this.Controls.Add(this.dgvHocVien);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLyThongTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thông Tin Học Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvHocVien, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHocVien;
        private System.Windows.Forms.TextBox txtPhapdanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnPhapDanh;
        private System.Windows.Forms.Button btnCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocvien_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn phapdanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn thedanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoithan_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd_note;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocvien_diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn namsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn khu_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitri;
        private System.Windows.Forms.DataGridViewTextBoxColumn caniemphat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayve;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.Button btnSTT;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Label label2;
    }
}
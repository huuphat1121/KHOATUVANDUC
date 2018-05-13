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
            this.btnTheDanh = new System.Windows.Forms.Button();
            this.btnPhapDanh = new System.Windows.Forms.Button();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTheDanh = new System.Windows.Forms.TextBox();
            this.txtPhapdanh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHocVien = new System.Windows.Forms.DataGridView();
            this.hocvien_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phapdanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thedanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoithan_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocvien_diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khu_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caniemphat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.Controls.Add(this.btnTheDanh);
            this.groupBox1.Controls.Add(this.btnPhapDanh);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSTT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTheDanh);
            this.groupBox1.Controls.Add(this.txtPhapdanh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 256);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(949, 146);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.AutoSize = true;
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(424, 107);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(107, 36);
            this.btnQuayLai.TabIndex = 9;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(287, 107);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 36);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(152, 107);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 36);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(12, 107);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 36);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCMND
            // 
            this.btnCMND.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCMND.Location = new System.Drawing.Point(260, 66);
            this.btnCMND.Margin = new System.Windows.Forms.Padding(4);
            this.btnCMND.Name = "btnCMND";
            this.btnCMND.Size = new System.Drawing.Size(77, 28);
            this.btnCMND.TabIndex = 5;
            this.btnCMND.Text = "Lọc";
            this.btnCMND.UseVisualStyleBackColor = true;
            this.btnCMND.Click += new System.EventHandler(this.btnCMND_Click);
            // 
            // btnSTT
            // 
            this.btnSTT.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTT.Location = new System.Drawing.Point(260, 27);
            this.btnSTT.Margin = new System.Windows.Forms.Padding(4);
            this.btnSTT.Name = "btnSTT";
            this.btnSTT.Size = new System.Drawing.Size(77, 28);
            this.btnSTT.TabIndex = 1;
            this.btnSTT.Text = "Lọc";
            this.btnSTT.UseVisualStyleBackColor = true;
            this.btnSTT.Click += new System.EventHandler(this.btnSTT_Click);
            // 
            // btnTheDanh
            // 
            this.btnTheDanh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheDanh.Location = new System.Drawing.Point(629, 66);
            this.btnTheDanh.Margin = new System.Windows.Forms.Padding(4);
            this.btnTheDanh.Name = "btnTheDanh";
            this.btnTheDanh.Size = new System.Drawing.Size(77, 28);
            this.btnTheDanh.TabIndex = 3;
            this.btnTheDanh.Text = "Lọc";
            this.btnTheDanh.UseVisualStyleBackColor = true;
            this.btnTheDanh.Click += new System.EventHandler(this.btnTheDanh_Click);
            // 
            // btnPhapDanh
            // 
            this.btnPhapDanh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhapDanh.Location = new System.Drawing.Point(629, 27);
            this.btnPhapDanh.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhapDanh.Name = "btnPhapDanh";
            this.btnPhapDanh.Size = new System.Drawing.Size(77, 28);
            this.btnPhapDanh.TabIndex = 3;
            this.btnPhapDanh.Text = "Lọc";
            this.btnPhapDanh.UseVisualStyleBackColor = true;
            this.btnPhapDanh.Click += new System.EventHandler(this.btnPhapDanh_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(119, 66);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(132, 27);
            this.txtCMND.TabIndex = 4;
            this.txtCMND.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCMND_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "CMND:";
            // 
            // txtSTT
            // 
            this.txtSTT.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTT.Location = new System.Drawing.Point(119, 27);
            this.txtSTT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(132, 27);
            this.txtSTT.TabIndex = 0;
            this.txtSTT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSTT_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "STT:";
            // 
            // txtTheDanh
            // 
            this.txtTheDanh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheDanh.Location = new System.Drawing.Point(488, 66);
            this.txtTheDanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTheDanh.Name = "txtTheDanh";
            this.txtTheDanh.Size = new System.Drawing.Size(132, 27);
            this.txtTheDanh.TabIndex = 2;
            this.txtTheDanh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTheDanh_KeyDown);
            // 
            // txtPhapdanh
            // 
            this.txtPhapdanh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhapdanh.Location = new System.Drawing.Point(488, 27);
            this.txtPhapdanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhapdanh.Name = "txtPhapdanh";
            this.txtPhapdanh.Size = new System.Drawing.Size(132, 27);
            this.txtPhapdanh.TabIndex = 2;
            this.txtPhapdanh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhapdanh_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thế danh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
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
            this.namsinh,
            this.phone,
            this.nguoithan_phone,
            this.cmnd,
            this.cmnd_note,
            this.hocvien_diachi,
            this.khu_id,
            this.vitri,
            this.caniemphat,
            this.ngayden,
            this.ngayve,
            this.ghichu,
            this.thoigian});
            this.dgvHocVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvHocVien.GridColor = System.Drawing.SystemColors.Control;
            this.dgvHocVien.Location = new System.Drawing.Point(16, 422);
            this.dgvHocVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHocVien.MultiSelect = false;
            this.dgvHocVien.Name = "dgvHocVien";
            this.dgvHocVien.ReadOnly = true;
            this.dgvHocVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocVien.Size = new System.Drawing.Size(949, 316);
            this.dgvHocVien.TabIndex = 102;
            this.dgvHocVien.DoubleClick += new System.EventHandler(this.dgvHocVien_DoubleClick);
            // 
            // hocvien_id
            // 
            this.hocvien_id.DataPropertyName = "hocvien_id";
            this.hocvien_id.HeaderText = "STT";
            this.hocvien_id.Name = "hocvien_id";
            this.hocvien_id.ReadOnly = true;
            this.hocvien_id.Width = 64;
            // 
            // phapdanh
            // 
            this.phapdanh.DataPropertyName = "phapdanh";
            this.phapdanh.HeaderText = "Pháp danh";
            this.phapdanh.Name = "phapdanh";
            this.phapdanh.ReadOnly = true;
            this.phapdanh.Width = 106;
            // 
            // thedanh
            // 
            this.thedanh.DataPropertyName = "thedanh";
            this.thedanh.HeaderText = "Thế danh";
            this.thedanh.Name = "thedanh";
            this.thedanh.ReadOnly = true;
            this.thedanh.Width = 98;
            // 
            // namsinh
            // 
            this.namsinh.DataPropertyName = "namsinh";
            this.namsinh.HeaderText = "Năm sinh";
            this.namsinh.Name = "namsinh";
            this.namsinh.ReadOnly = true;
            this.namsinh.Width = 96;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Điện thoại";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 101;
            // 
            // nguoithan_phone
            // 
            this.nguoithan_phone.DataPropertyName = "nguoithan_phone";
            this.nguoithan_phone.HeaderText = "ĐT Người thân";
            this.nguoithan_phone.Name = "nguoithan_phone";
            this.nguoithan_phone.ReadOnly = true;
            this.nguoithan_phone.Width = 129;
            // 
            // cmnd
            // 
            this.cmnd.DataPropertyName = "cmnd";
            this.cmnd.HeaderText = "CMND";
            this.cmnd.Name = "cmnd";
            this.cmnd.ReadOnly = true;
            this.cmnd.Width = 77;
            // 
            // cmnd_note
            // 
            this.cmnd_note.DataPropertyName = "cmnd_note";
            this.cmnd_note.HeaderText = "Tình trạng CMND";
            this.cmnd_note.Name = "cmnd_note";
            this.cmnd_note.ReadOnly = true;
            this.cmnd_note.Width = 134;
            // 
            // hocvien_diachi
            // 
            this.hocvien_diachi.DataPropertyName = "hocvien_diachi";
            this.hocvien_diachi.HeaderText = "Địa chỉ";
            this.hocvien_diachi.Name = "hocvien_diachi";
            this.hocvien_diachi.ReadOnly = true;
            this.hocvien_diachi.Width = 58;
            // 
            // khu_id
            // 
            this.khu_id.DataPropertyName = "khu_id";
            this.khu_id.HeaderText = "Khu";
            this.khu_id.Name = "khu_id";
            this.khu_id.ReadOnly = true;
            this.khu_id.Width = 62;
            // 
            // vitri
            // 
            this.vitri.DataPropertyName = "vitri";
            this.vitri.HeaderText = "Vị trí";
            this.vitri.Name = "vitri";
            this.vitri.ReadOnly = true;
            this.vitri.Width = 50;
            // 
            // caniemphat
            // 
            this.caniemphat.DataPropertyName = "caniemphat";
            this.caniemphat.HeaderText = "Ca niệm Phật";
            this.caniemphat.Name = "caniemphat";
            this.caniemphat.ReadOnly = true;
            this.caniemphat.Width = 111;
            // 
            // ngayden
            // 
            this.ngayden.DataPropertyName = "ngayden";
            this.ngayden.HeaderText = "Ngày đến";
            this.ngayden.Name = "ngayden";
            this.ngayden.ReadOnly = true;
            this.ngayden.ToolTipText = "Ngày Phật Tử bắt đầu khóa tu";
            this.ngayden.Width = 91;
            // 
            // ngayve
            // 
            this.ngayve.DataPropertyName = "ngayve";
            this.ngayve.HeaderText = "Ngày về";
            this.ngayve.Name = "ngayve";
            this.ngayve.ReadOnly = true;
            this.ngayve.ToolTipText = "Ngày Phật Tử rời khỏi khóa tu, có thể rời trước khi khóa tu kết thúc";
            this.ngayve.Width = 82;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.Name = "ghichu";
            this.ghichu.ReadOnly = true;
            this.ghichu.Width = 80;
            // 
            // thoigian
            // 
            this.thoigian.DataPropertyName = "thoigian";
            this.thoigian.HeaderText = "Thời Gian";
            this.thoigian.Name = "thoigian";
            this.thoigian.ReadOnly = true;
            this.thoigian.Visible = false;
            this.thoigian.Width = 91;
            // 
            // frmQuanLyThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 753);
            this.Controls.Add(this.dgvHocVien);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmQuanLyThongTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thông Tin Phật Tử";
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
        private System.Windows.Forms.Button btnSTT;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTheDanh;
        private System.Windows.Forms.TextBox txtTheDanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocvien_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn phapdanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn thedanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn namsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoithan_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd_note;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocvien_diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn khu_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitri;
        private System.Windows.Forms.DataGridViewTextBoxColumn caniemphat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayve;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigian;
    }
}
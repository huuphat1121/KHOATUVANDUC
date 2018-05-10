namespace QL_HocVien._SYSTEM
{
    partial class frmXemThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemThongTin));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXemTatCa = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.cbbKhu = new System.Windows.Forms.ComboBox();
            this.cbbCaNiem = new System.Windows.Forms.ComboBox();
            this.btnCMND = new System.Windows.Forms.Button();
            this.btnThedanh = new System.Windows.Forms.Button();
            this.btnNgayDi = new System.Windows.Forms.Button();
            this.btnNgayDen = new System.Windows.Forms.Button();
            this.btnKhu = new System.Windows.Forms.Button();
            this.btnCaNiem = new System.Windows.Forms.Button();
            this.btnPhapdanh = new System.Windows.Forms.Button();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtThedanh = new System.Windows.Forms.TextBox();
            this.txtPhapdanh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHocVien
            // 
            this.dgvHocVien.AllowUserToAddRows = false;
            this.dgvHocVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHocVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgvHocVien.Location = new System.Drawing.Point(16, 444);
            this.dgvHocVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHocVien.Name = "dgvHocVien";
            this.dgvHocVien.ReadOnly = true;
            this.dgvHocVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocVien.Size = new System.Drawing.Size(813, 183);
            this.dgvHocVien.TabIndex = 101;
            // 
            // hocvien_id
            // 
            this.hocvien_id.DataPropertyName = "hocvien_id";
            this.hocvien_id.HeaderText = "STT";
            this.hocvien_id.Name = "hocvien_id";
            this.hocvien_id.ReadOnly = true;
            // 
            // phapdanh
            // 
            this.phapdanh.DataPropertyName = "phapdanh";
            this.phapdanh.HeaderText = "Pháp danh";
            this.phapdanh.Name = "phapdanh";
            this.phapdanh.ReadOnly = true;
            // 
            // thedanh
            // 
            this.thedanh.DataPropertyName = "thedanh";
            this.thedanh.HeaderText = "Thế danh";
            this.thedanh.Name = "thedanh";
            this.thedanh.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Điện thoại";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // nguoithan_phone
            // 
            this.nguoithan_phone.DataPropertyName = "nguoithan_phone";
            this.nguoithan_phone.HeaderText = "ĐT Người thân";
            this.nguoithan_phone.Name = "nguoithan_phone";
            this.nguoithan_phone.ReadOnly = true;
            // 
            // cmnd
            // 
            this.cmnd.DataPropertyName = "cmnd";
            this.cmnd.HeaderText = "CMND";
            this.cmnd.Name = "cmnd";
            this.cmnd.ReadOnly = true;
            // 
            // cmnd_note
            // 
            this.cmnd_note.DataPropertyName = "cmnd_note";
            this.cmnd_note.HeaderText = "Tình trạng CMND";
            this.cmnd_note.Name = "cmnd_note";
            this.cmnd_note.ReadOnly = true;
            // 
            // hocvien_diachi
            // 
            this.hocvien_diachi.DataPropertyName = "hocvien_diachi";
            this.hocvien_diachi.HeaderText = "Địa chỉ";
            this.hocvien_diachi.Name = "hocvien_diachi";
            this.hocvien_diachi.ReadOnly = true;
            // 
            // namsinh
            // 
            this.namsinh.DataPropertyName = "namsinh";
            this.namsinh.HeaderText = "Năm sinh";
            this.namsinh.Name = "namsinh";
            this.namsinh.ReadOnly = true;
            // 
            // khu_id
            // 
            this.khu_id.DataPropertyName = "khu_id";
            this.khu_id.HeaderText = "Khu";
            this.khu_id.Name = "khu_id";
            this.khu_id.ReadOnly = true;
            // 
            // vitri
            // 
            this.vitri.DataPropertyName = "vitri";
            this.vitri.HeaderText = "Vị trí";
            this.vitri.Name = "vitri";
            this.vitri.ReadOnly = true;
            // 
            // caniemphat
            // 
            this.caniemphat.DataPropertyName = "caniemphat";
            this.caniemphat.HeaderText = "Ca niệm Phật";
            this.caniemphat.Name = "caniemphat";
            this.caniemphat.ReadOnly = true;
            // 
            // ngayden
            // 
            this.ngayden.DataPropertyName = "ngayden";
            this.ngayden.HeaderText = "Ngày đến";
            this.ngayden.Name = "ngayden";
            this.ngayden.ReadOnly = true;
            // 
            // ngayve
            // 
            this.ngayve.DataPropertyName = "ngayve";
            this.ngayve.HeaderText = "Ngày về";
            this.ngayve.Name = "ngayve";
            this.ngayve.ReadOnly = true;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.Name = "ghichu";
            this.ghichu.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnXemTatCa);
            this.groupBox1.Controls.Add(this.btnXuatExcel);
            this.groupBox1.Controls.Add(this.btnQuayLai);
            this.groupBox1.Controls.Add(this.cbbKhu);
            this.groupBox1.Controls.Add(this.cbbCaNiem);
            this.groupBox1.Controls.Add(this.btnCMND);
            this.groupBox1.Controls.Add(this.btnThedanh);
            this.groupBox1.Controls.Add(this.btnNgayDi);
            this.groupBox1.Controls.Add(this.btnNgayDen);
            this.groupBox1.Controls.Add(this.btnKhu);
            this.groupBox1.Controls.Add(this.btnCaNiem);
            this.groupBox1.Controls.Add(this.btnPhapdanh);
            this.groupBox1.Controls.Add(this.dtpNgayDi);
            this.groupBox1.Controls.Add(this.dtpNgayDen);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtThedanh);
            this.groupBox1.Controls.Add(this.txtPhapdanh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 252);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(813, 185);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu";
            // 
            // btnXemTatCa
            // 
            this.btnXemTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemTatCa.AutoSize = true;
            this.btnXemTatCa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTatCa.Location = new System.Drawing.Point(401, 139);
            this.btnXemTatCa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXemTatCa.Name = "btnXemTatCa";
            this.btnXemTatCa.Size = new System.Drawing.Size(123, 36);
            this.btnXemTatCa.TabIndex = 5;
            this.btnXemTatCa.Text = "Xem tất cả";
            this.btnXemTatCa.UseVisualStyleBackColor = true;
            this.btnXemTatCa.Click += new System.EventHandler(this.btnXemTatCa_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatExcel.AutoSize = true;
            this.btnXuatExcel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Location = new System.Drawing.Point(551, 139);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(125, 36);
            this.btnXuatExcel.TabIndex = 5;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuayLai.AutoSize = true;
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(705, 139);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(100, 36);
            this.btnQuayLai.TabIndex = 5;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // cbbKhu
            // 
            this.cbbKhu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbKhu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbKhu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhu.FormattingEnabled = true;
            this.cbbKhu.Location = new System.Drawing.Point(133, 139);
            this.cbbKhu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbKhu.Name = "cbbKhu";
            this.cbbKhu.Size = new System.Drawing.Size(132, 27);
            this.cbbKhu.Sorted = true;
            this.cbbKhu.TabIndex = 4;
            this.cbbKhu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbKhu_KeyDown);
            // 
            // cbbCaNiem
            // 
            this.cbbCaNiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbCaNiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCaNiem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCaNiem.FormattingEnabled = true;
            this.cbbCaNiem.Location = new System.Drawing.Point(485, 31);
            this.cbbCaNiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbCaNiem.Name = "cbbCaNiem";
            this.cbbCaNiem.Size = new System.Drawing.Size(132, 27);
            this.cbbCaNiem.Sorted = true;
            this.cbbCaNiem.TabIndex = 4;
            this.cbbCaNiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbCaNiem_KeyDown);
            // 
            // btnCMND
            // 
            this.btnCMND.AutoSize = true;
            this.btnCMND.Image = ((System.Drawing.Image)(resources.GetObject("btnCMND.Image")));
            this.btnCMND.Location = new System.Drawing.Point(275, 102);
            this.btnCMND.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCMND.Name = "btnCMND";
            this.btnCMND.Size = new System.Drawing.Size(35, 28);
            this.btnCMND.TabIndex = 3;
            this.btnCMND.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCMND.UseVisualStyleBackColor = true;
            this.btnCMND.Click += new System.EventHandler(this.btnCMND_Click);
            // 
            // btnThedanh
            // 
            this.btnThedanh.AutoSize = true;
            this.btnThedanh.Image = ((System.Drawing.Image)(resources.GetObject("btnThedanh.Image")));
            this.btnThedanh.Location = new System.Drawing.Point(275, 65);
            this.btnThedanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThedanh.Name = "btnThedanh";
            this.btnThedanh.Size = new System.Drawing.Size(35, 28);
            this.btnThedanh.TabIndex = 3;
            this.btnThedanh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThedanh.UseVisualStyleBackColor = true;
            this.btnThedanh.Click += new System.EventHandler(this.btnThedanh_Click);
            // 
            // btnNgayDi
            // 
            this.btnNgayDi.AutoSize = true;
            this.btnNgayDi.Image = ((System.Drawing.Image)(resources.GetObject("btnNgayDi.Image")));
            this.btnNgayDi.Location = new System.Drawing.Point(685, 101);
            this.btnNgayDi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNgayDi.Name = "btnNgayDi";
            this.btnNgayDi.Size = new System.Drawing.Size(35, 28);
            this.btnNgayDi.TabIndex = 3;
            this.btnNgayDi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNgayDi.UseVisualStyleBackColor = true;
            this.btnNgayDi.Click += new System.EventHandler(this.btnNgayDi_Click);
            // 
            // btnNgayDen
            // 
            this.btnNgayDen.AutoSize = true;
            this.btnNgayDen.Image = ((System.Drawing.Image)(resources.GetObject("btnNgayDen.Image")));
            this.btnNgayDen.Location = new System.Drawing.Point(685, 64);
            this.btnNgayDen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNgayDen.Name = "btnNgayDen";
            this.btnNgayDen.Size = new System.Drawing.Size(35, 28);
            this.btnNgayDen.TabIndex = 3;
            this.btnNgayDen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNgayDen.UseVisualStyleBackColor = true;
            this.btnNgayDen.Click += new System.EventHandler(this.btnNgayDen_Click);
            // 
            // btnKhu
            // 
            this.btnKhu.AutoSize = true;
            this.btnKhu.Image = ((System.Drawing.Image)(resources.GetObject("btnKhu.Image")));
            this.btnKhu.Location = new System.Drawing.Point(275, 138);
            this.btnKhu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKhu.Name = "btnKhu";
            this.btnKhu.Size = new System.Drawing.Size(35, 28);
            this.btnKhu.TabIndex = 3;
            this.btnKhu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKhu.UseVisualStyleBackColor = true;
            this.btnKhu.Click += new System.EventHandler(this.btnKhu_Click);
            // 
            // btnCaNiem
            // 
            this.btnCaNiem.AutoSize = true;
            this.btnCaNiem.Image = ((System.Drawing.Image)(resources.GetObject("btnCaNiem.Image")));
            this.btnCaNiem.Location = new System.Drawing.Point(627, 32);
            this.btnCaNiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCaNiem.Name = "btnCaNiem";
            this.btnCaNiem.Size = new System.Drawing.Size(35, 28);
            this.btnCaNiem.TabIndex = 3;
            this.btnCaNiem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCaNiem.UseVisualStyleBackColor = true;
            this.btnCaNiem.Click += new System.EventHandler(this.btnCaNiem_Click);
            // 
            // btnPhapdanh
            // 
            this.btnPhapdanh.AutoSize = true;
            this.btnPhapdanh.Image = ((System.Drawing.Image)(resources.GetObject("btnPhapdanh.Image")));
            this.btnPhapdanh.Location = new System.Drawing.Point(275, 31);
            this.btnPhapdanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPhapdanh.Name = "btnPhapdanh";
            this.btnPhapdanh.Size = new System.Drawing.Size(35, 28);
            this.btnPhapdanh.TabIndex = 3;
            this.btnPhapdanh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPhapdanh.UseVisualStyleBackColor = true;
            this.btnPhapdanh.Click += new System.EventHandler(this.btnPhapdanh_Click);
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDi.Location = new System.Drawing.Point(485, 102);
            this.dtpNgayDi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(191, 27);
            this.dtpNgayDi.TabIndex = 2;
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDen.Location = new System.Drawing.Point(485, 65);
            this.dtpNgayDen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(191, 27);
            this.dtpNgayDen.TabIndex = 2;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(133, 102);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(132, 27);
            this.txtCMND.TabIndex = 1;
            this.txtCMND.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCMND_KeyDown);
            // 
            // txtThedanh
            // 
            this.txtThedanh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThedanh.Location = new System.Drawing.Point(133, 65);
            this.txtThedanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtThedanh.Name = "txtThedanh";
            this.txtThedanh.Size = new System.Drawing.Size(132, 27);
            this.txtThedanh.TabIndex = 1;
            this.txtThedanh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtThedanh_KeyDown);
            // 
            // txtPhapdanh
            // 
            this.txtPhapdanh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhapdanh.Location = new System.Drawing.Point(133, 31);
            this.txtPhapdanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhapdanh.Name = "txtPhapdanh";
            this.txtPhapdanh.Size = new System.Drawing.Size(132, 27);
            this.txtPhapdanh.TabIndex = 1;
            this.txtPhapdanh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhapdanh_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày về:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày đến:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Khu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "CMND:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ca niệm phật:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thế danh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pháp danh:";
            // 
            // frmXemThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 642);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHocVien);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmXemThongTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Thông Tin Học Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.dgvHocVien, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHocVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPhapdanh;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtThedanh;
        private System.Windows.Forms.TextBox txtPhapdanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCMND;
        private System.Windows.Forms.Button btnThedanh;
        private System.Windows.Forms.Button btnCaNiem;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.ComboBox cbbKhu;
        private System.Windows.Forms.ComboBox cbbCaNiem;
        private System.Windows.Forms.Button btnKhu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNgayDi;
        private System.Windows.Forms.Button btnNgayDen;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnXemTatCa;
    }
}
namespace QL_HocVien._QUANLY
{
    partial class frmQLCaNiemPhat
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
            this.dgvCaNiemPhat = new System.Windows.Forms.DataGridView();
            this.ca_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_nguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ca_niem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCaNiemPhat = new System.Windows.Forms.TextBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaNiemPhat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCaNiemPhat
            // 
            this.dgvCaNiemPhat.AllowUserToAddRows = false;
            this.dgvCaNiemPhat.AllowUserToDeleteRows = false;
            this.dgvCaNiemPhat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCaNiemPhat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaNiemPhat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCaNiemPhat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCaNiemPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaNiemPhat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ca_id,
            this.so_nguoi,
            this.ca_niem});
            this.dgvCaNiemPhat.Location = new System.Drawing.Point(267, 217);
            this.dgvCaNiemPhat.Name = "dgvCaNiemPhat";
            this.dgvCaNiemPhat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaNiemPhat.Size = new System.Drawing.Size(245, 157);
            this.dgvCaNiemPhat.TabIndex = 104;
            this.dgvCaNiemPhat.DoubleClick += new System.EventHandler(this.dgvCaNiemPhat_DoubleClick);
            // 
            // ca_id
            // 
            this.ca_id.DataPropertyName = "ca_id";
            this.ca_id.HeaderText = "STT";
            this.ca_id.Name = "ca_id";
            this.ca_id.ReadOnly = true;
            // 
            // so_nguoi
            // 
            this.so_nguoi.DataPropertyName = "so_nguoi";
            this.so_nguoi.HeaderText = "Số Người";
            this.so_nguoi.Name = "so_nguoi";
            this.so_nguoi.ReadOnly = true;
            this.so_nguoi.Visible = false;
            // 
            // ca_niem
            // 
            this.ca_niem.DataPropertyName = "ca_niem";
            this.ca_niem.HeaderText = "Ca Niệm Phật";
            this.ca_niem.Name = "ca_niem";
            this.ca_niem.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtCaNiemPhat);
            this.groupBox1.Controls.Add(this.btnQuayLai);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 166);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // txtCaNiemPhat
            // 
            this.txtCaNiemPhat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaNiemPhat.Location = new System.Drawing.Point(111, 25);
            this.txtCaNiemPhat.Name = "txtCaNiemPhat";
            this.txtCaNiemPhat.Size = new System.Drawing.Size(111, 23);
            this.txtCaNiemPhat.TabIndex = 0;
            this.txtCaNiemPhat.TextChanged += new System.EventHandler(this.txtCaNiemPhat_TextChanged);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(167, 132);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 28);
            this.btnQuayLai.TabIndex = 3;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(86, 132);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 28);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(5, 132);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 28);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ca niệm phật:";
            // 
            // frmQLCaNiemPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 386);
            this.Controls.Add(this.dgvCaNiemPhat);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQLCaNiemPhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLCaNiemPhat";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvCaNiemPhat, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaNiemPhat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCaNiemPhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaNiemPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ca_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_nguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ca_niem;
    }
}
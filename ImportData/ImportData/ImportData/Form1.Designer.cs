namespace ImportData
{
    partial class Form1
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
            this.txtfilepath = new System.Windows.Forms.TextBox();
            this.btnBrown = new System.Windows.Forms.Button();
            this.btnVitri = new System.Windows.Forms.Button();
            this.btnHocVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtfilepath
            // 
            this.txtfilepath.Location = new System.Drawing.Point(12, 12);
            this.txtfilepath.Name = "txtfilepath";
            this.txtfilepath.Size = new System.Drawing.Size(281, 22);
            this.txtfilepath.TabIndex = 0;
            // 
            // btnBrown
            // 
            this.btnBrown.Location = new System.Drawing.Point(299, 12);
            this.btnBrown.Name = "btnBrown";
            this.btnBrown.Size = new System.Drawing.Size(92, 25);
            this.btnBrown.TabIndex = 1;
            this.btnBrown.Text = "Brown";
            this.btnBrown.UseVisualStyleBackColor = true;
            this.btnBrown.Click += new System.EventHandler(this.btnBrown_Click);
            // 
            // btnVitri
            // 
            this.btnVitri.Location = new System.Drawing.Point(12, 57);
            this.btnVitri.Name = "btnVitri";
            this.btnVitri.Size = new System.Drawing.Size(86, 47);
            this.btnVitri.TabIndex = 1;
            this.btnVitri.Text = "Import Vitri";
            this.btnVitri.UseVisualStyleBackColor = true;
            this.btnVitri.Click += new System.EventHandler(this.btnVitri_Click);
            // 
            // btnHocVien
            // 
            this.btnHocVien.Location = new System.Drawing.Point(141, 57);
            this.btnHocVien.Name = "btnHocVien";
            this.btnHocVien.Size = new System.Drawing.Size(146, 47);
            this.btnHocVien.TabIndex = 1;
            this.btnHocVien.Text = "Import Hocvien";
            this.btnHocVien.UseVisualStyleBackColor = true;
            this.btnHocVien.Click += new System.EventHandler(this.btnHocVien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 133);
            this.Controls.Add(this.btnHocVien);
            this.Controls.Add(this.btnVitri);
            this.Controls.Add(this.btnBrown);
            this.Controls.Add(this.txtfilepath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfilepath;
        private System.Windows.Forms.Button btnBrown;
        private System.Windows.Forms.Button btnVitri;
        private System.Windows.Forms.Button btnHocVien;
    }
}


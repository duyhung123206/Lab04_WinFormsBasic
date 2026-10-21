namespace Lab04_WinFormsBasic
{
    partial class FormDangKyHP
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
            this.checkedListBoxMonHoc = new System.Windows.Forms.CheckedListBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.lblTongTinChi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBoxMonHoc
            // 
            this.checkedListBoxMonHoc.FormattingEnabled = true;
            this.checkedListBoxMonHoc.Location = new System.Drawing.Point(114, 56);
            this.checkedListBoxMonHoc.Name = "checkedListBoxMonHoc";
            this.checkedListBoxMonHoc.Size = new System.Drawing.Size(380, 89);
            this.checkedListBoxMonHoc.TabIndex = 0;
            this.checkedListBoxMonHoc.Click += new System.EventHandler(this.FormDangKyHP_Load);
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(114, 180);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(120, 23);
            this.btnTinh.TabIndex = 1;
            this.btnTinh.Text = "Tính tổng tín chỉ";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lblTongTinChi
            // 
            this.lblTongTinChi.AutoSize = true;
            this.lblTongTinChi.Location = new System.Drawing.Point(114, 225);
            this.lblTongTinChi.Name = "lblTongTinChi";
            this.lblTongTinChi.Size = new System.Drawing.Size(44, 16);
            this.lblTongTinChi.TabIndex = 2;
            this.lblTongTinChi.Text = "label1";
            this.lblTongTinChi.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // FormDangKyHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTongTinChi);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.checkedListBoxMonHoc);
            this.Name = "FormDangKyHP";
            this.Text = "FormDangKyHP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxMonHoc;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label lblTongTinChi;
    }
}
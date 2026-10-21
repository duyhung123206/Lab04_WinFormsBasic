namespace Lab04_WinFormsBasic
{
    partial class FormBMI
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
            this.txtChieuCao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCanNang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTinhBMI = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblPhanLoai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtChieuCao
            // 
            this.txtChieuCao.Location = new System.Drawing.Point(99, 59);
            this.txtChieuCao.Name = "txtChieuCao";
            this.txtChieuCao.Size = new System.Drawing.Size(100, 22);
            this.txtChieuCao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chiều cao (cm)";
            // 
            // txtCanNang
            // 
            this.txtCanNang.Location = new System.Drawing.Point(99, 121);
            this.txtCanNang.Name = "txtCanNang";
            this.txtCanNang.Size = new System.Drawing.Size(100, 22);
            this.txtCanNang.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cân nặng(kg)";
            // 
            // btnTinhBMI
            // 
            this.btnTinhBMI.Location = new System.Drawing.Point(99, 190);
            this.btnTinhBMI.Name = "btnTinhBMI";
            this.btnTinhBMI.Size = new System.Drawing.Size(75, 23);
            this.btnTinhBMI.TabIndex = 4;
            this.btnTinhBMI.Text = "Tính BMI";
            this.btnTinhBMI.UseVisualStyleBackColor = true;
            this.btnTinhBMI.Click += new System.EventHandler(this.btnTinhBMI_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(99, 247);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(44, 16);
            this.lblKetQua.TabIndex = 5;
            this.lblKetQua.Text = "label3";
            this.lblKetQua.Click += new System.EventHandler(this.btnTinhBMI_Click);
            // 
            // lblPhanLoai
            // 
            this.lblPhanLoai.AutoSize = true;
            this.lblPhanLoai.Location = new System.Drawing.Point(99, 291);
            this.lblPhanLoai.Name = "lblPhanLoai";
            this.lblPhanLoai.Size = new System.Drawing.Size(44, 16);
            this.lblPhanLoai.TabIndex = 6;
            this.lblPhanLoai.Text = "label4";
            this.lblPhanLoai.Click += new System.EventHandler(this.btnTinhBMI_Click);
            // 
            // FormBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPhanLoai);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnTinhBMI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCanNang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChieuCao);
            this.Name = "FormBMI";
            this.Text = "FormBMI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChieuCao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCanNang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTinhBMI;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblPhanLoai;
    }
}
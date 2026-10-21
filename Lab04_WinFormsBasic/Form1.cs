using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_WinFormsBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Nạp danh sách khoa
            cboKhoa.Items.Clear();
            cboKhoa.Items.Add("Công nghệ thông tin");
            cboKhoa.Items.Add("Công nghệ kỹ thuật ô tô");
            cboKhoa.Items.Add("Kinh tế");

            // 2. Cấu hình kiểu hiển thị và chọn mục đầu tiên
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cboKhoa.Items.Count > 0)
            {
                cboKhoa.SelectedIndex = 0;
            }

            // 3. Đặt trạng thái mặc định cho giới tính (Nam)
            radNam.Checked = true;

            // 4. Tự động điền thông tin cá nhân
            txtMaSV.Text = "24001296";
            txtHoTen.Text = "Nguyễn Duy Hưng";
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string thongTin = string.Format(
                "Mã: {0}\nHọ tên: {1}\nNgày sinh: {2:dd/MM/yyyy}\nKhoa: {3}\nGiới tính: {4}",
                txtMaSV.Text, txtHoTen.Text, dtpNgaySinh.Value,
                cboKhoa.Text, gioiTinh);

            MessageBox.Show(thongTin, "Thông tin sinh viên");
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
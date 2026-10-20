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
            // Thêm sẵn dữ liệu mẫu cho ComboBox Khoa
            cboKhoa.Items.Add("Công nghệ Thông tin");
            cboKhoa.Items.Add("Quản trị Kinh doanh");
            cboKhoa.Items.Add("Kế toán - Tài chính");
            cboKhoa.SelectedIndex = 0; // Chọn sẵn mục đầu tiên

            // Tự động điền thông tin cá nhân
            txtMaSV.Text = "24001296";
            txtHoTen.Text = "Nguyễn Duy Hưng";
            radNam.Checked = true;
        
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            // Kiểm tra radNam phải là RadioButton (nút tròn lựa chọn giới tính)
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string thongTin = string.Format(
                "Mã: {0}\nHọ tên: {1}\nNgày sinh: {2:dd/MM/yyyy}\nKhoa: {3}\nGiới tính: {4}",
                txtMaSV.Text, txtHoTen.Text, dtpNgaySinh.Value,
                cboKhoa.Text, gioiTinh);

            MessageBox.Show(thongTin, "Thông tin sinh viên");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Hàm xử lý sự kiện click cho label (nếu có phát sinh từ giao diện thiết kế)
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
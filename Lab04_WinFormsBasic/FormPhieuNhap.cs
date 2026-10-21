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
    public partial class FormPhieuNhap : Form
    {
        // Biến lưu đường dẫn ảnh được chọn
        private string imagePath = "";

        public FormPhieuNhap()
        {
            InitializeComponent();
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            // Thêm một số loại sản phẩm mẫu vào ComboBox
            cmbLoai.Items.Add("Điện tử");
            cmbLoai.Items.Add("Gia dụng");
            cmbLoai.Items.Add("Thời trang");
            cmbLoai.Items.Add("Văn phòng phẩm");
        }

        // Sự kiện bấm nút chọn ảnh
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFile.FileName;
                picAnh.Image = Image.FromFile(imagePath);
            }
        }

        // Sự kiện bấm nút Lưu phiếu nhập
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMa.Text.Trim();
                string ten = txtTen.Text.Trim();
                string loai = cmbLoai.Text.Trim();
                int soLuong = int.Parse(txtSoLuong.Text);
                decimal donGia = decimal.Parse(txtDonGia.Text);
                string ngayNhap = dtpNgayNhap.Value.ToString("dd/MM/yyyy");

                // Kiểm tra dữ liệu cơ bản
                if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ mã và tên sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal thanhTien = soLuong * donGia;

                // Hiển thị thông báo tổng kết phiếu nhập
                string info = $"Lập phiếu nhập thành công!\n\n" +
                              $"- Mã SP: {ma}\n" +
                              $"- Tên SP: {ten}\n" +
                              $"- Loại: {loai}\n" +
                              $"- Số lượng: {soLuong}\n" +
                              $"- Đơn giá: {donGia:N0} VNĐ\n" +
                              $"- Thành tiền: {thanhTien:N0} VNĐ\n" +
                              $"- Ngày nhập: {ngayNhap}";

                MessageBox.Show(info, "Thông tin phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập định dạng số hợp lệ cho số lượng và đơn giá!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
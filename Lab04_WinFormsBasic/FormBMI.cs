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
    public partial class FormBMI : Form
    {
        public FormBMI()
        {
            InitializeComponent();
        }

        private void btnTinhBMI_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị chiều cao (cm) và cân nặng (kg) từ các ô TextBox
                double chieuCaoCm = double.Parse(txtChieuCao.Text);
                double canNang = double.Parse(txtCanNang.Text);

                // Chuyển đổi chiều cao từ cm sang mét (Ví dụ: 180 cm -> 1.8 m)
                double chieuCaoM = chieuCaoCm / 100.0;

                // Công thức tính BMI = Cân nặng / (Chiều cao (m) * Chiều cao (m))
                double bmi = canNang / (chieuCaoM * chieuCaoM);

                string phanLoai = "";

                // Phân loại mức độ gầy/béo theo tiêu chuẩn BMI
                if (bmi < 18.5)
                {
                    phanLoai = "Gầy";
                }
                else if (bmi < 25)
                {
                    phanLoai = "Bình thường";
                }
                else if (bmi < 30)
                {
                    phanLoai = "Thừa cân";
                }
                else
                {
                    phanLoai = "Béo phì";
                }

                // Hiển thị kết quả ra các Label
                lblKetQua.Text = "Chỉ số BMI: " + bmi.ToString("0.00");
                lblPhanLoai.Text = "Phân loại: " + phanLoai;
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho chiều cao và cân nặng!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
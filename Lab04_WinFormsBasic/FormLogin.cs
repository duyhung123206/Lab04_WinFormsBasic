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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            // Kiểm tra tài khoản đăng nhập mẫu
            if (user == "admin" && pass == "123456")
            {
                string msg = "Đăng nhập thành công!";
                if (chkRemember.Checked)
                {
                    msg += "\n(Đã ghi nhớ thông tin đăng nhập)";
                }
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
        }

        // Sự kiện tích chọn để hiện hoặc ẩn mật khẩu
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                // Hiện mật khẩu rõ trên màn hình
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu (dùng dấu hoa thị)
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Hàm trống phòng hờ trường hợp lỡ ấn nhầm vào nhãn trên giao diện
        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
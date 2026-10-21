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
    public partial class FormDangKyHP : Form
    {
        public FormDangKyHP()
        {
            InitializeComponent();
        }

        private void FormDangKyHP_Load(object sender, EventArgs e)
        {
            // Thêm các môn học mẫu vào CheckedListBox
            checkedListBoxMonHoc.Items.Add("Lập trình C# (3 tín chỉ)");
            checkedListBoxMonHoc.Items.Add("Cơ sở dữ liệu (3 tín chỉ)");
            checkedListBoxMonHoc.Items.Add("Lập trình Web (4 tín chỉ)");
            checkedListBoxMonHoc.Items.Add("Cấu trúc dữ liệu và giải thuật (3 tín chỉ)");
            checkedListBoxMonHoc.Items.Add("Kỹ thuật phần mềm (3 tín chỉ)");
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int tongTinChi = 0;

            // Duyệt qua tất cả các mục đang được tích chọn trong CheckedListBox
            foreach (var item in checkedListBoxMonHoc.CheckedItems)
            {
                string tenMon = item.ToString();

                // Kiểm tra xem tên môn học chứa số tín chỉ nào để cộng dồn
                if (tenMon.Contains("3 tín chỉ"))
                {
                    tongTinChi += 3;
                }
                else if (tenMon.Contains("4 tín chỉ"))
                {
                    tongTinChi += 4;
                }
            }

            // Hiển thị kết quả ra Label
            lblTongTinChi.Text = "Tổng số tín chỉ đã đăng ký: " + tongTinChi;
        }
    }
}
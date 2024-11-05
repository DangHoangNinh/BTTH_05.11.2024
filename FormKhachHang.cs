using System;
using System.Windows.Forms;

namespace BTTH_05._11._2024
{
    public partial class FormKhachHang : Form
    {
        // Thuộc tính chứa dữ liệu khách hàng nhập vào
        public string TenKhachHang { get; private set; }
        public string SoDienThoai { get; private set; }
        public string DiaChi { get; private set; }

        // Khởi tạo form với mã khách hàng mới
        public FormKhachHang(string maKhachHang)
        {
            InitializeComponent();
            txtMaKhachHang.Text = maKhachHang; // Hiển thị mã khách hàng nhưng không cho chỉnh sửa
            txtMaKhachHang.Enabled = false;
        }

        // Khởi tạo form với thông tin khách hàng đã có (chỉnh sửa)
        public FormKhachHang(KhachHang khachHang) : this(khachHang.MaKhachHang)
        {
            txtTenKhachHang.Text = khachHang.Ten;
            txtSoDienThoai.Text = khachHang.SoDienThoai;
            txtDiaChi.Text = khachHang.DiaChi;
        }

        // Sự kiện khi nhấn nút Lưu để lưu thông tin khách hàng
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường không được bỏ trống
            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text) ||
                string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Gán giá trị từ form vào thuộc tính
            TenKhachHang = txtTenKhachHang.Text;
            SoDienThoai = txtSoDienThoai.Text;
            DiaChi = txtDiaChi.Text;

            // Đóng form với kết quả OK để Form1 biết rằng dữ liệu đã được nhập
            DialogResult = DialogResult.OK;
            Close();
        }

        // Sự kiện khi nhấn nút Hủy để thoát mà không lưu
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

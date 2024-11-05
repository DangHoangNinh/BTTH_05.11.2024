using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BTTH_05._11._2024
{
    public partial class Form1 : Form
    {
        private List<KhachHang> danhSachKhachHang = new List<KhachHang>(); // Danh sách lưu khách hàng
        private List<DichVu> danhSachDichVu = new List<DichVu>(); // Danh sách lưu dịch vụ
        private int nextMaHoaDon = 1; // Biến để tạo mã hóa đơn tự động

        public Form1()
        {
            InitializeComponent(); // Khởi tạo giao diện
            LoadDanhSachDichVu();
            KiemTraTrangThaiNutSua(); // Kiểm tra trạng thái nút sửa khi form khởi động
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhachHang();
            CapNhatComboBoxKhachHang();
        }

        // Kiểm tra và kích hoạt nút Sửa nếu có khách hàng trong danh sách
        private void KiemTraTrangThaiNutSua()
        {
            btnSuaKhachHang.Enabled = danhSachKhachHang.Any();
        }

        // Tạo mã khách hàng mới tự động tăng
        private string TaoMaKhachHangMoi()
        {
            int maxMaSo = danhSachKhachHang.Count > 0
                          ? danhSachKhachHang.Max(kh => int.Parse(kh.MaKhachHang.Substring(2)))
                          : 0;
            return $"KH{(maxMaSo + 1):D3}";
        }

        // Tạo mã dịch vụ mới tự động tăng
        private string TaoMaDichVuMoi()
        {
            int maxMaSo = danhSachDichVu.Count > 0
                          ? danhSachDichVu.Max(dv => int.Parse(dv.MaDichVu.Substring(2)))
                          : 0;
            return $"DV{(maxMaSo + 1):D3}";
        }

        // Tải danh sách khách hàng lên DataGridView
        private void LoadDanhSachKhachHang()
        {
            dgvKhachHang.Rows.Clear();
            foreach (var kh in danhSachKhachHang)
            {
                dgvKhachHang.Rows.Add(kh.MaKhachHang, kh.Ten, kh.SoDienThoai, kh.DiaChi);
            }
            KiemTraTrangThaiNutSua(); // Cập nhật trạng thái nút Sửa
            CapNhatComboBoxKhachHang(); // Cập nhật ComboBox khách hàng
        }

        // Cập nhật danh sách khách hàng vào ComboBox
        private void CapNhatComboBoxKhachHang()
        {
            cmbKhachHang.Items.Clear();
            foreach (var kh in danhSachKhachHang)
            {
                cmbKhachHang.Items.Add(kh);
            }
            cmbKhachHang.DisplayMember = "Ten";
        }

        // Tải danh sách dịch vụ vào CheckedListBox
        private void LoadDanhSachDichVu()
        {
            clbDichVu.Items.Clear();
            danhSachDichVu.Add(new DichVu { MaDichVu = TaoMaDichVuMoi(), TenDichVu = "Dịch vụ A", GiaTien = 100000 });
            danhSachDichVu.Add(new DichVu { MaDichVu = TaoMaDichVuMoi(), TenDichVu = "Dịch vụ B", GiaTien = 150000 });
            danhSachDichVu.Add(new DichVu { MaDichVu = TaoMaDichVuMoi(), TenDichVu = "Dịch vụ C", GiaTien = 200000 });

            foreach (var dv in danhSachDichVu)
            {
                clbDichVu.Items.Add(dv);
            }
        }

        // Sự kiện khi nhấn nút Thêm khách hàng
        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            string maKhachHangMoi = TaoMaKhachHangMoi();
            FormKhachHang formKhachHang = new FormKhachHang(maKhachHangMoi);
            if (formKhachHang.ShowDialog() == DialogResult.OK)
            {
                var khachHang = new KhachHang
                {
                    MaKhachHang = maKhachHangMoi,
                    Ten = formKhachHang.TenKhachHang,
                    SoDienThoai = formKhachHang.SoDienThoai,
                    DiaChi = formKhachHang.DiaChi
                };
                danhSachKhachHang.Add(khachHang);
                LoadDanhSachKhachHang(); // Tải lại danh sách khách hàng
            }
        }

        // Sự kiện khi nhấn nút Sửa khách hàng
        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                string maKhachHang = dgvKhachHang.SelectedRows[0].Cells["Makhachhang"].Value.ToString();
                var khachHang = danhSachKhachHang.FirstOrDefault(kh => kh.MaKhachHang == maKhachHang);

                if (khachHang != null)
                {
                    FormKhachHang formKhachHang = new FormKhachHang(khachHang);
                    if (formKhachHang.ShowDialog() == DialogResult.OK)
                    {
                        khachHang.Ten = formKhachHang.TenKhachHang;
                        khachHang.SoDienThoai = formKhachHang.SoDienThoai;
                        khachHang.DiaChi = formKhachHang.DiaChi;
                        LoadDanhSachKhachHang();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để sửa.");
            }
        }

        // Sự kiện khi nhấn nút Xóa khách hàng
        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string maKhachHang = dgvKhachHang.SelectedRows[0].Cells["Makhachhang"].Value.ToString();
                    danhSachKhachHang.RemoveAll(kh => kh.MaKhachHang == maKhachHang);
                    LoadDanhSachKhachHang();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.");
            }
        }

        // Sự kiện khi nhấn nút Tạo hóa đơn
        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            if (cmbKhachHang.SelectedItem is KhachHang khachHang)
            {
                var hoaDon = new HoaDon
                {
                    MaHoaDon = nextMaHoaDon++,
                    KhachHang = khachHang
                };

                foreach (var item in clbDichVu.CheckedItems)
                {
                    if (item is DichVu dichVu)
                    {
                        hoaDon.DanhSachDichVu.Add(dichVu);
                    }
                }

                if (hoaDon.DanhSachDichVu.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một dịch vụ để tạo hóa đơn.");
                    return;
                }

                decimal tongTien = hoaDon.TongTien;

                string chiTietHoaDon = $"Mã hóa đơn: {hoaDon.MaHoaDon}\n";
                chiTietHoaDon += $"Khách hàng: {khachHang.Ten} - {khachHang.MaKhachHang}\n";
                chiTietHoaDon += $"Dịch vụ:\n";
                foreach (var dv in hoaDon.DanhSachDichVu)
                {
                    chiTietHoaDon += $"- {dv.TenDichVu}: {dv.GiaTien:C}\n";
                }
                chiTietHoaDon += $"Tổng tiền: {tongTien:C}";

                MessageBox.Show(chiTietHoaDon, "Hóa đơn tạm thời");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để tạo hóa đơn.");
            }
        }
    }

    // Lớp KhachHang quản lý thông tin khách hàng
    public class KhachHang
    {
        public string MaKhachHang { get; set; }
        public string Ten { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }

        public override string ToString()
        {
            return $"{Ten} ({MaKhachHang})";
        }
    }

    // Lớp DichVu quản lý thông tin dịch vụ
    public class DichVu
    {
        public string MaDichVu { get; set; }
        public string TenDichVu { get; set; }
        public decimal GiaTien { get; set; }

        public override string ToString()
        {
            return $"{MaDichVu} - {TenDichVu} - {GiaTien:C}";
        }
    }

    // Lớp HoaDon quản lý hóa đơn và tính tổng tiền
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public KhachHang KhachHang { get; set; }
        public List<DichVu> DanhSachDichVu { get; set; } = new List<DichVu>();
        public decimal TongTien => DanhSachDichVu.Sum(dv => dv.GiaTien);
    }
}

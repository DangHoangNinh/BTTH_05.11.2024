namespace BTTH_05._11._2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvKhachHang = new DataGridView();
            Makhachhang = new DataGridViewTextBoxColumn();
            Ten = new DataGridViewTextBoxColumn();
            Sodienthoai = new DataGridViewTextBoxColumn();
            Diachi = new DataGridViewTextBoxColumn();
            btnSuaKhachHang = new Button();
            btnXoaKhachHang = new Button();
            btnThemKhachHang = new Button();
            label1 = new Label();
            label2 = new Label();
            cmbKhachHang = new ComboBox();
            btnTaoHoaDon = new Button();
            label4 = new Label();
            clbDichVu = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.BackgroundColor = SystemColors.Control;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { Makhachhang, Ten, Sodienthoai, Diachi });
            dgvKhachHang.Location = new Point(12, 47);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(572, 180);
            dgvKhachHang.TabIndex = 7;
            // 
            // Makhachhang
            // 
            Makhachhang.HeaderText = "Mã khách hàng";
            Makhachhang.MinimumWidth = 6;
            Makhachhang.Name = "Makhachhang";
            Makhachhang.ReadOnly = true;
            Makhachhang.Width = 125;
            // 
            // Ten
            // 
            Ten.HeaderText = "Tên";
            Ten.MinimumWidth = 6;
            Ten.Name = "Ten";
            Ten.Width = 125;
            // 
            // Sodienthoai
            // 
            Sodienthoai.HeaderText = "Số điện thoại";
            Sodienthoai.MinimumWidth = 6;
            Sodienthoai.Name = "Sodienthoai";
            Sodienthoai.Width = 125;
            // 
            // Diachi
            // 
            Diachi.HeaderText = "Địa chỉ";
            Diachi.MinimumWidth = 6;
            Diachi.Name = "Diachi";
            Diachi.Width = 125;
            // 
            // btnSuaKhachHang
            // 
            btnSuaKhachHang.Location = new Point(212, 265);
            btnSuaKhachHang.Name = "btnSuaKhachHang";
            btnSuaKhachHang.Size = new Size(136, 47);
            btnSuaKhachHang.TabIndex = 9;
            btnSuaKhachHang.Text = "Sửa khách hàng";
            btnSuaKhachHang.UseVisualStyleBackColor = true;
            btnSuaKhachHang.Click += btnSuaKhachHang_Click;
            // 
            // btnXoaKhachHang
            // 
            btnXoaKhachHang.Location = new Point(395, 265);
            btnXoaKhachHang.Name = "btnXoaKhachHang";
            btnXoaKhachHang.Size = new Size(136, 47);
            btnXoaKhachHang.TabIndex = 10;
            btnXoaKhachHang.Text = "Xóa khách hàng";
            btnXoaKhachHang.UseVisualStyleBackColor = true;
            btnXoaKhachHang.Click += btnXoaKhachHang_Click;
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.ForeColor = SystemColors.ControlText;
            btnThemKhachHang.Location = new Point(40, 265);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new Size(136, 47);
            btnThemKhachHang.TabIndex = 8;
            btnThemKhachHang.Text = "Thêm khách hàng";
            btnThemKhachHang.UseVisualStyleBackColor = true;
            btnThemKhachHang.Click += btnThemKhachHang_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 11;
            label1.Text = "Danh sách khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(618, 19);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 12;
            label2.Text = "Danh sách dịch vụ:";
            // 
            // cmbKhachHang
            // 
            cmbKhachHang.FormattingEnabled = true;
            cmbKhachHang.Location = new Point(645, 284);
            cmbKhachHang.Name = "cmbKhachHang";
            cmbKhachHang.Size = new Size(151, 28);
            cmbKhachHang.TabIndex = 15;
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.Location = new Point(829, 274);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(136, 47);
            btnTaoHoaDon.TabIndex = 16;
            btnTaoHoaDon.Text = "Tạo hóa đơn";
            btnTaoHoaDon.UseVisualStyleBackColor = true;
            btnTaoHoaDon.Click += btnTaoHoaDon_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(645, 258);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 17;
            label4.Text = "Chọn khách hàng:";
            // 
            // clbDichVu
            // 
            clbDichVu.FormattingEnabled = true;
            clbDichVu.Location = new Point(618, 47);
            clbDichVu.Name = "clbDichVu";
            clbDichVu.Size = new Size(572, 180);
            clbDichVu.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 341);
            Controls.Add(clbDichVu);
            Controls.Add(label4);
            Controls.Add(btnTaoHoaDon);
            Controls.Add(cmbKhachHang);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvKhachHang);
            Controls.Add(btnSuaKhachHang);
            Controls.Add(btnXoaKhachHang);
            Controls.Add(btnThemKhachHang);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvKhachHang;
        private Button btnSuaKhachHang;
        private Button btnXoaKhachHang;
        private Button btnThemKhachHang;
        private Label label1;
        private Label label2;
        private ComboBox cmbKhachHang;
        private Button btnTaoHoaDon;
        private Label label4;
        private CheckedListBox clbDichVu;
        private DataGridViewTextBoxColumn Makhachhang;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn Sodienthoai;
        private DataGridViewTextBoxColumn Diachi;
    }
}

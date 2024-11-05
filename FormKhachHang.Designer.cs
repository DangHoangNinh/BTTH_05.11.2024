namespace BTTH_05._11._2024
{
    partial class FormKhachHang
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
            txtMaKhachHang = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTenKhachHang = new TextBox();
            txtSoDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Location = new Point(192, 64);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(190, 27);
            txtMaKhachHang.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 67);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã Khách Hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 137);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên Khách Hàng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 199);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 4;
            label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 265);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 5;
            label5.Text = "Địa chỉ:";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(192, 134);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(190, 27);
            txtTenKhachHang.TabIndex = 6;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(192, 199);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(190, 27);
            txtSoDienThoai.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(192, 262);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(190, 27);
            txtDiaChi.TabIndex = 8;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(64, 326);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(256, 326);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 387);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtDiaChi);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtTenKhachHang);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMaKhachHang);
            Name = "FormKhachHang";
            Text = "FormKhachHang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaKhachHang;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtTenKhachHang;
        private TextBox txtSoDienThoai;
        private TextBox txtDiaChi;
        private Button btnLuu;
        private Button btnHuy;
    }
}
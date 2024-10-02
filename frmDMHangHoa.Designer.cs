namespace Dientu
{
    partial class frmDMHangHoa
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
            panel1 = new Panel();
            btnReset = new Button();
            btnTimKiem = new Button();
            btnHienThiDS = new Button();
            btnDong = new Button();
            btnBoQua = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            txtDonGiaBan = new TextBox();
            btnOpen = new Button();
            picAnh = new PictureBox();
            txtGhiChu = new TextBox();
            label9 = new Label();
            txtSoLuong = new TextBox();
            cboMaLoaiSanPham = new ComboBox();
            label7 = new Label();
            label1 = new Label();
            txtAnh = new TextBox();
            txtTenHang = new TextBox();
            txtMaHang = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            dgvHangHoa = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(btnHienThiDS);
            panel1.Controls.Add(btnDong);
            panel1.Controls.Add(btnBoQua);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 587);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 72);
            panel1.TabIndex = 1;
            // 
            // btnReset
            // 
            btnReset.Image = Properties.Resources._8111405_reset_reload_refresh_sync_arrow_icon;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(866, 22);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 20;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = Properties.Resources._115695_magnifying_glass_zoom_find_search_icon;
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(579, 22);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(126, 29);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.Text = "&Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnHienThiDS
            // 
            btnHienThiDS.Image = Properties.Resources._1622833_checkmark_done_exam_list_pencil_icon;
            btnHienThiDS.ImageAlign = ContentAlignment.MiddleLeft;
            btnHienThiDS.Location = new Point(722, 22);
            btnHienThiDS.Name = "btnHienThiDS";
            btnHienThiDS.Size = new Size(122, 29);
            btnHienThiDS.TabIndex = 18;
            btnHienThiDS.Text = "Hiển thị DS";
            btnHienThiDS.UseVisualStyleBackColor = true;
            btnHienThiDS.Click += btnHienThiDS_Click;
            // 
            // btnDong
            // 
            btnDong.Image = Properties.Resources._32387_cancel_icon;
            btnDong.ImageAlign = ContentAlignment.MiddleLeft;
            btnDong.Location = new Point(985, 22);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 17;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Image = Properties.Resources._11055110_redo_next_ui_direction_skip_icon;
            btnBoQua.ImageAlign = ContentAlignment.MiddleLeft;
            btnBoQua.Location = new Point(468, 22);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(94, 29);
            btnBoQua.TabIndex = 16;
            btnBoQua.Text = "&Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Image = Properties.Resources._285657_floppy_guardar_save_icon;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(357, 22);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "&Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources._285638_pencil_icon;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(246, 22);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 14;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources._1891023_cancel_cercle_close_delete_dismiss_icon;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(135, 22);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources._299068_add_sign_icon;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(24, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "&Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtDonGiaBan);
            panel2.Controls.Add(btnOpen);
            panel2.Controls.Add(picAnh);
            panel2.Controls.Add(txtGhiChu);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtSoLuong);
            panel2.Controls.Add(cboMaLoaiSanPham);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtAnh);
            panel2.Controls.Add(txtTenHang);
            panel2.Controls.Add(txtMaHang);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1120, 280);
            panel2.TabIndex = 2;
            // 
            // txtDonGiaBan
            // 
            txtDonGiaBan.Location = new Point(156, 205);
            txtDonGiaBan.Name = "txtDonGiaBan";
            txtDonGiaBan.Size = new Size(278, 27);
            txtDonGiaBan.TabIndex = 31;
            txtDonGiaBan.TextAlign = HorizontalAlignment.Right;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(722, 56);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(48, 35);
            btnOpen.TabIndex = 29;
            btnOpen.Text = "&Mở";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // picAnh
            // 
            picAnh.Location = new Point(793, 56);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(170, 189);
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picAnh.TabIndex = 28;
            picAnh.TabStop = false;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(510, 144);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(206, 101);
            txtGhiChu.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 208);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 26;
            label9.Text = "Đơn giá bán:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(156, 168);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(278, 27);
            txtSoLuong.TabIndex = 24;
            txtSoLuong.TextAlign = HorizontalAlignment.Right;
            // 
            // cboMaLoaiSanPham
            // 
            cboMaLoaiSanPham.FormattingEnabled = true;
            cboMaLoaiSanPham.Location = new Point(156, 130);
            cboMaLoaiSanPham.Name = "cboMaLoaiSanPham";
            cboMaLoaiSanPham.Size = new Size(278, 28);
            cboMaLoaiSanPham.TabIndex = 23;
            cboMaLoaiSanPham.SelectedIndexChanged += a;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 167);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 22;
            label7.Text = "Số lượng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 130);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 21;
            label1.Text = "Mã Nhãn Hàng";
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(510, 56);
            txtAnh.Multiline = true;
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(206, 51);
            txtAnh.TabIndex = 19;
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(156, 93);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(278, 27);
            txtTenHang.TabIndex = 18;
            // 
            // txtMaHang
            // 
            txtMaHang.Location = new Point(156, 56);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.Size = new Size(278, 27);
            txtMaHang.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 144);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 16;
            label6.Text = "Ghi chú";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(463, 60);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 15;
            label5.Text = "Ảnh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 93);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 14;
            label3.Text = "Tên hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 56);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 13;
            label2.Text = "Mã hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(314, 9);
            label4.Name = "label4";
            label4.Size = new Size(286, 32);
            label4.TabIndex = 12;
            label4.Text = "DANH MỤC HÀNG HÓA";
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangHoa.Dock = DockStyle.Fill;
            dgvHangHoa.Location = new Point(0, 280);
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.RowHeadersWidth = 51;
            dgvHangHoa.Size = new Size(1120, 307);
            dgvHangHoa.TabIndex = 3;
            dgvHangHoa.CellContentClick += dgvHangHoa_CellContentClick;
            dgvHangHoa.Click += dgvHangHoa_Click;
            // 
            // frmDMHangHoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 659);
            Controls.Add(dgvHangHoa);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDMHangHoa";
            Text = "frmDMHangHoa";
            Load += frmDMHangHoa_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnHienThiDS;
        private Button btnDong;
        private Button btnBoQua;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel2;
        private TextBox txtAnh;
        private TextBox txtTenHang;
        private TextBox txtMaHang;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label4;
        private DataGridView dgvHangHoa;
        private TextBox txtGhiChu;
        private Label label9;
        private Label label8;
        private TextBox txtSoLuong;
        private ComboBox cboMaLoaiSanPham;
        private Label label7;
        private Label label1;
        private Button btnOpen;
        private PictureBox picAnh;
        private TextBox txtDonGiaBan;
        private TextBox txtDonGiaNhap;
        private Button btnTimKiem;
        private Button btnReset;
    }
}
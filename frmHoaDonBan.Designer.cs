namespace Dientu
{
    partial class frmHoaDonBan
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
            btnTimKiem = new Button();
            cboMaHD = new ComboBox();
            lblMaHD = new Label();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            cboMaKhach = new ComboBox();
            mtbDienThoai = new MaskedTextBox();
            txtTenNhanVien = new TextBox();
            txtDiaChi = new TextBox();
            cboMaNhanVien = new ComboBox();
            txtTenKhach = new TextBox();
            dtpNgayBan = new DateTimePicker();
            txtMaHDBan = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            dgvHDBanHang = new DataGridView();
            panel4 = new Panel();
            txtTongTien = new TextBox();
            label16 = new Label();
            lblBangChu = new Label();
            label14 = new Label();
            panel = new Panel();
            txtThanhTien = new TextBox();
            label15 = new Label();
            txtGiamGia = new TextBox();
            lblGiamGia = new Label();
            txtSoLuong = new TextBox();
            label13 = new Label();
            txtDonGiaBan = new TextBox();
            label12 = new Label();
            txtTenHang = new TextBox();
            label11 = new Label();
            cboMaHang = new ComboBox();
            label10 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btnSua = new Button();
            btnDong = new Button();
            btnInHoaDon = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnReset = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDBanHang).BeginInit();
            panel4.SuspendLayout();
            panel.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(cboMaHD);
            panel1.Controls.Add(lblMaHD);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 591);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 70);
            panel1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = Properties.Resources._115695_magnifying_glass_zoom_find_search_icon;
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(425, 11);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(123, 29);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "&Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cboMaHD
            // 
            cboMaHD.FormattingEnabled = true;
            cboMaHD.Location = new Point(139, 12);
            cboMaHD.Name = "cboMaHD";
            cboMaHD.Size = new Size(260, 28);
            cboMaHD.TabIndex = 1;
            cboMaHD.DropDown += cboMaHD_DropDown;
            cboMaHD.SelectedIndexChanged += cboMaHD_SelectedIndexChanged;
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Location = new Point(33, 15);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(89, 20);
            lblMaHD.TabIndex = 0;
            lblMaHD.Text = "Mã hóa đơn";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(label4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(898, 591);
            splitContainer1.SplitterDistance = 204;
            splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboMaKhach);
            groupBox1.Controls.Add(mtbDienThoai);
            groupBox1.Controls.Add(txtTenNhanVien);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(cboMaNhanVien);
            groupBox1.Controls.Add(txtTenKhach);
            groupBox1.Controls.Add(dtpNgayBan);
            groupBox1.Controls.Add(txtMaHDBan);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(4, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(850, 165);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // cboMaKhach
            // 
            cboMaKhach.FormattingEnabled = true;
            cboMaKhach.Location = new Point(563, 28);
            cboMaKhach.Name = "cboMaKhach";
            cboMaKhach.Size = new Size(278, 28);
            cboMaKhach.TabIndex = 25;
            cboMaKhach.SelectedIndexChanged += cboMaKhach_SelectedIndexChanged;
            // 
            // mtbDienThoai
            // 
            mtbDienThoai.Location = new Point(563, 130);
            mtbDienThoai.Mask = "(999) 000-0000";
            mtbDienThoai.Name = "mtbDienThoai";
            mtbDienThoai.ReadOnly = true;
            mtbDienThoai.Size = new Size(278, 27);
            mtbDienThoai.TabIndex = 24;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(135, 131);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(264, 27);
            txtTenNhanVien.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(563, 96);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.Size = new Size(278, 27);
            txtDiaChi.TabIndex = 23;
            // 
            // cboMaNhanVien
            // 
            cboMaNhanVien.FormattingEnabled = true;
            cboMaNhanVien.Location = new Point(135, 94);
            cboMaNhanVien.Name = "cboMaNhanVien";
            cboMaNhanVien.Size = new Size(264, 28);
            cboMaNhanVien.TabIndex = 10;
            cboMaNhanVien.SelectedIndexChanged += cboMaNhanVien_SelectedIndexChanged;
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(563, 62);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.ReadOnly = true;
            txtTenKhach.Size = new Size(278, 27);
            txtTenKhach.TabIndex = 22;
            txtTenKhach.TextChanged += txtTenKhach_TextChanged;
            // 
            // dtpNgayBan
            // 
            dtpNgayBan.Format = DateTimePickerFormat.Short;
            dtpNgayBan.Location = new Point(135, 58);
            dtpNgayBan.Name = "dtpNgayBan";
            dtpNgayBan.Size = new Size(264, 27);
            dtpNgayBan.TabIndex = 9;
            // 
            // txtMaHDBan
            // 
            txtMaHDBan.Location = new Point(135, 22);
            txtMaHDBan.Name = "txtMaHDBan";
            txtMaHDBan.ReadOnly = true;
            txtMaHDBan.Size = new Size(264, 27);
            txtMaHDBan.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(448, 130);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 7;
            label9.Text = "Điện thoại";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(448, 97);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 6;
            label8.Text = "Địa chỉ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(448, 64);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 5;
            label7.Text = "Tên khách hàng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 130);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 4;
            label6.Text = "Tên nhân viên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 97);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 3;
            label5.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 31);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 2;
            label3.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 64);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày bán:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 31);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(337, 9);
            label4.Name = "label4";
            label4.Size = new Size(266, 32);
            label4.TabIndex = 13;
            label4.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHDBanHang);
            groupBox2.Controls.Add(panel4);
            groupBox2.Controls.Add(panel);
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(898, 383);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // dgvHDBanHang
            // 
            dgvHDBanHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHDBanHang.Dock = DockStyle.Fill;
            dgvHDBanHang.Location = new Point(3, 130);
            dgvHDBanHang.Name = "dgvHDBanHang";
            dgvHDBanHang.RowHeadersWidth = 51;
            dgvHDBanHang.Size = new Size(892, 154);
            dgvHDBanHang.TabIndex = 3;
            dgvHDBanHang.Click += dgvHDBanHang_Click;
            dgvHDBanHang.DoubleClick += dgvHDBanHang_DoubleClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtTongTien);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(lblBangChu);
            panel4.Controls.Add(label14);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 284);
            panel4.Name = "panel4";
            panel4.Size = new Size(892, 52);
            panel4.TabIndex = 2;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(641, 6);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(201, 27);
            txtTongTien.TabIndex = 3;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(543, 9);
            label16.Name = "label16";
            label16.Size = new Size(72, 20);
            label16.TabIndex = 2;
            label16.Text = "Tổng tiền";
            // 
            // lblBangChu
            // 
            lblBangChu.AutoSize = true;
            lblBangChu.ForeColor = Color.FromArgb(0, 0, 192);
            lblBangChu.Location = new Point(9, 29);
            lblBangChu.Name = "lblBangChu";
            lblBangChu.Size = new Size(71, 20);
            lblBangChu.TabIndex = 1;
            lblBangChu.Text = "Bằng chữ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.FromArgb(192, 0, 0);
            label14.Location = new Point(9, 3);
            label14.Name = "label14";
            label14.Size = new Size(192, 20);
            label14.TabIndex = 0;
            label14.Text = "Nháy đúp một dòng để xóa";
            // 
            // panel
            // 
            panel.Controls.Add(txtThanhTien);
            panel.Controls.Add(label15);
            panel.Controls.Add(txtGiamGia);
            panel.Controls.Add(lblGiamGia);
            panel.Controls.Add(txtSoLuong);
            panel.Controls.Add(label13);
            panel.Controls.Add(txtDonGiaBan);
            panel.Controls.Add(label12);
            panel.Controls.Add(txtTenHang);
            panel.Controls.Add(label11);
            panel.Controls.Add(cboMaHang);
            panel.Controls.Add(label10);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(3, 23);
            panel.Name = "panel";
            panel.Size = new Size(892, 107);
            panel.TabIndex = 1;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(700, 55);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(160, 27);
            txtThanhTien.TabIndex = 11;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(622, 62);
            label15.Name = "label15";
            label15.Size = new Size(78, 20);
            label15.TabIndex = 10;
            label15.Text = "Thành tiền";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(412, 55);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(151, 27);
            txtGiamGia.TabIndex = 9;
            txtGiamGia.TextChanged += txtGiamGia_TextChanged;
            // 
            // lblGiamGia
            // 
            lblGiamGia.AutoSize = true;
            lblGiamGia.Location = new Point(334, 62);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(72, 20);
            lblGiamGia.TabIndex = 8;
            lblGiamGia.Text = "Giảm giá:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(136, 55);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(151, 27);
            txtSoLuong.TabIndex = 7;
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(49, 62);
            label13.Name = "label13";
            label13.Size = new Size(72, 20);
            label13.TabIndex = 6;
            label13.Text = "Số lượng:";
            // 
            // txtDonGiaBan
            // 
            txtDonGiaBan.Location = new Point(700, 16);
            txtDonGiaBan.Name = "txtDonGiaBan";
            txtDonGiaBan.ReadOnly = true;
            txtDonGiaBan.Size = new Size(160, 27);
            txtDonGiaBan.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(622, 18);
            label12.Name = "label12";
            label12.Size = new Size(65, 20);
            label12.TabIndex = 4;
            label12.Text = "Đơn giá:";
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(412, 11);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.ReadOnly = true;
            txtTenHang.Size = new Size(151, 27);
            txtTenHang.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(334, 19);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 2;
            label11.Text = "Tên hàng:";
            // 
            // cboMaHang
            // 
            cboMaHang.FormattingEnabled = true;
            cboMaHang.Location = new Point(136, 11);
            cboMaHang.Name = "cboMaHang";
            cboMaHang.Size = new Size(151, 28);
            cboMaHang.TabIndex = 1;
            cboMaHang.SelectedIndexChanged += cboMaHang_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(49, 19);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 0;
            label10.Text = "Mã hàng:";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 336);
            panel2.Name = "panel2";
            panel2.Size = new Size(892, 44);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSua);
            panel3.Controls.Add(btnDong);
            panel3.Controls.Add(btnInHoaDon);
            panel3.Controls.Add(btnLuu);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnThem);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(892, 44);
            panel3.TabIndex = 0;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources._285638_pencil_icon;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(689, 6);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 12;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnDong
            // 
            btnDong.Image = Properties.Resources._32387_cancel_icon;
            btnDong.ImageAlign = ContentAlignment.MiddleLeft;
            btnDong.Location = new Point(789, 6);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 11;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Image = Properties.Resources._2620507_employee_job_print_seeker_unemployee_icon;
            btnInHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnInHoaDon.Location = new Point(543, 6);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(136, 29);
            btnInHoaDon.TabIndex = 10;
            btnInHoaDon.Text = "&In Hóa Đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnLuu
            // 
            btnLuu.Image = Properties.Resources._285657_floppy_guardar_save_icon;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(197, 6);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(155, 29);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "&Lưu Hóa Đơn";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources._1891023_cancel_cercle_close_delete_dismiss_icon;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(373, 6);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(154, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "&Hủy Hóa Đơn";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources._299068_add_sign_icon;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(21, 6);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(147, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "&Thêm Hóa Đơn";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnReset
            // 
            btnReset.Image = Properties.Resources._8111405_reset_reload_refresh_sync_arrow_icon;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(567, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 13;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // frmHoaDonBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 661);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "frmHoaDonBan";
            Text = "Hóa đơn bán hàng";
            FormClosed += frmHoaDonBan_FormClosed;
            Load += frmHoaDonBan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHDBanHang).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblMaHD;
        private Button btnTimKiem;
        private ComboBox cboMaHD;
        private SplitContainer splitContainer1;
        private Label label4;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
        private DateTimePicker dtpNgayBan;
        private TextBox txtMaHDBan;
        private TextBox txtTenNhanVien;
        private ComboBox cboMaNhanVien;
        private MaskedTextBox mtbDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtTenKhach;
        private GroupBox groupBox2;
        private Panel panel;
        private Panel panel2;
        private TextBox txtTenHang;
        private Label label11;
        private ComboBox cboMaHang;
        private Label label10;
        private TextBox txtDonGiaBan;
        private Label label12;
        private Label label13;
        private TextBox txtThanhTien;
        private Label label15;
        private TextBox txtGiamGia;
        private Label lblGiamGia;
        private TextBox txtSoLuong;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dgvHDBanHang;
        private Label lblBangChu;
        private Label label14;
        private TextBox txtTongTien;
        private Label label16;
        private Button btnDong;
        private Button btnInHoaDon;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThem;
        private ComboBox cboMaKhach;
        private Button btnSua;
        private Button btnReset;
    }
}
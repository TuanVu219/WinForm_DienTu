namespace Dientu
{
    partial class frmDMKhachHang
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
            btnDong = new Button();
            btnBoQua = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            mtbDienThoai = new MaskedTextBox();
            txtDiaChi = new TextBox();
            txtTenKhachHang = new TextBox();
            txtMaKhachHang = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            dgvKhachHang = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDong);
            panel1.Controls.Add(btnBoQua);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 378);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 72);
            panel1.TabIndex = 0;
            // 
            // btnDong
            // 
            btnDong.Image = Properties.Resources._32387_cancel_icon;
            btnDong.ImageAlign = ContentAlignment.MiddleLeft;
            btnDong.Location = new Point(676, 22);
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
            btnBoQua.Location = new Point(547, 22);
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
            btnLuu.Location = new Point(418, 22);
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
            btnSua.Location = new Point(289, 22);
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
            btnXoa.Location = new Point(160, 22);
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
            btnThem.Location = new Point(31, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "&Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(mtbDienThoai);
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(txtTenKhachHang);
            panel2.Controls.Add(txtMaKhachHang);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 144);
            panel2.TabIndex = 1;
            // 
            // mtbDienThoai
            // 
            mtbDienThoai.Location = new Point(543, 94);
            mtbDienThoai.Mask = "(999) 000-0000";
            mtbDienThoai.Name = "mtbDienThoai";
            mtbDienThoai.Size = new Size(206, 27);
            mtbDienThoai.TabIndex = 20;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(543, 53);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(206, 27);
            txtDiaChi.TabIndex = 19;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(156, 98);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(278, 27);
            txtTenKhachHang.TabIndex = 18;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Location = new Point(156, 56);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(278, 27);
            txtMaKhachHang.TabIndex = 17;
            txtMaKhachHang.KeyUp += txtMaKhachHang_KeyUp;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(463, 97);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 16;
            label6.Text = "Điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(463, 59);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 15;
            label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 101);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 14;
            label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 60);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 13;
            label2.Text = "Mã khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(261, 9);
            label4.Name = "label4";
            label4.Size = new Size(317, 32);
            label4.TabIndex = 12;
            label4.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(0, 144);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(800, 234);
            dgvKhachHang.TabIndex = 2;
            dgvKhachHang.Click += dgvKhachHang_Click;
            // 
            // frmDMKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvKhachHang);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDMKhachHang";
            Text = "Danh mục khách hàng";
            Load += frmDMKhachHang_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvKhachHang;
        private MaskedTextBox mtbDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtTenKhachHang;
        private TextBox txtMaKhachHang;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btnDong;
        private Button btnBoQua;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}
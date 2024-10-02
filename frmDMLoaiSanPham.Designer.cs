namespace Dientu
{
    partial class frmDMLoaiSanPham
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
            txtTenLoaiSanPham = new TextBox();
            txtMaLoaiSanPham = new TextBox();
            lblTenLoaiSanPham = new Label();
            lblMaLoaiSanPham = new Label();
            label1 = new Label();
            dgvLoaiSanPham = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSanPham).BeginInit();
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
            panel1.Location = new Point(0, 462);
            panel1.Name = "panel1";
            panel1.Size = new Size(973, 60);
            panel1.TabIndex = 2;
            // 
            // btnDong
            // 
            btnDong.Image = Properties.Resources._32387_cancel_icon;
            btnDong.ImageAlign = ContentAlignment.MiddleLeft;
            btnDong.Location = new Point(670, 19);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 5;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Image = Properties.Resources._11055110_redo_next_ui_direction_skip_icon;
            btnBoQua.ImageAlign = ContentAlignment.MiddleLeft;
            btnBoQua.Location = new Point(541, 19);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(94, 29);
            btnBoQua.TabIndex = 4;
            btnBoQua.Text = "&Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Image = Properties.Resources._285657_floppy_guardar_save_icon;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(412, 19);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "&Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources._285638_pencil_icon;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(283, 19);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources._1891023_cancel_cercle_close_delete_dismiss_icon;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(154, 19);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources._299068_add_sign_icon;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(25, 19);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "&Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTenLoaiSanPham);
            panel2.Controls.Add(txtMaLoaiSanPham);
            panel2.Controls.Add(lblTenLoaiSanPham);
            panel2.Controls.Add(lblMaLoaiSanPham);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(973, 164);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // txtTenLoaiSanPham
            // 
            txtTenLoaiSanPham.Location = new Point(164, 112);
            txtTenLoaiSanPham.Name = "txtTenLoaiSanPham";
            txtTenLoaiSanPham.Size = new Size(255, 27);
            txtTenLoaiSanPham.TabIndex = 1;
            // 
            // txtMaLoaiSanPham
            // 
            txtMaLoaiSanPham.Location = new Point(164, 62);
            txtMaLoaiSanPham.Name = "txtMaLoaiSanPham";
            txtMaLoaiSanPham.Size = new Size(255, 27);
            txtMaLoaiSanPham.TabIndex = 0;
            txtMaLoaiSanPham.KeyUp += txtMaLoaiSanPham_KeyUp;
            // 
            // lblTenLoaiSanPham
            // 
            lblTenLoaiSanPham.AutoSize = true;
            lblTenLoaiSanPham.Location = new Point(31, 112);
            lblTenLoaiSanPham.Name = "lblTenLoaiSanPham";
            lblTenLoaiSanPham.Size = new Size(105, 20);
            lblTenLoaiSanPham.TabIndex = 2;
            lblTenLoaiSanPham.Text = "Tên nhãn hàng";
            // 
            // lblMaLoaiSanPham
            // 
            lblMaLoaiSanPham.AutoSize = true;
            lblMaLoaiSanPham.Location = new Point(31, 62);
            lblMaLoaiSanPham.Name = "lblMaLoaiSanPham";
            lblMaLoaiSanPham.Size = new Size(103, 20);
            lblMaLoaiSanPham.TabIndex = 1;
            lblMaLoaiSanPham.Text = "Mã nhãn hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(412, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 32);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC";
            // 
            // dgvLoaiSanPham
            // 
            dgvLoaiSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiSanPham.Dock = DockStyle.Fill;
            dgvLoaiSanPham.Location = new Point(0, 164);
            dgvLoaiSanPham.Name = "dgvLoaiSanPham";
            dgvLoaiSanPham.RowHeadersWidth = 51;
            dgvLoaiSanPham.Size = new Size(973, 298);
            dgvLoaiSanPham.TabIndex = 1;
            dgvLoaiSanPham.Click += dgvLoaiSanPham_Click;
            // 
            // frmDMLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 522);
            Controls.Add(dgvLoaiSanPham);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDMLoaiSanPham";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Danh mục chất liệu";
            Load += frmDMLoaiSanPham_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDong;
        private Button btnBoQua;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel2;
        private DataGridView dgvLoaiSanPham;
        private Label label1;
        private Label lblMaLoaiSanPham;
        private TextBox txtTenLoaiSanPham;
        private TextBox txtMaLoaiSanPham;
        private Label lblTenLoaiSanPham;
    }
}
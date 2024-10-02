namespace Dientu
{
    partial class frmStatistic
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
            cboNgay = new ComboBox();
            cboThang = new ComboBox();
            txtNam = new TextBox();
            lblNam = new Label();
            lblThang = new Label();
            cboMaHang = new ComboBox();
            label10 = new Label();
            cboMaKhach = new ComboBox();
            cboMaNhanVien = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            btnTimKiem = new Button();
            txtTongTien = new TextBox();
            label16 = new Label();
            dgvThongKe = new DataGridView();
            btnReset = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cboNgay);
            panel1.Controls.Add(cboThang);
            panel1.Controls.Add(txtNam);
            panel1.Controls.Add(lblNam);
            panel1.Controls.Add(lblThang);
            panel1.Controls.Add(cboMaHang);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cboMaKhach);
            panel1.Controls.Add(cboMaNhanVien);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 190);
            panel1.TabIndex = 0;
            // 
            // cboNgay
            // 
            cboNgay.FormattingEnabled = true;
            cboNgay.Location = new Point(108, 57);
            cboNgay.Name = "cboNgay";
            cboNgay.Size = new Size(264, 28);
            cboNgay.TabIndex = 40;
            // 
            // cboThang
            // 
            cboThang.FormattingEnabled = true;
            cboThang.Location = new Point(108, 103);
            cboThang.Name = "cboThang";
            cboThang.Size = new Size(264, 28);
            cboThang.TabIndex = 39;
            // 
            // txtNam
            // 
            txtNam.Location = new Point(108, 148);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(264, 27);
            txtNam.TabIndex = 37;
            txtNam.KeyPress += txtNam_KeyPress;
            // 
            // lblNam
            // 
            lblNam.AutoSize = true;
            lblNam.Location = new Point(5, 148);
            lblNam.Name = "lblNam";
            lblNam.Size = new Size(41, 20);
            lblNam.TabIndex = 36;
            lblNam.Text = "Năm";
            // 
            // lblThang
            // 
            lblThang.AutoSize = true;
            lblThang.Location = new Point(5, 103);
            lblThang.Name = "lblThang";
            lblThang.Size = new Size(50, 20);
            lblThang.TabIndex = 35;
            lblThang.Text = "Tháng";
            // 
            // cboMaHang
            // 
            cboMaHang.FormattingEnabled = true;
            cboMaHang.Location = new Point(622, 100);
            cboMaHang.Name = "cboMaHang";
            cboMaHang.Size = new Size(278, 28);
            cboMaHang.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(497, 103);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 32;
            label10.Text = "Mã hàng:";
            // 
            // cboMaKhach
            // 
            cboMaKhach.FormattingEnabled = true;
            cboMaKhach.Location = new Point(622, 51);
            cboMaKhach.Name = "cboMaKhach";
            cboMaKhach.Size = new Size(278, 28);
            cboMaKhach.TabIndex = 31;
            // 
            // cboMaNhanVien
            // 
            cboMaNhanVien.FormattingEnabled = true;
            cboMaNhanVien.Location = new Point(622, 140);
            cboMaNhanVien.Name = "cboMaNhanVien";
            cboMaNhanVien.Size = new Size(278, 28);
            cboMaNhanVien.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(497, 143);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 28;
            label5.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(497, 59);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 27;
            label3.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 65);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 26;
            label2.Text = "Ngày bán:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(414, 9);
            label4.Name = "label4";
            label4.Size = new Size(136, 32);
            label4.TabIndex = 14;
            label4.Text = "THỐNG KÊ";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(txtTongTien);
            panel2.Controls.Add(label16);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 393);
            panel2.Name = "panel2";
            panel2.Size = new Size(944, 57);
            panel2.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = Properties.Resources._115695_magnifying_glass_zoom_find_search_icon;
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(108, 16);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(123, 29);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "&Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(699, 18);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(201, 27);
            txtTongTien.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(601, 21);
            label16.Name = "label16";
            label16.Size = new Size(72, 20);
            label16.TabIndex = 4;
            label16.Text = "Tổng tiền";
            // 
            // dgvThongKe
            // 
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Dock = DockStyle.Fill;
            dgvThongKe.Location = new Point(0, 190);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowHeadersWidth = 51;
            dgvThongKe.Size = new Size(944, 203);
            dgvThongKe.TabIndex = 2;
            // 
            // btnReset
            // 
            btnReset.Image = Properties.Resources._8111405_reset_reload_refresh_sync_arrow_icon;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(278, 16);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 14;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // frmStatistic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 450);
            Controls.Add(dgvThongKe);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmStatistic";
            Text = "Form1";
            Load += frmStatistic_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvThongKe;
        private Label label4;
        private ComboBox cboMaKhach;
        private ComboBox cboMaNhanVien;
        private Label label5;
        private Label label3;
        private Label label2;
        private ComboBox cboMaHang;
        private Label label10;
        private TextBox txtTongTien;
        private Label label16;
        private Button btnTimKiem;
        private TextBox txtNam;
        private Label lblNam;
        private Label lblThang;
        private ComboBox cboThang;
        private ComboBox cboNgay;
        private Button btnReset;
    }
}
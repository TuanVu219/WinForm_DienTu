using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dientu
{
    public partial class frmStatistic : Form
    {
        DataTable tbltk;
        public frmStatistic()
        {
            InitializeComponent();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.InvoiceId, b.EmployId, a.ProductId, a.Amount, a.Price,b.Userid AS ThanhTien,b.Invoice_Date" +
                " FROM Invoice_Detail AS a, Invoice AS b" +
                " WHERE  a.InvoiceId=b.InvoiceId";
            tbltk = Function.GetDataToTable(sql);
            dgvThongKe.DataSource = tbltk;
            dgvThongKe.Columns[0].HeaderText = "Mã hóa đơn";
            dgvThongKe.Columns[1].HeaderText = "Mã nhân viên";
            dgvThongKe.Columns[2].HeaderText = "Mã hàng";
            dgvThongKe.Columns[3].HeaderText = "Số lượng";
            dgvThongKe.Columns[4].HeaderText = "Thành tiền";
            dgvThongKe.Columns[5].HeaderText = "Mã khách hàng";
            dgvThongKe.Columns[6].HeaderText = "Ngày xuất";
            dgvThongKe.Columns[0].Width = 150;
            dgvThongKe.Columns[1].Width = 130;
            dgvThongKe.Columns[2].Width = 80;
            dgvThongKe.Columns[3].Width = 90;
            dgvThongKe.Columns[4].Width = 90;
            dgvThongKe.Columns[5].Width = 90;
            dgvThongKe.Columns[6].Width = 150;
            dgvThongKe.AllowUserToAddRows = false;
            dgvThongKe.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void frmStatistic_Load(object sender, EventArgs e)
        {
            cboMaNhanVien.Enabled=true;
            cboMaKhach.Enabled=true;
            cboMaHang.Enabled=true;
            txtTongTien.Text = "0";
            cboMaNhanVien.Text="";
            cboMaKhach.Text="";
            string[] month = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            for (int i = 0; i <= 11; i++)
            {
                cboThang.Items.Add(month[i]);
            }
            for (int i = 1; i <= 31; i++)
            {
                cboNgay.Items.Add(i.ToString()); // Chuyển đổi số nguyên thành chuỗi và thêm vào ComboBox
            }
            Function.FillCombo("SELECT userid, full_name FROM users WHERE user_type_id=2", cboMaKhach, "userid", "userid");
            cboMaKhach.SelectedIndex = -1;
            Function.FillCombo("SELECT userid, full_name  FROM users WHERE user_type_id=1", cboMaNhanVien, "userid", "userid");
            cboMaNhanVien.SelectedIndex = -1;
            Function.FillCombo("SELECT ProductId, ProductName FROM Product", cboMaHang, "ProductId", "ProductId");
            cboMaHang.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            LoadDataGridView();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cboMaHang.SelectedValue=="") && (cboMaKhach.SelectedValue=="")&&(cboMaNhanVien.SelectedValue=="")&&(cboNgay.SelectedValue=="")&&(cboThang.SelectedValue=="")&&(txtNam.Text==""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "SELECT a.InvoiceId, b.EmployId, a.ProductId, a.Amount, a.Price,b.Userid AS ThanhTien,b.Invoice_Date" +
              " FROM Invoice_Detail AS a, Invoice AS b" +
              " WHERE a.InvoiceId=b.InvoiceId ";
            int MaHang;
            if (cboMaHang.Text!="")
            {
                if (!int.TryParse(cboMaHang.Text, out MaHang))
                {
                    MessageBox.Show("Vui lòng nhập mã hànglà một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                sql += " AND a.ProductId = " + MaHang;
            }
            if (cboMaKhach.Text!="")
            {
                int MaKhach;
                if (!int.TryParse(cboMaKhach.Text, out MaKhach))
                {
                    MessageBox.Show("Vui lòng nhập mã khách là một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                sql += " AND b.userid = " + MaKhach;
            }
            if (cboMaNhanVien.Text!="")
            {
                int MaNhanVien;
                if (!int.TryParse(cboMaNhanVien.Text, out MaNhanVien))
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên là một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                sql += " AND b.EmployId = " + MaNhanVien;
            }

            if (cboNgay.Text!="")
            {
                int day;
                if (!int.TryParse(cboNgay.Text, out day))
                {
                    MessageBox.Show("Vui lòng nhập ngày là một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                sql += " AND DAY(b.Invoice_Date) = " + day;
            }
            if (cboThang.Text!="")
            {
                int month;
                if (!int.TryParse(cboThang.Text, out month))
                {
                    MessageBox.Show("Vui lòng nhập tháng là một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                sql += " AND MONTH(b.Invoice_Date) = " + month;
            }
            if (txtNam.Text!="")
            {
                int year;
                if (!int.TryParse(txtNam.Text, out year))
                {
                    MessageBox.Show("Vui lòng nhập tháng là một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                sql += " AND YEAR(b.Invoice_Date) = " + year;
            }
            tbltk=Function.GetDataToTable(sql);

            if (tbltk.Rows.Count==0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Có"+tbltk.Rows.Count+"Bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            double sum = 0;
            for (int i = 0; i<tbltk.Rows.Count; i++)
            {
                sum+=Convert.ToDouble(tbltk.Rows[i][4]);
            }
            txtTongTien.Text=sum.ToString();
            dgvThongKe.DataSource=tbltk;
        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar>='0')&& (e.KeyChar<='9')) || (Convert.ToInt32(e.KeyChar)==8))
            {
                e.Handled=false;
            }
            else e.Handled=true;
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar>='0')&& (e.KeyChar<='9')) || (Convert.ToInt32(e.KeyChar)==8))
            {
                e.Handled=false;
            }
            else e.Handled=true;
        }

        private void txtNgay_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar>='0')&& (e.KeyChar<='9')) || (Convert.ToInt32(e.KeyChar)==8))
            {
                e.Handled=false;
            }
            else e.Handled=true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboMaHang.Text="";
            cboMaKhach.Text="";
            cboMaNhanVien.Text="";
            cboNgay.Text="";
            cboThang.Text="";
            txtNam.Text="";
        }
    }
}

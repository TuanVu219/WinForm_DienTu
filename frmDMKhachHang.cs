using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks.Sources;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Dientu
{
    public partial class frmDMKhachHang : Form
    {
        DataTable tblKH;
        public frmDMKhachHang()
        {
            InitializeComponent();
        }
        private void frmDMKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql="SELECT userid,full_name,address,Phone_number FROM users WHERE user_type_id=2";
            tblKH=Function.GetDataToTable(sql);
            dgvKhachHang.DataSource = tblKH;
            dgvKhachHang.Columns[0].HeaderText="Mã khách hàng";
            dgvKhachHang.Columns[1].HeaderText="Tên khách hàng";
            dgvKhachHang.Columns[2].HeaderText="Địa chỉ";
            dgvKhachHang.Columns[3].HeaderText="Điện thoại";
            dgvKhachHang.Columns[0].Width=100;
            dgvKhachHang.Columns[1].Width=150;
            dgvKhachHang.Columns[2].Width=150;
            dgvKhachHang.Columns[3].Width=100;
            dgvKhachHang.AllowUserToAddRows=false;
            dgvKhachHang.EditMode=DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled==false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhachHang.Focus();
                return;
            }
            if (tblKH.Rows.Count==0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaKhachHang.Text=dgvKhachHang.CurrentRow.Cells["userid"].Value.ToString();
            txtTenKhachHang.Text=dgvKhachHang.CurrentRow.Cells["full_name"].Value.ToString();
            txtDiaChi.Text=dgvKhachHang.CurrentRow.Cells["address"].Value.ToString();
            mtbDienThoai.Text=dgvKhachHang.CurrentRow.Cells["Phone_Number"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled=false;
            btnXoa.Enabled=false;
            btnBoQua.Enabled=true;
            btnLuu.Enabled=true;
            btnThem.Enabled=false;
            ResetValues();
            txtTenKhachHang.Focus();
        }

        private void ResetValues()
        {
            txtTenKhachHang.Text="";
            txtMaKhachHang.Text="";
            txtDiaChi.Text="";
            mtbDienThoai.Text="";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtTenKhachHang.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhachHang.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if (mtbDienThoai.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbDienThoai.Focus();
                return;
            }
            sql="INSERT INTO users(full_name,address,user_type_id,Phone_Number) VALUES (N'"+txtTenKhachHang.Text.Trim()+"',N'"+txtDiaChi.Text.Trim()+"','"+2+"','"+mtbDienThoai.Text+"')";
            Function.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenKhachHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhachHang.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if (mtbDienThoai.Text=="(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbDienThoai.Focus();
                return;
            }
            sql = "UPDATE users SET full_name=N'" + txtTenKhachHang.Text.Trim().ToString() + "',address=N'" +
                txtDiaChi.Text.Trim().ToString() + "',Phone_Number='" + mtbDienThoai.Text.ToString() +
                "' WHERE userid=N'" + txtMaKhachHang.Text + "'";
            Function.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql="SELECT InvoiceId FROM Invoice WHERE Userid=N'"+txtMaKhachHang.Text+"'";
                string MaHD=Function.GetFieldValues(sql);
                sql = "DELETE Invoice_Detail WHERE InvoiceId=N'" + MaHD + "'";
                Function.RunSQL(sql);
                sql = "DELETE Invoice WHERE userid=N'" + txtMaKhachHang.Text + "'";
                Function.RunSQL(sql);
                sql = "DELETE users WHERE userid=N'" + txtMaKhachHang.Text + "'";
                Function.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaKhachHang.Enabled = false;
        }

        private void txtMaKhachHang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

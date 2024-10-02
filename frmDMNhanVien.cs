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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
namespace Dientu
{
    public partial class frmDMNhanVien : Form
    {
        private DataTable tblNV;
        public frmDMNhanVien()
        {
            InitializeComponent();
        }

        private void frmDMNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            txtMaNhanVien.Enabled=false;
            btnLuu.Enabled=false;
            btnXoa.Enabled=false;
            txtMaNhanVien.Enabled =false;
            txtTenNhanVien.Enabled=false;
            txtTenDangNhap.Enabled=false;
            txtDiaChi.Enabled=false;
            mtbDienThoai.Enabled=false;
            dtpNgaySinh.Enabled=false;
            txtMatKhau.Enabled=false;

        }
        private void LoadDataGridView()
        {
            string sql;
            sql="SELECT userid,full_name,Gender,address,Phone_number,DayofBirth,UserName,password FROM users WHERE user_type_id=1 ";
            tblNV=Function.GetDataToTable(sql);
            dgvNhanVien.DataSource = tblNV;
            dgvNhanVien.Columns[0].HeaderText="Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText="Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText="Giới tính";
            dgvNhanVien.Columns[3].HeaderText="Địa chỉ";
            dgvNhanVien.Columns[4].HeaderText="Điện thoại";
            dgvNhanVien.Columns[5].HeaderText="Ngày sinh";
            dgvNhanVien.Columns[6].HeaderText="Tên đăng nhập";
            dgvNhanVien.Columns[7].HeaderText="Mật khẩu";
            dgvNhanVien.Columns[0].Width=100;
            dgvNhanVien.Columns[1].Width=150;
            dgvNhanVien.Columns[2].Width=100;
            dgvNhanVien.Columns[3].Width=150;
            dgvNhanVien.Columns[4].Width=100;
            dgvNhanVien.Columns[5].Width=100;
            dgvNhanVien.Columns[6].Width=100;
            dgvNhanVien.Columns[7].Width=150;
            dgvNhanVien.AllowUserToAddRows=false;
            dgvNhanVien.EditMode=DataGridViewEditMode.EditProgrammatically;

        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            txtTenNhanVien.Enabled=true;
            txtTenDangNhap.Enabled=true;
            txtDiaChi.Enabled=true;
            mtbDienThoai.Enabled=true;
            dtpNgaySinh.Enabled=true;
            txtMatKhau.Enabled=true;
            if (btnThem.Enabled==false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhanVien.Focus();
                return;
            }
            if (tblNV.Rows.Count==0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNhanVien.Text=dgvNhanVien.CurrentRow.Cells["userid"].Value.ToString();
            txtTenNhanVien.Text=dgvNhanVien.CurrentRow.Cells["full_name"].Value.ToString();
            if (dgvNhanVien.CurrentRow.Cells["Gender"].Value.ToString()=="Nam")
                chkGioitinh.Checked=true;
            else chkGioitinh.Checked=false;
            txtDiaChi.Text=dgvNhanVien.CurrentRow.Cells["address"].Value.ToString();
            mtbDienThoai.Text=dgvNhanVien.CurrentRow.Cells["Phone_Number"].Value.ToString();
            dtpNgaySinh.Text=dgvNhanVien.CurrentRow.Cells["DayofBirth"].Value.ToString();
            txtTenDangNhap.Text=dgvNhanVien.CurrentRow.Cells["UserName"].Value.ToString();
            txtMatKhau.Text=dgvNhanVien.CurrentRow.Cells["password"].Value.ToString();
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
            txtMaNhanVien.Enabled=false;
            txtTenNhanVien.Focus();
            txtTenNhanVien.Enabled=true;
            txtTenDangNhap.Enabled=true;
            txtDiaChi.Enabled=true;
            mtbDienThoai.Enabled=true;
            dtpNgaySinh.Enabled=true;
            txtMatKhau.Enabled=true;
        }

        private void ResetValues()
        {

            txtMaNhanVien.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text="";
            txtTenNhanVien.Text = "";
            chkGioitinh.Checked = false;
            txtDiaChi.Text = "";
            dtpNgaySinh.Text = DateTime.Now.ToString();
            mtbDienThoai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;

            }
            if (mtbDienThoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbDienThoai.Focus();
                return;
            }
            if (dtpNgaySinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            string hashedPassword = HashPassword(txtMatKhau.Text);
            if (chkGioitinh.Checked == true)
            {
                gt="Nam";
            }
            else
            {
                gt="Nữ";
            }
            sql="INSERT INTO users(full_name,Gender,address,user_type_id,Phone_Number,DayofBirth,UserName,password) VALUES (N'"+txtTenNhanVien.Text.Trim()+"',N'"+gt+"',N'"+txtDiaChi.Text.Trim()+"','"+1+"','"+mtbDienThoai.Text+"','"+dtpNgaySinh.Value+"','"+txtTenDangNhap.Text+"','"+hashedPassword+"')";
            Function.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNhanVien.Enabled = false;
        }
        public static string HashPassword(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNhanVien.Text=="")
            {
                MessageBox.Show("Bạn chưa có bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNhanVien.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;

            }
            if (mtbDienThoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbDienThoai.Focus();
                return;
            }
            if (dtpNgaySinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            string hashedPassword = HashPassword(txtMatKhau.Text);

            if (chkGioitinh.Checked == true)
            {
                gt="Nam";
            }
            else
            {
                gt="Nữ";
            }
            sql="UPDATE users SET full_name=N'"+txtTenNhanVien.Text+"',address='"+txtDiaChi.Text+"',Gender=N'"+gt+"',DayofBirth='"+dtpNgaySinh.Value+"',UserName='"+txtTenDangNhap.Text+"',password='"+hashedPassword+"' WHERE userid=N'"+txtMaNhanVien.Text+"'";
            Function.RunSQL(sql);
            MessageBox.Show("Update thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count==0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNhanVien.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql="SELECT InvoiceId FROM Invoice WHERE EmployId=N'"+txtMaNhanVien.Text+"'";
                string MaHD = Function.GetFieldValues(sql);
                sql = "DELETE Invoice_Detail WHERE InvoiceId=N'" + MaHD + "'";
                Function.RunSQL(sql);
                sql = "DELETE Invoice WHERE EmployId=N'" + txtMaNhanVien.Text + "'";
                Function.RunSQL(sql);
                sql="DELETE users WHERE userid=N'"+txtMaNhanVien.Text+"'";
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
            txtMaNhanVien.Enabled = false;
            txtTenDangNhap.Enabled=false;
            txtDiaChi.Enabled=false;
            mtbDienThoai.Enabled=false;
            dtpNgaySinh.Enabled=false;
            txtMatKhau.Enabled=false;
        }

        private void txtMaNhanVien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private bool ContainsVietnameseChars(string input)
        {
            string vietnameseChars = "àáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ";

            foreach (char c in input)
            {
                if (vietnameseChars.Contains(c))
                    return true;
            }
            return false;
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if (ContainsVietnameseChars(txtTenDangNhap.Text))
            {
                MessageBox.Show("Tên đăng nhập không được chứa dấu tiếng Việt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Text = "";
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (ContainsVietnameseChars(txtTenDangNhap.Text))
            {
                MessageBox.Show("Mật khẩu không được chứa dấu tiếng Việt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Text = "";
            }
        }
    }
}

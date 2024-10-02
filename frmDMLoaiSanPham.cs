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
using Microsoft.VisualBasic;
namespace Dientu
{
    public partial class frmDMLoaiSanPham : Form
    {
        DataTable tblCL;
        public frmDMLoaiSanPham()
        {
            InitializeComponent();
        }
        private void frmDMLoaiSanPham_Load(object sender, EventArgs e)
        {
            txtMaLoaiSanPham.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql="SELECT CategoryId, CategoryName FROM Category ";
            tblCL=Function.GetDataToTable(sql);
            dgvLoaiSanPham.DataSource=tblCL;// Nguồn dữ liệu
            dgvLoaiSanPham.Columns[0].HeaderText="Mã nhãn hàng";
            dgvLoaiSanPham.Columns[1].HeaderText="Tên nhãn hàng";
            dgvLoaiSanPham.Columns[0].Width=100;
            dgvLoaiSanPham.Columns[1].Width=300;
            dgvLoaiSanPham.AllowUserToAddRows= false;
            dgvLoaiSanPham.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled==false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLoaiSanPham.Focus();
                return;
            }
            if (tblCL.Rows.Count==0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            txtMaLoaiSanPham.Text=dgvLoaiSanPham.CurrentRow.Cells["CategoryId"].Value.ToString();
            txtTenLoaiSanPham.Text=dgvLoaiSanPham.CurrentRow.Cells["CategoryName"].Value.ToString();
            btnSua.Enabled=true;
            btnXoa.Enabled=true;
            btnBoQua.Enabled=true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled=false;
            btnXoa.Enabled=false;
            btnBoQua.Enabled=true;
            btnLuu.Enabled=true;
            btnThem.Enabled=false;
            ResetValue();
            txtTenLoaiSanPham.Focus();
        }

        private void ResetValue()
        {
            txtMaLoaiSanPham.Text="";
            txtTenLoaiSanPham.Text="";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtTenLoaiSanPham.Text.Trim().Length==0) //Kiểm tra xem đã nhập chưa
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoaiSanPham.Focus();
                return;
            }
            sql = "INSERT INTO CATEGORY(CategoryName) VALUES(N'" + txtTenLoaiSanPham.Text + "')";
            Function.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled=true;
            btnBoQua.Enabled=false;
            btnLuu.Enabled=false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCL.Rows.Count==0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLoaiSanPham.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenLoaiSanPham.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn chưa nhập loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sql="UPDATE Category SET CategoryName=N'"+txtTenLoaiSanPham.Text.ToString()+"'WHERE CategoryId=N'"+txtMaLoaiSanPham.Text+"'";
            Function.RunSQL(sql);
            LoadDataGridView();
            btnBoQua.Enabled=false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCL.Rows.Count==0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLoaiSanPham.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                sql="DELETE Category WHERE CategoryId=N'"+txtMaLoaiSanPham.Text+"'";
                Function.RunSQL(sql);
                LoadDataGridView();
                btnBoQua.Enabled=false;
            }

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaLoaiSanPham.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaLoaiSanPham_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNhanHang_Click(object sender, EventArgs e)
        {

        }
    }
}

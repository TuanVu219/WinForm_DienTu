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
using System.Security.Cryptography;
namespace Dientu
{
    public partial class frmDMHangHoa : Form
    {
        DataTable tblH;
        public frmDMHangHoa()
        {
            InitializeComponent();
        }

        private void frmDMHangHoa_Load(object sender, EventArgs e)
        {
            string sql;
            sql="SELECT* from Category";
            btnLuu.Enabled=false;
            btnBoQua.Enabled=false;
            LoadDataGridView();
            Function.FillCombo(sql, cboMaLoaiSanPham, "CategoryId", "CategoryName");
            cboMaLoaiSanPham.SelectedIndex = -1;
            ResetValues();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from Product";
            tblH = Function.GetDataToTable(sql);
            dgvHangHoa.DataSource = tblH;
            dgvHangHoa.Columns[0].HeaderText = "Mã hàng";
            dgvHangHoa.Columns[1].HeaderText = "Tên hàng";
            dgvHangHoa.Columns[2].HeaderText = "Mã nhãn hàng";
            dgvHangHoa.Columns[3].HeaderText = "Số lượng";
            dgvHangHoa.Columns[4].HeaderText = "Đơn giá bán";
            dgvHangHoa.Columns[5].HeaderText = "Ảnh";
            dgvHangHoa.Columns[6].HeaderText = "Ghi chú";
            dgvHangHoa.Columns[0].Width = 80;
            dgvHangHoa.Columns[1].Width = 140;
            dgvHangHoa.Columns[2].Width = 80;
            dgvHangHoa.Columns[3].Width = 80;
            dgvHangHoa.Columns[4].Width = 100;
            dgvHangHoa.Columns[5].Width = 200;
            dgvHangHoa.Columns[6].Width = 300;
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtMaHang.Text="";
            txtTenHang.Text="";
            cboMaLoaiSanPham.Text="";
            txtSoLuong.Text="";
            txtDonGiaBan.Text="";
            txtSoLuong.Enabled=true;
            txtDonGiaBan.Enabled=true;
            txtAnh.Text="";
            picAnh.Image=null;
            txtGhiChu.Text="";

        }

        private void dgvHangHoa_Click(object sender, EventArgs e)
        {
            string sql, MaChatLieu;
            if (btnThem.Enabled==false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
                return;
            }
            if (tblH.Rows.Count==0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaHang.Text=dgvHangHoa.CurrentRow.Cells["ProductId"].Value.ToString();
            txtTenHang.Text=dgvHangHoa.CurrentRow.Cells["ProductName"].Value.ToString();
            MaChatLieu=dgvHangHoa.CurrentRow.Cells["CategoryId"].Value.ToString();
            sql="SELECT CategoryName FROM Category WHERE CategoryId=N'"+MaChatLieu+"'";
            cboMaLoaiSanPham.Text=Function.GetFieldValues(sql);
            txtSoLuong.Text=dgvHangHoa.CurrentRow.Cells["Amount"].Value.ToString();
            txtDonGiaBan.Text=dgvHangHoa.CurrentRow.Cells["Price"].Value.ToString();
            sql = "SELECT Img FROM Product WHERE ProductId=N'" + txtMaHang.Text + "'";
            txtAnh.Text = dgvHangHoa.CurrentRow.Cells["Img"].Value.ToString();
            picAnh.Image = Image.FromFile(txtAnh.Text);
            txtGhiChu.Text = dgvHangHoa.CurrentRow.Cells["Note"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;

        }

        private void a(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHang.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtTenHang.Focus();
            txtSoLuong.Enabled = true;
            txtDonGiaBan.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
                return;
            }
            if (cboMaLoaiSanPham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaLoaiSanPham.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOpen.Focus();
                return;
            }

            sql = "INSERT INTO Product(ProductName, CategoryId, Amount, Price, Img, Note) VALUES(N'"
       + txtTenHang.Text.Trim() + "',N'" +
       cboMaLoaiSanPham.SelectedValue.ToString() +
       "'," + txtSoLuong.Text.Trim() + "," + txtDonGiaBan.Text +
       ",'" + txtAnh.Text + "',N'" + txtGhiChu.Text.Trim() + "')";
            Function.RunSQL(sql);
            LoadDataGridView();
            //ResetValues();
            btnXoa.Enabled=true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaHang.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();

            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|PNG(*.png)|*.png|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh họa cho sản phẩm";

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
                return;
            }
            if (cboMaLoaiSanPham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaLoaiSanPham.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnh.Focus();
                return;
            }
            sql = "UPDATE Product SET ProductName=N'" + txtTenHang.Text.Trim().ToString() +
                "',CategoryId=N'" + cboMaLoaiSanPham.SelectedValue.ToString() +
                "',Amount="+txtSoLuong.Text+
                ",Img='" + txtAnh.Text + "',Note=N'" + txtGhiChu.Text +"' WHERE ProductId=N'" + txtMaHang.Text + "'";
            Function.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql="DELETE Invoice_Detail WHERE ProductId=N'"+txtMaHang.Text+"'";
                Function.RunSQL(sql);
                sql = "DELETE Product WHERE ProductId=N'" + txtMaHang.Text + "'";
                Function.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
          
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaHang.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtTenHang.Text=="") && (txtMaHang.Text=="")&&(cboMaLoaiSanPham.Text==""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql="SELECT * from Product WHERE 1=1";
            if (txtMaHang.Text!="")
                sql+="AND ProductId LIKE N'%"+txtMaHang.Text+"%'";
            if (txtTenHang.Text!="")
                sql+="AND ProductName LIKE N'%"+txtTenHang.Text+"%'";
            if (cboMaLoaiSanPham.Text!="")
                sql+="AND CategoryId LIKE N'%"+cboMaLoaiSanPham.SelectedValue+"%'";
            tblH=Function.GetDataToTable(sql);
            if (tblH.Rows.Count==0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Có"+tblH.Rows.Count+"Bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvHangHoa.DataSource=tblH;
            ResetValues();
        }

        private void btnHienThiDS_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanHang_Click(object sender, EventArgs e)
        {
            frmDMLoaiSanPham frm = new frmDMLoaiSanPham();
            frm.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetValues();
        }
    }
}


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
using COMExcel = Microsoft.Office.Interop.Excel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.VisualBasic.ApplicationServices;
namespace Dientu
{
    public partial class frmHoaDonBan : Form
    {
        private int _employid=0;
        DataTable tblCTHDB;
        public frmHoaDonBan()
        {
            InitializeComponent();
        }
        public frmHoaDonBan(int employid)
        {
            InitializeComponent();
            _employid=employid;
        }

        // Nạp dữ liệu
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.ProductId, b.ProductName, a.Amount, b.Price, a.Voucher,a.Price AS ThanhTien" +
                " FROM Invoice_Detail AS a, Product AS b" +
                " WHERE a.InvoiceId = N'" + txtMaHDBan.Text + "' AND a.ProductId=b.ProductId";
            tblCTHDB = Function.GetDataToTable(sql);
            dgvHDBanHang.DataSource = tblCTHDB;
            dgvHDBanHang.Columns[0].HeaderText = "Mã hàng";
            dgvHDBanHang.Columns[1].HeaderText = "Tên hàng";
            dgvHDBanHang.Columns[2].HeaderText = "Số lượng";
            dgvHDBanHang.Columns[3].HeaderText = "Đơn giá";
            dgvHDBanHang.Columns[4].HeaderText = "Giảm giá";
            dgvHDBanHang.Columns[5].HeaderText = "Thành tiền";
            dgvHDBanHang.Columns[0].Width = 80;
            dgvHDBanHang.Columns[1].Width = 130;
            dgvHDBanHang.Columns[2].Width = 80;
            dgvHDBanHang.Columns[3].Width = 90;
            dgvHDBanHang.Columns[4].Width = 90;
            dgvHDBanHang.Columns[5].Width = 90;
            dgvHDBanHang.AllowUserToAddRows = false;
            dgvHDBanHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            dtpNgayBan.Enabled=false;
            cboMaNhanVien.Enabled=false;
            cboMaKhach.Enabled=false;
            cboMaHang.Enabled=false;
            txtSoLuong.Enabled=false;
            txtGiamGia.Enabled=false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnInHoaDon.Enabled = false;
            txtMaHDBan.ReadOnly = true;
            txtTenNhanVien.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            mtbDienThoai.ReadOnly = true;
            txtTenHang.ReadOnly = true;
            txtDonGiaBan.ReadOnly = false;
            txtThanhTien.ReadOnly = false;
            txtTongTien.ReadOnly = true;
            txtGiamGia.Text = "0";
            txtTongTien.Text = "0";
            cboMaNhanVien.Text="";
            cboMaKhach.Text="";
            Function.FillCombo("SELECT userid, full_name FROM users WHERE user_type_id=2", cboMaKhach, "userid", "userid");
            cboMaKhach.SelectedIndex = -1;
            if (_employid!=0)
            {
                cboMaNhanVien.Text=_employid.ToString();
                string sql="SELECT full_name FROM users WHERE userid=N'"+cboMaNhanVien.Text+"'";
                txtTenNhanVien.Text=Function.GetFieldValues(sql);

            }
            else
            {
                Function.FillCombo("SELECT userid, full_name FROM users WHERE user_type_id=1", cboMaNhanVien, "userid", "userid");
                cboMaNhanVien.SelectedIndex = -1;
            }
            Function.FillCombo("SELECT ProductId, ProductName FROM Product", cboMaHang, "ProductId", "ProductId");
            cboMaHang.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtMaHDBan.Text != "")
            {
                LoadInfoHoaDon();
                btnXoa.Enabled = true;
                btnInHoaDon.Enabled = true;
            }
            LoadDataGridView();
        }
        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT Invoice_Date FROM Invoice WHERE InvoiceId = N'" + txtMaHDBan.Text + "'";
            dtpNgayBan.Text = Function.GetFieldValues(str);
            str = "SELECT EmployId FROM Invoice WHERE InvoiceId = N'" + txtMaHDBan.Text + "'";
            cboMaNhanVien.Text = Function.GetFieldValues(str);
            str = "SELECT UserId FROM Invoice WHERE InvoiceId = N'" + txtMaHDBan.Text + "'";
            cboMaKhach.Text = Function.GetFieldValues(str);
            str = "SELECT TotalPrice FROM Invoice WHERE InvoiceId = N'" + txtMaHDBan.Text + "'";
            txtTongTien.Text = Function.GetFieldValues(str);
            lblBangChu.Text = "Bằng chữ: " + Function.ChuyenSoSangChuoi(Double.Parse(txtTongTien.Text));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtDonGiaBan.Enabled=false;
            txtDiaChi.ReadOnly = false;
            mtbDienThoai.ReadOnly = false;
            txtTenKhach.ReadOnly = false;
            txtThanhTien.Enabled=false;
            mtbDienThoai.Enabled=true;
            cboMaNhanVien.Enabled=true;
            cboMaKhach.Enabled=true;
            cboMaHang.Enabled=true;
            txtSoLuong.Enabled=true;
            txtGiamGia.Enabled=true;
            btnXoa.Enabled = false;
            dtpNgayBan.Enabled=false;
            btnLuu.Enabled = true;
            btnInHoaDon.Enabled = false;
            btnThem.Enabled = false;

            ResetValues();
            txtMaHDBan.Text = Function.CreateKey("HDB");
            LoadDataGridView();
        }
        private void ResetValues()
        {
            cboMaHang.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
            txtTenHang.Text="";
            txtDonGiaBan.Text="";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT InvoiceId FROM Invoice WHERE InvoiceId=N'" + txtMaHDBan.Text + "'";
            if (!Function.CheckKey(sql))
            {
                if (cboMaNhanVien.Text.Length==0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaNhanVien.Focus();
                    return;
                }
                if (cboMaKhach.Text.Length == 0 && txtTenKhach.Text=="")
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenKhach.Focus();
                    return;
                }
                if (txtDiaChi.Text=="")
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDiaChi.Focus();
                    return;
                }
                if (mtbDienThoai.Text=="")
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDiaChi.Focus();
                    return;
                }
                if (cboMaKhach.Text=="" && txtTenKhach.Text!="")
                {
                    sql = "INSERT INTO users(full_name,address,user_type_id,Phone_Number) VALUES (N'" + txtTenKhach.Text.Trim() + "', N'" + txtDiaChi.Text.Trim() + "','" + 2 + "','" + mtbDienThoai.Text + "')";
                    Function.RunSQL(sql);

                    // Lấy userid mới được tạo
                    sql = "SELECT @@IDENTITY";
                    string userId = Function.GetFieldValues(sql);

                    if (_employid!=0)
                    {
                        sql = "INSERT INTO Invoice(InvoiceId, Invoice_Date, EmployId, Userid, TotalPrice) VALUES (N'" + txtMaHDBan.Text.Trim() + "', '" +
                        dtpNgayBan.Text.Trim() + "', N'" + cboMaNhanVien.Text + "', N'" + userId + "', " + txtTongTien.Text + ")";
                        Function.RunSQL(sql);

                    }
                    else
                    {
                        // Tiếp tục thêm hóa đơn với userid mới
                        sql = "INSERT INTO Invoice(InvoiceId, Invoice_Date, EmployId, Userid, TotalPrice) VALUES (N'" + txtMaHDBan.Text.Trim() + "', '" +
                            dtpNgayBan.Text.Trim() + "', N'" + cboMaNhanVien.SelectedValue + "', N'" + userId + "', " + txtTongTien.Text + ")";
                        Function.RunSQL(sql);
                    }
                }
                else if (cboMaKhach.Text!="")
                {
                    if (_employid!=0)
                    {
                        sql = "INSERT INTO Invoice(InvoiceId, Invoice_Date, EmployId, Userid, TotalPrice) VALUES (N'" + txtMaHDBan.Text.Trim() + "', '" +
                        dtpNgayBan.Text.Trim() + "', N'" + cboMaNhanVien.Text + "', N'" + cboMaKhach.SelectedValue + "', " + txtTongTien.Text + ")";
                        Function.RunSQL(sql);

                    }
                    else
                    {
                        // Tiếp tục thêm hóa đơn với userid mới
                        sql = "INSERT INTO Invoice(InvoiceId, Invoice_Date, EmployId, Userid, TotalPrice) VALUES (N'" + txtMaHDBan.Text.Trim() + "', '" +
                            dtpNgayBan.Text.Trim() + "', N'" + cboMaNhanVien.SelectedValue + "', N'" + cboMaKhach.SelectedValue + "', " + txtTongTien.Text + ")";
                        Function.RunSQL(sql);
                    }
                }
        }
            if (cboMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHang.Focus();
                return;
            }
            if ((txtSoLuong.Text.Trim().Length == 0) || (txtSoLuong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            sql="SELECT ProductId FROM Invoice_Detail WHERE ProductId=N'"+cboMaHang.SelectedValue+"'AND InvoiceId=N'"+txtMaHDBan.Text.Trim()+"'";

            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cboMaHang.Focus();
                return;
            }
            sl=Convert.ToDouble(Function.GetFieldValues("SELECT Amount FROM Product WHERE ProductId=N'"+cboMaHang.SelectedValue +"'"));
            if (Convert.ToDouble(txtSoLuong.Text)>sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            double totalPriceInWord = Convert.ToDouble(txtThanhTien.Text); // giả định txtThanhTien.Text chứa giá trị số
            string priceInWord = Function.ChuyenSoSangChuoi(totalPriceInWord);
            sql="INSERT INTO Invoice_Detail(InvoiceId,ProductId,Amount,Price,Voucher) VALUES (N'"+txtMaHDBan.Text.Trim()+"',N'"+cboMaHang.SelectedValue+"'," + txtSoLuong.Text +"," + txtThanhTien.Text+  ","+  txtGiamGia.Text  +")";
            Function.RunSQL(sql);
            LoadDataGridView();

            //Cập nhật lại số lượng
            SLcon=sl-Convert.ToDouble(txtSoLuong.Text);
            sql="UPDATE Product SET Amount="+SLcon+"WHERE ProductId =N'"+cboMaHang.SelectedValue+"'";
            Function.RunSQL(sql);
            //Cập nhật lại tổng tiền cho hóa đơn bán
            tong=Convert.ToDouble(Function.GetFieldValues("SELECT TotalPrice FROM Invoice WHERE InvoiceId=N'"+txtMaHDBan.Text+"'"));
            Tongmoi=tong+Convert.ToDouble(txtThanhTien.Text);
            sql="UPDATE Invoice SET TotalPrice="+Tongmoi+"WHERE InvoiceId =N'"+txtMaHDBan.Text+"'";
            Function.RunSQL(sql);
            txtTongTien.Text=Tongmoi.ToString();
            lblBangChu.Text = "Bằng chữ: " + Function.ChuyenSoSangChuoi(Double.Parse(Tongmoi.ToString()));
            ResetValuesHang();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnInHoaDon.Enabled = true;

        }

        private void ResetValuesHang()
        {
            cboMaHang.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
            txtTenHang.Text="";
            txtDonGiaBan.Text="";
        }

        private void cboMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenNhanVien.Text="";
            DataRowView drv = cboMaNhanVien.SelectedItem as DataRowView; // Lấy đối tượng DataRowView từ combobox
            if (drv != null)
            {
                string userId = drv.Row["userid"].ToString(); // Lấy giá trị của trường userid từ đối tượng DataRowView
                string sql = "SELECT full_name FROM users WHERE userid = '" + userId + "'";
                txtTenNhanVien.Text = Function.GetFieldValues(sql); // Hiển thị tên khách hàng trong TextBox
            }

        }

        private void cboMaKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenKhach.Text="";
            txtDiaChi.Text="";
            mtbDienThoai.Text="";
            DataRowView drv = cboMaKhach.SelectedItem as DataRowView; // Lấy đối tượng DataRowView từ combobox
            if (drv != null)
            {
                txtDiaChi.ReadOnly=true;
                mtbDienThoai.ReadOnly=true;
                string userId = drv.Row["userid"].ToString(); // Lấy giá trị của trường userid từ đối tượng DataRowView
                string sql = "SELECT full_name FROM users WHERE userid = '" + userId + "'";
                txtTenKhach.Text = Function.GetFieldValues(sql); // Hiển thị tên khách hàng trong TextBox
                sql = "SELECT address FROM users WHERE userid = '" + userId + "'";
                txtDiaChi.Text = Function.GetFieldValues(sql);
                sql = "SELECT Phone_Number FROM users WHERE userid = '" + userId + "'";
                mtbDienThoai.Text = Function.GetFieldValues(sql);

            }


        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenHang.Text ="";
            txtDonGiaBan.Text ="";
            DataRowView drv = cboMaHang.SelectedItem as DataRowView;
            if (drv != null)
            {
                string ProductId = drv.Row["ProductId"].ToString();
                string sql = "SELECT ProductName FROM Product WHERE ProductId = '" + ProductId + "'";
                txtTenHang.Text = Function.GetFieldValues(sql);
                sql = "SELECT Price FROM Product WHERE ProductId = '" + ProductId + "'";
                txtDonGiaBan.Text = Function.GetFieldValues(sql);
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);

            if (txtDonGiaBan.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaBan.Text);
            tt = sl * dg;
            txtThanhTien.Text = tt.ToString();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGiaBan.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaBan.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }

        private void dgvHDBanHang_Click(object sender, EventArgs e)
        {
            cboMaHang.Enabled = false;
            txtDonGiaBan.Enabled=false;
            txtThanhTien.Enabled=false;
            string sql, MaChatLieu;
            if (btnThem.Enabled==false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
                return;
            }
            if (tblCTHDB.Rows.Count==0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cboMaHang.Text=dgvHDBanHang.CurrentRow.Cells["ProductId"].Value.ToString();
            txtTenHang.Text=dgvHDBanHang.CurrentRow.Cells["ProductName"].Value.ToString();
            txtDonGiaBan.Text=dgvHDBanHang.CurrentRow.Cells["Price"].Value.ToString();
            txtSoLuong.Text=dgvHDBanHang.CurrentRow.Cells["Amount"].Value.ToString();
            txtGiamGia.Text=dgvHDBanHang.CurrentRow.Cells["Voucher"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            double tong;
            string sql, gt;
            if (tblCTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboMaHang.Text=="")
            {
                MessageBox.Show("Bạn chưa có bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSoLuong.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }

            double slsua, tongsl, slxoa, slupdate;
            sql="SELECT Amount FROM Product WHERE ProductId=N'"+cboMaHang.SelectedValue+"'";
            tongsl=Convert.ToDouble(Function.GetFieldValues(sql));
            sql="SELECT Amount FROM Invoice_Detail WHERE InvoiceId=N'"+txtMaHDBan.Text+"'AND ProductId=N'"+cboMaHang.SelectedValue+"'";
            slxoa=Convert.ToDouble(Function.GetFieldValues(sql));
            slsua=Convert.ToDouble(txtSoLuong.Text);
            slupdate=tongsl+slxoa-slsua;
            sql="UPDATE Product SET Amount='"+slupdate+"' WHERE ProductId=N'"+cboMaHang.SelectedValue+"'";
            Function.RunSQL(sql);

            sql="UPDATE Invoice_Detail SET Amount='"+txtSoLuong.Text+"',Voucher='"+txtGiamGia.Text+"',Price='"+txtThanhTien.Text+"' WHERE InvoiceId=N'"+txtMaHDBan.Text+"' AND ProductId='"+cboMaHang.SelectedValue+"'";
            Function.RunSQL(sql);
            MessageBox.Show("Update thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            double total = 0;
            sql = "SELECT SUM(CAST(Price AS FLOAT)) FROM Invoice_Detail WHERE InvoiceId = N'" + txtMaHDBan.Text + "'";
            string result = Function.GetFieldValues(sql);
            if (!string.IsNullOrEmpty(result))
            {
                total = Convert.ToDouble(result);
            }
            txtTongTien.Text = total.ToString();
            sql="UPDATE Invoice SET TotalPrice='"+txtTongTien.Text+"' WHERE InvoiceId=N'"+txtMaHDBan.Text+"'";
            Function.GetFieldValues(sql);




            lblBangChu.Text = "Bằng chữ: " + Function.ChuyenSoSangChuoi(Double.Parse(txtTongTien.Text));
            LoadDataGridView();
            ResetValues();
        }

        private void cboMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMaHD_DropDown(object sender, EventArgs e)
        {
            Function.FillCombo("SELECT InvoiceId FROM Invoice", cboMaHD, "InvoiceId", "InvoiceId");
            cboMaHD.SelectedIndex=-1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboMaHD.Text=="")
            {
                MessageBox.Show("Bạn phải chọn một hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHD.Focus();
                return;
            }
            txtMaHDBan.Text= cboMaHD.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            btnXoa.Enabled=true;
            btnLuu.Enabled=true;
            btnInHoaDon.Enabled=true;
            cboMaHD.SelectedValue=-1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (txtMaHDBan.Text=="")
            {
                MessageBox.Show("Chọn hóa đơn muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT ProductId, Amount FROM Invoice_Detail WHERE InvoiceId=N'"+cboMaHD.Text+"'";
                DataTable tblHang = Function.GetDataToTable(sql);
                for (int hang = 0; hang<=tblHang.Rows.Count-1; hang++)
                {
                    sl=Convert.ToDouble(Function.GetFieldValues("SELECT Amount FROM Product WHERE InvoiceId=N'"+tblHang.Rows[hang][0].ToString()+"'"));
                    slxoa=Convert.ToDouble(tblHang.Rows[hang][1].ToString());
                    slcon=sl+slxoa;
                    sql="UPDATE Product SET Amount="+slcon+ " WHERE ProductId=N'"+tblHang.Rows[hang][0].ToString()+"'";
                    Function.RunSQL(sql);
                }
                sql = "DELETE Invoice_Detail WHERE InvoiceId=N'" + txtMaHDBan.Text + "'";
                Function.RunSQL(sql);

                sql = "DELETE Invoice WHERE InvoiceId=N'" + txtMaHDBan.Text + "'";
                Function.RunSQL(sql);
                ResetValues();
                LoadDataGridView();
                btnXoa.Enabled = false;
                btnInHoaDon.Enabled = false;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar>='0')&& (e.KeyChar<='9')) || (Convert.ToInt32(e.KeyChar)==8))
            {
                e.Handled=false;
            }
            else e.Handled=true;
        }

        private void dgvHDBanHang_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (tblCTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                // Xóa hàng và cập nhật lại số lượng
                MaHangxoa=dgvHDBanHang.CurrentRow.Cells["ProductId"].Value.ToString();
                SoLuongxoa=Convert.ToDouble(dgvHDBanHang.CurrentRow.Cells["Amount"].Value.ToString());
                ThanhTienxoa=Convert.ToDouble(dgvHDBanHang.CurrentRow.Cells["ThanhTien"].Value.ToString());
                sql="DELETE Invoice_Detail WHERE InvoiceId=N'"+txtMaHDBan.Text+"'AND ProductId=N'"+MaHangxoa+"'";
                Function.RunSQL(sql);

                // Cập nhật lại số lượng mặt hàng
                sl = Convert.ToDouble(Function.GetFieldValues("SELECT Amount FROM Product WHERE ProductId = N'" + MaHangxoa + "'"));
                slcon=sl+SoLuongxoa;
                sql = "UPDATE Product SET Amount =" + slcon + " WHERE ProductId= N'" +  MaHangxoa + "'";
                Function.RunSQL(sql);

                // Cập nhật lại tổng tiền cho đơn hàng
                tong = Convert.ToDouble(Function.GetFieldValues("SELECT TotalPrice FROM Invoice WHERE InvoiceId = N'" + txtMaHDBan.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE Invoice SET TotalPrice =" + tongmoi + " WHERE InvoiceId = N'" + txtMaHDBan.Text + "'";
                Function.RunSQL(sql);
                txtTongTien.Text = tongmoi.ToString();
                lblBangChu.Text = "Bằng chữ: " + Function.ChuyenSoSangChuoi(Convert.ToDouble(tongmoi.ToString()));
                LoadDataGridView();
            }


        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Shop T.V.";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Bách Khoa - Đà Nẵng";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)38526419";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.InvoiceId, a.Invoice_Date, a.TotalPrice, b.full_name, b.address, b.Phone_Number , c.full_name" +
                " FROM Invoice AS a, users AS b, users AS c " +
                "WHERE a.InvoiceId = N'" + txtMaHDBan.Text + "' AND a.Userid = b.userid AND a.EmployId = c.userid";
            tblThongtinHD = Function.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][2].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.ProductName, a.Amount, b.Price, a.Voucher, a.Price " +
                  "FROM Invoice_Detail AS a , Product AS b WHERE a.InvoiceId = N'" +
                  txtMaHDBan.Text + "' AND a.ProductId = b.ProductId";
            tblThongtinHang = Function.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + Function.ChuyenSoSangChuoi(Convert.ToDouble(tblThongtinHD.Rows[0][2].ToString()));
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Đà Nẵng, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }

        private void frmHoaDonBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Xóa dữ liệu trong các điều khiển trước khi đóng Form
            ResetValues();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenKhach_TextChanged(object sender, EventArgs e)
        {
            if (txtTenKhach.Text!="" && cboMaKhach.Text=="")
            {
                cboMaKhach.Enabled=false;

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboMaKhach.Text="";
            cboMaNhanVien.Text="";
            txtTenKhach.Text="";
            txtDiaChi.Text="";
            mtbDienThoai.Text="";
        }
    }
}

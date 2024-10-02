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
using System.Security.Cryptography;
namespace Dientu
{
    public partial class frmLogin : Form
    {
        private DataTable tblDN;
        public frmLogin()
        {
            InitializeComponent();
           txtMatKhau.PasswordChar = '*';
            this.AcceptButton=btnDangNhap;
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
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Enter UserName and Password");
            }
            else
            {
                try
                {
                    string sql;
                    sql="SELECT UserName,password,user_type_id,userid FROM users WHERE UserName='" + txtTaiKhoan.Text + "'";
                    tblDN= Function.GetDataToTable(sql);
                    if (tblDN.Rows.Count > 0)
                    {
                        string hashedPassword = HashPassword(txtMatKhau.Text);
                        if (tblDN.Rows[0]["password"].ToString() == hashedPassword)
                        {
                            // Đăng nhập thành công
                            // Tiếp tục xử lý ở đây
                            
                            if (Convert.ToInt32(tblDN.Rows[0]["user_type_id"])==1)
                            {
                                int employid = Convert.ToInt32(tblDN.Rows[0]["userid"]);
                                frmNhanVien frm = new frmNhanVien(employid);
                                frm.Show();
                                this.Hide();
                            }
                            else if (Convert.ToInt32(tblDN.Rows[0]["user_type_id"])==3)
                            {
                                frmMain frm = new frmMain();
                                frm.Show();
                                this.Hide();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong UserName or Password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Function.Connect();
        }
    }
}

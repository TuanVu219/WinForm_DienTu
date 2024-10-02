using System.Numerics;
using System.Runtime.InteropServices;

namespace Dientu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {

            InitializeComponent();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Function.Disconnect();
            Application.Exit();
        }

        private void mnuLoaiSanPham_Click(object sender, EventArgs e)
        {
            frmDMLoaiSanPham frm = new frmDMLoaiSanPham();
            frm.ShowDialog();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHangHoa frm = new frmDMHangHoa();
            frm.ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frm = new frmDMNhanVien();
            frm.ShowDialog();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frm = new frmDMKhachHang();
            frm.ShowDialog();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frm = new frmHoaDonBan();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Function.Connect();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatistic frm = new frmStatistic();
            frm.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm=new frmLogin();
            frm.Show();
            this.Hide();    
        }
    }
}

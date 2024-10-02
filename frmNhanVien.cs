using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dientu
{
    public partial class frmNhanVien : Form
    {
        private int _employid;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        public frmNhanVien(int employid)
        {
            InitializeComponent();
            _employid = employid;
        }



        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frm = new frmDMKhachHang();
            frm.Show();

        }

        private void tênNhãnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMLoaiSanPham frm = new frmDMLoaiSanPham();
            frm.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMHangHoa frm = new frmDMHangHoa();
            frm.Show();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frm = new frmHoaDonBan(_employid);
            frm.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatistic frm = new frmStatistic();
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            khoa frKhoa = new khoa();
            frKhoa.MdiParent = this;
            frKhoa.StartPosition = FormStartPosition.Manual;
            frKhoa.Location = new Point(150, 0);
            frKhoa.Show();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            sinhVien sv = new sinhVien();
            sv.MdiParent = this;
            sv.StartPosition = FormStartPosition.Manual;
            sv.Location = new Point(170, 20);
            sv.Show();
        }

        private void btnDeTai_Click(object sender, EventArgs e)
        {
            deTai dt = new deTai();
            dt.MdiParent = this;
            dt.StartPosition = FormStartPosition.Manual;
            dt.Location = new Point(190, 40);
            dt.Show();
        }
            
        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            giangVien gv = new giangVien();
            gv.MdiParent = this;
            gv.StartPosition = FormStartPosition.Manual;
            gv.Location = new Point(210, 60);
            gv.Show();
        }   

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            huongDan hd = new huongDan();
            hd.MdiParent = this;
            hd.StartPosition = FormStartPosition.Manual;
            hd.Location = new Point(230, 80);
            hd.Show();
        }   

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSinhVien.PerformClick();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnKhoa.PerformClick();
        }

        private void quảnLýGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnGiangVien.PerformClick();
        }

        private void quảnLýĐềTàiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDeTai.PerformClick();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timKiem inSV = new timKiem();
            inSV.MdiParent = this;
            inSV.StartPosition = FormStartPosition.Manual;
            inSV.Location = new Point(230, 80);
            inSV.Show();
        }

        private void inDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timKiem inSV = new timKiem();
            inSV.MdiParent = this;
            inSV.StartPosition = FormStartPosition.Manual;
            inSV.Location = new Point(230, 80);
            inSV.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void kếtQuảPhânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            dangNhap dn = new dangNhap();
            dn.Show();
        }

        private void danhSáchPhânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPhanCong.PerformClick();
        }
        
    }
}

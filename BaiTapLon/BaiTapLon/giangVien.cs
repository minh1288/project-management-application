using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class giangVien : Form
    {
        quanLy ql = new quanLy();

        public giangVien()
        {
            InitializeComponent();
        }

        private void giangVien_Load(object sender, EventArgs e)
        {
            loadData();
            loadDataKhoa();
            enabledTextBox(false);
            enabledButton(true, false, false, false, true);
        }

        private void loadData()
        {                          
            dataGridView1.DataSource = ql.getData("select * from vw_hienGiangvien");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            enabledTextBox(true);
            enabledButton(false, false, false, true, true);
            txtMaGV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_Empty() && check_Ma_Sua())
                {                           
                    using (SqlCommand Cmd = new SqlCommand("suaGiangVien", ql.Cnn))
                    {
                        ql.openConnect();
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Parameters.AddWithValue("@sMakhoa", cbTenkhoa.SelectedValue);
                        Cmd.Parameters.AddWithValue("@sTenGV", txtHoten.Text);
                        Cmd.Parameters.AddWithValue("@sGT", cbGioitinh.Text);
                        Cmd.Parameters.AddWithValue("@sSoDT", txtSDT.Text);
                        Cmd.Parameters.AddWithValue("@sMaGV", txtMaGV.Text);
                        Cmd.Parameters.AddWithValue("@taikhoan", txtTaikhoan.Text);
                        Cmd.Parameters.AddWithValue("@matkhau", txtMatkhau.Text);
                        int i = Cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            loadData();
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        ql.closeConnect();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaGV.Text))
            {
                ql.deleteData("tblGiangVien","sMaGV", "@sMaGV", txtMaGV.Text);
                loadData();
                enabledButton(true, false, false, false, true);
                enabledTextBox(false);
            }
            else
            {
                MessageBox.Show("Chọn mã giảng viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                enabledTextBox(true);
            }
            resetNull();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_Empty() && check_Ma())
                {                          
                    using (SqlCommand Cmd = new SqlCommand("themGiangVien", ql.Cnn))
                    {    
                        ql.openConnect();
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Parameters.AddWithValue("@sMaGV", txtMaGV.Text);
                        Cmd.Parameters.AddWithValue("@sMakhoa", cbTenkhoa.SelectedValue);
                        Cmd.Parameters.AddWithValue("@sTenGV", txtHoten.Text);
                        Cmd.Parameters.AddWithValue("@sGT", cbGioitinh.Text);
                        Cmd.Parameters.AddWithValue("@sSoDT", txtSDT.Text);  
                        Cmd.Parameters.AddWithValue("@taikhoan", txtTaikhoan.Text.Trim());
                        Cmd.Parameters.AddWithValue("@matkhau", txtMatkhau.Text.Trim());
                        int i = Cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            loadData();
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        ql.closeConnect();
                    }
                    resetNull();
                    enabledTextBox(false);
                    enabledButton(true, false, false, false, true);
                }
            }
            catch
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            resetNull();
            loadData();
            enabledTextBox(false);
            enabledButton(true, false, false, false, true);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {      
            enabledButton(true, true, true, false, true);
            enabledTextBox(true);
            txtMaGV.Enabled = false;
            txtMaGV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbTenkhoa.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtHoten.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cbGioitinh.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTaikhoan.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtMatkhau.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void loadDataKhoa()
        {
            DataTable dt = ql.getData("select sMakhoa,sTenkhoa from tblKhoa");
            DataView dv = new DataView(dt);
            dv.Sort = "sTenkhoa";
            cbTenkhoa.DataSource = dv;
            cbTenkhoa.DisplayMember = "sTenkhoa";
            cbTenkhoa.ValueMember = "sMakhoa";
        }

        private void resetNull()
        {
            txtMaGV.Text = "";
            txtHoten.Text = "";
            cbTenkhoa.Text = null;
            txtSDT.Text = "";
            cbGioitinh.Text = null;
            txtTaikhoan.Text = "";
            txtMatkhau.Text = "";
        }

        private void enabledTextBox(bool mo)
        {
            txtMaGV.Enabled = mo;
            txtHoten.Enabled = mo;
            cbTenkhoa.Enabled = mo;
            txtSDT.Enabled = mo;
            cbGioitinh.Enabled = mo;
            txtTaikhoan.Enabled = mo;
            txtMatkhau.Enabled = mo;
        }

        private void enabledButton(bool them, bool sua, bool xoa, bool luu, bool thoat)
        {
            btnThem.Enabled = them;
            btnSua.Enabled = sua;
            btnXoa.Enabled = xoa;
            btnLuu.Enabled = luu;
            btnThoat.Enabled = thoat;
        }

        private bool check_Empty()
        {
            if (string.IsNullOrEmpty(txtMaGV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtHoten.Text))
            {
                MessageBox.Show("Vui lòng nhập tên giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoten.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbTenkhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTenkhoa.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbGioitinh.Text))
            {
                MessageBox.Show("Vui lòng nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbGioitinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTaikhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaikhoan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMatkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatkhau.Focus();
                return false;
            }
            return true;
        }

        private bool check_Ma_Sua()
        {
            try
            {
                if (txtMaGV.Text.Trim() != dataGridView1.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Không được sửa mã giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool check_Ma()
        {
            try
            {                                                                                               
                return ql.check_Key("tblGiangvien","sMaGv",txtMaGV.Text.Trim(), "Đã tồn tại mã giảng viên này");
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

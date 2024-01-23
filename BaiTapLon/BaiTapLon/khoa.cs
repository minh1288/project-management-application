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
    public partial class khoa : Form
    {
        quanLy ql = new quanLy();

        public khoa()
        {
            InitializeComponent();
        }

        private void khoa_Load(object sender, EventArgs e)
        {                                            
            enabledTextBox(false);
            enabledButton(true, false, false, false, true);
            loadData();
        }

        private void loadData()
        {
            dataGridView1.DataSource = ql.getData("select * from vw_hienAllKhoa");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {                               
            enabledTextBox(true);
            enabledButton(false, false, false, true, true);
            txtMakhoa.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_Empty() && check_Ma_Sua())
                {                      
                    using (SqlCommand Cmd = new SqlCommand("suaKhoa", ql.Cnn))
                    {
                        ql.openConnect();
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Parameters.AddWithValue("@sTenkhoa", txtTenkhoa.Text);
                        Cmd.Parameters.AddWithValue("@sDienthoai", txtDienthoai.Text);
                        Cmd.Parameters.AddWithValue("@sDiachi", txtDiaChi.Text);
                        Cmd.Parameters.AddWithValue("@sMakhoa", txtMakhoa.Text);
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
            catch (Exception)
            {
                return;
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMakhoa.Text))
            {
                ql.deleteData("tblKhoa","sMakhoa", "@sMakhoa", txtMakhoa.Text);
                loadData();
            }
            else
            {
                MessageBox.Show("Chọn mã khoa cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            resetNull();
            enabledTextBox(false);
            enabledButton(true, false, false, false, true);
        }
            
        private void txtLuu_Click(object sender, EventArgs e)
        {
            //try
            {
                if (check_Empty() && check_Ma())
                {                         
                    using (SqlCommand Cmd = new SqlCommand("themKhoa", ql.Cnn))
                    {
                        ql.openConnect();
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Parameters.AddWithValue("@sMakhoa", txtMakhoa.Text);
                        Cmd.Parameters.AddWithValue("@sTenkhoa", txtTenkhoa.Text);
                        Cmd.Parameters.AddWithValue("@sDienthoai", txtDienthoai.Text);
                        Cmd.Parameters.AddWithValue("@sDiachi", txtDiaChi.Text);
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
            //catch (Exception ex)
            //{
            //    return;
            //}
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            resetNull();
            loadData();
            enabledTextBox(false);
            enabledButton(true, false, false, false, true);
        }

        private void resetNull()
        {
            txtTenkhoa.Text = "";
            txtMakhoa.Text = "";
            txtDienthoai.Text = "";
            txtDiaChi.Text = "";
        }

        private void enabledTextBox(bool mo)
        {
            txtMakhoa.Enabled = mo;
            txtTenkhoa.Enabled = mo;
            txtDienthoai.Enabled = mo;
            txtDiaChi.Enabled = mo;
        }

        private void enabledTextBox(bool makhoa, bool tenkhoa, bool sodienthoai, bool diachi)
        {
            txtMakhoa.Enabled = makhoa;
            txtTenkhoa.Enabled = tenkhoa;
            txtDienthoai.Enabled = sodienthoai;
            txtDiaChi.Enabled = diachi;
        }

        private void enabledButton(bool them, bool sua, bool xoa, bool luu, bool thoat)
        {
            btnThem.Enabled = them;
            btnSua.Enabled = sua;
            btnXoa.Enabled = xoa;
            btnLuu.Enabled = luu;
            btnThoat.Enabled = thoat;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enabledButton(true, true, true, false, true);
            enabledTextBox(true);
            txtMakhoa.Enabled = false;
            txtMakhoa.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenkhoa.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtDienthoai.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private bool check_Empty()
        {
            if (string.IsNullOrEmpty(txtMakhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMakhoa.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenkhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenkhoa.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDienthoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienthoai.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return false;
            }
            return true;
        }

        private bool check_Ma_Sua()
        {
            try
            {
                if (txtMakhoa.Text.Trim() != dataGridView1.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Không được sửa mã khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                return ql.check_Key("tblKhoa", "sMakhoa", txtMakhoa.Text.Trim(), "Đã tồn tại mã khoa này");
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

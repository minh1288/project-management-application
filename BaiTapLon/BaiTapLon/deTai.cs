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
    public partial class deTai : Form
    {
        quanLy ql = new quanLy();
        public deTai()
        {
            InitializeComponent();
        }

        private void deTai_Load(object sender, EventArgs e)
        {
            loadData();
            enabledTextBox(false);
            enabledButton(true, false, false, false, true);
        }

        private void loadData()
        {
            dataGridView1.DataSource = ql.getData("select * from vw_hienDetai");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            enabledTextBox(true);
            enabledButton(false, false, false, true, true);
            txtMadetai.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_Empty() && check_Ma_Sua())
                {                            
                    using (SqlCommand Cmd = new SqlCommand("suaDetai", ql.Cnn))
                    {
                        ql.openConnect();
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Parameters.AddWithValue("@sTendt", txtTendetai.Text);
                        Cmd.Parameters.AddWithValue("@sMadt", txtMadetai.Text);
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
            if (!string.IsNullOrEmpty(txtMadetai.Text))
            {
                ql.deleteData("tblDetai","sMadt", "@sMadt", txtMadetai.Text);
                loadData();
                enabledButton(true, false, false, false, true);
                enabledTextBox(false);
            }
            else
            {
                MessageBox.Show("Chọn mã đề tài cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    using (SqlCommand Cmd = new SqlCommand("themDetai", ql.Cnn))
                    {
                        ql.openConnect();
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Parameters.AddWithValue("@sMadt", txtMadetai.Text);
                        Cmd.Parameters.AddWithValue("@sTendt", txtTendetai.Text);
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
            txtMadetai.Enabled = false;
            txtMadetai.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTendetai.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void resetNull()
        {
            txtMadetai.Text = "";
            txtTendetai.Text = "";
        }

        private void enabledTextBox(bool mo)
        {
            txtMadetai.Enabled = mo;
            txtTendetai.Enabled = mo;
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
            if (string.IsNullOrEmpty(txtMadetai.Text))
            {
                MessageBox.Show("Vui lòng nhập mã đề tài", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMadetai.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTendetai.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đề tài", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTendetai.Focus();
                return false;
            } 
            return true;
        }

        private bool check_Ma_Sua()
        {
            try
            {
                if (txtMadetai.Text.Trim() != dataGridView1.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Không được sửa mã đề tài", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                return ql.check_Key("tblDetai", "sMadt", txtMadetai.Text.Trim(), "Đã tồn tại mã khoa này");
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void txtMadetai_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }
    }
}

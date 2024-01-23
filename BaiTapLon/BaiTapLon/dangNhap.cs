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
    public partial class dangNhap : Form
    {
        quanLy ql = new quanLy();                       

        public dangNhap()
        {
            InitializeComponent();
        }

        private void dangNhap_Load(object sender, EventArgs e)
        {
            txtTaikhoan.Focus();   
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {                       
            if (check_Empty())
            {         
                if (check_TaiKhoan().Read())
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Main main = new Main();
                    //inDsSinhVien inds = new inDsSinhVien(txtTaikhoan.Text);       
                    main.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Nhập sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }    

        private bool check_Empty()
        {
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

        private void btnThoat_Click(object sender, EventArgs e)
        {                            
            this.Close();
        }    

        private SqlDataReader check_TaiKhoan()
        {
            using (SqlCommand Cmd = new SqlCommand("dangNhap", ql.Cnn))
            {
                ql.openConnect();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@taikhoan", txtTaikhoan.Text.Trim());
                Cmd.Parameters.AddWithValue("@matkhau", txtMatkhau.Text.Trim());
                SqlDataReader reader = Cmd.ExecuteReader(); 
                return reader;
            }
        }

        public string hienTen()
        {
            return check_TaiKhoan().GetString(0);
        }
    }
}

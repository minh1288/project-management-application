using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTapLon
{
    public class quanLy
    {
        public string strConnect = @"Data Source=DESKTOP-H9U80G2\MINH;Initial Catalog=quanLyduan;user id=DESKTOP-H9U80G2\nhulon ; Pwd= ;Trusted_Connection=True";
        public SqlConnection Cnn = new SqlConnection();

        public void openConnect()
        {
            try
            {
                if (Cnn.State == ConnectionState.Open)
                {
                    Cnn.Close();
                }
                Cnn.ConnectionString = strConnect;
                Cnn.Open();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu", "Thông báo");
                return;
            }
        }

        public void closeConnect()
        {
            if (Cnn.State == ConnectionState.Open)
            {
                Cnn.Close();
            }
        }

        public DataTable getData(string sql)
        {
            using (SqlCommand Cmd = new SqlCommand(sql, Cnn))
            {
                openConnect();
                using (SqlDataAdapter da = new SqlDataAdapter(Cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    closeConnect();
                    return dt;
                }
            }
        }

        public void getDataComBoBox(string sTenbang, string sTencotkhoa, string sTenCotHienthi, ComboBox cbo)
        {
            openConnect();
            string strSQL = "select " + sTencotkhoa + "," + sTenCotHienthi + " from " + sTenbang;
            SqlDataAdapter da = new SqlDataAdapter(strSQL, Cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = sTenCotHienthi;
            cbo.ValueMember = sTencotkhoa;
            da.Dispose();
            closeConnect();
        }

        public void getTextFromComBoBox(string sTenkhoa, string sTenHienthi, string sTenbang, TextBox text, ComboBox cbo)
        {
            string strSQL = "select " + sTenHienthi + " from " + sTenbang + " where " + sTenkhoa + "='" + cbo.Text + "'";
            using (SqlCommand Cmd = new SqlCommand(strSQL, Cnn))
            {
                openConnect();
                Cmd.CommandType = CommandType.Text;
                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.Read())
                {
                    text.Text = reader.GetString(0);
                    reader.Close();
                }
            }
            closeConnect();
        }

        public bool check_Key(string tenbang, string tenma, string giatri, string thongbao)
        {
            using (SqlCommand Cmd = new SqlCommand("select * from " + tenbang + " where " + tenma + "='" + giatri + "'", Cnn))
            {
                openConnect();
                Cmd.CommandType = CommandType.Text;
                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    closeConnect();
                    MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                closeConnect();
                return true;
            }
        }

        public void deleteData(string tenbang, string tenma, string maxoa, string Giatri)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlCommand Cmd = new SqlCommand("delete " + tenbang + " where " + tenma + "=" + maxoa, Cnn))
                    {
                        openConnect();
                        Cmd.CommandType = CommandType.Text;
                        Cmd.Parameters.AddWithValue(maxoa, Giatri);
                        int i = Cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        closeConnect();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xóa thất bại vì giảng viên này đang hướng dẫn đồ án ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void deleteData1(string tenbang, string tenma, string maxoa, string Giatri)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlCommand Cmd = new SqlCommand("delete " + tenbang + " where " + tenma + "=" + maxoa, Cnn))
                    {
                        openConnect();
                        Cmd.CommandType = CommandType.Text;
                        Cmd.Parameters.AddWithValue(maxoa, Giatri);
                        int i = Cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        closeConnect();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xóa thất bại vì sinh viên này đang làm đồ án ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

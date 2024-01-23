using Microsoft.Office.Interop.Excel;
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
    public partial class huongDan : Form
    {
        quanLy ql = new quanLy();

        public huongDan()
        {
            InitializeComponent();
        }

        private void huongDan_Load(object sender, EventArgs e)
        {
            loadData();
            ql.getDataComBoBox("tblSinhvien", "sHoten", "sMaSV", cbMaSV);  
            txtHoten.ReadOnly = true;
            txtTenkhoa.ReadOnly = true;
            ql.getDataComBoBox("tblDetai", "sMadt", "sTendt", cbDetai);
            ql.getDataComBoBox("tblGiangvien", "sMaGV", "sTenGV", cbTenGV);
            resetNull();
            enabledTextBox(false);
            enabledButton(true, false, false, false, true);
        }

        private void loadData()
        {
            dataGridView1.DataSource = ql.getData("select * from vw_hienHuongDan");
            cbDetai.Refresh();
            cbMaSV.Refresh();
            cbKetqua.Refresh();
            cbTenGV.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            enabledTextBox(true);
            enabledButton(false, false, false, true, true);
            cbMaSV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(check_Empty() && check_Ma_Sua())
            {
                using(SqlCommand Cmd = new SqlCommand("suaHuongdan", ql.Cnn))
                {
                    ql.openConnect();
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.AddWithValue("@sMaSV", cbMaSV.Text.ToString());
                    Cmd.Parameters.AddWithValue("@sMadt", cbDetai.SelectedValue.ToString());
                    Cmd.Parameters.AddWithValue("@sMaGV", cbTenGV.SelectedValue.ToString());
                    Cmd.Parameters.AddWithValue("@dNgayBD", DateTime.Parse(dtNgayBD.Value.ToString()));
                    Cmd.Parameters.AddWithValue("@dNgaybaocao", DateTime.Parse(dtNgayBC.Value.ToString()));
                    Cmd.Parameters.AddWithValue("@sKetqua", cbKetqua.Text.ToString());
                    int ret = Cmd.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        loadData();
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại" + cbMaSV.Text.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ql.closeConnect();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbMaSV.Text))
            {
                ql.deleteData("tblHuongDan", "sMaSV", "@sMaSV", cbMaSV.Text);
                loadData();
                enabledButton(true, false, false, false, true);
                enabledTextBox(false);
            }
            else
            {
                MessageBox.Show("Chọn mã sinh viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    using (SqlCommand Cmd = new SqlCommand("themHuongDan", ql.Cnn))
                    {
                        ql.openConnect();
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Parameters.AddWithValue("@sMaSV", cbMaSV.Text);
                        Cmd.Parameters.AddWithValue("@sMadt", cbDetai.SelectedValue.ToString());
                        Cmd.Parameters.AddWithValue("@sMaGV", cbTenGV.SelectedValue.ToString());
                        Cmd.Parameters.AddWithValue("@dNgayBD", DateTime.Parse(dtNgayBD.Value.ToString()));
                        Cmd.Parameters.AddWithValue("@dNgaybaocao", DateTime.Parse(dtNgayBC.Value.ToString()));
                        Cmd.Parameters.AddWithValue("@sKetqua", cbKetqua.Text);
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
            cbMaSV.Enabled = false;
            cbMaSV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbDetai.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbTenGV.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dtNgayBD.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            dtNgayBC.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            cbKetqua.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void resetNull()
        {
            cbMaSV.Text = null;
            txtHoten.Text = "";
            txtTenkhoa.Text = "";
            cbDetai.Text = null;
            cbTenGV.Text = null;
            cbKetqua.Text = null; 
        }

        private void enabledTextBox(bool mo)
        {
            cbMaSV.Enabled = mo;
            txtHoten.Enabled = mo;
            txtTenkhoa.Enabled = mo;
            cbDetai.Enabled = mo;
            dtNgayBC.Enabled = mo;
            dtNgayBD.Enabled = mo;
            cbTenGV.Enabled = mo;
            cbKetqua.Enabled = mo;    
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
            if (string.IsNullOrEmpty(cbMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMaSV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtHoten.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoten.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenkhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn tên khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenkhoa.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbDetai.Text))
            {
                MessageBox.Show("Vui lòng chọn tên đề tài", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbDetai.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbTenGV.Text))
            {
                MessageBox.Show("Vui lòng tên giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTenGV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbKetqua.Text))
            {
                MessageBox.Show("Vui lòng nhập kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbKetqua.Focus();
                return false;
            }     
            return true;
        }

        private bool check_Ma_Sua()
        {
            try
            {
                if (cbMaSV.Text.Trim() != dataGridView1.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Không được sửa mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                return ql.check_Key("tblHuongDan", "sMaSv", cbMaSV.Text.Trim(), "Đã tồn tại mã sinh viên này");
            }
            catch (Exception)
            {
                return false;
            }
        }  

        private void cbMaSV_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbMaSV.Text))
            {
                txtHoten.Text = cbMaSV.SelectedValue.ToString();
                hienTenKhoa(txtTenkhoa);
            }
            else
            {
                return;
            }
        }

        private void hienTenKhoa(System.Windows.Forms.TextBox tb)
        {
            using(SqlCommand Cmd = new SqlCommand("hienTenkhoa", ql.Cnn))
            {
                ql.openConnect();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@sMaSV", cbMaSV.Text);
                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.Read())
                {
                    tb.Text = reader.GetString(0);         
                    reader.Close();
                }
                ql.closeConnect();
            }
        }

        private void cbDetai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {

                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];

                worksheet.Name = "Quản lý đồ án";
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[3, i + 1] = dataGridView1.Columns[i].HeaderText;
                    worksheet.Cells[3, i + 1].Borders.LineStyle = XlLineStyle.xlContinuous;
                }
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 4, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                        worksheet.Cells[i + 4, j + 1].Borders.LineStyle = XlLineStyle.xlContinuous;
                    }
                }
                Range titleRange = worksheet.Range["A1:B1"];
                titleRange.Merge();
                titleRange.Cells[1, 1] = "Cộng hòa xã hội chủ nghĩa Việt Nam";
                titleRange.Cells.Font.Bold = true;
                titleRange.Cells.Font.Italic = false;
                titleRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                titleRange.ColumnWidth = 30; 

                Range subTitleRange = worksheet.Range["A2:B2"];
                subTitleRange.Merge();
                subTitleRange.Cells[1, 1] = "Độc lập - Tự do - Hạnh phúc";
                subTitleRange.Cells.Font.Bold = true;
                subTitleRange.Cells.Font.Italic = true;
                subTitleRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                titleRange.ColumnWidth = 30;
                
                workbook.SaveAs(fileName);

                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dataGridView1, saveFileDialog1.FileName);
            }
        }

    }
    }


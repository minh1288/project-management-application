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
    public partial class timKiem : Form
    {
        quanLy ql = new quanLy();

        public timKiem()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void inSinhVien_Load(object sender, EventArgs e)
        {
            
        }

        private void loadData(string tenview)
        {
            dataGridView1.DataSource = ql.getData("select * from " + tenview);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void timData(string tenview, string tenma,string giatrima)
        {
            dataGridView1.DataSource = ql.getData("select * from " + tenview + " where " + tenma + " like N'%" + giatrima +"%'");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void timData(string tenview, string sMa, string giatrima, string sTen,string giatriten)
        {
            dataGridView1.DataSource = ql.getData("select * from " + tenview + " where " + sMa + " like N'%" + giatrima + "%' and " + sTen + " like N'%" + giatriten + "%'");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (check_Empty())
            {
                if (rdHienAll.Checked)
                {

                    if (comboBox1.SelectedIndex == 0)
                    {
                        loadData("vw_hienAllSinhVien");
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        loadData("vw_hienAllKhoa");
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        loadData("vw_hienGiangvien");
                    }
                    else if (comboBox1.SelectedIndex == 3)
                    {
                        loadData("vw_hienDetai");
                    }
                    else if (comboBox1.SelectedIndex == 4)
                    {
                        loadData("vw_hienHuongDan");
                    }
                }else if (ckMa.Checked == true && ckTen.Checked == false)
                {
                    rdHienAll.Checked = false;
                    if (!string.IsNullOrEmpty(txtTheoMa.Text))
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            timData("vw_hienAllSinhVien", "[Mã sinh viên]", txtTheoMa.Text);
                        }
                        else if (comboBox1.SelectedIndex == 1)
                        {
                            timData("vw_hienAllKhoa","[Mã khoa]",txtTheoMa.Text);
                        }
                        else if (comboBox1.SelectedIndex == 2)
                        {
                            timData("vw_hienGiangvien","[Mã giảng viên]",txtTheoMa.Text);
                        }
                        else if (comboBox1.SelectedIndex == 3)
                        {
                            timData("vw_hienDetai","[Mã đề tài]",txtTheoMa.Text);
                        }
                        else if (comboBox1.SelectedIndex == 4)
                        {
                            timData("vw_hienHuongDan","[Mã sinh viên]",txtTheoMa.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập mã tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }  
                } else if (ckTen.Checked == true && ckMa.Checked == false)
                {
                    rdHienAll.Checked = false;
                    if (!string.IsNullOrEmpty(txtTheoTen.Text))
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            timData("vw_hienAllSinhVien", "[Họ tên]", txtTheoTen.Text);
                        }
                        else if (comboBox1.SelectedIndex == 1)
                        {
                            timData("vw_hienAllKhoa", "[Tên khoa]", txtTheoTen.Text);
                        }
                        else if (comboBox1.SelectedIndex == 2)
                        {
                            timData("vw_hienGiangvien", "[Họ tên]", txtTheoTen.Text);
                        }
                        else if (comboBox1.SelectedIndex == 3)
                        {
                            timData("vw_hienDetai", "[Tên đề tài]", txtTheoTen.Text);
                        }
                        else if (comboBox1.SelectedIndex == 4)
                        {
                            timData("vw_hienHuongDan", "[Họ tên]", txtTheoTen.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập tên để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }else if(ckTen.Checked == true && ckMa.Checked == true)
                {
                    if (!string.IsNullOrEmpty(txtTheoTen.Text) && !string.IsNullOrEmpty(txtTheoMa.Text))
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            timData("vw_hienAllSinhVien","[Mã sinh viên]" ,txtTheoMa.Text ,"[Họ tên]", txtTheoTen.Text);
                        }
                        else if (comboBox1.SelectedIndex == 1)
                        {
                            timData("vw_hienAllKhoa", "[Mã khoa]", txtTheoMa.Text, "[Tên khoa]", txtTheoTen.Text);
                        }
                        else if (comboBox1.SelectedIndex == 2)
                        {
                            timData("vw_hienGiangvien", "[Mã giảng viên]", txtTheoMa.Text, "[Họ tên]", txtTheoTen.Text);
                        }
                        else if (comboBox1.SelectedIndex == 3)
                        {
                            timData("vw_hienDetai", "[Mã đề tài]", txtTheoMa.Text, "[Tên đề tài]", txtTheoTen.Text);
                        }
                        else if (comboBox1.SelectedIndex == 4)
                        {
                            timData("vw_hienHuongDan", "[Mã sinh viên]", txtTheoMa.Text, "[Họ tên]", txtTheoTen.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập đủ thông tin để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;  
                    }
                }
            }
            //if (ckNgay.Checked == true)
            //{                                                        
            //    dataGridView1.DataSource = ql.getData("select * from vw_hienAllSinhVien where [Ngày sinh] = '" + dtNgay.Value.ToString("MM/dd/yyyy").Trim() + "'");
            //}
        }

        private bool check_Empty()
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Chưa chọn bảng cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Focus();
                return false;
            }
            if (rdHienAll.Checked == false && ckMa.Checked == false && ckTen.Checked == false)
            {
                MessageBox.Show("Chưa chọn điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void rdHienAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdHienAll.Checked)
            {
                ckMa.Checked = false;
                ckTen.Checked = false;
            }
        }

        private void ckMa_CheckedChanged(object sender, EventArgs e)
        {
            rdHienAll.Checked = false;
        }

        private void ckTen_CheckedChanged(object sender, EventArgs e)
        {
            rdHienAll.Checked = false;
        }
    }
}

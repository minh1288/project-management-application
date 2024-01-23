namespace BaiTapLon
{
    partial class huongDan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(huongDan));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbDetai = new System.Windows.Forms.ComboBox();
            this.dtNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMaSV = new System.Windows.Forms.ComboBox();
            this.cbKetqua = new System.Windows.Forms.ComboBox();
            this.dtNgayBC = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTenGV = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenkhoa = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(833, 204);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTitle.Location = new System.Drawing.Point(302, 3);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(206, 25);
            this.lbTitle.TabIndex = 33;
            this.lbTitle.Text = "Cập nhật thông tin";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXoa.Location = new System.Drawing.Point(237, 397);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 40);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã SV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Họ tên:";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSua.Location = new System.Drawing.Point(128, 397);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 40);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThem.Location = new System.Drawing.Point(19, 397);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 40);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbDetai
            // 
            this.cbDetai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDetai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbDetai.FormattingEnabled = true;
            this.cbDetai.Location = new System.Drawing.Point(405, 42);
            this.cbDetai.Name = "cbDetai";
            this.cbDetai.Size = new System.Drawing.Size(428, 28);
            this.cbDetai.TabIndex = 4;
            this.cbDetai.SelectedIndexChanged += new System.EventHandler(this.cbDetai_SelectedIndexChanged);
            // 
            // dtNgayBD
            // 
            this.dtNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayBD.Location = new System.Drawing.Point(405, 80);
            this.dtNgayBD.Name = "dtNgayBD";
            this.dtNgayBD.Size = new System.Drawing.Size(153, 26);
            this.dtNgayBD.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(610, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Kết quả:";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThoat.Location = new System.Drawing.Point(455, 397);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 40);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Hủy";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(3, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tên khoa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(320, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tên đề tài:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(327, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ngày BĐ:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.cbMaSV);
            this.panel1.Controls.Add(this.cbKetqua);
            this.panel1.Controls.Add(this.dtNgayBC);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbTenGV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbDetai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtNgayBD);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTenkhoa);
            this.panel1.Controls.Add(this.txtHoten);
            this.panel1.Location = new System.Drawing.Point(19, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 146);
            this.panel1.TabIndex = 47;
            // 
            // cbMaSV
            // 
            this.cbMaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbMaSV.FormattingEnabled = true;
            this.cbMaSV.Location = new System.Drawing.Point(85, 42);
            this.cbMaSV.Name = "cbMaSV";
            this.cbMaSV.Size = new System.Drawing.Size(188, 28);
            this.cbMaSV.TabIndex = 1;
            this.cbMaSV.TextChanged += new System.EventHandler(this.cbMaSV_TextChanged);
            // 
            // cbKetqua
            // 
            this.cbKetqua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbKetqua.FormattingEnabled = true;
            this.cbKetqua.Items.AddRange(new object[] {
            "Thông qua",
            "Không đạt",
            "Chưa xác định"});
            this.cbKetqua.Location = new System.Drawing.Point(680, 116);
            this.cbKetqua.Name = "cbKetqua";
            this.cbKetqua.Size = new System.Drawing.Size(153, 28);
            this.cbKetqua.TabIndex = 8;
            // 
            // dtNgayBC
            // 
            this.dtNgayBC.CustomFormat = "dd/MM/yyyy";
            this.dtNgayBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtNgayBC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayBC.Location = new System.Drawing.Point(405, 116);
            this.dtNgayBC.Name = "dtNgayBC";
            this.dtNgayBC.Size = new System.Drawing.Size(153, 26);
            this.dtNgayBC.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(293, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ngày báo cáo:";
            // 
            // cbTenGV
            // 
            this.cbTenGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbTenGV.FormattingEnabled = true;
            this.cbTenGV.Location = new System.Drawing.Point(680, 78);
            this.cbTenGV.Name = "cbTenGV";
            this.cbTenGV.Size = new System.Drawing.Size(153, 28);
            this.cbTenGV.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(610, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Tên GV:";
            // 
            // txtTenkhoa
            // 
            this.txtTenkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenkhoa.Location = new System.Drawing.Point(85, 116);
            this.txtTenkhoa.Name = "txtTenkhoa";
            this.txtTenkhoa.Size = new System.Drawing.Size(188, 26);
            this.txtTenkhoa.TabIndex = 2;
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHoten.Location = new System.Drawing.Point(85, 80);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(188, 26);
            this.txtHoten.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLuu.Location = new System.Drawing.Point(346, 397);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 40);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(565, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 40);
            this.button1.TabIndex = 48;
            this.button1.Text = "Xuất file Excel";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // huongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLuu);
            this.Name = "huongDan";
            this.Text = "Thông tin kết quả đồ án";
            this.Load += new System.EventHandler(this.huongDan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbDetai;
        private System.Windows.Forms.DateTimePicker dtNgayBD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DateTimePicker dtNgayBC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTenGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbKetqua;
        private System.Windows.Forms.ComboBox cbMaSV;
        private System.Windows.Forms.TextBox txtTenkhoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
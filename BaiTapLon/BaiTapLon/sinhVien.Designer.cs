namespace BaiTapLon
{
    partial class sinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sinhVien));
            this.btnLuu = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.cbMakhoa = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuequan = new System.Windows.Forms.TextBox();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            resources.ApplyResources(this.btnLuu, "btnLuu");
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lbTitle
            // 
            resources.ApplyResources(this.lbTitle, "lbTitle");
            this.lbTitle.Name = "lbTitle";
            // 
            // cbMakhoa
            // 
            this.cbMakhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbMakhoa, "cbMakhoa");
            this.cbMakhoa.FormattingEnabled = true;
            this.cbMakhoa.Name = "cbMakhoa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btExcel);
            this.panel1.Controls.Add(this.cbMakhoa);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbGioitinh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtQuequan);
            this.panel1.Controls.Add(this.dtNgaysinh);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMasv);
            this.panel1.Controls.Add(this.txtHoten);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btExcel
            // 
            resources.ApplyResources(this.btExcel, "btExcel");
            this.btExcel.Name = "btExcel";
            this.btExcel.UseVisualStyleBackColor = true;
            this.btExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbGioitinh, "cbGioitinh");
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Items.AddRange(new object[] {
            resources.GetString("cbGioitinh.Items"),
            resources.GetString("cbGioitinh.Items1")});
            this.cbGioitinh.Name = "cbGioitinh";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtQuequan
            // 
            resources.ApplyResources(this.txtQuequan, "txtQuequan");
            this.txtQuequan.Name = "txtQuequan";
            // 
            // dtNgaysinh
            // 
            resources.ApplyResources(this.dtNgaysinh, "dtNgaysinh");
            this.dtNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaysinh.Name = "dtNgaysinh";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtMasv
            // 
            resources.ApplyResources(this.txtMasv, "txtMasv");
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.TextChanged += new System.EventHandler(this.txtMasv_TextChanged);
            // 
            // txtHoten
            // 
            resources.ApplyResources(this.txtHoten, "txtHoten");
            this.txtHoten.Name = "txtHoten";
            // 
            // btnThem
            // 
            resources.ApplyResources(this.btnThem, "btnThem");
            this.btnThem.Name = "btnThem";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            resources.ApplyResources(this.btnSua, "btnSua");
            this.btnSua.Name = "btnSua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            resources.ApplyResources(this.btnXoa, "btnXoa");
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            resources.ApplyResources(this.btnThoat, "btnThoat");
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sinhVien
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "sinhVien";
            this.Load += new System.EventHandler(this.sinhVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ComboBox cbMakhoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuequan;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
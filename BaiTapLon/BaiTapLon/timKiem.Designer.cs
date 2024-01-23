namespace BaiTapLon
{
    partial class timKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timKiem));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbTitle = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rdHienAll = new System.Windows.Forms.RadioButton();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTheoMa = new System.Windows.Forms.TextBox();
            this.txtTheoTen = new System.Windows.Forms.TextBox();
            this.ckMa = new System.Windows.Forms.CheckBox();
            this.ckTen = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(825, 248);
            this.dataGridView1.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(113, 25);
            this.lbTitle.TabIndex = 33;
            this.lbTitle.Text = "Tìm kiếm:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sinh Viên",
            "Khoa",
            "Giảng Viên",
            "Đề Tài",
            "Đồ Án"});
            this.comboBox1.Location = new System.Drawing.Point(17, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // rdHienAll
            // 
            this.rdHienAll.AutoSize = true;
            this.rdHienAll.Location = new System.Drawing.Point(17, 83);
            this.rdHienAll.Name = "rdHienAll";
            this.rdHienAll.Size = new System.Drawing.Size(130, 17);
            this.rdHienAll.TabIndex = 35;
            this.rdHienAll.TabStop = true;
            this.rdHienAll.Text = "Hiện tất cả danh sách";
            this.rdHienAll.UseVisualStyleBackColor = true;
            this.rdHienAll.CheckedChanged += new System.EventHandler(this.rdHienAll_CheckedChanged);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.Location = new System.Drawing.Point(232, 38);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(103, 35);
            this.btnTimkiem.TabIndex = 38;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTheoMa
            // 
            this.txtTheoMa.Location = new System.Drawing.Point(188, 116);
            this.txtTheoMa.Name = "txtTheoMa";
            this.txtTheoMa.Size = new System.Drawing.Size(125, 20);
            this.txtTheoMa.TabIndex = 39;
            // 
            // txtTheoTen
            // 
            this.txtTheoTen.Location = new System.Drawing.Point(188, 149);
            this.txtTheoTen.Name = "txtTheoTen";
            this.txtTheoTen.Size = new System.Drawing.Size(125, 20);
            this.txtTheoTen.TabIndex = 39;
            // 
            // ckMa
            // 
            this.ckMa.AutoSize = true;
            this.ckMa.Location = new System.Drawing.Point(17, 116);
            this.ckMa.Name = "ckMa";
            this.ckMa.Size = new System.Drawing.Size(84, 17);
            this.ckMa.TabIndex = 40;
            this.ckMa.Text = "Tìm theo mã";
            this.ckMa.UseVisualStyleBackColor = true;
            this.ckMa.CheckedChanged += new System.EventHandler(this.ckMa_CheckedChanged);
            // 
            // ckTen
            // 
            this.ckTen.AutoSize = true;
            this.ckTen.Location = new System.Drawing.Point(17, 149);
            this.ckTen.Name = "ckTen";
            this.ckTen.Size = new System.Drawing.Size(85, 17);
            this.ckTen.TabIndex = 40;
            this.ckTen.Text = "Tìm theo tên";
            this.ckTen.UseVisualStyleBackColor = true;
            this.ckTen.CheckedChanged += new System.EventHandler(this.ckTen_CheckedChanged);
            // 
            // timKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.ckTen);
            this.Controls.Add(this.ckMa);
            this.Controls.Add(this.txtTheoTen);
            this.Controls.Add(this.txtTheoMa);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.rdHienAll);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "timKiem";
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.inSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rdHienAll;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTheoMa;
        private System.Windows.Forms.TextBox txtTheoTen;
        private System.Windows.Forms.CheckBox ckMa;
        private System.Windows.Forms.CheckBox ckTen;
    }
}
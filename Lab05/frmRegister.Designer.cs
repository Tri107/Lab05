namespace Lab05
{
    partial class frmRegister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDangKyChuyenNganh = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.dgvDanhSachDangKy = new System.Windows.Forms.DataGridView();
            this.cbxChuyenNganh = new System.Windows.Forms.ComboBox();
            this.lblChuyenNganh = new System.Windows.Forms.Label();
            this.btnDangKyChuyenNganh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.chkChuaDkChuyenNganh = new System.Windows.Forms.CheckBox();
            this.colChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDangKyChuyenNganh
            // 
            this.lblDangKyChuyenNganh.AutoSize = true;
            this.lblDangKyChuyenNganh.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangKyChuyenNganh.ForeColor = System.Drawing.Color.Blue;
            this.lblDangKyChuyenNganh.Location = new System.Drawing.Point(384, 9);
            this.lblDangKyChuyenNganh.Name = "lblDangKyChuyenNganh";
            this.lblDangKyChuyenNganh.Size = new System.Drawing.Size(568, 47);
            this.lblDangKyChuyenNganh.TabIndex = 54;
            this.lblDangKyChuyenNganh.Text = "ĐĂNG KÝ CHUYÊN NGÀNH";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(345, 71);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(70, 29);
            this.lblKhoa.TabIndex = 55;
            this.lblKhoa.Text = "Khoa";
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Location = new System.Drawing.Point(458, 68);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(323, 37);
            this.cbxKhoa.TabIndex = 56;
            this.cbxKhoa.SelectedIndexChanged += new System.EventHandler(this.cbxKhoa_SelectedIndexChanged);
            // 
            // dgvDanhSachDangKy
            // 
            this.dgvDanhSachDangKy.AllowUserToAddRows = false;
            this.dgvDanhSachDangKy.AllowUserToDeleteRows = false;
            this.dgvDanhSachDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachDangKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDanhSachDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChon});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachDangKy.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDanhSachDangKy.Location = new System.Drawing.Point(12, 174);
            this.dgvDanhSachDangKy.Name = "dgvDanhSachDangKy";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachDangKy.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvDanhSachDangKy.RowHeadersWidth = 62;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDanhSachDangKy.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDanhSachDangKy.Size = new System.Drawing.Size(1176, 472);
            this.dgvDanhSachDangKy.TabIndex = 57;
            // 
            // cbxChuyenNganh
            // 
            this.cbxChuyenNganh.FormattingEnabled = true;
            this.cbxChuyenNganh.Location = new System.Drawing.Point(458, 117);
            this.cbxChuyenNganh.Name = "cbxChuyenNganh";
            this.cbxChuyenNganh.Size = new System.Drawing.Size(323, 37);
            this.cbxChuyenNganh.TabIndex = 59;
            // 
            // lblChuyenNganh
            // 
            this.lblChuyenNganh.AutoSize = true;
            this.lblChuyenNganh.Location = new System.Drawing.Point(282, 121);
            this.lblChuyenNganh.Name = "lblChuyenNganh";
            this.lblChuyenNganh.Size = new System.Drawing.Size(170, 29);
            this.lblChuyenNganh.TabIndex = 58;
            this.lblChuyenNganh.Text = "Chuyên Ngành";
            // 
            // btnDangKyChuyenNganh
            // 
            this.btnDangKyChuyenNganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKyChuyenNganh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKyChuyenNganh.Location = new System.Drawing.Point(941, 121);
            this.btnDangKyChuyenNganh.Name = "btnDangKyChuyenNganh";
            this.btnDangKyChuyenNganh.Size = new System.Drawing.Size(129, 47);
            this.btnDangKyChuyenNganh.TabIndex = 60;
            this.btnDangKyChuyenNganh.Text = "Đăng ký";
            this.btnDangKyChuyenNganh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangKyChuyenNganh.UseVisualStyleBackColor = true;
            this.btnDangKyChuyenNganh.Click += new System.EventHandler(this.btnDangKyChuyenNganh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1076, 121);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 47);
            this.btnThoat.TabIndex = 61;
            this.btnThoat.Text = "Trở lại";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // chkChuaDkChuyenNganh
            // 
            this.chkChuaDkChuyenNganh.AutoSize = true;
            this.chkChuaDkChuyenNganh.Location = new System.Drawing.Point(12, 134);
            this.chkChuaDkChuyenNganh.Name = "chkChuaDkChuyenNganh";
            this.chkChuaDkChuyenNganh.Size = new System.Drawing.Size(361, 33);
            this.chkChuaDkChuyenNganh.TabIndex = 62;
            this.chkChuaDkChuyenNganh.Text = "Chưa Đăng Ký Chuyên Ngành";
            this.chkChuaDkChuyenNganh.UseVisualStyleBackColor = true;
            this.chkChuaDkChuyenNganh.CheckedChanged += new System.EventHandler(this.chkChuaDkChuyenNganh_CheckedChanged);
            // 
            // colChon
            // 
            this.colChon.HeaderText = "Chọn";
            this.colChon.MinimumWidth = 8;
            this.colChon.Name = "colChon";
            this.colChon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colChon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.chkChuaDkChuyenNganh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKyChuyenNganh);
            this.Controls.Add(this.cbxChuyenNganh);
            this.Controls.Add(this.lblChuyenNganh);
            this.Controls.Add(this.dgvDanhSachDangKy);
            this.Controls.Add(this.cbxKhoa);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lblDangKyChuyenNganh);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đăng ký chuyên ngành";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDangKyChuyenNganh;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.DataGridView dgvDanhSachDangKy;
        private System.Windows.Forms.ComboBox cbxChuyenNganh;
        private System.Windows.Forms.Label lblChuyenNganh;
        private System.Windows.Forms.Button btnDangKyChuyenNganh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox chkChuaDkChuyenNganh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChon;
    }
}
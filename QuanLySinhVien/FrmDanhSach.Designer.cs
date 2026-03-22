namespace QuanLySinhVien
{
    partial class FrmDanhSach
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnQLSinhVien = new System.Windows.Forms.Button();
            this.btnQLLopHoc = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();

            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblTieuDeLeft = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();

            this.panelRight = new System.Windows.Forms.Panel();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();

            this.panelTop.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 50);
            this.panelTop.TabIndex = 0;
            this.panelTop.Controls.Add(this.btnQLSinhVien);
            this.panelTop.Controls.Add(this.btnQLLopHoc);
            this.panelTop.Controls.Add(this.btnDangXuat);

            this.btnQLSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSinhVien.FlatAppearance.BorderSize = 0;
            this.btnQLSinhVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnQLSinhVien.ForeColor = System.Drawing.Color.White;
            this.btnQLSinhVien.Location = new System.Drawing.Point(15, 5);
            this.btnQLSinhVien.Name = "btnQLSinhVien";
            this.btnQLSinhVien.Size = new System.Drawing.Size(160, 40);
            this.btnQLSinhVien.TabIndex = 0;
            this.btnQLSinhVien.Text = "📋 QL Sinh Viên";
            this.btnQLSinhVien.UseVisualStyleBackColor = false;
            this.btnQLSinhVien.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnQLSinhVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLSinhVien.Click += new System.EventHandler(this.btnQLSinhVien_Click);

            this.btnQLLopHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLLopHoc.FlatAppearance.BorderSize = 0;
            this.btnQLLopHoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnQLLopHoc.ForeColor = System.Drawing.Color.White;
            this.btnQLLopHoc.Location = new System.Drawing.Point(185, 5);
            this.btnQLLopHoc.Name = "btnQLLopHoc";
            this.btnQLLopHoc.Size = new System.Drawing.Size(160, 40);
            this.btnQLLopHoc.TabIndex = 1;
            this.btnQLLopHoc.Text = "🏫 QL Lớp Học";
            this.btnQLLopHoc.UseVisualStyleBackColor = false;
            this.btnQLLopHoc.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnQLLopHoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLLopHoc.Click += new System.EventHandler(this.btnQLLopHoc_Click);

            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(880, 5);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(110, 40);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "🚪 Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);

            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 50);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(300, 510);
            this.panelLeft.TabIndex = 1;
            this.panelLeft.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelLeft.Controls.Add(this.lblTieuDeLeft);
            this.panelLeft.Controls.Add(this.lblMa);
            this.panelLeft.Controls.Add(this.txtMa);
            this.panelLeft.Controls.Add(this.lblTen);
            this.panelLeft.Controls.Add(this.txtTen);
            this.panelLeft.Controls.Add(this.lblLop);
            this.panelLeft.Controls.Add(this.cboLop);
            this.panelLeft.Controls.Add(this.lblNgaySinh);
            this.panelLeft.Controls.Add(this.dtpNgaySinh);
            this.panelLeft.Controls.Add(this.lblTenLop);
            this.panelLeft.Controls.Add(this.txtTenLop);
            this.panelLeft.Controls.Add(this.panelButtons);

            this.lblTieuDeLeft.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTieuDeLeft.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTieuDeLeft.Location = new System.Drawing.Point(15, 10);
            this.lblTieuDeLeft.Name = "lblTieuDeLeft";
            this.lblTieuDeLeft.Size = new System.Drawing.Size(270, 30);
            this.lblTieuDeLeft.TabIndex = 0;
            this.lblTieuDeLeft.Text = "THÔNG TIN SINH VIÊN";

            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMa.Location = new System.Drawing.Point(15, 55);
            this.lblMa.Name = "lblMa";
            this.lblMa.Text = "Mã:";

            this.txtMa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMa.Location = new System.Drawing.Point(15, 78);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(270, 25);
            this.txtMa.ReadOnly = true;
            this.txtMa.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);

            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTen.Location = new System.Drawing.Point(15, 115);
            this.lblTen.Name = "lblTen";
            this.lblTen.Text = "Họ tên:";

            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTen.Location = new System.Drawing.Point(15, 138);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(270, 25);

            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLop.Location = new System.Drawing.Point(15, 175);
            this.lblLop.Name = "lblLop";
            this.lblLop.Text = "Lớp:";

            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLop.Location = new System.Drawing.Point(15, 198);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(270, 25);
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 235);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Text = "Ngày sinh:";

            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgaySinh.Location = new System.Drawing.Point(15, 258);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(270, 25);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTenLop.Location = new System.Drawing.Point(15, 55);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Text = "Tên lớp:";
            this.lblTenLop.Visible = false;

            this.txtTenLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenLop.Location = new System.Drawing.Point(15, 78);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(270, 25);
            this.txtTenLop.Visible = false;

            this.panelButtons.Location = new System.Drawing.Point(15, 310);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(270, 45);
            this.panelButtons.TabIndex = 10;
            this.panelButtons.Controls.Add(this.btnThem);
            this.panelButtons.Controls.Add(this.btnLuu);
            this.panelButtons.Controls.Add(this.btnSua);
            this.panelButtons.Controls.Add(this.btnXoa);

            int btnW = 60;
            int btnH = 35;
            int gap = 5;

            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(btnW, btnH);
            this.btnThem.Text = "Thêm";
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnLuu.Location = new System.Drawing.Point(btnW + gap, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(btnW, btnH);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            this.btnSua.Location = new System.Drawing.Point((btnW + gap) * 2, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(btnW, btnH);
            this.btnSua.Text = "Sửa";
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Location = new System.Drawing.Point((btnW + gap) * 3, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(btnW, btnH);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(300, 50);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(10);
            this.panelRight.TabIndex = 2;
            this.panelRight.Controls.Add(this.dgvDanhSach);

            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.dgvDanhSach.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDanhSach.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvDanhSach.EnableHeadersVisualStyles = false;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowTemplate.Height = 28;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.dgvDanhSach.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvDanhSach.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 560);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Name = "FrmDanhSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnQLSinhVien;
        private System.Windows.Forms.Button btnQLLopHoc;
        private System.Windows.Forms.Button btnDangXuat;

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblTieuDeLeft;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dgvDanhSach;
    }
}

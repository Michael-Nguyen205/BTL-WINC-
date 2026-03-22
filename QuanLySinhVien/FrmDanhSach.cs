using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FrmDanhSach : Form
    {
        private string currentMode = "SinhVien";
        private bool isAdding = false;

        public FrmDanhSach()
        {
            InitializeComponent();
            this.Load += FrmDanhSach_Load;
            dgvDanhSach.CellDoubleClick += dgvDanhSach_CellDoubleClick;
        }

        private string LayConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;
        }

        private void FrmDanhSach_Load(object sender, EventArgs e)
        {
            ChuyenModeSinhVien();
        }

        private void btnQLSinhVien_Click(object sender, EventArgs e)
        {
            ChuyenModeSinhVien();
        }

        private void btnQLLopHoc_Click(object sender, EventArgs e)
        {
            ChuyenModeLopHoc();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult xacNhan = MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacNhan == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ChuyenModeSinhVien()
        {
            currentMode = "SinhVien";
            isAdding = false;

            btnQLSinhVien.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnQLLopHoc.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);

            lblTieuDeLeft.Text = "THÔNG TIN SINH VIÊN";

            lblMa.Visible = true; txtMa.Visible = true;
            lblTen.Visible = true; txtTen.Visible = true;
            lblLop.Visible = true; cboLop.Visible = true;
            lblNgaySinh.Visible = true; dtpNgaySinh.Visible = true;

            lblTenLop.Visible = false; txtTenLop.Visible = false;

            LoadDanhSachLopComboBox();
            LoadDanhSachSinhVien();
            XoaFormNhap();
        }

        private void ChuyenModeLopHoc()
        {
            currentMode = "LopHoc";
            isAdding = false;

            btnQLLopHoc.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnQLSinhVien.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);

            lblTieuDeLeft.Text = "THÔNG TIN LỚP HỌC";

            lblMa.Visible = false; txtMa.Visible = false;
            lblTen.Visible = false; txtTen.Visible = false;
            lblLop.Visible = false; cboLop.Visible = false;
            lblNgaySinh.Visible = false; dtpNgaySinh.Visible = false;

            lblTenLop.Visible = true; txtTenLop.Visible = true;

            txtMa.Visible = false;

            LoadDanhSachLopHoc();
            XoaFormNhap();
        }

        private void LoadDanhSachSinhVien()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(LayConnectionString()))
                {
                    conn.Open();
                    string sql = @"SELECT s.Id AS [Mã SV], s.Name AS [Họ tên], 
                                   ISNULL(c.ClassName, '') AS [Lớp], 
                                   FORMAT(s.BirthDate, 'dd/MM/yyyy') AS [Ngày sinh],
                                   s.ClassId
                                   FROM Student s 
                                   LEFT JOIN Class c ON s.ClassId = c.Id
                                   ORDER BY s.Id";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.Fill(dt);
                }
                dgvDanhSach.DataSource = dt;

                if (dgvDanhSach.Columns["ClassId"] != null)
                    dgvDanhSach.Columns["ClassId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách sinh viên!\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachLopHoc()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(LayConnectionString()))
                {
                    conn.Open();
                    string sql = @"SELECT c.Id AS [Mã lớp], c.ClassName AS [Tên lớp],
                                   (SELECT COUNT(*) FROM Student s WHERE s.ClassId = c.Id) AS [Sĩ số]
                                   FROM Class c ORDER BY c.Id";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.Fill(dt);
                }
                dgvDanhSach.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách lớp học!\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachLopComboBox()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(LayConnectionString()))
                {
                    conn.Open();
                    string sql = "SELECT Id, ClassName FROM Class ORDER BY ClassName";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.Fill(dt);
                }

                cboLop.DataSource = dt;
                cboLop.DisplayMember = "ClassName";
                cboLop.ValueMember = "Id";
                cboLop.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách lớp!\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            isAdding = false;
            DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];

            if (currentMode == "SinhVien")
            {
                txtMa.Text = row.Cells["Mã SV"].Value?.ToString() ?? "";
                txtTen.Text = row.Cells["Họ tên"].Value?.ToString() ?? "";

                var classIdValue = row.Cells["ClassId"].Value;
                if (classIdValue != null && classIdValue != DBNull.Value)
                    cboLop.SelectedValue = Convert.ToInt32(classIdValue);
                else
                    cboLop.SelectedIndex = -1;

                string ngaySinh = row.Cells["Ngày sinh"].Value?.ToString() ?? "";
                if (DateTime.TryParse(ngaySinh, out DateTime dt))
                    dtpNgaySinh.Value = dt;
            }
            else if (currentMode == "LopHoc")
            {
                txtMa.Text = row.Cells["Mã lớp"].Value?.ToString() ?? "";
                txtTenLop.Text = row.Cells["Tên lớp"].Value?.ToString() ?? "";

            }
        }
        private void dgvDanhSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || currentMode != "LopHoc") return;

            DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];
            int classId = Convert.ToInt32(row.Cells["Mã lớp"].Value);
            string className = row.Cells["Tên lớp"].Value?.ToString() ?? "";

            HienThiSinhVienTheoLop(classId, className);
        }

        private void HienThiSinhVienTheoLop(int classId, string className)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(LayConnectionString()))
                {
                    conn.Open();
                    string sql = @"SELECT s.Id AS [Mã SV], s.Name AS [Họ tên], 
                                   FORMAT(s.BirthDate, 'dd/MM/yyyy') AS [Ngày sinh]
                                   FROM Student s WHERE s.ClassId = @classId ORDER BY s.Id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@classId", classId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }

                Form frmSVLop = new Form();
                frmSVLop.Text = "Danh sách sinh viên lớp: " + className;
                frmSVLop.Size = new System.Drawing.Size(600, 400);
                frmSVLop.StartPosition = FormStartPosition.CenterParent;

                DataGridView dgv = new DataGridView();
                dgv.Dock = DockStyle.Fill;
                dgv.DataSource = dt;
                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;
                dgv.ReadOnly = true;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.BackgroundColor = System.Drawing.Color.White;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                dgv.EnableHeadersVisualStyles = false;
                dgv.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
                dgv.RowTemplate.Height = 28;

                frmSVLop.Controls.Add(dgv);
                frmSVLop.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách sinh viên!\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            XoaFormNhap();

            if (currentMode == "SinhVien")
            {
                txtTen.Focus();
            }
            else
            {
                txtTenLop.Focus();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(LayConnectionString()))
                {
                    conn.Open();

                    if (currentMode == "SinhVien")
                    {
                        string hoTen = txtTen.Text.Trim();
                        if (string.IsNullOrEmpty(hoTen))
                        {
                            MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        int? classId = (cboLop.SelectedValue != null && cboLop.SelectedValue != DBNull.Value)
                                        ? Convert.ToInt32(cboLop.SelectedValue)
                                        : (int?)null;
                        DateTime ngaySinh = dtpNgaySinh.Value;

                        if (isAdding)
                        {
                            string sql = "INSERT INTO Student (Name, ClassId, BirthDate) VALUES (@name, @classId, @birth)";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@name", hoTen);
                            cmd.Parameters.AddWithValue("@classId", classId.HasValue ? (object)classId.Value : DBNull.Value);
                            cmd.Parameters.AddWithValue("@birth", ngaySinh);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtMa.Text))
                            {
                                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            int id = int.Parse(txtMa.Text);
                            string sql = "UPDATE Student SET Name=@name, ClassId=@classId, BirthDate=@birth WHERE Id=@id";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@name", hoTen);
                            cmd.Parameters.AddWithValue("@classId", classId.HasValue ? (object)classId.Value : DBNull.Value);
                            cmd.Parameters.AddWithValue("@birth", ngaySinh);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        LoadDanhSachSinhVien();
                    }
                    else
                    {
                        string tenLop = txtTenLop.Text.Trim();
                        if (string.IsNullOrEmpty(tenLop))
                        {
                            MessageBox.Show("Vui lòng nhập tên lớp!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (isAdding)
                        {
                            string sql = "INSERT INTO Class (ClassName) VALUES (@name)";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@name", tenLop);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm lớp học thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtMa.Text))
                            {
                                MessageBox.Show("Vui lòng chọn lớp cần sửa!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            int id = int.Parse(txtMa.Text);
                            string sql = "UPDATE Class SET ClassName=@name WHERE Id=@id";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@name", tenLop);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật lớp học thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        LoadDanhSachLopHoc();
                    }

                    isAdding = false;
                    XoaFormNhap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isAdding = false;

            if (currentMode == "SinhVien")
                txtTen.Focus();
            else
                txtTenLop.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count == 0 || string.IsNullOrEmpty(txtMa.Text))
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult xacNhan = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacNhan != DialogResult.Yes) return;

            try
            {
                int id = int.Parse(txtMa.Text);
                using (SqlConnection conn = new SqlConnection(LayConnectionString()))
                {
                    conn.Open();

                    if (currentMode == "SinhVien")
                    {
                        string sql = "DELETE FROM Student WHERE Id=@id";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachSinhVien();
                    }
                    else
                    {
                        string sqlCheck = "SELECT COUNT(*) FROM Student WHERE ClassId=@id";
                        SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                        cmdCheck.Parameters.AddWithValue("@id", id);
                        int count = (int)cmdCheck.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show($"Không thể xóa! Lớp này còn {count} sinh viên.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string sql = "DELETE FROM Class WHERE Id=@id";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa lớp học thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachLopHoc();
                    }
                }

                XoaFormNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaFormNhap()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            if (cboLop.Items.Count > 0)
                cboLop.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Now;
            txtTenLop.Text = "";
        }
    }
}

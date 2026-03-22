using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FrmDanhSach : Form
    {
        public FrmDanhSach()
        {
            InitializeComponent();
            this.Load += FrmDanhSach_Load;
        }

        private string LayConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;
        }

        private void FrmDanhSach_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection(LayConnectionString());
                conn.Open();

                string sql = "SELECT Id AS [Mã SV], Name AS [Họ tên], Class AS [Lớp], BirthDate AS [Ngày sinh] FROM Student";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                reader.Close();
                conn.Close();

                dgvSinhVien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách sinh viên!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgLuu = new SaveFileDialog();
            dlgLuu.Filter = "Backup File (*.bak)|*.bak";
            dlgLuu.FileName = "QLSV_Backup_" + DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".bak";

            if (dlgLuu.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                SqlConnection conn = new SqlConnection(LayConnectionString());
                conn.Open();

                string sql = "BACKUP DATABASE QuanLySinhVienDB TO DISK = @duongDan WITH FORMAT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@duongDan", dlgLuu.FileName);
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Sao lưu cơ sở dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sao lưu thất bại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult xacNhan = MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacNhan == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

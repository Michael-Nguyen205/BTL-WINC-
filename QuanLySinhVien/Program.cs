using System;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            FrmDangNhap frmLogin = new FrmDangNhap();
            DialogResult ketQua = frmLogin.ShowDialog();

            if (ketQua == DialogResult.OK)
            {
                Application.Run(new FrmDanhSach());
            }
        }
    }
}

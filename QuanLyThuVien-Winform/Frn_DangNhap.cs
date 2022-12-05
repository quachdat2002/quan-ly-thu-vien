using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_Winform
{
    public partial class Frn_DangNhap : Form
    {
        private readonly BaseContext baseContext;
        public Frn_DangNhap()
        {
            InitializeComponent();
            baseContext = new BaseContext();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var tenDN = txtUser.Text;
            var matKhau = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(tenDN))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.");
                txtUser.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.");
                txtPassword.Focus();
                return;
            }
            var checkLogin = baseContext.NguoiDungs.AsQueryable().FirstOrDefault(z => z.TenDangNhap == tenDN && z.MatKhau == matKhau);
           
            if (checkLogin != null)
            {
                Frm_Main fm = new Frm_Main();
                fm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập hoặc mật khẩu không chính xác.");
            }
        }
    }
}

using DTO;
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
    public partial class Frm_DocGia : Form
    {
        private readonly BaseContext baseContext;
        public Frm_DocGia()
        {
            InitializeComponent();
            baseContext = new BaseContext();
            BindingGridview();
        }

        private void dtgThemDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dtgThemDocGia.Rows[rowIndex];
            txtMaDocGia.Text = row.Cells[6].Value?.ToString();
            txtTen.Text = row.Cells[0].Value?.ToString();
            //dtNamSinh.Value = Convert.ToDateTime(row.Cells[2].Value);
            txtSĐT.Text = row.Cells[2].Value?.ToString();
            txtEmail.Text = row.Cells[3].Value?.ToString();
            txtDiaChi.Text = row.Cells[4].Value?.ToString();
            cbbGioiTinh.Text = row.Cells[5].Value?.ToString();
        }
        private void BindingGridview()
        { 
            List<DocGiaDTO> data = baseContext.DocGias.Select(z => new DocGiaDTO
            {
                Id = z.Id,
                HoVaTen = z.HoVaTen,
                NgaySinh = z.NgaySinh,
                DienThoai = z.DienThoai,
                Email = z.Email,
                DiaChi = z.DiaChi,
                GioiTinh = z.GioiTinh,
                NgayTao = z.NgayTao,
                NgayCapNhat = z.NgayCapNhat
            }).ToList();
            DataTable table = new DataTable();
            if (data != null && data.Any())
            {
                table = data.ToDataTable<DocGiaDTO>();
            }
            dtgThemDocGia.DataSource = table;
            dtgThemDocGia.AutoGenerateColumns = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tenDocGia = txtTen.Text;
            var ngaySinh = dtNamSinh.Value;
            var dienThoai = txtSĐT.Text;
            var email = txtEmail.Text;
            var diaChi = txtDiaChi.Text;
            var gioiTinh = cbbGioiTinh.Text.ToString();
            if (string.IsNullOrWhiteSpace(tenDocGia))
            {
                MessageBox.Show("Tên độc giả là bắt buộc.");
                txtTen.Focus();
                return;
            }
            var Seq = baseContext.DocGias.Count() + 1;
            var Entity = new DocGia
            {
                HoVaTen = tenDocGia,
                NgaySinh = Convert.ToDateTime(ngaySinh),
                DienThoai = dienThoai,
                Email = email,
                DiaChi = diaChi,
                GioiTinh = gioiTinh,
                NgayTao = DateTime.Now
            };
            baseContext.DocGias.Add(Entity);
            var Result = baseContext.SaveChanges() > 0;
            if (Result)
            {
                MessageBox.Show("Thêm mới độc giả thành công.");
                txtTen.Text = string.Empty;
                BindingGridview();
            }
            else
            {
                MessageBox.Show("Không thể tạo thông tin độc giả lúc này.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maDocGia = Convert.ToInt32(txtMaDocGia.Text);
            var tenDocGia = txtTen.Text;
            var ngaySinh = dtNamSinh.Value;
            var dienThoai = txtSĐT.Text;
            var email = txtEmail.Text;
            var diaChi = txtDiaChi.Text;
            var gioiTinh = cbbGioiTinh.Text.ToString();
            if (string.IsNullOrWhiteSpace(tenDocGia))
            {
                MessageBox.Show("Tên độc giả là bắt buộc.");
                txtTen.Focus();
                return;
            }
            var Entity = baseContext.DocGias.FirstOrDefault(z => z.Id == maDocGia);
            if (Entity == null)
            {
                MessageBox.Show("Không tìm thấy thông tin độc giả.");
                return;
            }
            Entity.HoVaTen = tenDocGia;
            Entity.NgaySinh = Convert.ToDateTime(ngaySinh);
            Entity.DienThoai = dienThoai;
            Entity.Email = email;
            Entity.DiaChi = diaChi;
            Entity.GioiTinh = gioiTinh;
            Entity.NgayCapNhat = DateTime.Now;
            var Result = baseContext.SaveChanges() > 0;
            if (Result)
            {
                MessageBox.Show("Cập nhật thông tin độc giả thành công.");
                BindingGridview();
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin độc gỉả lúc này.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt32(txtMaDocGia.Text);
            var Entity = baseContext.DocGias.FirstOrDefault(z => z.Id == id);
            if (Entity == null)
            {
                MessageBox.Show("Không tìm thấy thông tin độc giả.");
                return;
            }
            baseContext.DocGias.Remove(Entity);
            var Result = baseContext.SaveChanges() > 0;
            if (Result)
            {
                BindingGridview();
            }
            else
            {
                MessageBox.Show("Không thể xóa thông tin độc giả lúc này.");
            }
        }
    }
}

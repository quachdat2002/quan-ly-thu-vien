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
    public partial class Frm_Sach : Form
    {
        private readonly BaseContext baseContext;
        public Frm_Sach()
        {
            InitializeComponent();
            baseContext = new BaseContext();
            BindingGridview();
        }
        private void BindingGridview()
        {
            List<SachDTO> data = baseContext.Sachs.Select(z => new SachDTO
            {
                Id = z.Id,
                TenSach = z.TenSach,
                TacGia = z.TacGia,
                NhaXuatBan = z.NhaXuatBan,
                NamXuatBan = z.NamXuatBan,
                DonGia = z.DonGia,
                SoLuong = z.SoLuong,
                NgayTao = z.NgayTao,
                NgayCapNhat = z.NgayCapNhat
            }).ToList();
            DataTable table = new DataTable();
            if (data != null && data.Any())
            {
                table = data.ToDataTable<SachDTO>();
            }
            dtgSach.DataSource = table;
            dtgSach.AutoGenerateColumns = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tenSach = txtTenSach.Text;
            var tacGia = txtTacGia.Text;
            var NXB = txtNXB.Text;
            var namXB = txtNamXB.Text;
            var donGia = txtDonGia.Text;
            var soLuong = txtSoLuong.Text;
            if (string.IsNullOrWhiteSpace(tenSach))
            {
                MessageBox.Show("Tên sách là bắt buộc.");
                txtTenSach.Focus();
                return;
            }
            var Seq = baseContext.Sachs.Count() + 1;
            var Entity = new Sach
            {
                TenSach = tenSach,
                TacGia = tacGia,
                NhaXuatBan = NXB,
                NamXuatBan = int.Parse(namXB),
                DonGia = int.Parse(donGia),
                SoLuong = int.Parse(soLuong),
                NgayTao = DateTime.Now
            };
            baseContext.Sachs.Add(Entity);
            var Result = baseContext.SaveChanges() > 0;
            if (Result)
            {
                MessageBox.Show("Thêm mới sách thành công.");
                txtTenSach.Text = string.Empty;
                BindingGridview();
            }
            else
            {
                MessageBox.Show("Không thể tạo thông tin sách lúc này.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maSach = Convert.ToInt32(txtMaSach.Text);
            var tenSach = txtTenSach.Text;
            var tacGia = txtTacGia.Text;
            var NXB = txtNXB.Text;
            var namXB = txtNamXB.Text;
            var donGia = txtDonGia.Text;
            var soLuong = txtSoLuong.Text;
            if (maSach < 1)
            {
                MessageBox.Show("Vui lòng chọn sách.");
                txtTenSach.Focus();
                return;
            }
            var Entity = baseContext.Sachs.FirstOrDefault(z => z.Id == maSach);
            if (Entity == null)
            {
                MessageBox.Show("Không tìm thấy thông tin sách.");
                return;
            }
            Entity.TenSach = tenSach;
            Entity.TacGia = tacGia;
            Entity.NamXuatBan = int.Parse(namXB);
            Entity.NhaXuatBan = NXB;
            Entity.DonGia = int.Parse(donGia);
            Entity.SoLuong = int.Parse(soLuong);
            Entity.NgayCapNhat = DateTime.Now;
            var Result = baseContext.SaveChanges() > 0;
            if (Result)
            {
                MessageBox.Show("Cập nhật thông tin sách thành công.");
                BindingGridview();
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin sách lúc này.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt32(txtMaSach.Text);
            var Entity = baseContext.Sachs.FirstOrDefault(z => z.Id == id);
            if (Entity == null)
            {
                MessageBox.Show("Không tìm thấy thông tin sách.");
                return;
            }
            baseContext.Sachs.Remove(Entity);
            var Result = baseContext.SaveChanges() > 0;
            if (Result)
            {
                BindingGridview();
            }
            else
            {
                MessageBox.Show("Không thể xóa thông tin sách lúc này.");
            }
        }

        private void dtgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dtgSach.Rows[rowIndex];
            txtMaSach.Text = row.Cells[6].Value?.ToString();
            txtTenSach.Text = row.Cells[1].Value?.ToString();
            txtTacGia.Text = row.Cells[2].Value?.ToString();
            txtNXB.Text = row.Cells[3].Value?.ToString();
            txtNamXB.Text = row.Cells[4].Value?.ToString();
            txtDonGia.Text = row.Cells[5].Value?.ToString();
            txtSoLuong.Text = row.Cells[6].Value?.ToString();
        }
    }
}

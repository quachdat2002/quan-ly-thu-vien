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
    public partial class Frm_QuanLyMuon : Form
    {
        private readonly BaseContext baseContext;
        public Frm_QuanLyMuon()
        {
            InitializeComponent();
            baseContext = new BaseContext();
            LoadDropdownDocGia();
            LoadDropdownSach();
            BindingGridview();
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            int maDocGia = Convert.ToInt32(txtMaDocGia.Text);
            int maSach = Convert.ToInt32(txtMaSachMuon.Text);
            var exist = baseContext.SachMuons.FirstOrDefault(w => w.MaDocGia == maDocGia && w.MaSach == maSach);
            if (exist != null)
            {
                exist.SoLuong = exist.SoLuong + 1;
                exist.NgayCapNhat = DateTime.Now;
            }
            else
            {
                var Entity = new SachMuon
                {
                    MaSach = maSach,
                    MaDocGia = maDocGia,
                    SoLuong = 1,
                    NgayTao = DateTime.Now
                };
                baseContext.SachMuons.Add(Entity);
            }
            var Result = baseContext.SaveChanges() > 0;

            BindingGridview();
        }

        private void btnXuatPhieu_Click(object sender, EventArgs e)
        {

        }
        private void LoadDropdownSach()
        {
            var dataTable = new DataTable();
            var data = baseContext.Sachs.Select(z => new SachView
            {
                Id = z.Id,
                TenSach = z.TenSach
            }).ToList();

            if (data != null && data.Any())
            {
                dataTable = data.ToDataTable<SachView>();
            }
            cbbSachMuon.DisplayMember = "TenSach";
            cbbSachMuon.ValueMember = "Id";
            cbbSachMuon.DataSource = dataTable;
        }

        private void LoadDropdownDocGia()
        {
            var dataTable = new DataTable();
            var data = baseContext.DocGias.Select(z => new DocGiaView
            {
                Id = z.Id,
                HoVaTen = z.HoVaTen
            }).ToList();

            if (data != null && data.Any())
            {
                dataTable = data.ToDataTable<DocGiaView>();
            }
            cbbDocGia.DisplayMember = "HoVaTen";
            cbbDocGia.ValueMember = "Id";
            cbbDocGia.DataSource = dataTable;
        }

        private void cbbDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maDocGia = Convert.ToInt32(cbbDocGia.SelectedValue);
            var docGiaDetail = baseContext.DocGias.Where(w => w.Id == maDocGia).FirstOrDefault();
            if (docGiaDetail != null)
            {
                txtMaDocGia.Text = docGiaDetail.Id.ToString();
                txtHoVaTen.Text = docGiaDetail.HoVaTen;
                txtDienThoai.Text = docGiaDetail.DienThoai;
                txtEmail.Text = docGiaDetail.Email;
                txtDiaChi.Text = docGiaDetail.DiaChi;
                txtGioiTinh.Text = docGiaDetail.GioiTinh;
            }
        }

        private void cbbSachMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maSach = Convert.ToInt32(cbbSachMuon.SelectedValue);
            var sachDetail = baseContext.Sachs.Where(w => w.Id == maSach).FirstOrDefault();
            if (sachDetail != null)
            {
                txtMaSachMuon.Text = sachDetail.Id.ToString();
                txtTenSach.Text = sachDetail.TenSach;
                txtTacGia.Text = sachDetail.TacGia;
                txtNXB.Text = sachDetail.NhaXuatBan;
                txtNamXB.Text = sachDetail.NamXuatBan.ToString();
                txtDonGia.Text = sachDetail.DonGia.ToString();
            }
        }

        private void BindingGridview()
        {
            int maDocGia = Convert.ToInt32(cbbDocGia.SelectedValue);
            if (maDocGia > 0)
            {
                var maSachs = baseContext.SachMuons.Where(w => w.MaDocGia == maDocGia).Select(s => s.MaSach);
                List<SachDTO> data = baseContext.Sachs.Join(baseContext.SachMuons, s => s.Id, sm => sm.MaSach, (s, sm) => new { s, sm })
                    .Where(w => maSachs.Contains(w.sm.MaSach)).Select(z => new SachDTO
                    {
                        Id = z.s.Id,
                        TenSach = z.s.TenSach,
                        TacGia = z.s.TacGia,
                        NhaXuatBan = z.s.NhaXuatBan,
                        NamXuatBan = z.s.NamXuatBan,
                        DonGia = z.s.DonGia,
                        SoLuong = z.sm.SoLuong,
                        NgayTao = z.s.NgayTao,
                        NgayCapNhat = z.s.NgayCapNhat
                    }).ToList();
                DataTable table = new DataTable();
                if (data != null && data.Any())
                {
                    table = data.ToDataTable<SachDTO>();
                }
                dtgSachMuon.DataSource = table;
                dtgSachMuon.AutoGenerateColumns = false;
            }
        }
    }

    public class SachView
    {
        public long Id { get; set; }
        public string TenSach { get; set; }
    }
    public class DocGiaView
    {
        public long Id { get; set; }
        public string HoVaTen { get; set; }
    }
}

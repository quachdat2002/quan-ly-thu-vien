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
    public partial class Frm_QuanLyTra : Form
    {
        private readonly BaseContext baseContext;
        public Frm_QuanLyTra()
        {
            InitializeComponent();
            baseContext = new BaseContext();
            LoadDropdownNguoiMuon();
            LoadDropdownSach();
            BindingGridview();
        }

        private void button1_Click(object sender, EventArgs e)
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
            cbbSach.DisplayMember = "TenSach";
            cbbSach.ValueMember = "Id";
            cbbSach.DataSource = dataTable;
        }

        private void LoadDropdownNguoiMuon()
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
            cbbNguoiMuon.DisplayMember = "HoVaTen";
            cbbNguoiMuon.ValueMember = "Id";
            cbbNguoiMuon.DataSource = dataTable;
        }

        private void BindingGridview()
        {
            int maDocGia = Convert.ToInt32(cbbNguoiMuon.SelectedValue);
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

        private void btnTra_Click(object sender, EventArgs e)
        {
            int maSach = Convert.ToInt32(cbbSach.SelectedValue);
            int madocGia = Convert.ToInt32(cbbNguoiMuon.SelectedValue);
            if (maSach > 0 && madocGia > 0)
            {
                var sachMuon = baseContext.SachMuons.Where(w => w.MaSach == maSach && w.MaDocGia == madocGia).ToList();
                if (sachMuon != null)
                {
                    baseContext.SachMuons.RemoveRange(sachMuon);
                    var Result = baseContext.SaveChanges() > 0;
                    BindingGridview();
                }
            }
        }

        private void cbbNguoiMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingGridview();
        }

        private void cbbSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maSach = Convert.ToInt32(cbbSach.SelectedValue);
            var sachDetail = baseContext.Sachs.Where(w => w.Id == maSach).FirstOrDefault();
            if (sachDetail != null)
            {
                txtTenSach.Text = sachDetail.Id.ToString();
                txtNhaXuatBan.Text = sachDetail.TenSach;
                txtNamXuatBan.Text = sachDetail.TacGia;
                txtDonGia.Text = sachDetail.DonGia.ToString();
                txtSoLuong.Text = sachDetail.SoLuong.ToString();
            }
        }
    }
}

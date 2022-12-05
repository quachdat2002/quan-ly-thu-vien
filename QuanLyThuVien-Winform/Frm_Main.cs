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
    public partial class Frm_Main : Form
    {
        public List<SachDTO> sachList;
        private readonly BaseContext baseContext;
        public Frm_Main()
        {
            InitializeComponent();
            sachList = new List<SachDTO>();
            baseContext = new BaseContext();
            HienThiDataGridView();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            Frm_Sach frm = new Frm_Sach();
            frm.ShowDialog();
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            Frm_DocGia frm = new Frm_DocGia();
            frm.ShowDialog();
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            Frm_QuanLyMuon frm = new Frm_QuanLyMuon();
            frm.ShowDialog();
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            Frm_QuanLyTra frm = new Frm_QuanLyTra();
            frm.ShowDialog();
        }
        private void HienThiDataGridView()
        {
            dtgMuonSach.DataSource = null;
            var sach = baseContext.Sachs.AsQueryable();
            var muon = baseContext.Muons.AsQueryable();
            //var sachIds = muon.Select(s => s.SachID).Select(s=>s.GetConvertedType());

            List<SachView> data = sach.Select(z => new SachView
            {
                 Id = z.Id,
                 TenSach = z.TenSach,
                 TacGia = z.TacGia,
                 NhaXuatBan = z.NhaXuatBan,
                 NamXuatBan = z.NamXuatBan,
                 DonGia = z.DonGia,
                 SoLuong = z.SoLuong
             }).ToList();
            DataTable table = new DataTable();
            if (data != null && data.Any())
            {
                table = data.ToDataTable<SachView>();
            }
            dtgMuonSach.DataSource = table;
            dtgMuonSach.AutoGenerateColumns = false;

            //dtgMuonSach.Columns[0].HeaderText = "Mã";
            //dtgMuonSach.Columns[1].HeaderText = "Tên sách";
            //dtgMuonSach.Columns[2].HeaderText = "Tác giả";
            //dtgMuonSach.Columns[3].HeaderText = "NXB";
            //dtgMuonSach.Columns[4].HeaderText = "Năm XB";
            //dtgMuonSach.Columns[5].HeaderText = "Đơn giá";
            //dtgMuonSach.Columns[6].HeaderText = "Số lượng";
        }

        public class SachView
        {
            public long Id { get; set; }
            public string TenSach { get; set; }
            public string TacGia { get; set; }
            public string NhaXuatBan { get; set; }
            public int NamXuatBan { get; set; }
            public int DonGia { get; set; }
            public int SoLuong { get; set; }
        }
    }
}

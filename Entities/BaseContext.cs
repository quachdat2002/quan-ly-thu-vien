using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("Core_Context") { }

        public virtual DbSet<Sach> Sachs { get; set; }
        public virtual DbSet<DocGia> DocGias { get; set; }
        public virtual DbSet<Tra> Tras { get; set; }
        public virtual DbSet<Muon> Muons { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<SachMuon> SachMuons { get; set; }

    }
}
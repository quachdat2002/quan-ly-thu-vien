using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SachMuon : BaseEntities
    {
        public long MaSach { get; set; }
        public long MaDocGia { get; set; }
        public int SoLuong { get; set; }
    }
}

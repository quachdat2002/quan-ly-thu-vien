using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGiaDTO : BaseDTO
    {
        public string HoVaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TraDTO : BaseDTO
    {
        public int MuonID { get; set; }
        public DateTime NgayTra { get; set; }
        public int TienPhat { get; set; }
    }
}

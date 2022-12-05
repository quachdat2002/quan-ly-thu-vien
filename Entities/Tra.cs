using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Tra : BaseEntities
    {
        public int MuonID { get; set; }
        public DateTime NgayTra { get; set; }
        public int TienPhat { get; set; }
    }
}

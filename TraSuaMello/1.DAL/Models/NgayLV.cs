using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaMello._1.DAL.Models
{
    public class NgayLV
    {
        [Key]
        public DateTime Ngay { get; set; }
        public string MaCa { get; set; }
        public virtual ICollection<CaLam> CaLams { get; set; }
    }
}

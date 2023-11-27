using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaMello._1.DAL.Models
{
    public class CaLam
    {
        [Key]
        public string MaCa { get; set; }
        public bool BatDau { get; set; }
        public bool KetThuc { get; set; }
        public virtual NgayLV NgayLV { get; set; }
    }
}

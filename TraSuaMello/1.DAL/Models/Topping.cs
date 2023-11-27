using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaMello._1.DAL.Models
{
    public class Topping
    {
        [Key]
        public string MaTopping { get; set; }
        public string Ten { get; set; }
        public string Gia { get; set; }
        public virtual HoaDonChiTiet HoaDonChiTiets { get; set; }

    }
}

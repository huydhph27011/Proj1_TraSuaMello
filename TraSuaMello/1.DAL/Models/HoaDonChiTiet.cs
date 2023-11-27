using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaMello._1.DAL.Models
{
    public class HoaDonChiTiet
    {
        [Key]
        public string MaHDCT { get; set; }
        public string MaHoaDon { get; set; }
        public string MaTraSua { get; set; }
        public string MaTopping { get; set; }
        public virtual ICollection<Topping> Toppings { get; set; }
        public virtual ICollection<TraSua> TraSuas { get; set; }
        public virtual HoaDon HoaDon { get; set; }
    }
}

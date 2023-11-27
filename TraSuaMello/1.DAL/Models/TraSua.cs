using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaMello._1.DAL.Models
{
    public class TraSua
    {
        [Key]
        public string MaTraSua { get; set; }
        public string Loai { get; set; }
        public int Size { get; set; }
        public double Gia { get; set; }
        public virtual HoaDonChiTiet HoaDonChiTiets { get; set; }
    }
}

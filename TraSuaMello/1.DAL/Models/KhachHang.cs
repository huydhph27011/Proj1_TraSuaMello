using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaMello._1.DAL.Models
{
    public class KhachHang
    {
        [Key]
        public string MaKhachHang { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string MaMember { get; set; }
        public virtual Membership Membership { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}

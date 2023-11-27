using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaMello._1.DAL.Models
{
    public class Membership
    {
        [Key]
        public string MaMember { get; set; }
        public DateTime NgayDangKi { get; set; }
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
}

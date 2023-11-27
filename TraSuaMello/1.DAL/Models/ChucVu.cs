using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaMello._1.DAL.Models
{
    public class ChucVu
    {
        [Key]
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaMello._1.DAL.Models
{
    public class LichLamViec
    {
        [Key]
        public string MaLich { get; set; }
        public DateTime Ngay { get; set; }
        public string MaNhanVien { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual NgayLV NgayLV { get; set; }
    }
}

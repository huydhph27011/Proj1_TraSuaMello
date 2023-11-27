using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaMello._1.DAL.Models
{
    public class Voucher
    {
        [Key]
        public string MaGiamGia { get; set; }
        public int SoLuong { get; set; }
        public DateTime ThoiHan { get; set; }
        public int TrangThai { get; set; }
        public float GiaTri { get; set; }
        public string MaNhanVien { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}

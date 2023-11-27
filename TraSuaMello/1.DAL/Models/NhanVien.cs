using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaMello._1.DAL.Models
{
    public class NhanVien
    {
        [Key]
        public string MaNhanVien { get; set; }
        public string Name { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public double TienLuong { get; set; }
        public string MaChucVu { get; set; }
        public virtual ChucVu ChucVu { get; set; }
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
        public virtual ICollection<Voucher> Vouchers { get; set; }
        public virtual ICollection<LichLamViec> LichLamViecs { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaMello._1.DAL.Models
{
    public class HoaDon
    {
        [Key]
        public string MaHoaDon { get; set; }
        public DateTime NgayLap { get; set; }
        public double ThanhTien { get; set; }
        public string MaKhachHang { get; set; }
        public string MaVoucher { get; set; }
        public string MaNhanVien { get; set; }
        public int HinhThuThanhToan { get; set; }
        public int MaBan { get; set; }
        public virtual Ban Ban { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual Voucher Voucher { get; set; }
        public virtual KhachHang KhachHang { get; set; }
    }
}

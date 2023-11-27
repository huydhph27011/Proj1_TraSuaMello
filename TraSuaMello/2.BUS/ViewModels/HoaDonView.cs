using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaMello._2.BUS.ViewModels
{
    public class HoaDonView
    {
        public string MaHoaDon { get; set; }
        public DateTime NgayLap { get; set; }
        public double ThanhTien { get; set; }
        public string MaVoucher { get; set; }
        public string TenNV { get; set; }
        public int HinhThuThanhToan { get; set; }
        public int SoBan { get; set; }
    }
}

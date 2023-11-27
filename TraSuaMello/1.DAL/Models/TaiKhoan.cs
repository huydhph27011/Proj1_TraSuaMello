using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaMello._1.DAL.Models
{
    public class TaiKhoan
    {
        [Key]
        public string MaTaiKhoan { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string MaNhanVien { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}

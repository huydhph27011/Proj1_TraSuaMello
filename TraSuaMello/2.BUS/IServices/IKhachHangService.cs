using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._2.BUS.IServices
{
    internal interface IKhachHangService
    {
        public string Add(KhachHang kh);
        public string Delete(string ma);
        public string Update(KhachHang kh);
        public List<KhachHang> GetAll();
        public KhachHang GetKhachHangByName(string name);
    }
}

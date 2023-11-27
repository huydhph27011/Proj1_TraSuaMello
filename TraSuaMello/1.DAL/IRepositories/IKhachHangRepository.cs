using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._1.DAL.IRepositories
{
    public interface IKhachHangRepository
    {
        public List<KhachHang> GetKhachHangs();
        public bool GetKhachHangById(int id);
        public KhachHang GetKhachHangByName(string name);
        public bool Add(KhachHang kh);
        public bool Delete(string ma);
        public bool Update(KhachHang kh);
    }
}

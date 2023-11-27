using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._1.DAL.IRepositories
{
    public interface INhanVienRepository
    {
        public List<NhanVien> GetNhanViens();
        public bool GetBanById(string ma);
        public bool Add(NhanVien nv);
        public bool Delete(string ma);
        public bool Update(NhanVien nv);
    }
}

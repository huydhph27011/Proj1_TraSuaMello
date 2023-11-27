using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._1.DAL.IRepositories
{
    public interface IChucVuRepository
    {
        public List<ChucVu> GetChucVus();
        public bool GetChucVuById(int id);
        public bool Add(ChucVu cv);
        public bool Delete(string ma);
        public bool Update(ChucVu cv);
    }
}

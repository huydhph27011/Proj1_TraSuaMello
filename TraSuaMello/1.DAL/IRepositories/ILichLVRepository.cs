using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._1.DAL.IRepositories
{
    public interface ILichLVRepository
    {
        public List<LichLamViec> GetLichLVs();
        public bool GetLLVById(int id);
        public bool Add(LichLamViec llv);
        public bool Delete(string ma);
        public bool Update(LichLamViec llv);
    }
}

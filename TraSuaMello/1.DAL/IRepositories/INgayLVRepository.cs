using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._1.DAL.IRepositories
{
    public interface INgayLVRepository
    {
        public List<NgayLV> GetNgayLVs();
        public bool GetNgayLVById(int id);
        public bool Add(NgayLV ban);
        public bool Delete(string ma);
        public bool Update(NgayLV ban);
    }
}

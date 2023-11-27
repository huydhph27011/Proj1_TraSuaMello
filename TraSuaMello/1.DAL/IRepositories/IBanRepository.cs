using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._1.DAL.IRepositories
{
    public interface IBanRepository
    {
        public List<Ban> GetBans();
        public bool GetBanById(int id);
        public bool Add(Ban ban);
        public bool Delete(string ma);
        public bool Update(Ban ban);
    }
}

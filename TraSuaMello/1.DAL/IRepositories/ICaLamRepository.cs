using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._1.DAL.IRepositories
{
    public interface ICaLamRepository
    {
        public List<CaLam> GetCaLams();
        public bool GetCaLamById(int id);
        public bool Add(CaLam ban);
        public bool Delete(string ma);
        public bool Update(CaLam ban);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._1.DAL.IRepositories
{
    public interface ITraSuaRepository
    {
        public List<TraSua> GetTraSuas();
        public bool GetTraSuaById(int id);
        public bool Add(TraSua ts);
        public bool Delete(string ma);
        public bool Update(TraSua ts);
    }
}

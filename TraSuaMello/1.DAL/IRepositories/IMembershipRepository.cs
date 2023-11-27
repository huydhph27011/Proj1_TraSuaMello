using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._1.DAL.IRepositories
{
    public interface IMembershipRepository
    {
        public List<Membership> GetMembers();
        public bool GetMemberById(int id);
        public bool Add(Membership mem);
        public bool Delete(string ma);
        public bool Update(Membership mem);
    }
}

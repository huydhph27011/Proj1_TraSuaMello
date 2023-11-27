using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Context;
using TraSuaMello._1.DAL.IRepositories;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._1.DAL.Repositories
{
    public class MembershipRepository : IMembershipRepository
    {
        ShopDbContext _dbContext;
        public MembershipRepository()
        {
            _dbContext = new ShopDbContext();
        }
        public bool Add(Membership mem)
        {
            _dbContext.Add(mem);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(string ma)
        {
            _dbContext.Remove(ma);
            _dbContext.SaveChanges();
            return true;
        }

        public bool GetMemberById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Membership> GetMembers()
        {
            return _dbContext.memberships.ToList();
        }

        public bool Update(Membership mem)
        {
            _dbContext.Update(mem);
            _dbContext.SaveChanges();
            return true;
        }
    }
}

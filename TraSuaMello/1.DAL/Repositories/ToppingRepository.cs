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
    public class ToppingRepository : IToppingRepository
    {
        ShopDbContext _dbContext;
        public ToppingRepository()
        {
            _dbContext = new ShopDbContext();
        }
        public bool Add(Topping ban)
        {
            _dbContext.Add(ban);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(string ma)
        {
            _dbContext.Remove(ma);
            _dbContext.SaveChanges();
            return true;
        }

        public bool GetToppingById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Topping> GetToppings()
        {
            return _dbContext.toppings.ToList();
        }

        public bool Update(Topping ban)
        {
            _dbContext.Update(ban);
            _dbContext.SaveChanges();
            return true;
        }
    }
}

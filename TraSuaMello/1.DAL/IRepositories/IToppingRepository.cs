using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._1.DAL.IRepositories
{
    public interface IToppingRepository
    {
        public List<Topping> GetToppings();
        public bool GetToppingById(int id);
        public bool Add(Topping ban);
        public bool Delete(string ma);
        public bool Update(Topping ban);
    }
}

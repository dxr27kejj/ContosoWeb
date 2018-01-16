using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;

namespace Contoso.Data
{
    public class PersonRepository : Repository<People>, IPersonRepository
    {
        public PersonRepository(ContosoDbContext context) : base(context)
        {
        }

        public People GetByLastName(string LastName)
        {
            var Person = _context.People.Where(p => p.LastName == LastName).FirstOrDefault();
            return Person;
        }
    }
    public interface IPersonRepository : IRepository<People>
    {
        People GetByLastName(String name);
    }
}

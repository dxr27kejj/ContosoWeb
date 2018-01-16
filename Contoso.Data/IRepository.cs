using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public interface IRepository<T> where T : class //generic constraints in c#
                                            //struct: only value types
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int Id);
        IEnumerable<T> GetAll();
        IQueryable<T> GetQueryable();
        T Get(Expression<Func<T, bool>> where);
        void SaveChanges();
    }
}

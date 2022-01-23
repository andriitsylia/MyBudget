using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IMyBudgetRepository<T> where T : class
    {
        void Create(T entity);
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
                           Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                           string includeProperties = "");
        T GetById(int id);
        void Update(T entity);
        void Delete(T entity);
        bool SaveChanges();
    }
}

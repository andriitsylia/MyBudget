using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IMyBudgetService<T> where T : class
    {
        void Create(T item);
        IEnumerable<T> GetAll();
        T GetById(int id);
        bool Update(int id, T item);
        bool Delete(int id);
    }
}

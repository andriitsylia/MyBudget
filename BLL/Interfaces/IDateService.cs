using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IDateService<T> : IMyBudgetService<T> where T : class
    {
        IEnumerable<T> GetByDate(DateTime date);
        IEnumerable<T> GetByDateInterval(DateTime beginDate, DateTime endDate);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IByDateService<T> : IBudgetService<T> where T : class
    {
        IEnumerable<T> GetByDate(DateTime date);
        IEnumerable<T> GetByDateInterval(DateTime beginDate, DateTime endDate);
    }
}

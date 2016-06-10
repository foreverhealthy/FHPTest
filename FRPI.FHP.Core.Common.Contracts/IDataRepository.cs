using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRPI.FHP.Core.Common.Contracts
{
    public interface IDataRepository
    {

    }

 public interface IDataRepository<T> : IDataRepository 
        where T : class,  new ()
    {
        T Add(T entity);
        void Remove(T entity);
        void Remove(int id);
        T Update(T entity);
        IEnumerable<T> Get();
        T Get(int id);
        IEnumerable<T> GetData(Func<T, bool> predicate);
        List<T> ExecStoredProcedure(string storedProc, SqlParameter sqlParams);
        IQueryable<T> ReturnQueryableList();
        IList<T> ReturnList();

        //IEnumerable<object> GetTreeData(Func<T, bool> predicate);
        //IEnumerable<T> GetAllLazyLoad(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] children);
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONECCTION
{
    public interface IConecctionSQL
    {
        public void ExecuteSqlNonQuery(string comandSql);
        public void ExecuteSqlNonQueryAuto(string procedureName, Object parameters);
        public IEnumerable<T> ExecuteSqlViewFindByCondition<T>(string procedureName, object parameters);
        public T ExecuteSqlViewId<T>(string procedureName, T parameters);
        public IEnumerable<T> ExecuteSqlViewAll<T>(string procedureName, T parameters);
        public object ExecuteSqlInsert<T>(string procedureName, T parameters);
        public IEnumerable<T> ExecuteSqlInsertQuery<T>(string procedureName, Object parameters);
        public object ExecuteSqlUpdate<T>(string procedureName, T parameters);
        public object ExecuteSqlDelete<T>(string procedureName, T parameters);
        //public DbParametro[] ExecuteSqlNonQuery(string procedureName, DbParametro[] parameters);
        public IEnumerable<T> ExecuteSqlQuery<T>(string comandSql);
        //public IEnumerable<T> ExecuteSqlQuery<T>(string procedureName, DbParametro[] parameters);
        public void ExecuteSqlNonQueryAutoParameters(string procedureName, object parameters);
    }    
}

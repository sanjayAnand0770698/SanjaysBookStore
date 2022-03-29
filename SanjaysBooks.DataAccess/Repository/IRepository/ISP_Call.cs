using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanjaysBooks.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        //e.g. first column of first row in the result set
        T Single<T>(string procedurename, DynamicParameters param = null);
        //execute something to the database but not retrieve anything
        void Execute(string procedurename, DynamicParameters param = null);
        T OneRecord<T>(string procedurename, DynamicParameters param = null);
        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);

    }
}

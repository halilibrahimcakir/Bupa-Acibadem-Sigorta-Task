using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        bool Add(string procedureName, T entity);
        DataTable GetAll(string procedureName);
        bool Update(string rocedureName, T entity);
        bool Delete(string procedureName, int id);
        DataTable GetById(string procedureName, int id);
    }
}

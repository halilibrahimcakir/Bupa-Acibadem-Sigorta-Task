using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Insurance.Data.Repository
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        public bool Add(string procedureName, T entity)
        {
            
            return DbHelper.ExecuteAdd(procedureName, entity);
        }

        public bool Delete(string procedureName, int id)
        {
            DbHelper.ExecuteDelete(procedureName, id);
            return true;
        }

        public DataTable GetAll(string procedureName)
        {
            return DbHelper.ExecuteGetAll(procedureName);
        }

        public DataTable GetById(string procedureName, int id)
        {
            return DbHelper.ExecuteGetById(procedureName,id);
        }


        public bool Update(string procedureName, T entity)
        {
            return DbHelper.ExecudeUpdate(procedureName, entity);
        }
    }
}

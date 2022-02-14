using Insurance.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Variable
        private CustomerRepository _customerRepository = null;
        #endregion  

        #region Ctor
        public UnitOfWork()
        {

        }
        #endregion

        #region Generic Repositorty
        public IRepository<T> GetRepository<T>() where T : class
        {
            return new RepositoryBase<T>();
        }

        #endregion

        #region  Custom Repository
        public CustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                    _customerRepository = new CustomerRepository();

                return _customerRepository;
            }
        }
        #endregion

        #region Disposable
        bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            disposed = true;
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
        #endregion
    }
}

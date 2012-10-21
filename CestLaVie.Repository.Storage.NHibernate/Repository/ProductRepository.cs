using System;
using System.Linq;
using System.Linq.Expressions;
using CestLaVie.Common.Repository;
using CestLaVie.Common.Repository.Interfaces;
using CestLaVie.Common.Repository.NHibernate;
using CestLaVie.Model;
using CestLaVie.Repository.Interfaces;
using NHibernate;
using NHibernate.Linq;

namespace CestLaVie.Repository.Storage.NHibernate.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ISession session;
        private NHibernateUnitOfWork nHibernateUnitOfWork;

        public ProductRepository()
        {
            session = NHibernateHelper<Product>.OpenSession();
            session.FlushMode = FlushMode.Commit;
            nHibernateUnitOfWork = new NHibernateUnitOfWork(session.BeginTransaction());
        }

        #region Implementation of IDisposable

        public void Dispose()
        {
          session.Dispose();
        }

        #endregion

        #region Implementation of IRepository<Product>

        public IUnitOfWork UnitOfWork
        {
            get { return nHibernateUnitOfWork; }
            set { nHibernateUnitOfWork = value as NHibernateUnitOfWork; }
        }

        public IQueryable<Product> All()
        {
            var result = session.CreateCriteria<Product>().List<Product>();
            return result.AsQueryable();
        }

        public IQueryable<Product> Where(Expression<Func<Product, bool>> expression)
        {
             return session.Query<Product>().Where(expression);
            
        }

        public void Add(Product newItem)
        {
            session.Save(newItem);
        }

        public void Update(Product updatedItem)
        {
            session.Update(updatedItem);
            
        }

        public void Delete(Product deletedItem)
        {
            session.Delete(deletedItem);
        }

        #endregion
    }
}

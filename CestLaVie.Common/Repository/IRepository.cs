using System;
using System.Linq;
using System.Linq.Expressions;

namespace CestLaVie.Common.Repository
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IUnitOfWork UnitOfWork { get; set; }
        IQueryable<T> All();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        void Add(T newItem);
        void Update(T updatedItem);
        void Delete(T deletedItem);
    }
}

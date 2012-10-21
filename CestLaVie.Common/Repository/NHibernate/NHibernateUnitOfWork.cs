using NHibernate;

namespace CestLaVie.Common.Repository.NHibernate
{
    public class NHibernateUnitOfWork : IUnitOfWork
    {
        public ITransaction Transaction;
        #region Implementation of IUnitOfWork

        public NHibernateUnitOfWork(ITransaction currentTransaction)
        {
            Transaction = currentTransaction;
        }

        public void Commit()
        {
            Transaction.Commit();
        }

        #endregion
    }
}

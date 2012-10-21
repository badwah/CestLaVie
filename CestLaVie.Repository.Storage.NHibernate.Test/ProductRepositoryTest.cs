using System.Linq;
using CestLaVie.Common.Repository;
using CestLaVie.Repository.Interfaces;
using NUnit.Framework;

namespace CestLaVie.Repository.Storage.NHibernate.Test
{
    [TestFixture]
    public class ProductRepositoryTest
    {
        [Test]
        public void GetAllTest()
        {
            var productRepo = new RepositoryFactory<IProductRepository>().ResolveRepository();
            var allProducts = productRepo.All();
            Assert.IsNotNull(allProducts.FirstOrDefault());
        }
    }
}

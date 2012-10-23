using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CestLaVie.Common.Repository;
using CestLaVie.Repository.Interfaces;
using CestLaVie.Shared;
using CestLaVie.Model;
using CestLaVie.Shared.FacadeInterface;
using CestLaVie.Shared.Filter;


namespace CestLaVie.Core.Facade
{
    public class ProductFacade:IProductFacade
    {
        #region Implementation of ICrudFacade<Product,ProductFilter>

        private readonly IProductRepository productRepository;

        public ProductFacade()
        {
            Mapper.CreateMap<Product, Shared.Dto.Product>();
            productRepository = new RepositoryFactory<IProductRepository>().ResolveRepository();
        }

        public IList<Shared.Dto.Product> Search(ProductFilter filter)
        {

            IList<Product> products = productRepository.Where(p => p.Id == filter.Id).ToList();
            return Mapper.Map<IList<Product>, IList<Shared.Dto.Product>>(products);
        }

        public void Save(Shared.Dto.Product dto)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}

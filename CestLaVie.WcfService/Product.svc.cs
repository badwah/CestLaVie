using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CestLaVie.Core.Facade;
using CestLaVie.Shared.FacadeInterface;
using CestLaVie.Shared.Filter;

namespace CestLaVie.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Product" in code, svc and config file together.
    public class Product : IProductFacade
    {
        
        #region Implementation of ICrudFacade<Product,ProductFilter>

        public IList<Shared.Dto.Product> Search(ProductFilter filter)
        {
            return new ProductFacade().Search(filter);
        }

        public void Save(Shared.Dto.Product dto)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

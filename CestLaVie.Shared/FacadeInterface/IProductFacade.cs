using System.ServiceModel;
using CestLaVie.Shared.Dto;
using CestLaVie.Shared.Filter;

namespace CestLaVie.Shared.FacadeInterface
{
    [ServiceContract]
    public interface IProductFacade : ICrudFacade<Product,ProductFilter>
    {
    }
}

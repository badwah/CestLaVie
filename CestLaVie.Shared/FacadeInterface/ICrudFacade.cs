using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace CestLaVie.Shared.FacadeInterface
{
    [ServiceContract]
    public interface ICrudFacade<T, TFilter>
    {
        [OperationContract]
        IList<T> Search(TFilter filter);

        [OperationContract]
        void Save(T dto);
    }
}
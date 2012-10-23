using System;
using System.Runtime.Serialization;

namespace CestLaVie.Shared.Dto
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public String Id { get; set; }
        [DataMember]
        public String Name { get; set; }
        [DataMember]
        public String Description { get; set; }
    }
}

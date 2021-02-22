using System.Runtime.Serialization;

namespace PVAO.ApplicationCore
{
    [DataContract]
    public class BaseEntity<IdType>
    {
        /*[DataMember(IsRequired = false)]
        public IdType Id { get; set; }*/
    }
}

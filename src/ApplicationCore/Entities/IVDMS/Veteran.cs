using System.Runtime.Serialization;

namespace PVAO.ApplicationCore.Entities.IVDMS
{
    public class Veteran : BaseEntity<int>
    {
        [DataMember]
        public int VdmsNo { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string MiddleName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public string Sex { get; set; }
    }
}

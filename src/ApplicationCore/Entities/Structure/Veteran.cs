using System;
using System.Runtime.Serialization;

namespace PVAO.ApplicationCore.Entities.Structure
{
    public class Veteran : BaseEntity<int>
    {
        [DataMember]
        public int vdmsno { get; set; }

        [DataMember]
        public string lastName { get; set; }

        [DataMember]
        public string firstName { get; set; }

        [DataMember]
        public string middleName { get; set; }

        [DataMember]
        public string extensionName { get; set; }

        [DataMember]
        public string currentAddress1 { get; set; }

        [DataMember]
        public string currentAddress2 { get; set; }

        [DataMember]
        public string currentAddress3 { get; set; }

        [DataMember]
        public string currentZipCode { get; set; }

        [DataMember]
        public DateTime? dateOfBirth { get; set; }

        [DataMember]
        public string placeOfBirth { get; set; }

        [DataMember]
        public int? age { get; set; }

        [DataMember]
        public string nationality { get; set; }

        [DataMember]
        public string mortalStatus { get; set; }

        [DataMember]
        public DateTime? dateOfDeath { get; set; }

        [DataMember]
        public string causeOfDeath { get; set; }

        [DataMember]
        public string placeOfDeath { get; set; }

        [DataMember]
        public string sex { get; set; }

        [DataMember]
        public string country { get; set; }

        [DataMember]
        public string vfpOrganization { get; set; }

        [DataMember]
        public DateTime? dateCreated { get; set; }

        [DataMember]
        public DateTime? dateModified { get; set; }
    }
}

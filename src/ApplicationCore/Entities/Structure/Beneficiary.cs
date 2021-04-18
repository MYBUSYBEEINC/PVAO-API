using System;
using System.Runtime.Serialization;

namespace PVAO.ApplicationCore.Entities.Structure
{
    public class Beneficiary : BaseEntity<int>
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string vdmsNo { get; set; }

        [DataMember]
        public string lastName { get; set; }

        [DataMember]
        public string firstName { get; set; }

        [DataMember]
        public string middleName { get; set; }

        [DataMember]
        public string extensionName { get; set; }

        [DataMember]    
        public string relationCode { get; set; }

        [DataMember]
        public DateTime? dateOfBirth { get; set; }

        [DataMember]
        public string placeOfBirth { get; set; }

        [DataMember]
        public string mortalStatus { get; set; }

        [DataMember]
        public string sex { get; set; }

        [DataMember]
        public string mobile { get; set; }

        [DataMember]
        public string telephone { get; set; }

        [DataMember]
        public DateTime? dateOfDeath { get; set; }

        [DataMember]
        public string placeOfDeath { get; set; }

        [DataMember]
        public string currentAddress1 { get; set; }

        [DataMember]
        public string currentAddress2 { get; set; }

        [DataMember]
        public string currentAddress3 { get; set; }

        [DataMember]
        public string currentZipCode { get; set; }

        [DataMember]
        public string emailaddress { get; set; }

        [DataMember]
        public DateTime? dateCreated { get; set; }
    }
}

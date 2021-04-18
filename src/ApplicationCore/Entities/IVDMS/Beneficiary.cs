using System;
using System.Runtime.Serialization;

namespace PVAO.ApplicationCore.Entities.IVDMS
{
    public class Beneficiary : BaseEntity<int>
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string VdmsNo { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string MiddleName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]    
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public string Sex { get; set; }

        [DataMember]
        public string CurrentAddress1 { get; set; }

        [DataMember]
        public string CurrentAddress2 { get; set; }

        [DataMember]
        public string CurrentAddress3 { get; set; }

        [DataMember]
        public string CurrentZipCode { get; set; }

        [DataMember]
        public string RelationCode { get; set; }

        public string FullAddress => $"{CurrentAddress1}, {CurrentAddress2}, {CurrentAddress3}, {CurrentZipCode}";

        public int Age => DateTime.Now.Year - DateOfBirth.Year;
    }
}

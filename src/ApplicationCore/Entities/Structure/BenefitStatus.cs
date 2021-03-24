using System;
using System.Runtime.Serialization;

namespace PVAO.ApplicationCore.Entities.Structure
{
    public class BenefitStatus : BaseEntity<int>
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Prefix { get; set; }

        [DataMember]
        public string Claimant { get; set; }

        [DataMember]
        public int CreatedBy { get; set; }

        [DataMember]
        public DateTime DateCreated { get; set; }

        [DataMember]
        public int? UpdatedBy { get; set; }

        [DataMember]
        public DateTime? DateUpdated { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PVAO.ApplicationCore.Entities.Structure
{
    public class ClaimCheque : BaseEntity<int>
    {
        [DataMember]
        public string claimNo { get; set; }

        [DataMember]
        public decimal? checkNumber { get; set; }

        [DataMember]
        public string checkStatus { get; set; }

        [DataMember]
        public DateTime? dateIssued { get; set; }

        [DataMember]
        public decimal? checkAmount { get; set; }

        [DataMember]
        public string checkType { get; set; }

        [DataMember]
        public string checkRemarks { get; set; }

        [DataMember]
        public DateTime? dateRemitted { get; set; }

        [DataMember]
        public DateTime? dateCreated { get; set; }
    }
}

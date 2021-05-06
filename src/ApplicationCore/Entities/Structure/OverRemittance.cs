using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PVAO.ApplicationCore.Entities.Structure
{
    public class OverRemittance
    {
        [DataMember]
        public string ClaimNumber { get; set; }

        [DataMember]
        public string BenefitCode { get; set; }

        [DataMember]
        public string VdmsNumber { get; set; }

        [DataMember]
        public string BeneficiaryName { get; set; }

        [DataMember]
        public string Relation { get; set; }

        [DataMember]
        public string Gender { get; set; }

        [DataMember]
        public string Amount { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public DateTime? DateApproved { get; set; }
    }
}

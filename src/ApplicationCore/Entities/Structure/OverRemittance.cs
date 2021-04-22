using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PVAO.ApplicationCore.Entities.Structure
{
    public class OverRemittance
    {
        [DataMember]
        public long Id { get; set; }

        public string VDMSNumber { get; set; }

        [DataMember]
        public string BeneficiaryName { get; set; }

        [DataMember]
        public string Relation { get; set; }

        [DataMember]
        public string Gender { get; set; }

        [DataMember]
        public string BenefitCode { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public int Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PVAO.ApplicationCore.Entities.Structure
{
    public class BenefitCode : BaseEntity<int>
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string benefitCode { get; set; }

        [DataMember]
        public string benefit { get; set; }

        [DataMember]
        public decimal? benefitAmount { get; set; }

        [DataMember]
        public string benefitStat { get; set; }
    }
}

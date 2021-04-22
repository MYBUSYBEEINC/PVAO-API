using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PVAO.ApplicationCore.Entities.Structure
{
    public class ClaimApplication : BaseEntity<int>
    {
        [DataMember]
        public string claimNo { get; set; }

        [DataMember]
        public string vdmsNo { get; set; }

        [DataMember]
        public string benefitCode { get; set; }

        [DataMember]
        public string lastName { get; set; }

        [DataMember]
        public string firstName { get; set; }

        [DataMember]
        public string middleName { get; set; }

        [DataMember]
        public string referenceNumber { get; set; }

        [DataMember]
        public DateTime? dateFiled { get; set; }

        [DataMember]
        public DateTime? dateApproved { get; set; }
    }
}

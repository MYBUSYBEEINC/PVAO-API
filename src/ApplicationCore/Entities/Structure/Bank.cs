using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PVAO.ApplicationCore.Entities.Structure
{
    public class Bank : BaseEntity<int>
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string bankCode { get; set; }

        [DataMember]
        public string bankName { get; set; }

        [DataMember]
        public string bankBranch { get; set; }

        [DataMember]
        public string bankAddress { get; set; }

        [DataMember]
        public string zipCode { get; set; }
    }
}

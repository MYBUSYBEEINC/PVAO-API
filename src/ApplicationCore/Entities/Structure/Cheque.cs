using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PVAO.ApplicationCore.Entities.Structure
{
    public class Cheque : BaseEntity<int>
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int DisbursementsID { get; set; }

        [DataMember]
        public string ChequeNumber { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public DateTime ChequeDate { get; set; }

        [DataMember]
        public string BankCode { get; set; }

        [DataMember]
        public string Payee { get; set; }

        [DataMember]
        public string PayeeBankCode { get; set; }

        [DataMember]
        public DateTime CreatedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PVAO.ApplicationCore.DTOs.IVDMS
{
    public class BankDTO
    {
        public int id { get; set; }
        public string bankCode { get; set; }
        public string bankName { get; set; }
        public string bankBranch { get; set; }
        public string bankAddress { get; set; }
        public string zipCode { get; set; }
    }
}

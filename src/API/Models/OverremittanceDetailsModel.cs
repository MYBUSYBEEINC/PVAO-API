using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PVAO.ApplicationCore.Entities.IVDMS;

namespace PVAO.API.Models
{
    public class OverremittanceDetailsModel
    {
        public Beneficiary Beneficiary { get; set; }

        public Veteran Veteran { get; set; }
    }
}

using PVAO.ApplicationCore.Entities.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVAO.ApplicationCore.Interfaces
{
    public interface IClaimApplicationRepository
    {
        IQueryable<ClaimApplication> Get();
    }
}

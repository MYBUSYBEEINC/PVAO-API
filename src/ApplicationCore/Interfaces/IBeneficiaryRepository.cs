using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVAO.ApplicationCore.Entities.IVDMS;

namespace PVAO.ApplicationCore.Interfaces
{
    public interface IBeneficiaryRepository
    {
        IQueryable<Beneficiary> Get();
        Task<Beneficiary> GetById(int id);
        Task<Beneficiary> Add(Beneficiary settings);
        Task<Beneficiary> Update(Beneficiary settings);
    }
}

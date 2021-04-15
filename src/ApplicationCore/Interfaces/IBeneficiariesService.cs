using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVAO.ApplicationCore.DTOs;
using PVAO.ApplicationCore.Entities.IVDMS;

namespace PVAO.ApplicationCore.Interfaces
{
    public interface IBeneficiariesService
    {
        IQueryable<Beneficiary> Get();
        Task<Beneficiary> GetById(int id);
        Task<Beneficiary> Add(BeneficiaryDTO beneficiaryDTO);
        Task<Beneficiary> Update(BeneficiaryDTO beneficiaryDTO);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVAO.ApplicationCore.DTOs;
using PVAO.ApplicationCore.Entities.Structure;

namespace PVAO.ApplicationCore.Interfaces
{
    public interface IBeneficiaryService
    {
        IQueryable<Beneficiary> Get();
        Task<Beneficiary> GetById(int id);
        IQueryable<Beneficiary> GetOverRemittances();
        Task<Beneficiary> Add(BeneficiaryDTO beneficiaryDTO);
        Task<Beneficiary> Update(BeneficiaryDTO beneficiaryDTO);
    }
}

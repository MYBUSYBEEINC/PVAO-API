using System;
using System.Linq;
using System.Threading.Tasks;
using PVAO.ApplicationCore.DTOs;
using PVAO.ApplicationCore.Entities.IVDMS;
using PVAO.ApplicationCore.Interfaces;

namespace PVAO.ApplicationCore.Services
{
    public class BeneficiariesService : IBeneficiariesService
    {
        private readonly IBeneficiaryRepository _repository;

        public BeneficiariesService(IBeneficiaryRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<Beneficiary> Get()
        {
            return _repository.Get();
        }

        public async Task<Beneficiary> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<Beneficiary> Add(BeneficiaryDTO beneficiaryDTO)
        {
            var beneficiary = new Beneficiary()
            {
                Id = beneficiaryDTO.Id,
                VdmsNo = beneficiaryDTO.VdmsNo,
                FirstName = beneficiaryDTO.FirstName,
                MiddleName = beneficiaryDTO.MiddleName,
                LastName = beneficiaryDTO.LastName,
                DateOfBirth = beneficiaryDTO.DateOfBirth,
                Sex = beneficiaryDTO.Sex
            };

            try
            {
                return await _repository.Add(beneficiary);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Beneficiary> Update(BeneficiaryDTO beneficiaryDTO)
        {
            var veteran = _repository.GetById(beneficiaryDTO.Id).Result;

            veteran.FirstName = beneficiaryDTO.FirstName;
            veteran.MiddleName = beneficiaryDTO.MiddleName;
            veteran.LastName = beneficiaryDTO.LastName;
            veteran.DateOfBirth = beneficiaryDTO.DateOfBirth;
            veteran.Sex = beneficiaryDTO.Sex;

            return await _repository.Update(veteran);
        }
    }
}

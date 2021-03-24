using System;
using System.Linq;
using System.Threading.Tasks;
using PVAO.ApplicationCore.DTOs;
using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;

namespace PVAO.ApplicationCore.Services
{
    public class BenefitStatusService : IBenefitStatusService
    {
        private readonly IBenefitStatusRepository _repository;

        public BenefitStatusService(IBenefitStatusRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<BenefitStatus> Get()
        {
            return _repository.Get();
        }

        public async Task<BenefitStatus> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<BenefitStatus> Add(BenefitStatusDTO benefitStatusDTO)
        {
            var benefitStatus = new BenefitStatus
            {
                Claimant = benefitStatusDTO.Claimant,
                Prefix = benefitStatusDTO.Prefix,
                Description = benefitStatusDTO.Description,
                CreatedBy = benefitStatusDTO.CreatedBy,
                DateCreated = benefitStatusDTO.DateCreated,
                UpdatedBy = benefitStatusDTO.UpdatedBy,
                DateUpdated = benefitStatusDTO.DateUpdated
            };

            try
            {
                return await _repository.Add(benefitStatus);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<BenefitStatus> Update(BenefitStatusDTO benefitStatusDTO)
        {
            var benefitStatus = _repository.GetById(benefitStatusDTO.Id).Result;

            benefitStatus.Claimant = benefitStatusDTO.Claimant;
            benefitStatus.Prefix =  benefitStatusDTO.Prefix;
            benefitStatus.Description = benefitStatusDTO.Description;
            benefitStatus.CreatedBy = benefitStatusDTO.CreatedBy;
            benefitStatus.DateCreated = benefitStatusDTO.DateCreated;
            benefitStatus.UpdatedBy = benefitStatusDTO.UpdatedBy;
            benefitStatus.DateUpdated = benefitStatusDTO.DateUpdated;

            return await _repository.Update(benefitStatus);
        }
    }
}

using System;
using System.Linq;
using System.Threading.Tasks;
using PVAO.ApplicationCore.DTOs;
using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;

namespace PVAO.ApplicationCore.Services
{
    public class BeneficiaryService : IBeneficiaryService
    {
        private readonly IBeneficiaryRepository _repository;

        public BeneficiaryService(IBeneficiaryRepository repository)
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

        public Beneficiary GetByVeteranId(string veteranId)
        {
            return _repository.GetByVeteranId(veteranId);
        }

        public async Task<Beneficiary> Add(BeneficiaryDTO beneficiaryDTO)
        {
            var beneficiary = new Beneficiary()
            {
                id = beneficiaryDTO.id,
                vdmsNo = beneficiaryDTO.vdmsNo,
                lastName = beneficiaryDTO.lastName,
                firstName = beneficiaryDTO.firstName,
                middleName = beneficiaryDTO.middleName,
                extensionName = beneficiaryDTO.extensionName,
                relationCode = beneficiaryDTO.relationCode,
                dateOfBirth = beneficiaryDTO.dateOfBirth,
                placeOfBirth = beneficiaryDTO.placeOfBirth,
                mortalStatus = beneficiaryDTO.mortalStatus,
                sex = beneficiaryDTO.sex,
                mobile = beneficiaryDTO.mobile,
                telephone = beneficiaryDTO.telephone,
                dateOfDeath = beneficiaryDTO.dateOfDeath,
                placeOfDeath = beneficiaryDTO.placeOfDeath,
                currentAddress1 = beneficiaryDTO.currentAddress1,
                currentAddress2 = beneficiaryDTO.currentAddress2,
                currentAddress3 = beneficiaryDTO.currentAddress3,
                currentZipCode = beneficiaryDTO.currentZipCode,
                emailaddress = beneficiaryDTO.emailaddress,
                dateCreated = beneficiaryDTO.dateCreated
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
            var veteran = _repository.GetById(beneficiaryDTO.id).Result;

            veteran.vdmsNo = beneficiaryDTO.vdmsNo;
            veteran.lastName = beneficiaryDTO.lastName;
            veteran.firstName = beneficiaryDTO.firstName;
            veteran.middleName = beneficiaryDTO.middleName;
            veteran.extensionName = beneficiaryDTO.extensionName;
            veteran.relationCode = beneficiaryDTO.relationCode;
            veteran.dateOfBirth = beneficiaryDTO.dateOfBirth;
            veteran.placeOfBirth = beneficiaryDTO.placeOfBirth;
            veteran.mortalStatus = beneficiaryDTO.mortalStatus;
            veteran.sex = beneficiaryDTO.sex;
            veteran.mobile = beneficiaryDTO.mobile;
            veteran.telephone = beneficiaryDTO.telephone;
            veteran.dateOfDeath = beneficiaryDTO.dateOfDeath;
            veteran.placeOfDeath = beneficiaryDTO.placeOfDeath;
            veteran.currentAddress1 = beneficiaryDTO.currentAddress1;
            veteran.currentAddress2 = beneficiaryDTO.currentAddress2;
            veteran.currentAddress3 = beneficiaryDTO.currentAddress3;
            veteran.currentZipCode = beneficiaryDTO.currentZipCode;
            veteran.emailaddress = beneficiaryDTO.emailaddress;

            return await _repository.Update(veteran);
        }
    }
}

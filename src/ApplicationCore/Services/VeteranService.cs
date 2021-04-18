using System;
using System.Linq;
using System.Threading.Tasks;
using PVAO.ApplicationCore.DTOs;
using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;

namespace PVAO.ApplicationCore.Services
{
    public class VeteranService : IVeteranService
    {
        private readonly IVeteranRepository _repository;

        public VeteranService(IVeteranRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<Veteran> Get()
        {
            return _repository.Get();
        }

        public async Task<Veteran> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<Veteran> Add(VeteranDTO veteransDTO)
        {
            var veteran = new Veteran
            {
                vdmsno = veteransDTO.vdmsno,
                lastName = veteransDTO.lastName,
                firstName = veteransDTO.firstName,
                middleName = veteransDTO.middleName,
                extensionName = veteransDTO.extensionName,
                currentAddress1 = veteransDTO.currentAddress1,
                currentAddress2 = veteransDTO.currentAddress2,
                currentAddress3 = veteransDTO.currentAddress3,
                currentZipCode = veteransDTO.currentZipCode,
                dateOfBirth = veteransDTO.dateOfBirth,
                placeOfBirth = veteransDTO.placeOfBirth,
                age = veteransDTO.age,
                nationality = veteransDTO.nationality,
                mortalStatus = veteransDTO.mortalStatus,
                dateOfDeath = veteransDTO.dateOfDeath,
                causeOfDeath = veteransDTO.causeOfDeath,
                placeOfDeath = veteransDTO.placeOfDeath,
                sex = veteransDTO.sex,
                country = veteransDTO.country,
                vfpOrganization = veteransDTO.vfpOrganization,
                dateCreated = veteransDTO.dateCreated
            };

            try
            {
                return await _repository.Add(veteran);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Veteran> Update(VeteranDTO veteransDTO)
        {
            var veteran = _repository.GetById(veteransDTO.vdmsno).Result;

            veteran.lastName = veteransDTO.lastName;
            veteran.firstName = veteransDTO.firstName;
            veteran.middleName = veteransDTO.middleName;
            veteran.extensionName = veteransDTO.extensionName;
            veteran.currentAddress1 = veteransDTO.currentAddress1;
            veteran.currentAddress2 = veteransDTO.currentAddress2;
            veteran.currentAddress3 = veteransDTO.currentAddress3;
            veteran.currentZipCode = veteransDTO.currentZipCode;
            veteran.dateOfBirth = veteransDTO.dateOfBirth;
            veteran.placeOfBirth = veteransDTO.placeOfBirth;
            veteran.age = veteransDTO.age;
            veteran.nationality = veteransDTO.nationality;
            veteran.mortalStatus = veteransDTO.mortalStatus;
            veteran.dateOfDeath = veteransDTO.dateOfDeath;
            veteran.causeOfDeath = veteransDTO.causeOfDeath;
            veteran.placeOfDeath = veteransDTO.placeOfDeath;
            veteran.sex = veteransDTO.sex;
            veteran.country = veteransDTO.country;
            veteran.vfpOrganization = veteransDTO.vfpOrganization;

            return await _repository.Update(veteran);
        }
    }
}

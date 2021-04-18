using System;
using System.Linq;
using System.Threading.Tasks;
using PVAO.ApplicationCore.DTOs;
using PVAO.ApplicationCore.Entities.IVDMS;
using PVAO.ApplicationCore.Interfaces;

namespace PVAO.ApplicationCore.Services
{
    public class VeteransService : IVeteransService
    {
        private readonly IVeteransRepository _repository;

        public VeteransService(IVeteransRepository repository)
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

        public async Task<Veteran> Add(VeteransDTO veteransDTO)
        {
            var veteran = new Veteran
            {
                VdmsNo = veteransDTO.VdmsNo,
                FirstName = veteransDTO.FirstName,
                MiddleName = veteransDTO.MiddleName,
                LastName = veteransDTO.LastName,
                Age = veteransDTO.Age,
                Sex = veteransDTO.Sex
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

        public async Task<Veteran> Update(VeteransDTO veteransDTO)
        {
            var veteran = _repository.GetById(veteransDTO.VdmsNo).Result;

            veteran.FirstName = veteransDTO.FirstName;
            veteran.MiddleName = veteransDTO.MiddleName;
            veteran.LastName = veteransDTO.LastName;
            veteran.Age = veteransDTO.Age;
            veteran.Sex = veteransDTO.Sex;

            return await _repository.Update(veteran);
        }
    }
}

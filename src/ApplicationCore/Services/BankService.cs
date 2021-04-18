using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace PVAO.ApplicationCore.Services
{
    public class BankService : IBankService
    {
        private readonly IBankRepository _repository;

        public BankService(IBankRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<Bank> Get()
        {
            return _repository.Get();
        }

        public async Task<Bank> GetById(int id)
        {
            return await _repository.GetById(id);
        }
    }
}

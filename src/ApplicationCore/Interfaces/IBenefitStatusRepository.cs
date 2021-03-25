using System.Linq;
using System.Threading.Tasks;
using PVAO.ApplicationCore.Entities.Structure;

namespace PVAO.ApplicationCore.Interfaces
{
    public interface IBenefitStatusRepository
    {
        IQueryable<BenefitStatus> Get();
        Task<BenefitStatus> GetById(int id);
        Task<BenefitStatus> Add(BenefitStatus settings);
        Task<BenefitStatus> Update(BenefitStatus settings);
    }
}

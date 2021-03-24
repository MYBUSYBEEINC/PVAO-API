using System.Linq;
using System.Threading.Tasks;
using PVAO.ApplicationCore.DTOs;
using PVAO.ApplicationCore.Entities.Structure;

namespace PVAO.ApplicationCore.Interfaces
{
    public interface IBenefitStatusService
    {
        IQueryable<BenefitStatus> Get();
        Task<BenefitStatus> GetById(int id);
        Task<BenefitStatus> Add(BenefitStatusDTO benefitStatusDto);
        Task<BenefitStatus> Update(BenefitStatusDTO benfBenefitStatusDTO);
    }
}

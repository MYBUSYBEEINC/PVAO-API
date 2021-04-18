using PVAO.ApplicationCore.Entities.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVAO.ApplicationCore.Interfaces
{
    public interface IBankService
    {
        IQueryable<Bank> Get();
        Task<Bank> GetById(int id);
    }
}

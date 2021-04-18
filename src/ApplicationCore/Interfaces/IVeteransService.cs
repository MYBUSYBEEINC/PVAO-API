using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVAO.ApplicationCore.DTOs;
using PVAO.ApplicationCore.Entities.IVDMS;
using PVAO.ApplicationCore.Entities.Structure;

namespace PVAO.ApplicationCore.Interfaces
{
    public interface IVeteransService
    {
        IQueryable<Veteran> Get();
        Task<Veteran> GetById(int id);
        Task<Veteran> Add(VeteransDTO veteransDTO);
        Task<Veteran> Update(VeteransDTO veteransDTO);
    }
}

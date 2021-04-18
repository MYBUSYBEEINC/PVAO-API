using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVAO.ApplicationCore.DTOs;
using PVAO.ApplicationCore.Entities;
using PVAO.ApplicationCore.Entities.Structure;

namespace PVAO.ApplicationCore.Interfaces
{
    public interface IVeteranService
    {
        IQueryable<Veteran> Get();
        Task<Veteran> GetById(int id);
        Task<Veteran> Add(VeteranDTO veteransDTO);
        Task<Veteran> Update(VeteranDTO veteransDTO);
    }
}

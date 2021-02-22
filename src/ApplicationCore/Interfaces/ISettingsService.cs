using PVAO.ApplicationCore.DTOs;
using PVAO.ApplicationCore.Entities.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVAO.ApplicationCore.Interfaces
{
    public interface ISettingsService
    {
        IQueryable<Settings> Get();
        Task<Settings> GetById(int id);
        Task<Settings> Add(SettingsDTO settingsDTO);
        Task<Settings> Update(SettingsDTO settingsDTO);
    }
}

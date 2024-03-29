﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVAO.ApplicationCore.Entities;
using PVAO.ApplicationCore.Entities.Structure;

namespace PVAO.ApplicationCore.Interfaces
{
    public interface IVeteranRepository
    {
        IQueryable<Veteran> Get();
        Task<Veteran> GetById(int id);
        Task<Veteran> Add(Veteran settings);
        Task<Veteran> Update(Veteran settings);
    }
}

using Entities.DTOs;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface ILessionMajorRepository
    {
        Task<List<LessionInList>> GetLessionbyListMajor(List<int> majorsId);
    }
}

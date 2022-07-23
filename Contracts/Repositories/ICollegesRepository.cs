﻿using Entities.DTOs;
using Entities.Models;
using Entities.RequestFeature;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface ICollegesRepository
    {
        Task<List<CollegesInList>> GetColleges(PagingParameters param);
        Task<CollegesReturn> GetDetail(int colleges_id);
        void Create(Colleges colleges);
    }
}
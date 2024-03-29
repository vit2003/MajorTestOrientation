﻿using Entities.DataTransferObject;
using Entities.DTOs;
using Entities.Models;
using Entities.RequestFeature;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface ICollegesRepository
    {
        Task<Pagination<CollegesInList>> GetColleges(PagingParameters param);
        Task<CollegesReturn> GetDetail(int colleges_id);
        void Create(Colleges colleges);
        void Update(Colleges colleges);
        Task<Pagination<CollegesReturn>> GetAll(PagingParameters param);
        Task<IEnumerable<CollegesStatistic>> GetName(IEnumerable<CollegesStatistic> data);
        Task<CollegesDetail> GetDetailDashboard(int college_id);
    }
}
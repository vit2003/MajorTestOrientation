﻿using Entities.DataTransferObject;
using Entities.DTOs;
using Entities.Models;
using Entities.RequestFeature;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface ITestDeclarationRepository
    {
        Task<TestDeclarations> GetById(int id);
        Task<Pagination<TestToUpdateQuestion>> GetAllTest(PagingParameters param);
        Task<List<TestToUpdateQuestion>> GetByType(int type_id);
        Task Update(int test_id, UpdateTest info);
        void Create(TestDeclarations test);
        Task<int> GetTestType(int test_id);
    }
}

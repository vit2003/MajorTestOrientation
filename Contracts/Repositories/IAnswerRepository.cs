﻿using Entities.DTOs;
using Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IAnswerRepository
    {
        Task<List<AnswerInTest>> GetMbtiAnswer(int questionId);
        Task<TestAnswers> GetAnswerById(int id);
    }
}
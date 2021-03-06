using Entities.DTOs;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface ISubjectGroupSubjectRepository
    {
        Task<List<SubjectReturn>> GetSubject(int group_id);
        Task<List<SubjectGroupReturn>> GetSubjectOfGroup(List<SubjectGroupReturn> result);
        Task<List<Subject>> GetSubjects(int group_id);
    }
}

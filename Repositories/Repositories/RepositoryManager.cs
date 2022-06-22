﻿using Contracts.Repositories;
using Entities;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        public RepositoryManager(DataContext context)
        {
            _context = context;
        }

        private ISysUserRepository _sysUser;
        private ISecurityCodeRepository _sCode;
        private IQuestionRepository _question;
        private IAnswerRepository _answer;
        private ITestResultRepository _result;
        private ITestDeclarationRepository _test;
        private readonly DataContext _context;

        public ISysUserRepository SysUser
        {
            get
            {
                if(_sysUser == null)
                {
                    _sysUser = new SysUserRepository(_context);
                }
                return _sysUser;
            }
        }

        public ISecurityCodeRepository SecurityCode
        {
            get
            {
                if(_sCode == null)
                {
                    _sCode = new SecurityCodeRepository(_context);
                }
                return _sCode;
            }
        }

        public IQuestionRepository Question
        {
            get
            {
                if(_question == null)
                {
                    _question = new QuestionRepository(_context);
                }
                return _question;
            }
        }

        public IAnswerRepository Answer
        {
            get
            {
                if(_answer == null)
                {
                    _answer = new AnswerRepository(_context);
                }
                return _answer;
            }
        }

        public ITestResultRepository TestResult
        {
            get
            {
                if(_result == null)
                {
                    _result = new TestResultRepository(_context);
                }
                return _result;
            }
        }

        public ITestDeclarationRepository Test
        {
            get
            {
                if(_test == null)
                {
                    _test = new TestDeclarationRepository(_context);
                }
                return _test;
            }
        }

        public Task SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}

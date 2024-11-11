using Domain.General;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace TestBusiness.User
{
    internal class RepositoryUserMockTest : IRUser
    {
        public async Task<int> Add(Domain.User entity)
        {
            return await Task.FromResult(1);
        }

        public async Task Delete(int UserId)
        {
            await Task.Run(() => { });
        }


        public async Task<IEnumerable<Domain.User>> GetAll()
        {
            return await Task.FromResult(new List<Domain.User>());
        }

        public async Task<Domain.User> GetOne(Domain.User entity)
        {
            return await Task.FromResult(new Domain.User());
        }


        public async Task<Domain.User> Update(Domain.User entity)
        {
            return await Task.FromResult(entity);
        }
    }
}

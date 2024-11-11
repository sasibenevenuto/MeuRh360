using Domain.General;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace TestBusiness.Company
{
    internal class RepositoryCompanyMockTest : IRCompany
    {
        public async Task Add(Domain.Company entity)
        {
            await Task.Run(() => { });
        }

        public async Task Delete(int companyId)
        {
            await Task.Run(() => { });
        }


        public async Task<IEnumerable<Domain.Company>> GetAll()
        {
            return await Task.FromResult(new List<Domain.Company>());
        }

        public async Task<Domain.Company> GetOne(Domain.Company entity)
        {
            return await Task.FromResult(new Domain.Company());
        }


        public async Task<Domain.Company> Update(Domain.Company entity)
        {
            return await Task.FromResult(entity);
        }
    }
}

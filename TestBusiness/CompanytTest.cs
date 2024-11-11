using Business.Commands;
using Business.Querys;
using Repository;
using Repository.Interfaces;
using TestBusiness.Company;

namespace TestBusiness
{
    public class CompanytTest
    {
        [Fact]
        public async Task CompanyAddTest()
        {
            BCompanyCommand bCompanyCommand = new BCompanyCommand(new RepositoryCompanyMockTest());

            await bCompanyCommand.Handler(new Domain.Commands.CompanyAdd());

            Assert.True(true);
        }

        [Fact]
        public async Task CompanyUpdateTest()
        {
            BCompanyCommand bCompanyCommand = new BCompanyCommand(new RepositoryCompanyMockTest());

            await bCompanyCommand.Handler(new Domain.Commands.CompanyUpdate());

            Assert.True(true);
        }

        [Fact]
        public async Task CompanyGetAllTest()
        {
            BCompanyQuery bCompanyQuery = new BCompanyQuery(new RepositoryCompanyMockTest());

            await bCompanyQuery.Handler();

            Assert.True(true);
        }

        [Fact]
        public async Task CompanyGetOneTest()
        {
            BCompanyQuery bCompanyQuery = new BCompanyQuery(new RepositoryCompanyMockTest());

            await bCompanyQuery.Handler(1);

            Assert.True(true);
        }

        [Fact]
        public async Task CompanyDeleteTest()
        {
            BCompanyCommand bCompanyCommand = new BCompanyCommand(new RepositoryCompanyMockTest());

            await bCompanyCommand.Handler(1);

            Assert.True(true);
        }
    }
}
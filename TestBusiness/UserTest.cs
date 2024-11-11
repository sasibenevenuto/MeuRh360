using Business.Commands;
using Business.Querys;
using Repository;
using Repository.Interfaces;
using TestBusiness.User;

namespace TestBusiness
{
    public class UsertTest
    {
        [Fact]
        public async Task UserAddTest()
        {
            BUserCommand bUserCommand = new BUserCommand(new RepositoryUserMockTest());

            await bUserCommand.Handler(new Domain.Commands.UserAdd());

            Assert.True(true);
        }

        [Fact]
        public async Task UserUpdateTest()
        {
            BUserCommand bUserCommand = new BUserCommand(new RepositoryUserMockTest());

            await bUserCommand.Handler(new Domain.Commands.UserUpdate());

            Assert.True(true);
        }

        [Fact]
        public async Task UserGetAllTest()
        {
            BUserQuery bUserQuery = new BUserQuery(new RepositoryUserMockTest());

            await bUserQuery.Handler();

            Assert.True(true);
        }

        [Fact]
        public async Task UserGetOneTest()
        {
            BUserQuery bUserQuery = new BUserQuery(new RepositoryUserMockTest());

            await bUserQuery.Handler(1);

            Assert.True(true);
        }

        [Fact]
        public async Task UserDeleteTest()
        {
            BUserCommand bUserCommand = new BUserCommand(new RepositoryUserMockTest());

            await bUserCommand.Handler(1);

            Assert.True(true);
        }
    }
}
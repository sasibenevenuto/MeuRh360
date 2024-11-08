using Business.Querys.Interfaces;
using Domain;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Querys
{
    public class BUserQuery : IBUserQuery
    {
        private readonly IRUser _rUser;
        public BUserQuery(IRUser rUser)
        {
            _rUser = rUser;
        }

        public async Task<IEnumerable<User>> Handler()
        {
            return await _rUser.GetAll();
        }

        public async Task<User> Handler(int userId)
        {
            return await _rUser.GetOne(new User() { UserId = userId});
        }
    }
}

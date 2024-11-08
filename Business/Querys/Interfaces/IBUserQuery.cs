using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Querys.Interfaces
{
    public interface IBUserQuery
    {
        Task<User> Handler(int userId);
        Task<IEnumerable<User>> Handler();
    }
}

using Domain;
using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Commands.Interfcaes
{
    public interface IBUserCommand
    {
        Task<int> Handler(UserAdd entity);
        Task<User> Handler(UserUpdate entity);
        Task Handler(int userId);
    }
}

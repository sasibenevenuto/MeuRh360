using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.Interfaces
{
    public interface IRUser
    {
        Task<int> Add(User entity);
        Task<User> Update(User entity);
        Task Delete(int userId);
        Task<User> GetOne(int userId);
        Task<IEnumerable<User>> GetAll();
    }
}

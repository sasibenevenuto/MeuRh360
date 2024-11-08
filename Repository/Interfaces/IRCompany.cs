using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IRCompany
    {
        Task Add(Company entity);
        Task<Company> Update(Company entity);
        Task Delete(int companyId);
        Task<Company> GetOne(Company entity);
        Task<IEnumerable<Company>> GetAll();
    }
}

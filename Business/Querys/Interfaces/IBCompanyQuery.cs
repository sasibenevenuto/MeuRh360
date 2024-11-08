using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Querys.Interfaces
{
    public interface IBCompanyQuery
    {
        Task<Company> Handler(int companyId);
        Task<IEnumerable<Company>> Handler();
    }
}

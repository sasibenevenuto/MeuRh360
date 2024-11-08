using Domain;
using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Commands.Interfcaes
{
    public interface IBCompanyCommand
    {
        Task Handler(CompanyAdd entity);
        Task<Company> Handler(CompanyUpdate entity);
        Task Handler(int companyId);
    }
}

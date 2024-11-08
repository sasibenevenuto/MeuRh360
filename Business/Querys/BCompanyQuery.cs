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
    public class BCompanyQuery : IBCompanyQuery
    {
        private readonly IRCompany _rCompany;
        public BCompanyQuery(IRCompany rCompany)
        {
            _rCompany = rCompany;
        }

        public async Task<IEnumerable<Company>> Handler()
        {
            return await _rCompany.GetAll();
        }

        public async Task<Company> Handler(int companyId)
        {
            return await _rCompany.GetOne(new Company() { CompanyId = companyId });
        }
    }
}

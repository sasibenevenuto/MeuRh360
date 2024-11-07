using Business.Commands.Interfcaes;
using Domain;
using Domain.Commands;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.Commands
{
    public class BCompanyCommand : IBCompanyCommand
    {
        private readonly IRCompany _rCompany;

        public BCompanyCommand(IRCompany rCompany)
        {
            _rCompany = rCompany;
        }

        public async Task<int> Handler(CompanyAdd entity)
        {
            return await _rCompany.Add(entity);
        }

        public async Task Handler(int companyId)
        {
            await _rCompany.Delete(companyId);
        }

        public async Task<Company> Handler(CompanyUpdate entity)
        {
            return await _rCompany.Update(entity);
        }
    }
}

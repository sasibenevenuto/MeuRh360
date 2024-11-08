using Business.Commands.Interfcaes;
using Domain;
using Domain.Commands;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business.Commands
{
    public class BCompanyCommand : IBCompanyCommand
    {
        private readonly IRCompany _rCompany;

        public BCompanyCommand(IRCompany rCompany)
        {
            _rCompany = rCompany;
        }

        public async Task Handler(CompanyAdd entity)
        {
            await _rCompany.Add(new Company()
            {
                TypeCompany = entity.TypeCompany,
                Name = entity.Name,
                Cnpj = entity.Cnpj,
                PostalCode = entity.PostalCode,
                Address = entity.Address,
                Neighborhood = entity.Neighborhood,
                FederativeUnit = entity.FederativeUnit,
                City = entity.City,
                Complement = entity.Complement,
                CellPhone = entity.CellPhone,
                NameAdministrator = entity.NameAdministrator,
                CpfAdministrator = entity.CpfAdministrator,
                EmailAdministrator = entity.EmailAdministrator
            });
        }

        public async Task Handler(int companyId)
        {
            await _rCompany.Delete(companyId);
        }

        public async Task<Company> Handler(CompanyUpdate entity)
        {
            return await _rCompany.Update(new Company()
            {
                CompanyId = entity.Companyid,
                TypeCompany = entity.TypeCompany,
                Name = entity.Name,
                Cnpj = entity.Cnpj,
                PostalCode = entity.PostalCode,
                Address = entity.Address,
                Neighborhood = entity.Neighborhood,
                FederativeUnit = entity.FederativeUnit,
                City = entity.City,
                Complement = entity.Complement,
                CellPhone = entity.CellPhone,
                NameAdministrator = entity.NameAdministrator,
                CpfAdministrator = entity.CpfAdministrator,
                EmailAdministrator = entity.EmailAdministrator
            });
        }
    }
}

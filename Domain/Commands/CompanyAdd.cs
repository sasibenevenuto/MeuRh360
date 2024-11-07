using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands
{
    public class CompanyAdd
    {
        public string TypeCompany { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string Neighborhood { get; set; }
        public string FederativeUnit { get; set; }
        public string City { get; set; }
        public string Complement { get; set; }
        public string CellPhone { get; set; }
        public string NameAdministrator { get; set; }
        public string CpfAdministrator { get; set; }
        public string EmailAdministrator { get; set; }

        public static implicit operator CompanyAdd(Company model)
        {
            return new CompanyAdd
            {
                TypeCompany = model.TypeCompany,
                Name = model.Name,
                Cnpj = model.Cnpj,
                PostalCode = model.PostalCode,
                Address = model.Address,
                Neighborhood = model.Neighborhood,
                FederativeUnit = model.FederativeUnit,
                City = model.City,
                Complement = model.Complement,
                CellPhone = model.CellPhone,
                NameAdministrator = model.NameAdministrator,
                CpfAdministrator = model.CpfAdministrator,
                EmailAdministrator = model.EmailAdministrator
            };
        }
    }
}

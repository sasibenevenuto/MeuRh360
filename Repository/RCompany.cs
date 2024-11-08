using Domain;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RCompany : IRCompany
    {
        private readonly IRepository<Company> _repository;

        public RCompany(IRepository<Company> repository)
        {
            _repository = repository;
        }
        public async Task Add(Company entity)
        {
            var query = @"INSERT INTO public.company(
                                                    companyId, 
                                                    typeCompany, 
                                                    name, 
                                                    cnpj, 
                                                    postalCode,
                                                    address, 
                                                    neighborhood, 
                                                    federativeUnit, 
                                                    city, 
                                                    complement, 
                                                    cellPhone,
                                                    nameAdministrator, 
                                                    cpfAdministrator, 
                                                    emailAdministrator) 
                                        VALUES (
                                                    @CompanyId, 
                                                    @TypeCompany, 
                                                    @Name, 
                                                    @Cnpj, 
                                                    @PostalCode, 
                                                    @Address, 
                                                    @Neighborhood, 
                                                    @FederativeUnit, 
                                                    @City, 
                                                    @Complement, 
                                                    @CellPhone, 
                                                    @NameAdministrator, 
                                                    @CpfAdministrator, 
                                                    @EmailAdministrator);";
            await _repository.Add(query, entity);
        }

        public async Task Delete(int companyId)
        {
            await _repository.Delete($"DELETE FROM public.company WHERE companyId = {companyId};");
        }

        public async Task<IEnumerable<Company>> GetAll()
        {
            return await _repository.GetAll("SELECT * FROM public.company;");
        }

        public async Task<Company> GetOne(Company entity)
        {
            return await _repository.GetOne("SELECT * FROM public.company where companyId = @CompanyId;", entity);
        }

        public async Task<Company> Update(Company entity)
        {
            var query = @"UPDATE public.company SET 
                                                companyId=@CompanyId, 
                                                typeCompany=@TypeCompany, 
                                                name=@Name, 
                                                cnpj=@Cnpj, 
                                                postalCode=@PostalCode, 
                                                address=@Address, 
                                                neighborhood=@Neighborhood, 
                                                federativeUnit=@FederativeUnit, 
                                                city=@City, 
                                                complement=@Complement, 
                                                cellPhone=@CellPhone, 
                                                nameAdministrator=@NameAdministrator, 
                                                cpfAdministrator=@CpfAdministrator, 
                                                emailAdministrator=@EmailAdministrator 
                                        WHERE companyId = @CompanyId;";
            return await _repository.Update(query, entity);
        }
    }
}

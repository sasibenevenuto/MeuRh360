using Domain;
using Repository.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RUser : IRUser
    {
        private readonly IRepository<User> _repository;

        public RUser(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task<int> Add(User entity)
        {
            var userId = (await _repository.GetAll(@"SELECT MAX(""userId"") AS userId FROM public.""user"";"))?.FirstOrDefault()?.UserId ?? 0;

            var query = $@"INSERT INTO public.user(""userId"",name, email, password, ""passwordConfirm"", ""acceptanceTerms"") 
                                        VALUES ({++userId},@Name, @Email, @Password, @PasswordConfirm, CAST({Convert.ToInt32(entity.AcceptanceTerms)} AS bit));";
            await _repository.Add(query, entity);
            return await Task.FromResult(userId);
        }

        public async Task Delete(int userId)
        {
            await _repository.Delete($@"DELETE FROM public.user WHERE ""userId"" = {userId};");
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _repository.GetAll("SELECT * FROM public.user;");
        }

        public async Task<User> GetOne(int userId)
        {
            return await _repository.GetOne(@"SELECT * FROM public.user where ""userId"" = @UserId;", new User() { UserId = userId });
        }

        public async Task<User> Update(User entity)
        {
            var query = @"UPDATE public.user
	                            SET userId=@UserId, name=@Name, email=@Email, password=@Password, passwordConfirm=@PasswordConfirm, acceptanceTerms=@AcceptanceTerms
	                            WHERE userId = @UserId;";
            return await _repository.Update(query, entity);
        }
    }
}

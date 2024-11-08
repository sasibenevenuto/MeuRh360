using Business.Commands.Interfcaes;
using Domain;
using Domain.Commands;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Commands
{
    public class BUserCommand : IBUserCommand
    {
        private readonly IRUser _rUser;
        public BUserCommand(IRUser rUser)
        {
            _rUser = rUser;
        }

        public async Task<int> Handler(UserAdd entity)
        {
            return await _rUser.Add(new User()
            {
                Name = entity.Name,
                Email = entity.Email,
                Password = entity.Password,
                PasswordConfirm = entity.PasswordConfirm,
                AcceptanceTerms = entity.AcceptanceTerms,
            });            
        }

        public async Task Handler(int userId)
        {
            await _rUser.Delete(userId);
        }

        public async Task<User> Handler(UserUpdate entity)
        {
           return await _rUser.Update(new User()
           {
               UserId = entity.UserId,
               Name = entity.Name,
               Email = entity.Email,    
               Password = entity.Password,
               PasswordConfirm = entity.PasswordConfirm,
               AcceptanceTerms = entity.AcceptanceTerms
           });           
        }
    }
}

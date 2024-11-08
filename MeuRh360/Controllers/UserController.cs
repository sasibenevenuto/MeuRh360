using Business.Commands.Interfcaes;
using Business.Querys.Interfaces;
using Domain.Commands;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeuRh360.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IBUserQuery _userQuery;
        private readonly IBUserCommand _userCommand;

        public UserController(IBUserQuery companyQuery, IBUserCommand userCommand)
        {
            _userQuery = companyQuery;
            _userCommand = userCommand;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _userQuery.Handler());
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("GetOne/{userId}")]
        public async Task<IActionResult> GetOne(int userId)
        {
            try
            {
                return Ok(await _userQuery.Handler(userId));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserAdd command)
        {
            try
            {
                return Ok(await _userCommand.Handler(command));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UserUpdate command)
        {
            try
            {
                return Ok(await _userCommand.Handler(command));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] int userId)
        {
            try
            {
                await _userCommand.Handler(userId);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

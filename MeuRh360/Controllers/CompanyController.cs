using Business.Commands.Interfcaes;
using Business.Querys.Interfaces;
using Domain;
using Domain.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeuRh360.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IBCompanyQuery _companyQuery;
        private readonly IBCompanyCommand _companyCommand;

        public CompanyController(IBCompanyQuery companyQuery, IBCompanyCommand CompanyCommand)
        {
            _companyQuery = companyQuery;
            _companyCommand = CompanyCommand;
        }      

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _companyQuery.Handler());
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("GetOne/{companyId}")]
        public async Task<IActionResult> GetOne(int companyId)
        {
            try
            {
                return Ok(await _companyQuery.Handler(companyId));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CompanyAdd command)
        {
            try
            {
                await _companyCommand.Handler(command);
                return Ok("Empresa criada com sucesso");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] CompanyUpdate command)
        {
            try
            {
                return Ok(await _companyCommand.Handler(command));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] int CompanyId)
        {
            try
            {
                await _companyCommand.Handler(CompanyId);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

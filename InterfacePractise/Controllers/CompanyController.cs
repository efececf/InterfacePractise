using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InterfacePractise.Db;
using InterfacePractise.Models;
using System.Collections.Generic;
using MediatR;
using InterfacePractise.Queries;

namespace InterfacePractise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        IMediator _mediatr;
        CompanyFactory _factory;
        public CompanyController(IMediator mediatr,CompanyFactory fact) {
            _mediatr = mediatr;
            _factory = fact;
        }

        [HttpPost]
        public ActionResult<Company> addCompany(string typ) {
            var company = _factory.getWorkType(typ);
            if (company == null)
            {
                return BadRequest();
            }
            else
            {
                _context.Companies.Add((Company)company);
                _context.SaveChanges();
                return Ok(company);
            }

        }
        [HttpGet]
        public async Task<ActionResult<Company>> getCompanyById(Guid id) 
        {
            var response= await _mediatr.Send(new GetCompanyQuery(id));
            if (response == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(response);
            }
        }
    }
}

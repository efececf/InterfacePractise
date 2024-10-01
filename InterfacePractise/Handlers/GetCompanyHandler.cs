using MediatR;
using InterfacePractise.Queries;
using InterfacePractise.Models;
using InterfacePractise.Interfaces;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Linq;

namespace InterfacePractise.Handlers
{
    public class GetCompanyHandler : IRequestHandler<GetCompanyQuery, Company>
    {
        private readonly ILogger<GetCompanyHandler> _logger;
        private readonly CompanyRepository _companyRepository;
        public GetCompanyHandler(ILogger<GetCompanyHandler> logger,CompanyRepository companyRepository){
            _logger = logger; 
            _companyRepository = companyRepository;
        }
        public async Task<Company> Handle(GetCompanyQuery request,CancellationToken cancellationToken)
        {
            var comp=await _companyRepository.QuerybyID(request.Id);
            return comp;
            
        }
    }
}

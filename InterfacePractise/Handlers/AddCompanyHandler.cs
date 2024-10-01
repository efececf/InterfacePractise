using InterfacePractise.Commands;
using MediatR;
using InterfacePractise.Models;
namespace InterfacePractise.Handlers
{
    public class AddCompanyHandler: IRequestHandler<AddCompanyCommand,Company>
    {
        private readonly ILogger<AddCompanyHandler> _logger;
        private readonly CompanyRepository _companyRepository;
        public AddCompanyHandler(ILogger<AddCompanyHandler> logger, CompanyRepository companyRepository)
        {
            _logger = logger;
            _companyRepository = companyRepository;
        }
        public async Task<Company> Handle(AddCompanyCommand command, CancellationToken cancellationToken)
        {
            await _companyRepository.AddAsync(command._company);
            return command._company;
        
        }
    }
}

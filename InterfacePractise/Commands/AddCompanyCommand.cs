using InterfacePractise.Models;
using MediatR;

namespace InterfacePractise.Commands
{
    public class AddCompanyCommand: IRequest<Company>
    {
        public Company _company { get; set; }
        public AddCompanyCommand(Company company)
        {
            _company=company;
        }
    }
}

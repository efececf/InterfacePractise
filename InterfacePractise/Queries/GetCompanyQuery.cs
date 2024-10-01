using MediatR;
using InterfacePractise.Models;


namespace InterfacePractise.Queries
{
    public class GetCompanyQuery:IRequest<Company>
    {
        public Guid Id { get; set; }
        public GetCompanyQuery(Guid id)
        {
            Id = id;
        }
    }
}

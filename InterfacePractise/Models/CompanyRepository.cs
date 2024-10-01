using InterfacePractise.Interfaces;
using InterfacePractise.Db;
using Microsoft.EntityFrameworkCore;
namespace InterfacePractise.Models
{
    public class CompanyRepository:IRepository<Company>
    {
        private readonly Context _context;
        public CompanyRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<Company>> GetAll()
        {
            var companies =await _context.Companies.ToListAsync();
            return companies;
        }
        public async Task<Company> QuerybyID(Guid id)
        {
            var company=await _context.Companies.FindAsync(id);
            return company;
        }
        public async Task AddAsync(Company company)
        {
            _context.Companies.Add(company);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Company company)
        {
            _context.Companies.Update(company);   
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            var company=await _context.Companies.FindAsync(id);
            _context.Companies.Remove(company);
        }
    }
}

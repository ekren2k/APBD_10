using Microsoft.EntityFrameworkCore;

namespace APBD_10.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly MasterContext _context;

    public EmployeeRepository(MasterContext context)
    {
        _context = context;
    }
    
    public async Task<Employee?> GetEmployeeByIdAsync(int id)
    {
        return await _context.Employees
            .Include(p => p.Person)
            .Include(p => p.Position)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<IEnumerable<Employee>> GetAllAsync()
    {
        return await _context.Employees
            .Include(p => p.Person)
            .Include(p => p.Position)
            .ToListAsync();
    }
}
namespace APBD_10.Repositories;

public interface IEmployeeRepository
{
    Task<Employee?> GetEmployeeByIdAsync(int id);
    Task<IEnumerable<Employee>> GetAllAsync();

}
namespace APBD_10.Repositories;

public interface IEmployeeRepository
{
    Task<Employee?> GetEmployeeByIdAsync(string id);
    Task<IEnumerable<Employee>> GetAllAsync();
    Task AddAsync(Employee employee);
    void Update(Employee employee);
    void Delete(Employee employee);
    Task<bool> ExistsAsync(int id);
}
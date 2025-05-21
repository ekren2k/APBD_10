using APBD_10.DTOs;

namespace APBD_10;

public interface IEmployeeService
{
    Task<IEnumerable<EmployeeListDto>> GetAllEmployeesAsync();
    Task<EmployeeDetailDto?> GetEmployeeByIdAsync(int id);
}
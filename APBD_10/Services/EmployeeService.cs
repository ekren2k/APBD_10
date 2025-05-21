using APBD_10.DTOs;
using APBD_10.Repositories;

namespace APBD_10;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }


    public async Task<IEnumerable<EmployeeListDto>> GetAllEmployeesAsync()
    {
        var employees = await _employeeRepository.GetAllAsync();
        return employees.Select(e => new EmployeeListDto
        {
            Id = e.Id,
            FullName = e.Person.FirstName + " " + e.Person.MiddleName + " " + e.Person.LastName,
        });
    }

    public async Task<EmployeeDetailDto?> GetEmployeeByIdAsync(int id)
    {
        var employee = await _employeeRepository.GetEmployeeByIdAsync(id);
        if (employee == null) return null;

        return new EmployeeDetailDto
        {
            PassportNumber = employee.Person.PassportNumber,
            FirstName = employee.Person.FirstName,
            MiddleName = employee.Person.MiddleName,
            LastName = employee.Person.LastName,
            PhoneNumber = employee.Person.PhoneNumber,
            Email = employee.Person.Email,
            Salary = employee.Salary,
            HireDate = employee.HireDate,
            Position = new EmployeeDetailDto.PositionDto
            {
                Id = employee.Position.Id,
                Name = employee.Position.Name
            }
        };
    }
}
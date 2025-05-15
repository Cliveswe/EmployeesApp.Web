using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services;

public class EmployeeService
{
    private static List<Employee> employees = [
            new Employee{Id = 1, Name = "Alice Johnson", Email = "alice.johnson@example.com" },
            new Employee{Id = 2, Name = "Bob Smith", Email = "bob.smith@example.com" },
            new Employee{Id = 3, Name = "Charlie Brown", Email = "charlie.brown@example.com" },
            new Employee{Id = 4, Name = "Diana Prince", Email = "diana.prince@example.com" },
            new Employee{Id = 5, Name = "Ethan Hunt", Email = "ethan.hunt@example.com" },
            new Employee{Id = 6, Name = "Fiona Scott", Email = "fiona.scott@example.com" },
            new Employee{Id = 7, Name = "George White", Email = "george.white@example.com" },
            new Employee{Id = 8, Name = "Hannah Green",Email =  "hannah.green@example.com" },
            new Employee{Id = 9, Name = "Ian Black", Email = "ian.black@example.com" },
            new Employee{Id = 10, Name = "Jane Miller", Email = "jane.miller@example.com" }
        ];

    private int NextId { get => employees.Count > 0 ? employees.Max(o => o.Id) + 1 : 1; }

    public void AddEmployee(Employee employee) {
        employee.Id = NextId;
        employees.Add(employee);
    }

    public Employee[] GetAll() =>  employees.ToArray();

    public Employee? GetById(int id) => employees.SingleOrDefault(employee => employee.Id == id);
    
}

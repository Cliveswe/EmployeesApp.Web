using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services;

public class EmployeeService
{
    private static List<Employee> employees = [
            new Employee(1, "Alice Johnson", "alice.johnson@example.com"),
            new Employee(2, "Bob Smith", "bob.smith@example.com"),
            new Employee(3, "Charlie Brown", "charlie.brown@example.com"),
            new Employee(4, "Diana Prince", "diana.prince@example.com"),
            new Employee(5, "Ethan Hunt", "ethan.hunt@example.com"),
            new Employee(6, "Fiona Scott", "fiona.scott@example.com"),
            new Employee(7, "George White", "george.white@example.com"),
            new Employee(8, "Hannah Green", "hannah.green@example.com"),
            new Employee(9, "Ian Black", "ian.black@example.com"),
            new Employee(10, "Jane Miller", "jane.miller@example.com")
        ];

    private int NextId { get => employees.Max(o => o.Id) + 1; }

}

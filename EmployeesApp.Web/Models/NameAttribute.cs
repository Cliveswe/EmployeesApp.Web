using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Models;

public class NameAttribute : ValidationAttribute
{
    public string Name { get; set; }
    public NameAttribute(string name) {
        Name = name;
    }

    public override bool IsValid(object? value) {
        string? name = value as string;
        if(name?.Length > 20)
            return false;
        return true;
    }
}

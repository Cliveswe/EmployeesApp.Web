using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Models;

public class Employee
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Enter Name")]
    [Display(Name = "User name", Prompt = "Enter a user name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Enter Email")]
    [Display(Name = "User email", Prompt = "Enter an Email")]
    [EmailAddress(ErrorMessage = "Enter an Email")]
    public string Email { get; set; }
}

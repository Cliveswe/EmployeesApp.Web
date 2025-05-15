using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Models;

public class Employee
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Enter Name")]
    [Display(Name = "Name", Prompt = "Enter a user name")]
    [NameAttribute("Name", ErrorMessage ="Name to long ! can have max 20 characters")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Enter Email")]
    [Display(Name = "Email", Prompt = "Enter an Email")]
    [EmailAddress(ErrorMessage = "Enter an Email")]
    public string Email { get; set; }
}

using EmployeesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApp.Web.Controllers;

public class EmployeesController : Controller
{
    static EmployeeService EmployeeService = new EmployeeService();


    [HttpGet("")]
    public IActionResult Index()
    { 
        var model = EmployeeService.GetAll();
        return View(model);
    }

}

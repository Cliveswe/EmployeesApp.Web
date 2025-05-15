using EmployeesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;
using EmployeesApp.Web.Models;

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

    [HttpGet("/Create")]
    public IActionResult Create()
    {
        return View();
    }


    [HttpPost("/Create")]
    public IActionResult Create(Employee employee )
    {   
        EmployeeService.AddEmployee(employee);
        return RedirectToAction(nameof(Index)); 
    }

}

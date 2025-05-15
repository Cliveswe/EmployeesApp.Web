using EmployeesApp.Web.Models;
using EmployeesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApp.Web.Controllers;

public class EmployeesController : Controller
{
    static EmployeeService EmployeeService = new EmployeeService();


    [HttpGet("")]
    public IActionResult Index() {
        var model = EmployeeService.GetAll();
        return View(model);
    }

    [HttpGet("/Create")]
    public IActionResult Create() {
        return View();
    }


    [HttpPost("/Create")]
    public IActionResult Create(Employee employee) {
        if(!ModelState.IsValid)
            return View();

        EmployeeService.AddEmployee(employee);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet("/detail/{id}")]
    public IActionResult Detail(int id) {
        var employee = EmployeeService.GetById(id);

        if(employee == null)
            return View();

        return View(employee);

    }

}

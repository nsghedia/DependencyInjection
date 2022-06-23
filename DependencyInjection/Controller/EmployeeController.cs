using DependencyInjection.InterfaceFactory;
using DependencyInjection.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DependencyInjection.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeDetails _employeeService;
        private readonly IOptions<MyJson> _settingsOptions;

        public EmployeeController(IEmployeeDetails employeeService, IOptions<MyJson> settingsOptions)
        {
            _employeeService = employeeService;
            _settingsOptions = settingsOptions;
        }
        [Route("MyJson")]
        [HttpGet]
        public IActionResult MyJson()
        {
            return new JsonResult(_settingsOptions.Value);
        }
        [Route("GetEmployee")]
        [HttpGet]
        public IActionResult GetEmployee()
        {
            var res = _employeeService.GetEmployee();
            return new JsonResult(res);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreData.Model;
using CoreData.Interface;
using CoreData.Repository;

namespace CoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private IEmployee employee = new EmpRepository();

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<IEnumerable<Employee>> GetAll()
        {
            return employee.GetAll();
        }

        [HttpGet]
        [Route("ById/{id}")]
        public ActionResult<Employee> GetById(int id)
        {
            return employee.GetById(id);
        }

        [HttpGet]
        [Route("ByName/{name}")]
        public ActionResult<Employee> GetByName(string name)
        {
            return employee.GetByName(name);
        }

        [HttpGet]
        [Route("ByName/{name}")]
        public ActionResult<Employee> GetFromQueryData([FromQuery] string name)
        {
            return employee.GetFromQueryData(name);
        }

        [HttpGet("FromBodyData")]
        [Route("ById/{id}")]
        public ActionResult<Employee> GetFromBodyData([FromBody] Employee emp)
        {
            return employee.GetFromBodyData(emp.EmpName);
        }

        [HttpGet("FromFormData")]
        [Route("ById/{id}")]
        public ActionResult<Employee> GetFromFormData([FromForm] Employee emp)
        {
            return employee.GetFromFormData(emp.EmpName);
        }
    }
}

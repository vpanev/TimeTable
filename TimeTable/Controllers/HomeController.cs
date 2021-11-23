using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TimeTable.Data;

namespace TimeTable.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly EmployeeRepository empRepository;
      

        public HomeController(EmployeeRepository empRepository)
        {
            this.empRepository = empRepository;
        }

        //GET: api/Employees
        [HttpGet("Employees")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            return await this.empRepository.GetAll();
        }

        //POST: api/Employees
        [HttpPost("Employees")]
        public async Task<IActionResult> PostEmployee(Employee employee)
        {
            await this.empRepository.Add(employee);
            return CreatedAtAction("PostEmployee", new { id = employee.EmployeeId }, employee);
        }

        //PUT: api/Employees/id
        [HttpPut("Employees/{id}")]
        public async Task<IActionResult> PutEmployee(Employee employee,int id)
        {
            if (id != employee.EmployeeId)
            {
                return BadRequest();
            }
            await this.empRepository.Update(employee);
            return Ok();
        } 

        //DELETE: api/Employees/id
        [HttpDelete("Employees/{id}")]
        public async Task<ActionResult<IEnumerable<Employee>>> DeleteEmployee(int id)
        {
            var employee = await this.empRepository.Delete(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

    }
}

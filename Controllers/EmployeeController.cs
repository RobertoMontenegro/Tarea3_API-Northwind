using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea1_EFCore.Models;
using Tarea3_API_Northwind.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tarea3_API_Northwind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        
        
        public static EmployeeSC employeeSC = new EmployeeSC();

        // GET: api/<EmployeeController>
        [HttpGet]
        public IQueryable<Employees> Get()
        {
            var allEmployees = employeeSC.GetAllEmployees();
            return allEmployees;
        }


        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employees Get(int id)
        {
            var selectedEmployee = employeeSC.GetEmployeeById(id);
            return selectedEmployee;
        }


        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            employeeSC.UpdateEmployeeFirstNameById(id, value);
            return;
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            employeeSC.DeleteEmployeeById(id);
            return;
        }
    }
}

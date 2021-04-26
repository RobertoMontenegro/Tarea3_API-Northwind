using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea3_API_Northwind.Services;
using Tarea1_EFCore.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tarea3_API_Northwind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public static CustomersSC customerSC = new CustomersSC();

        // GET: api/<CustomerController>
        [HttpGet]
        public IQueryable<Customers> Get()
        {
            var allCustomers = customerSC.GetCustomers();
            return allCustomers;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customers Get(int id)
        {
            var selectedCustomer = customerSC.GetCustomerById(id);
            return selectedCustomer;
        }


        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            customerSC.UpdateCustomerFirstNameById(id, value);
            return;
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            customerSC.DeleteCustomerById(id);
            return;
        }
    }
}

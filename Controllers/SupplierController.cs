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
    public class SupplierController : ControllerBase
    {
        public static SuppliersSC supplierSC = new SuppliersSC();

        // GET: api/<SupplierController>
        [HttpGet]
        public IQueryable<Suppliers> Get()
        {
            var allSuppliers = supplierSC.GetSuppliers();
            return allSuppliers;
        }

        // GET api/<SupplierController>/5
        [HttpGet("{id}")]
        public Suppliers Get(int id)
        {
            var selectedSupplier = supplierSC.GetSupplierById(id);
            return selectedSupplier;
        }


        // PUT api/<SupplierController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            supplierSC.UpdateSupplierFirstNameById(id, value);
            return;
        }

        // DELETE api/<SupplierController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            supplierSC.DeleteSupplierById(id);
            return;
        }
    }
}

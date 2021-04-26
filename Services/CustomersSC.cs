using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea1_EFCore.Models;

namespace Tarea3_API_Northwind.Services
{
    public class CustomersSC : BaseSC
    { 

        public Customers GetCustomerById(int id)
        {
            return GetCustomers().Where(x => x.CustomerId == id.ToString()).FirstOrDefault();
        }
        public IQueryable<Customers> GetCustomers()
        {
            return DataContext.Customers.Select(x => x);
        }

        public void DeleteCustomerById(int id)
        {
            var customer = GetCustomerById(id);
            DataContext.Customers.Remove(customer);
            DataContext.SaveChanges();
        }

        public void UpdateCustomerFirstNameById(int id, string newName)
        {
            Customers customer = GetCustomerById(id);

            if (customer == null)
                throw new Exception("No se encontró el empleado con el ID proporcionado");

            customer.ContactName = newName;
            DataContext.SaveChanges();
        }

    }
}

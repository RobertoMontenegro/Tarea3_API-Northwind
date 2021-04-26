using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea1_EFCore.Models;

namespace Tarea3_API_Northwind.Services
{
    
    public class EmployeeSC : BaseSC
    {

        public Employees GetEmployeeById(int id)
        {
            return GetAllEmployees().Where(s => s.EmployeeId == id).FirstOrDefault();
        }

        public IQueryable<Employees> GetAllEmployees()
        {
            return DataContext.Employees.Select(s => s);
        }


        public void DeleteEmployeeById(int id)
        {
            var employee = GetEmployeeById(id);
            DataContext.Employees.Remove(employee);
            DataContext.SaveChanges();
        }

        public void UpdateEmployeeFirstNameById(int id, string newName)
        {
            var currentEmployee = GetEmployeeById(id);

            if (currentEmployee == null)
                throw new Exception("No se encontró el empleado con el ID proporcionado");

            currentEmployee.FirstName = newName;
            DataContext.SaveChanges();
        }
    }

}

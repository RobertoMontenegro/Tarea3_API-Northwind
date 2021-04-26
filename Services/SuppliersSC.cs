using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea1_EFCore.Models;

namespace Tarea3_API_Northwind.Services
{
    public class SuppliersSC : BaseSC
    {

        public IQueryable<Suppliers> GetSuppliers()
        {
            return DataContext.Suppliers.Select(x => x);
        }

        public Suppliers GetSupplierById(int id)
        {
            return GetSuppliers().Where(x => x.SupplierId == id).FirstOrDefault();
        }


        public void UpdateSupplierFirstNameById(int id, string newName)
        {
            Suppliers currentSupplier = GetSupplierById(id);

            if (currentSupplier == null)
                throw new Exception("No se encontró el nombre de contacto con el ID proporcionado");

            currentSupplier.ContactName = newName;
            DataContext.SaveChanges();
        }

        // FUNCIONES PUT, POST, DELETE
        public void DeleteSupplierById(int id)
        {
            var supplier = GetSupplierById(id);
            DataContext.Suppliers.Remove(supplier);
            DataContext.SaveChanges();
        }
    }
}

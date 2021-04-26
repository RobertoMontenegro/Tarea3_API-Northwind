using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea1_EFCore.Models;

namespace Tarea3_API_Northwind.Services
{
    public class BaseSC
    {
        protected northwindContext DataContext = new northwindContext();
    }
}

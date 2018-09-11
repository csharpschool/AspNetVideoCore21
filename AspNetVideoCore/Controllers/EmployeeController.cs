using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetVideoCore.Controllers
{
    public class EmployeeController
    {
        public string Name()
        {
            return "Jonas";
        }

        public string Country()
        {
            return "Sweden";
        }

        public string Index()
        {
            return "Hello from Employee";
        }

    }
}

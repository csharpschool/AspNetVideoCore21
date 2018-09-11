using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetVideoCore.Controllers
{
    [Route("company/[controller]/[action]")]
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

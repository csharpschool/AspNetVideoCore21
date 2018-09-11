using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetVideoCore.Controllers
{
    [Route("employee")]
    public class EmployeeController
    {
        [Route("[action]")]
        public string Name()
        {
            return "Jonas";
        }

        [Route("[action]")]
        public string Country()
        {
            return "Sweden";
        }

        [Route("")]
        [Route("[action]")]
        public string Index()
        {
            return "Hello from Employee";
        }

    }
}

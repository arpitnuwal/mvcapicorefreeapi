using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace webapitest.Controllers
{
    [EnableCors(origins: "http://localhost:51747", headers: "*", methods: "*")]
    public class testController : ApiController
    {
        public IEnumerable<Employee> GetList()
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "John Doe", Department = "IT" },
                new Employee { Id = 2, Name = "Jane Smith", Department = "HR" },
                new Employee { Id = 3, Name = "Bob Johnson", Department = "Finance" },
                  new Employee { Id = 4, Name = "Bob Johnson", Department = "Finance" },
                    new Employee { Id = 5, Name = "Bob Johnson", Department = "Finance" },
                      new Employee { Id = 6, Name = "Bob Johnson", Department = "Finance" }
                // Add more employees as needed
            };

            //    return employees;


            return employees;
        }



        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
        }
    }

}

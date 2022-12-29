using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCORECRUD.Models.Domain
{
    public class Employee
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Salary { get; set; }
        public DateTime DateofBirth { get; set; }
        public String Department { get; set; }
    }
}

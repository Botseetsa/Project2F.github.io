using System;
using System.Collections.Generic;

namespace OrganisationAppx.Models
{
    public partial class Employees
    {
        public int EmpId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string EmployeeN { get; set; }
    }
}

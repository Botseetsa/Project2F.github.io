using System;
using System.Collections.Generic;

namespace OrganisationAppx.Models
{
    public partial class Departments
    {
        public int DepId { get; set; }
        public int? EmpId { get; set; }
        public string DepType { get; set; }
        public string BusinessT { get; set; }
        public int? JobL { get; set; }
        public string JobR { get; set; }
    }
}

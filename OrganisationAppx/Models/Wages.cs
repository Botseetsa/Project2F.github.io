using System;
using System.Collections.Generic;

namespace OrganisationAppx.Models
{
    public partial class Wages
    {
        public int WageId { get; set; }
        public int? EmpId { get; set; }
        public string HourlyRate { get; set; }
        public string MonthlyIncome { get; set; }
        public string OverTime { get; set; }
    }
}

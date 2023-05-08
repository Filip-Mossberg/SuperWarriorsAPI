using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class TimeReport
    {
        [Key]
        public int TimeReportID { get; set; }
        [Required]
        public Employee? Employee { get; set; }
        public int EmployeeID { get; set; }
        public int? Week { get; set; }
        [Range(0, 40)]
        public int? HoursWorked { get; set; }
    }
}

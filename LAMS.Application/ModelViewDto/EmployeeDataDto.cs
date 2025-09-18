using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Application.ModelViewDto
{
    public class EmployeeDataDto
    {
        public int EmployeeID { get; set; }       // Assuming EmployeeID is int
        public string EmployeeName { get; set; }  // Employee name
        public string Designation { get; set; }   // Job title
        public string Department { get; set; }    // Department name
        public decimal Salary { get; set; }       // Salary (decimal is best for money)
    }
}

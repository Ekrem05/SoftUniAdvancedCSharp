﻿using System;
using System.Collections.Generic;

namespace SoftUni.Models
{
    public partial class EmployeesNew
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string JobTitle { get; set; } = null!;
        public int DepartmentId { get; set; }
        public int? ManagerId { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public int? AddressId { get; set; }
    }
}

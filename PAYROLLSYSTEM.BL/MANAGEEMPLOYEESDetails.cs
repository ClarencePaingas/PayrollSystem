﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLLSYSTEM.BL
{
    public class MANAGEEMPLOYEESDetails
    {

        public string EmployeeName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string JobClass { get; set; }
        public DateTime HireDate { get; set; }
        public string Status { get; set; }
        public string EmploymentType { get; set; }
        public static char Input { get; set; }
        public static string InputName { get; set; }

    }
}
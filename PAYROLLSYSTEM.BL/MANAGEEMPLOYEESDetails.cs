using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLLSYSTEM.BL
{
    public class MANAGEEMPLOYEESDetails
    {
        //-dito ko po nilalagay yung mga properties ko po
        //para sa MANAGEEMPLOYEES na class po
        //tsaka para na din po sa mga iniinput po na value
        //ni user na payroll details po ng employee
        public static string Name1 { get; set; }
        public static string Name2 { get; set; }
        public static string Name3 { get; set; }
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

using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLLSYSTEM.BL
{
    public class MANAGEEMPLOYEES
    {
        public static List<string> Names = new List<string>();
        public static List<MANAGEEMPLOYEESDetails> EmployeeDetails = new List<MANAGEEMPLOYEESDetails>();
        
        public static void AddNames(string names)
        {

            Names.Add(names);
            //move to another class

        }

        public static void AddEmployeeDetails(MANAGEEMPLOYEESDetails details)
        {

            EmployeeDetails.Add(details);

        }

    }
}

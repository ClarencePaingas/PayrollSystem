using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLLSYSTEM.BL
{
    public class MANAGEEMPLOYEES
    {
        //-dito ko po nilagay yung list po para po sa names at details po
        //ng employees.Nandito din po yung method ko po para po pang add
        //ng name at details po ng employee.

        public static List<string> Names = new List<string>();
        public static List<MANAGEEMPLOYEESDetails> EmployeeDetails = new List<MANAGEEMPLOYEESDetails>();
        
        public static void AddNames(string names)
        {

            Names.Add(names);

        }

        public static void AddEmployeeDetails(MANAGEEMPLOYEESDetails details)
        {

            EmployeeDetails.Add(details);

        }

    }
}

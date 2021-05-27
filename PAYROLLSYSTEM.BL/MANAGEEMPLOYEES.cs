using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLLSYSTEM.BL
{
    public class MANAGEEMPLOYEES
    {

        public static List<MANAGEEMPLOYEESDetails> EmployeeDetails = new List<MANAGEEMPLOYEESDetails>();

        public static void AddEmployeeDetails(MANAGEEMPLOYEESDetails details)
        {

            EmployeeDetails.Add(details);

        }

    }
}

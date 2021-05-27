using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class ManageEmployees
    {

        
        public string EmployeeName { get; set; }
        public string Position { get; set; }
        public ME_E_Department Department { get; set; }
        public ME_E_JobClass JobClass { get; set; }
        public ME_E_PayGrade PayGrade { get; set; }
        public DateTime HireDate { get; set; }
        public ME_E_Status Status { get; set; }
        public ME_E_EmploymentType EmploymentType { get; set; }

        public int HourlyWage { get; set; }
        public int OTWage { get; set; }
        public int DaysPresent { get; set; }
        public int HoursWorked { get; set; }
        public int OTHOursWorked { get; set; }
        public int Bonus { get; set; }

        //public static void addemployee(list<manageemployees> employee)
        //{
        //    _employeedetails.addrange(employee);
        //}



    }
}

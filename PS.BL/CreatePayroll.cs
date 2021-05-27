using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class CreatePayroll
    {
        public static List<String> _employeeNames = new List<String>()
        {
            "Mary Paingas",
            "Clarence Martin",
            "Dolores Lobrigo"
        };

        public static void DisplayCreatePayroll()
        {

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                   C R E A T E   P A Y R O L L");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("PLEASE ENTER EXISTING EMPLOYEE NAME TO CREATE PAYROLL.");
            Console.Write("\nEmployee Name: ");
            string employeeName = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------------------");
            

            if (_employeeNames.Exists( name => string.Equals(name, employeeName, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Correct ka bishh");
            }

            else
            {
                Console.WriteLine("May Tama Ka Sa Utak Bishh");
            }
        }

        public void EmployeeDetails()
        {
            ManageEmployees employee1 = new ManageEmployees();

            employee1.EmployeeName = "Mary Paingas";
            employee1.Position = "Assistant Manager";
            employee1.Department = ME_E_Department.Marketing;
            employee1.JobClass = ME_E_JobClass.Executive;
            employee1.PayGrade = ME_E_PayGrade.Executive;
            employee1.HireDate = new DateTime(2019, 08, 04);
            employee1.Status = ME_E_Status.Active;
            employee1.EmploymentType = ME_E_EmploymentType.Full_Time;

            ManageEmployees employee2 = new ManageEmployees();
            employee2.EmployeeName = "Clarence Martin";
            employee2.Position = "Department Head";
            employee2.Department = ME_E_Department.IT_Support;
            employee2.JobClass = ME_E_JobClass.Executive;
            employee2.PayGrade = ME_E_PayGrade.Executive;
            employee2.HireDate = new DateTime(2015, 07, 17);
            employee2.Status = ME_E_Status.Active;
            employee2.EmploymentType = ME_E_EmploymentType.Full_Time;

            ManageEmployees employee3 = new ManageEmployees();
            employee3.EmployeeName = "Clarence Martin";
            employee3.Position = "Manager";
            employee3.Department = ME_E_Department.Accounting_And_Finance;
            employee3.JobClass = ME_E_JobClass.Executive;
            employee3.PayGrade = ME_E_PayGrade.Executive;
            employee3.HireDate = new DateTime(2010, 11, 27);
            employee3.Status = ME_E_Status.Active;
            employee3.EmploymentType = ME_E_EmploymentType.Full_Time;

            CreatePayroll create = new CreatePayroll();

            create.AddEmployee(employee1);
            _employeeDetails.AddEmployee(employee2);
            _employeeDetails.AddEmployee(employee3);

        }

        private static List<ManageEmployees> _employeeDetails = new List<ManageEmployees>()
        {

        };
        private int CalculateGrossIncome()
        {
            var grossIncome = 0;
            foreach (var pay in _employeeDetails)
            {
                //grossIncome = pay.HourlyWage * pay.
            }
            return grossIncome;
        }
        private int _grossIncome;
        public int GrossIncome
        {
            get { return CalculateGrossIncome(); }
        }

        public static void AddEmployee(List<ManageEmployees> employee)
        {
            _employeeDetails.AddRange(employee);
        }

        public static List<ManageEmployees> GetAllEmployees()
        {
            return _employeeDetails;
        }









    }
}

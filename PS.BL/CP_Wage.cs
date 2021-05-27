using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class CP_Wage
    {

        private List<ME_Employee> _employees = new List<ME_Employee>();
        public string EmployeeName { get; set; }
        public int DaysPresent { get; set; }
        public int HoursWorked { get; set; }
        public int OTWorked { get; set; }
        public int Bonus { get; set; }

        public void AddEmployee(ME_Employee employee)
        {
            _employees.Add(employee);
        }

        public List<ME_Employee> GetEmployee()
        {
            return _employees;
        }

        public void wages()
        {
            Console.WriteLine("This is wage");
        }
    }
}

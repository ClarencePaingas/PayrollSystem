using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class CALCULATE
    {
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
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PAYROLLSYSTEM.BL
{
    public class CREATEPAYROLL
    {
        public static List<string> Names = new List<string>();

        public static void AddNames(string names)
        {

            Names.Add(names);

        }

        public static void CalculateGrossIncome()
        {

            var HourlyWage = CREATEPAYROLLDetails.HourlyRate * CREATEPAYROLLDetails.HoursWorked;
            var OTWage = CREATEPAYROLLDetails.OTRate * CREATEPAYROLLDetails.OTHoursWorked;
            CREATEPAYROLLDetails.GrossIncome = HourlyWage + OTWage + CREATEPAYROLLDetails.Bonus;

        }

        public static void CalculateNetIncome()
        {

            var AllDeductions = CREATEPAYROLLDetails.Tax + CREATEPAYROLLDetails.SSS +
                                CREATEPAYROLLDetails.PhilHealth + CREATEPAYROLLDetails.PagIbig +
                                CREATEPAYROLLDetails.CashAdvance + CREATEPAYROLLDetails.SalaryLoan +
                                CREATEPAYROLLDetails.PagIbigLoan + CREATEPAYROLLDetails.Bonus;
            CREATEPAYROLLDetails.NetIncome = CREATEPAYROLLDetails.GrossIncome - AllDeductions;

        }


    }
}

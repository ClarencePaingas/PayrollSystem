using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLLSYSTEM.BL
{
    public class CREATEPAYROLL_GrossIncome_
    {
        //CREATEPAYROLL_GrossIncome_
        //-Dito po kina calculate yung gross income.


        //CreatePayroll lang po sya dati.Isang class lang po.Bali nandun na po both yung pag calculate ng gross at net income.Pinag hiwalay ko lang po.
        public static void CalculateGrossIncome()
        {

            var HourlyWage = CREATEPAYROLLDetails.HourlyRate * CREATEPAYROLLDetails.HoursWorked;
            var OTWage = CREATEPAYROLLDetails.OTRate * CREATEPAYROLLDetails.OTHoursWorked;
            CREATEPAYROLLDetails.GrossIncome = HourlyWage + OTWage + CREATEPAYROLLDetails.Bonus;

        }

    }
}

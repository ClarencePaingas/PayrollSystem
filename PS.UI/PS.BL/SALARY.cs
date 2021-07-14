using System;
using System.Collections.Generic;
using System.Text;

namespace PS.BL
{
    public class SALARY
    {
        public static List<double> DailySalaryPerPosition = new List<double>()
        {
            3045.45,
            1818.18,
            1727.27,
        };
        public static int PayrollNumber = 1;
        public static int OTSalary = 400;
        public static int StandardWorkingDays = 22;
        public static double SalaryE1 = StandardWorkingDays * DailySalaryPerPosition[1];
        public static double SalaryE2 = StandardWorkingDays * DailySalaryPerPosition[0];
        public static double SalaryE3 = StandardWorkingDays * DailySalaryPerPosition[2];
        public static int SSSSalaryA = 5000;
        public static int SSSSalaryB = 10000;
        public static int SSSSalaryC = 15000;
        public static int SSSSalaryD = 20000;
        public static int SSSContributionA = 225;
        public static int SSSContributionB = 450;
        public static int SSSContributionC = 675;
        public static int SSSContributionD = 900;
        public static int SSSContributionE = 2155;
        public static int TaxA = 20833;
        public static int TaxB = 33333;
        public static int TaxC = 66667;
        public static int TaxD = 166667;
        public static int TaxE = 666667;
        public static double Incentive { get; set; }
        public static double CashAdvance { get; set; }
        public static double SalaryLoan { get; set; }
        public static double PagIbigLoan { get; set; }
        public static double Others { get; set; }
        public static string SalaryMonthE1 { get; set; }
        public static string SalaryMonthE2 { get; set; }
        public static string SalaryMonthE3 { get; set; }

        public static double TotalDailySalaryE1
        {
            get { return GetTotalDailySalaryE1(); }
        }
        private static double GetTotalDailySalaryE1()
        {
            var total = 0.0;
            total = EMPLOYEE.Employee1Attendance.Count * DailySalaryPerPosition[1];

            return total;
        }

        public static double TotalOTSalaryE1
        {
            get { return GetTotalOTSalaryE1(); }
        }
        private static double GetTotalOTSalaryE1()
        {
            var total = 0.0;
            if (EMPLOYEE.Employee1Attendance.Count >= StandardWorkingDays)
            {
                var oTDays = EMPLOYEE.Employee1Attendance.Count - StandardWorkingDays;
                total = oTDays * OTSalary;
            }
            else 
            {
                return total;
            }

            return total;
        }

        public static double TotalGrossIncomeE1
        {
            get { return GetTotalGrossIncomeE1(); }
        }
        private static double GetTotalGrossIncomeE1()
        {
            var total = 0.0;
            total = Incentive + TotalDailySalaryE1 + TotalOTSalaryE1;
            return total;
        }

        public static double TotalDailySalaryE2
        {
            get { return GetTotalDailySalaryE2(); }
        }
        private static double GetTotalDailySalaryE2()
        {
            var total = 0.0;
            total = EMPLOYEE.Employee2Attendance.Count * DailySalaryPerPosition[0];

            return total;
        }

        public static double TotalOTSalaryE2
        {
            get { return GetTotalOTSalaryE2(); }
        }
        private static double GetTotalOTSalaryE2()
        {
            var total = 0.0;
            if (EMPLOYEE.Employee2Attendance.Count >= StandardWorkingDays)
            {
                var oTDays = EMPLOYEE.Employee2Attendance.Count - StandardWorkingDays;
                total = oTDays * OTSalary;
            }
            else if (EMPLOYEE.Employee2Attendance.Count <= StandardWorkingDays)
            {
                return total;
            }

            return total;
        }

        public static double TotalGrossIncomeE2
        {
            get { return GetTotalGrossIncomeE2(); }
        }
        private static double GetTotalGrossIncomeE2()
        {
            var total = 0.0;
            total = Incentive + TotalDailySalaryE2 + TotalOTSalaryE2;
            return total;
        }

        public static double TotalDailySalaryE3
        {
            get { return GetTotalDailySalaryE3(); }
        }
        private static double GetTotalDailySalaryE3()
        {
            var total = 0.0;
            total = EMPLOYEE.Employee3Attendance.Count * DailySalaryPerPosition[2];

            return total;
        }

        public static double TotalOTSalaryE3
        {
            get { return GetTotalOTSalaryE3(); }
        }
        private static double GetTotalOTSalaryE3()
        {
            var total = 0.0;
            if (EMPLOYEE.Employee3Attendance.Count >= StandardWorkingDays)
            {
                var oTDays = EMPLOYEE.Employee3Attendance.Count - StandardWorkingDays;
                total = oTDays * OTSalary;
            }
            else if (EMPLOYEE.Employee3Attendance.Count <= StandardWorkingDays)
            {
                return total;
            }

            return total;
        }

        public static double TotalGrossIncomeE3
        {
            get { return GetTotalGrossIncomeE3(); }
        }
        private static double GetTotalGrossIncomeE3()
        {
            var total = 0.0;
            total = Incentive + TotalDailySalaryE3 + TotalOTSalaryE3;
            return total;
        }

        //Employee1
        public static double TotalSSSE1
        {
            get { return GetTotalSSSE1(); }
        }
        private static double GetTotalSSSE1()
        {
            var total = 0.0;

            if (SalaryE1 <= SSSSalaryA)
            {
                total = SSSContributionA;
            }
            else if (SalaryE1 >= SSSSalaryA && SalaryE1 <= SSSSalaryB)
            {
                total = SSSContributionB;
            }
            else if (SalaryE1 >= SSSSalaryB && SalaryE1 <= SSSSalaryC)
            {
                total = SSSContributionC;
            }
            else if (SalaryE1 >= SSSSalaryC && SalaryE1 <= SSSSalaryD)
            {
                total = SSSContributionD;
            }
            else if (SalaryE1 >= SSSSalaryD)
            {
                total = SSSContributionE;
            }

            return total;
        }
        public static double TotalPhilHealthE1
        {
            get{return GetTotalPhilHealthE1();}
        }
        private static double GetTotalPhilHealthE1()
        {
            var total = 0.0;
            total = (SalaryE1 * 0.035) / 2;

            return total;
        }

        public static double TotalPagIbigE1
        {
            get { return GetTotalPagIbigE1(); }
        }
        private static double GetTotalPagIbigE1()
        {
            var total = 0.0;
            total = (SalaryE1 * 0.02);

            return total;
        }

        public static double TotalTaxE1
        {
            get { return GetTotalTaxE1(); }
        }
        private static double GetTotalTaxE1()
        {
            var total = 0.0;

            var deductions = TotalPagIbigE1 + TotalPhilHealthE1 + TotalSSSE1;
            var salaryAfterDeductions = SalaryE1 - deductions;

            if (salaryAfterDeductions <= TaxA)
            {
                total = salaryAfterDeductions;
            }

            else if (salaryAfterDeductions >= TaxA && salaryAfterDeductions <= TaxB)
            {
                total = ((salaryAfterDeductions - TaxA) * 0.20) + 0;
            }
            else if (salaryAfterDeductions >= TaxB && salaryAfterDeductions <= TaxC)
            {
                total = ((salaryAfterDeductions - TaxB) * 0.25) + 2500;
            }
            else if (salaryAfterDeductions >= TaxC && salaryAfterDeductions <= TaxD)
            {
                total = ((salaryAfterDeductions - TaxC) * 0.30) + 10833.33;
            }
            else if (salaryAfterDeductions >= TaxD && salaryAfterDeductions <= TaxE)
            {
                total = ((salaryAfterDeductions - TaxD) * 0.32) + 40833.33;
            }
            else if (salaryAfterDeductions >= TaxE)
            {
                total = ((salaryAfterDeductions - TaxE) * 0.35) + 200833.33;
            }
            return total;
        }

        public static double TotalDeductionsE1
        {
            get { return GetTotalDeductionsE1(); }
        }

        private static double GetTotalDeductionsE1()
        {
            var total = 0.0;
            total = TotalTaxE1 + TotalSSSE1 + TotalPhilHealthE1 + TotalPagIbigE1 + CashAdvance + SalaryLoan + PagIbigLoan + Others;
            return total;
        }

        public static double TotalNetIncomeE1
        {
            get { return GetTotalNetIncomeE1(); }
        }

        private static double GetTotalNetIncomeE1()
        {
            var total = 0.0;
            total = TotalGrossIncomeE1 - TotalDeductionsE1;
            return total;
        }

        //Employee2
        public static double TotalSSSE2
        {
            get { return GetTotalSSSE2(); }
        }
        private static double GetTotalSSSE2()
        {
            var total = 0.0;

            if (SalaryE2 <= SSSSalaryA)
            {
                total = SSSContributionA;
            }
            else if (SalaryE2 >= SSSSalaryA && SalaryE2 <= SSSSalaryB)
            {
                total = SSSContributionB;
            }
            else if (SalaryE2 >= SSSSalaryB && SalaryE2 <= SSSSalaryC)
            {
                total = SSSContributionC;
            }
            else if (SalaryE2 >= SSSSalaryC && SalaryE2 <= SSSSalaryD)
            {
                total = SSSContributionD;
            }
            else if (SalaryE2 >= SSSSalaryD)
            {
                total = SSSContributionE;
            }

            return total;
        }
        public static double TotalPhilHealthE2
        {
            get { return GetTotalPhilHealthE2(); }
        }
        private static double GetTotalPhilHealthE2()
        {
            var total = 0.0;
            total = (SalaryE2 * 0.035) / 2;

            return total;
        }

        public static double TotalPagIbigE2
        {
            get { return GetTotalPagIbigE2(); }
        }
        private static double GetTotalPagIbigE2()
        {
            var total = 0.0;
            total = (SalaryE2 * 0.02);

            return total;
        }

        public static double TotalTaxE2
        {
            get { return GetTotalTaxE2(); }
        }
        private static double GetTotalTaxE2()
        {
            var total = 0.0;

            var deductions = TotalPagIbigE2 + TotalPhilHealthE2 + TotalSSSE2;
            var salaryAfterDeductions = SalaryE2 - deductions;

            if (salaryAfterDeductions <= TaxA)
            {
                total = salaryAfterDeductions;
            }

            else if (salaryAfterDeductions >= TaxA && salaryAfterDeductions <= TaxB)
            {
                total = ((salaryAfterDeductions - TaxA) * 0.20) + 0;
            }
            else if (salaryAfterDeductions >= TaxB && salaryAfterDeductions <= TaxC)
            {
                total = ((salaryAfterDeductions - TaxB) * 0.25) + 2500;
            }
            else if (salaryAfterDeductions >= TaxC && salaryAfterDeductions <= TaxD)
            {
                total = ((salaryAfterDeductions - TaxC) * 0.30) + 10833.33;
            }
            else if (salaryAfterDeductions >= TaxD && salaryAfterDeductions <= TaxE)
            {
                total = ((salaryAfterDeductions - TaxD) * 0.32) + 40833.33;
            }
            else if (salaryAfterDeductions >= TaxE)
            {
                total = ((salaryAfterDeductions - TaxE) * 0.35) + 200833.33;
            }
            return total;
        }

        public static double TotalDeductionsE2
        {
            get { return GetTotalDeductionsE2(); }
        }

        private static double GetTotalDeductionsE2()
        {
            var total = 0.0;
            total = TotalTaxE2 + TotalSSSE2 + TotalPhilHealthE2+ TotalPagIbigE2 + CashAdvance + SalaryLoan + PagIbigLoan + Others;
            return total;
        }

        public static double TotalNetIncomeE2
        {
            get { return GetTotalNetIncomeE2(); }
        }

        private static double GetTotalNetIncomeE2()
        {
            var total = 0.0;
            total = TotalGrossIncomeE2 - TotalDeductionsE2;
            return total;
        }

        //Employee3
        public static double TotalSSSE3
        {
            get { return GetTotalSSSE3(); }
        }
        private static double GetTotalSSSE3()
        {
            var total = 0.0;

            if (SalaryE3 <= SSSSalaryA)
            {
                total = SSSContributionA;
            }
            else if (SalaryE3 >= SSSSalaryA && SalaryE3 <= SSSSalaryB)
            {
                total = SSSContributionB;
            }
            else if (SalaryE3 >= SSSSalaryB && SalaryE3 <= SSSSalaryC)
            {
                total = SSSContributionC;
            }
            else if (SalaryE3 >= SSSSalaryC && SalaryE3 <= SSSSalaryD)
            {
                total = SSSContributionD;
            }
            else if (SalaryE3 >= SSSSalaryD)
            {
                total = SSSContributionE;
            }

            return total;
        }
        public static double TotalPhilHealthE3
        {
            get { return GetTotalPhilHealthE3(); }
        }
        private static double GetTotalPhilHealthE3()
        {
            var total = 0.0;
            total = (SalaryE3 * 0.035) / 2;

            return total;
        }

        public static double TotalPagIbigE3
        {
            get { return GetTotalPagIbigE3(); }
        }
        private static double GetTotalPagIbigE3()
        {
            var total = 0.0;
            total = (SalaryE3 * 0.02);

            return total;
        }

        public static double TotalTaxE3
        {
            get { return GetTotalTaxE3(); }
        }
        private static double GetTotalTaxE3()
        {
            var total = 0.0;

            var deductions = TotalPagIbigE3 + TotalPhilHealthE3 + TotalSSSE3;
            var salaryAfterDeductions = SalaryE3 - deductions;

            if (salaryAfterDeductions <= TaxA)
            {
                total = salaryAfterDeductions;
            }

            else if (salaryAfterDeductions >= TaxA && salaryAfterDeductions <= TaxB)
            {
                total = ((salaryAfterDeductions - TaxA) * 0.20) + 0;
            }
            else if (salaryAfterDeductions >= TaxB && salaryAfterDeductions <= TaxC)
            {
                total = ((salaryAfterDeductions - TaxB) * 0.25) + 2500;
            }
            else if (salaryAfterDeductions >= TaxC && salaryAfterDeductions <= TaxD)
            {
                total = ((salaryAfterDeductions - TaxC) * 0.30) + 10833.33;
            }
            else if (salaryAfterDeductions >= TaxD && salaryAfterDeductions <= TaxE)
            {
                total = ((salaryAfterDeductions - TaxD) * 0.32) + 40833.33;
            }
            else if (salaryAfterDeductions >= TaxE)
            {
                total = ((salaryAfterDeductions - TaxE) * 0.35) + 200833.33;
            }
            return total;
        }

        public static double TotalDeductionsE3
        {
            get { return GetTotalDeductionsE3(); }
        }

        private static double GetTotalDeductionsE3()
        {
            var total = 0.0;
            total = TotalTaxE3 + TotalSSSE3 + TotalPhilHealthE3 + TotalPagIbigE3 + CashAdvance + SalaryLoan + PagIbigLoan + Others;
            return total;
        }

        public static double TotalNetIncomeE3
        {
            get { return GetTotalNetIncomeE3(); }
        }

        private static double GetTotalNetIncomeE3()
        {
            var total = 0.0;
            total = TotalGrossIncomeE3 - TotalDeductionsE3;
            return total;
        }
    }
}

//philhealth 3.5% half
//pagibig 2%
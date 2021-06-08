using PAYROLLSYSTEM.BL;

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PAYROLLSYSTEM.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            USERLoginDetails.Username = "admin1234";
            USERLoginDetails.Password = "password";
            USERLoginDetails.Attempts = 0;

            MANAGEEMPLOYEESDetails.Name1 = "Mary Paingas";
            MANAGEEMPLOYEESDetails.Name2 = "Clarence Martin";
            MANAGEEMPLOYEESDetails.Name3 = "Dolores Lobrigo";

            MANAGEEMPLOYEES.AddNames(MANAGEEMPLOYEESDetails.Name1);
            MANAGEEMPLOYEES.AddNames(MANAGEEMPLOYEESDetails.Name2);
            MANAGEEMPLOYEES.AddNames(MANAGEEMPLOYEESDetails.Name3);

            do
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("                           L O G   I N");
                Console.WriteLine("-------------------------------------------------------------------");

                Console.Write("Username: ");
                USERLoginDetails.UsernameInput = Console.ReadLine();

                Console.Write("Password: ");
                USERLoginDetails.PasswordInput = Console.ReadLine();
                Console.Clear();

                USERLoginDetails.Attempts++;

            } while (USERLoginDetails.Username != USERLoginDetails.UsernameInput &&
                USERLoginDetails.Password != USERLoginDetails.PasswordInput &&
                USERLoginDetails.Attempts != 5);

            USERLogin.LoginAuthentication();

            MainOptionsInput();



        }

        static void MainOptionsInput()
        {
            MAINOptionsDetails.MainOptionMessage = "-------------------------------------------------------------------\r\n" +
                                                   "         W E L C O M E   T O   P A Y R O L L   S Y S T E M\r\n" +
                                                   "-------------------------------------------------------------------\r\n" +
                                                   "PLEASE INPUT ANY OF THE FOLLOWING OPTIONS.\r\n";
            MAINOptionsDetails.Options = "A - Create Payroll\r\n" +
                "B - Employee Management\r\n" +
                "C - Log Out\r\n" +
                "D - Payroll History\r\n" +
                "E - User Reports";

            MAINOptions.DisplayMainOptions();

            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.Write("INPUT: ");
            MAINOptionsDetails.Input = Convert.ToChar(Console.ReadLine().ToUpper());


            switch (MAINOptionsDetails.Input)
            {
                case 'A':
                    var message = "A - Create Payroll";
                    USERReports.AddActionReport(message);
                    CreatePayroll();

                    break;

                case 'B':
                    message = "B - Manage Employees";
                    USERReports.AddActionReport(message);
                    ManageEmployees();
                    break;

                case 'C':
                    Console.Clear();
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                         L O G G E D  O U T");
                    Console.WriteLine("-------------------------------------------------------------------");
                    System.Environment.Exit(0);
                    break;

                case 'D':
                    message = "D - Payroll History";
                    USERReports.AddActionReport(message);
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                   P A Y R O L L   H I S T O R Y");
                    Console.WriteLine("-------------------------------------------------------------------\n");

                    PAYROLLHISTORY.ShowPayrollHistory();

                    Console.WriteLine("\n-------------------------------------------------------------------");
                    Console.WriteLine("PLEASE PRESS ANY KEY TO GO BACK TO MAIN OPTIONS.");
                    Console.ReadKey();

                    MainOptionsInput();
                    break;

                case 'E':
                    message = "E - User Reports";
                    USERReports.AddActionReport(message);
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                        U S E R   R E P O R T S");
                    Console.WriteLine("-------------------------------------------------------------------\n");

                    USERReports.ShowReports();

                    Console.WriteLine("\n-------------------------------------------------------------------");
                    Console.WriteLine("PLEASE PRESS ANY KEY TO GO BACK TO MAIN OPTIONS.");
                    Console.ReadKey();

                    MainOptionsInput();
                    break;
                default:
                    Console.Clear();
                    message = "Main Options Invalid Input";
                    USERReports.AddResultReport(message);
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                            E R R O R");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("INVALID INPUT. PLEASE PRESS ANY KEY TO TRY AGAIN.\n");
                    Console.ReadKey();

                    MainOptionsInput();
                    break;
            }

        }

        static void CreatePayroll()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                   C R E A T E   P A Y R O L L");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("PLEASE ENTER EXISTING EMPLOYEE NAME TO CREATE PAYROLL.");
            Console.WriteLine("REMINDER: Capitalize Only the First Letter of Each Name.");

            Console.Write("\nEmployee Name: ");
            CREATEPAYROLLDetails.NameInput = Console.ReadLine();

            var message = "Name:\t" + CREATEPAYROLLDetails.NameInput;
            USERReports.AddActionReport(message);

            message = "Employee Name:\t\t\t\t\t" + CREATEPAYROLLDetails.NameInput;
            PAYROLLPROCESSINGHistory.AddPayrollDetail(message);

            message = "\t\t" + CREATEPAYROLLDetails.NameInput;
            PAYROLLHISTORY.AddEmployeeName(message);

            if (MANAGEEMPLOYEES.Names.Any(s => s.Equals(CREATEPAYROLLDetails.NameInput, StringComparison.OrdinalIgnoreCase)))
            {

                Console.WriteLine("\n-------------------------------------------------------------------");
                Console.WriteLine("PLEASE ENTER EMPLOYEE'S PAYROLL DETAILS.");

                Console.Write("\nTotal Days Present: ");
                CREATEPAYROLLDetails.DaysPresent = Convert.ToInt32(Console.ReadLine());
                message = "Days Present:\t" + CREATEPAYROLLDetails.DaysPresent + " days";
                USERReports.AddActionReport(message);
                message = "Total Days Present:\t\t\t\t" + CREATEPAYROLLDetails.DaysPresent + " days";
                PAYROLLPROCESSINGHistory.AddPayrollDetail(message);

                Console.Write("\nTotal Hours Worked: ");
                CREATEPAYROLLDetails.HoursWorked = Convert.ToInt32(Console.ReadLine());
                message = "Hours Worked:\t" + CREATEPAYROLLDetails.HoursWorked + " hours";
                USERReports.AddActionReport(message);
                message = "Total Hours Worked:\t\t\t\t" + CREATEPAYROLLDetails.HoursWorked + " hours";
                PAYROLLPROCESSINGHistory.AddPayrollDetail(message);

                Console.Write("\nHourly Rate: ");
                CREATEPAYROLLDetails.HourlyRate = Convert.ToInt32(Console.ReadLine());
                message = "Hourly Rate:\tPhp. " + CREATEPAYROLLDetails.HourlyRate;
                USERReports.AddActionReport(message);
                message = "Hourly Rate:\t\t\t\t\tPhp. " + CREATEPAYROLLDetails.HourlyRate;
                PAYROLLPROCESSINGHistory.AddPayrollDetail(message);

                Console.Write("\nTotal Over Time Hours Worked: ");
                CREATEPAYROLLDetails.OTHoursWorked = Convert.ToInt32(Console.ReadLine());
                message = "OT Hours Worked:" + CREATEPAYROLLDetails.OTHoursWorked + " hours";
                USERReports.AddActionReport(message);
                message = "Total OT Hours Worked:\t\t\t\t" + CREATEPAYROLLDetails.OTHoursWorked + " hours";
                PAYROLLPROCESSINGHistory.AddPayrollDetail(message);

                Console.Write("\nOver Time Rate: ");
                CREATEPAYROLLDetails.OTRate = Convert.ToInt32(Console.ReadLine());
                message = "OT Rate:\tPhp. " + CREATEPAYROLLDetails.OTRate;
                USERReports.AddActionReport(message);
                message = "OT Rate:\t\t\t\t\tPhp. " + CREATEPAYROLLDetails.OTRate;
                PAYROLLPROCESSINGHistory.AddPayrollDetail(message);

                Console.Write("\nBonus: ");
                CREATEPAYROLLDetails.Bonus = Convert.ToInt32(Console.ReadLine());
                message = "Bonus:\t\tPhp. " + CREATEPAYROLLDetails.Bonus;
                USERReports.AddActionReport(message);
                message = "Bonus:\t\t\t\t\t\tPhp. " + CREATEPAYROLLDetails.Bonus;
                PAYROLLPROCESSINGHistory.AddPayrollDetail(message);

                CREATEPAYROLL_GrossIncome_.CalculateGrossIncome();

                message = "Gross Income:\tPhp. " + CREATEPAYROLLDetails.GrossIncome;
                USERReports.AddResultReport(message);
                message = "\t\t\t\t\t---------------------------";
                PAYROLLPROCESSINGHistory.AddPayrollDetail(message);
                message = "GROSS INCOME:\t\t\t\t\tPhp. " + CREATEPAYROLLDetails.GrossIncome + "\n";
                PAYROLLPROCESSINGHistory.AddPayrollDetail(message);

                message = "\tPhp. " + CREATEPAYROLLDetails.GrossIncome;
                PAYROLLHISTORY.AddGrossIncome(message);

                Console.WriteLine("\n-------------------------------------------------------------------");
                Console.WriteLine("Gross Income: Php. " + CREATEPAYROLLDetails.GrossIncome);

                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("PLEASE ENTER EMPLOYEE'S WITHHOLDING TAX AND DEDUCTION DETAILS.");

                Console.Write("\nTax: ");
                CREATEPAYROLLDetails.Tax = Convert.ToInt32(Console.ReadLine());
                message = "Tax:\t\tPhp. " + CREATEPAYROLLDetails.Tax;
                USERReports.AddActionReport(message);
                message = "Tax:\t\t\t\t\t\tPhp. " + CREATEPAYROLLDetails.Tax;
                PAYROLLPROCESSINGHistory.AddPayrollDetail(message);

                Console.Write("\nSSS: ");
                CREATEPAYROLLDetails.SSS = Convert.ToInt32(Console.ReadLine());
                message = "SSS:\t\tPhp. " + CREATEPAYROLLDetails.SSS;
                USERReports.AddActionReport(message);
                message = "SSS:\t\t\t\t\t\tPhp. " + CREATEPAYROLLDetails.SSS;
                PAYROLLPROCESSINGHistory.AddPayrollDetail(message);

                Console.Write("\nPhilHealth: ");
                CREATEPAYROLLDetails.PhilHealth = Convert.ToInt32(Console.ReadLine());
                message = "PhilHealth:\tPhp. " + CREATEPAYROLLDetails.PhilHealth;
                USERReports.AddActionReport(message);
                message = "PhilHealth:\t\t\t\t\tPhp. " + CREATEPAYROLLDetails.PhilHealth;
                PAYROLLPROCESSINGHistory.AddPayrollDetail(message);

                Console.Write("\nPag Ibig: ");
                CREATEPAYROLLDetails.PagIbig = Convert.ToInt32(Console.ReadLine());
                message = "Pag Ibig:\tPhp. " + CREATEPAYROLLDetails.PagIbig;
                USERReports.AddActionReport(message);
                message = "Pag Ibig:\t\t\t\t\tPhp. " + CREATEPAYROLLDetails.PagIbig;
                PAYROLLPROCESSINGHistory.AddPayrollDetail(message);

                Console.Write("\nCash Advance: ");
                CREATEPAYROLLDetails.CashAdvance = Convert.ToInt32(Console.ReadLine());
                message = "Cash Advance:\tPhp. " + CREATEPAYROLLDetails.CashAdvance;
                USERReports.AddActionReport(message);
                message = "Cash Advance:\t\t\t\t\tPhp. " + CREATEPAYROLLDetails.CashAdvance;
                PAYROLLPROCESSINGHistory.AddPayrollDetail(message);

                Console.Write("\nSalary Loan: ");
                CREATEPAYROLLDetails.SalaryLoan = Convert.ToInt32(Console.ReadLine());
                message = "Salary Loan:\tPhp. " + CREATEPAYROLLDetails.SalaryLoan;
                USERReports.AddActionReport(message);
                message = "Salary Loan:\t\t\t\t\tPhp. " + CREATEPAYROLLDetails.SalaryLoan;
                PAYROLLPROCESSINGHistory.AddPayrollDetail(message);

                Console.Write("\nPag Ibig Loan: ");
                CREATEPAYROLLDetails.PagIbigLoan = Convert.ToInt32(Console.ReadLine());
                message = "Pag Ibig Loan:\tPhp. " + CREATEPAYROLLDetails.PagIbigLoan;
                USERReports.AddActionReport(message);
                message = "Pag Ibig Loan:\t\t\t\t\tPhp. " + CREATEPAYROLLDetails.PagIbigLoan;
                PAYROLLPROCESSINGHistory.AddPayrollDetail(message);

                Console.Write("\nOthers: ");
                CREATEPAYROLLDetails.Others = Convert.ToInt32(Console.ReadLine());
                message = "Others:\t\tPhp. " + CREATEPAYROLLDetails.Others;
                USERReports.AddActionReport(message);
                message = "Others: \t\t\t\t\tPhp. " + CREATEPAYROLLDetails.Others;
                PAYROLLPROCESSINGHistory.AddPayrollDetail(message);

                CREATEPAYROLL_NetIncome_.CalculateNetIncome();

                message = "Net Income:\tPhp. " + CREATEPAYROLLDetails.NetIncome;
                USERReports.AddResultReport(message);
                message = "\t\t\t\t\t---------------------------";
                PAYROLLPROCESSINGHistory.AddPayrollDetail(message);
                message = "NET INCOME:\t\t\t\t\tPhp. " + CREATEPAYROLLDetails.NetIncome + "\n";
                PAYROLLPROCESSINGHistory.AddPayrollDetail(message);

                message = "\tPhp. " + CREATEPAYROLLDetails.NetIncome;
                PAYROLLHISTORY.AddNetIncome(message);

                Console.WriteLine("\n-------------------------------------------------------------------");
                Console.WriteLine("Net Income: Php. " + CREATEPAYROLLDetails.NetIncome);

                PayrollProcessing();
            }

            else
            {

                Console.Clear();
                message = "Invalid Employee Name";
                USERReports.AddResultReport(message);
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("                            E R R O R");
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("EMPLOYEE NAME DOES NOT EXIST. PLEASE PRESS ANY KEY TO TRY AGAIN.\n");
                Console.ReadKey();
                CreatePayroll();

            }
        }

        static void PayrollProcessing()
        {

            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.WriteLine("PLEASE INPUT ANY OF THE FOLLOWING OPTIONS.");
            Console.WriteLine("\nA - Print Pay Slip");
            Console.WriteLine("B - View Payroll Details");
            Console.WriteLine("C - Terminate Payroll Processing");
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.Write("INPUT: ");
            CREATEPAYROLLDetails.Input = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (CREATEPAYROLLDetails.Input)
            {

                case 'A':
                    Console.Clear();

                    var message = "A - Print Pay Slip";
                    USERReports.AddActionReport(message);

                    message = "Payroll Processed";
                    PAYROLLHISTORY.AddPayrollProcessing(message);

                    Console.WriteLine("\n-------------------------------------------------------------------");
                    Console.WriteLine("      P A Y R O L L   P R O C E S S I N G   C O M P L E T E D");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("YOU HAVE FINISHED PROCESSING THE PAYROLL");
                    Console.WriteLine("SORRY, PAY SLIP PRINTING NOT YET SUPPORTED.");
                    Console.WriteLine("\nPRESS ANY KEY TO GO BACK TO MAIN OPTIONS.");
                    Console.ReadKey();

                    MainOptionsInput();
                    break;

                case 'B':
                    Console.Clear();
                    message = "B - View Payroll Details";
                    USERReports.AddActionReport(message);

                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("               V I E W   P A Y R O L L   D E T A I L S");
                    Console.WriteLine("-------------------------------------------------------------------");

                    PAYROLLPROCESSINGHistory.ShowPayrollDetails();

                    Console.WriteLine("\n-------------------------------------------------------------------");
                    Console.WriteLine("PLEASE PRESS ANY KEY TO GO BACK TO PAYROLL PROCESSING OPTIONS.");
                    Console.ReadKey();
                    PayrollProcessing();

                    break;

                case 'C':
                    message = "C - Terminate Payroll Processing";
                    USERReports.AddActionReport(message);
                    message = "Payroll Terminated";
                    PAYROLLHISTORY.AddPayrollProcessing(message);

                    MainOptionsInput();
                    break;

                default:
                    Console.Clear();
                    message = "Payroll Processing Invalid Input";
                    USERReports.AddResultReport(message);
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                            E R R O R");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("INVALID INPUT. PLEASE PRESS ANY KEY TO TRY AGAIN.");
                    Console.ReadKey();
                    PayrollProcessing();
                    break;
            }
        }

        static void EmployeeA()
        {
            MANAGEEMPLOYEESDetails Employee1 = new MANAGEEMPLOYEESDetails
            {

                EmployeeName = "Mary Paingas",
                Position = "Assistant Manager",
                Department = "Marketing",
                JobClass = "Executive",
                HireDate = new DateTime(2019, 08, 04),
                Status = "Active",
                EmploymentType = "Full_Time"

            };

            MANAGEEMPLOYEES.AddEmployeeDetails(Employee1);

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"\nName: {Employee1.EmployeeName}");
            Console.WriteLine($"Position: {Employee1.Position}");
            Console.WriteLine($"Department: {Employee1.Department}");
            Console.WriteLine($"Job Class: {Employee1.JobClass}");
            Console.WriteLine($"Hire Date: {Employee1.HireDate}");
            Console.WriteLine($"Status: {Employee1.Status}");
            Console.WriteLine($"Employment Type: {Employee1.EmploymentType}");

            Message();

        }

        static void EmployeeB()
        {

            MANAGEEMPLOYEESDetails Employee2 = new MANAGEEMPLOYEESDetails
            {

                EmployeeName = "Clarence Martin",
                Position = "Department Head",
                Department = "IT Support",
                JobClass = "Executive",
                HireDate = new DateTime(2015, 07, 17),
                Status = "Active",
                EmploymentType = "Full_Time"

            };

            MANAGEEMPLOYEES.AddEmployeeDetails(Employee2);

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"\nName: {Employee2.EmployeeName}");
            Console.WriteLine($"Position: {Employee2.Position}");
            Console.WriteLine($"Department: {Employee2.Department}");
            Console.WriteLine($"Job Class: {Employee2.JobClass}");
            Console.WriteLine($"Hire Date: {Employee2.HireDate}");
            Console.WriteLine($"Status: {Employee2.Status}");
            Console.WriteLine($"Employment Type: {Employee2.EmploymentType}");

            Message();
        }

        static void EmployeeC()
        {

            MANAGEEMPLOYEESDetails Employee3 = new MANAGEEMPLOYEESDetails
            {

                EmployeeName = "Dolores Lobrigo",
                Position = "Consultant",
                Department = "Accounting And Finance",
                JobClass = "Executive",
                HireDate = new DateTime(2015, 07, 17),
                Status = "Active",
                EmploymentType = "Full_Time"
            };

            MANAGEEMPLOYEES.AddEmployeeDetails(Employee3);

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"\nName: {Employee3.EmployeeName}");
            Console.WriteLine($"Position: {Employee3.Position}");
            Console.WriteLine($"Department: {Employee3.Department}");
            Console.WriteLine($"Job Class: {Employee3.JobClass}");
            Console.WriteLine($"Hire Date: {Employee3.HireDate}");
            Console.WriteLine($"Status: {Employee3.Status}");
            Console.WriteLine($"Employment Type: {Employee3.EmploymentType}");

            Message();

        }
        static void ManageEmployees()
        {

            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                M A N A G E   E M P L O Y E E S");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("PLEASE INPUT ANY OF THE FOLLOWING OPTIONS.");
            Console.WriteLine("\nA - View Employee List");
            Console.WriteLine("B - View Employee Profile");
            Console.WriteLine("C - Back");
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.Write("INPUT: ");

            MANAGEEMPLOYEESDetails.Input = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (MANAGEEMPLOYEESDetails.Input)
            {

                case 'A':
                    var message = "A - View Employee List";
                    USERReports.AddActionReport(message);
                    ViewEmployeeList();
                    break;

                case 'B':
                    message = "B - View Employee Profile";
                    USERReports.AddActionReport(message);
                    ViewEmployeeProfile();
                    break;
                case 'C':

                    MainOptionsInput();
                    break;

                default:
                    Console.Clear();
                    message = "Manage Employees Invalid Input";
                    USERReports.AddResultReport(message);
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                            E R R O R");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("INVALID INPUT. PLEASE PRESS ANY KEY TO TRY AGAIN.\n");
                    Console.ReadKey();
                    ManageEmployees();
                    break;
            }

        }

        static void ViewEmployeeList()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                V I E W   E M P L O Y E E   L I S T");
            Console.WriteLine("-------------------------------------------------------------------\n");

            foreach (var name in MANAGEEMPLOYEES.Names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.WriteLine("PLEASE PRESS ANY KEY TO GO BACK TO MANAGE EMPLOYEES OPTIONS.");
            Console.ReadKey();
            ManageEmployees();
        }

        static void ViewEmployeeProfile()
        {

            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("           V I E W   E M P L O Y E E   P R O F I L E S");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("PLEASE ENTER EXISTING EMPLOYEE NAME TO VIEW EMPLOYEE PROFILES.");
            Console.WriteLine("REMINDER: Capitalize Only  the First Letter of Each Name.");
            Console.Write("\nEMPLOYEE NAME: ");
            MANAGEEMPLOYEESDetails.InputName = Console.ReadLine();

            switch (MANAGEEMPLOYEESDetails.InputName)
            {

                case "Mary Paingas":
                    var message = "Viewed Mary Paingas Profile";
                    USERReports.AddActionReport(message);
                    EmployeeA();
                    break;

                case "Clarence Martin":
                    message = "Viewed Clarence Martin Profile";
                    USERReports.AddActionReport(message);
                    EmployeeB();
                    break;

                case "Dolores Lobrigo":
                    message = "Viewed Dolores Lobrigo Profile";
                    USERReports.AddActionReport(message);
                    EmployeeC();
                    break;

                default:
                    Console.Clear();
                    message = "Invalid Employee Name";
                    USERReports.AddActionReport(message);
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                            E R R O R");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("EMPLOYEE NAME DOES NOT EXIST. PLEASE PRESS ANY KEY TO TRY AGAIN.\n");
                    Console.ReadKey();
                    ViewEmployeeProfile();
                    break;
            }

        }
        static void Message()
        {
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.WriteLine("PLEASE PRESS ANY KEY TO GO BACK TO MANAGE EMPLOYEES OPTIONS.");
            Console.ReadKey();
            ManageEmployees();
        }

    }
}

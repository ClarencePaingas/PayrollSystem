using System;
using System.Collections.Generic;

namespace PayrollSystem
{
    class Program
    {
        private static List<string> reviews = new List<string>();
        public static List<string> actionsDescription = new List<string>()
        {
            "\na - Create Payroll",
            "\nb - Employee Management",
            "\nc - Log Out"
        };

        public static List<char> actions = new List<char>() { 'a', 'b', 'c' };

        public static List<string> employeeNames = new List<string>()
        {
            "\nPaingas"
        };

        public static List<string> payTypeOptions = new List<string>()
        {
            "\na - Monthly",
            "\nb - Bi-Montlhy",
            "\nc - Cancel"
        };

        public static List<char> payTypes = new List<char>() { 'a', 'b', 'c' };
        public int SalaryPerHoursWorked(int a, int b)
        {
            return a * b;
        }
        public int SalaryPerOTWorked(int c, int d)
        {
            return c * d;
        }
        public int GrossIncome(int e, int f, int g)
        {
            return e + f + g;
        }
        public int AddAllDeductions(int h, int i, int j, int k, int l, int m, int n, int o)
        {
            return h + i + j + k + l + m + n + o;
        }

        public int NetIncome(int p, int q)
        {
            return p - q;
        }

        public static List<string> payrollProcessingOptions = new List<string>()
        {
            "\na - Complete Payroll",
            "\nb - Review Payroll Details",
            "\nc - Cancel"
        };
        public static List<char> payrollOptions = new List<char>() { 'a', 'b', 'c' };

        public static List<string> payrollProcessingOptions2 = new List<string>()
        {
            "\na - Complete Payroll",
            "\nb - Cancel"
        };
        public static List<int> payrollOptions2 = new List<int>() { 'a', 'b' };

        public static List<string> employeeManagementOptions = new List<string>()
        {
            "\na - Add Employee",
            "\nb - View Employee Information",
            "\nc - Exit"
        };

        public static List<char> managementOptions = new List<char>() { 'a', 'b', 'c' };

        public static List<string> addEmployeeOptions = new List<string>()
        {
            "\na - View Employee Information",
            "\nb - Exit",
        };

        public static List<char> addOptions = new List<char>() { 'a', 'b' };

        public static List<string> EmployeeInformations = new List<string>()
        {
            "Accounting Department",
            "Bookkeeper",
            "December 27, 2019"
        };

        static void Main(string[] args)
        {
            String adminUsernameInput2;
            String adminPasswordInput2;
            int loginAttempts = 0;

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                           L O G   I N");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("Username: ");
            String adminUsernameInput = Console.ReadLine();
            Console.Write("Password: ");
            String adminPasswordInput = Console.ReadLine();
            Console.Clear();

            if (adminUsernameInput == "admin1234" && adminPasswordInput == "password")
            {
                DisplaySuccessfulLogin();
            }
            else
            {
                do
                {
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                           L O G   I N");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("");

                    Console.Write("Username: ");
                    adminUsernameInput2 = Console.ReadLine();
                    Console.Write("Password: ");
                    adminPasswordInput2 = Console.ReadLine();
                    Console.Clear();


                    loginAttempts++;

                } while (adminUsernameInput2 != "admin1234" && adminPasswordInput2 != "password" && loginAttempts != 4);

                if (adminUsernameInput2 == "admin1234" && adminPasswordInput2 == "password")
                {
                    DisplaySuccessfulLogin();
                }
                else
                {
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                   P R O G R A M   E X I T I N G");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("YOU HAVE REACHED THE MAXIMUM RETRIES POSSIBLE.");
                    Console.WriteLine("PLEASE TRY AGAIN LATER.");
                }
            }
        }
        static void DisplaySuccessfulLogin()
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("         W E L C O M E   T O   P A Y R O L L   S Y S T E M");
            Console.WriteLine("-------------------------------------------------------------------");

            for (var userInput = GetUserInputIndexValue();
                userInput != actions.IndexOf('c');
                userInput = GetUserInputIndexValue())
            {
                var message = String.Empty;
                if (userInput.Equals(actions.IndexOf('a')))
                {
                    Console.Clear();
                    DisplayCreatePayroll();
                    break;
                }

                else if (userInput.Equals(actions.IndexOf('b')))
                {
                    Console.Clear();
                    DisplayEmployeeManagement();
                    break;
                }


            }

            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                         L O G G E D  O U T");
            Console.WriteLine("-------------------------------------------------------------------");
        }
        static void ShowUserOptions()
        {
            Console.WriteLine("PLEASE INPUT ANY OF THE FOLLOWING OPTIONS.");

            foreach (var description in actionsDescription)
            {
                Console.WriteLine(description);
            }
        }
        static int GetUserInputIndexValue()
        {
            ShowUserOptions();
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.Write("INPUT: ");
            var action = (Convert.ToChar(Console.ReadLine().ToLower()));
            Console.WriteLine("-------------------------------------------------------------------");
            var actionIndex = actions.IndexOf(action);

            if (actionIndex != -1)
            {
                return actionIndex;
            }

            else
            {
                Console.WriteLine("\n-------------------------------------------------------------------");
                var message = "INVALID INPUT. PLEASE TRY AGAIN.";
                Console.WriteLine(message);
                return GetUserInputIndexValue();
            }
        }

        static void DisplayCreatePayroll()
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                 C R E A T I N G   P A Y R O L L");
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("PLEASE CHOOSE FROM THE FOLLOWING EMPLOYEE TO CREATE PAYROLL.");

            ShowEmployeeNames();

            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.Write("EMPLOYEE NAME: ");
            var employeeNameInput = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------------------");
            var input = "EMPLOYEE NAME: \t\t\t\t" + employeeNameInput;
            AddPayrollReview(input);

            for (var payTypeInput = GetPayTypeIndexValue();
                payTypeInput != payTypes.IndexOf('c');
                payTypeInput = GetPayTypeIndexValue())
            {
                var message = String.Empty;
                if (payTypeInput.Equals(payTypes.IndexOf('a')))
                {
                    ShowMonthlyOption();
                    break;
                }

                else if (payTypeInput.Equals(payTypes.IndexOf('b')))
                {
                    ShowBiMonthlyOption();
                    break;
                }
            }



        }

        static void ShowEmployeeNames()
        {
            foreach (var names in employeeNames)
            {
                Console.WriteLine(names);
            }
        }

        static void ShowPayTypeOptions()
        {
            Console.WriteLine("PAY TYPE: ");

            foreach (var salary in payTypeOptions)
            {
                Console.WriteLine(salary);
            }
        }

        static int GetPayTypeIndexValue()
        {
            ShowPayTypeOptions();
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.Write("INPUT: ");
            var payType = (Convert.ToChar(Console.ReadLine().ToLower()));
            Console.WriteLine("-------------------------------------------------------------------");
            var payTypeIndex = payTypes.IndexOf(payType);

            if (payTypeIndex != -1)
            {
                return payTypeIndex;
            }

            else
            {
                Console.WriteLine("\n-------------------------------------------------------------------");
                var message = "INVALID INPUT. PLEASE TRY AGAIN.";
                Console.WriteLine(message);
                return GetPayTypeIndexValue();
            }
        }

        static void ShowMonthlyOption()
        {
            Console.WriteLine("\n                   *** M O N T H L Y   P A Y ***");
            var input = "PAY TYPE: \t\t\t\t\t\tMonthly";
            AddPayrollReview(input);
            DisplayPayrollDetails();
        }

        static void ShowBiMonthlyOption()
        {
            Console.WriteLine("\n               *** B I - M O N T H L Y   P A Y ***");
            var input = "PAY TYPE:\t\t\t\t\t\tBi-Monthly";
            AddPayrollReview(input);
            DisplayPayrollDetails();

        }
        static void DisplayPayrollDetails()
        {
            Console.WriteLine("              *** P A Y R O L L   D E T A I L S ***");

            Console.Write("\nTotal Days Present: ");
            var daysPresent = Console.ReadLine();
            var input = "Total Days Present: \t\t\t\t\t" + daysPresent + " days";
            AddPayrollReview(input);

            Console.Write("\nTotal Hours Worked: ");
            var hoursWorked = Convert.ToInt32(Console.ReadLine());
            input = "Total Hours Worked: \t\t\t\t\t" + hoursWorked + " hours";
            AddPayrollReview(input);

            Console.Write("\nTotal Over Time Hours Worked: ");
            var otHoursWorked = Convert.ToInt32(Console.ReadLine());
            input = "Total Over Time Hours Worked: \t\t\t\t" + otHoursWorked + " hours";
            AddPayrollReview(input);

            Console.Write("\nBonus: ");
            var bonus = Convert.ToInt32(Console.ReadLine());
            input = "Bonus: \t\t\t\t\t\tPhp. " + bonus;
            AddPayrollReview(input);

            var hourlyRate = 40;
            var otRate = 500;

            var calculate = new Program();
            var hourlycalculation = calculate.SalaryPerHoursWorked(hoursWorked, hourlyRate);
            var otcalculation = calculate.SalaryPerOTWorked(otHoursWorked, otRate);

            var grossIncome = calculate.GrossIncome(hourlycalculation, otcalculation, bonus);
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.WriteLine("Gross Income: " + grossIncome);
            Console.WriteLine("-------------------------------------------------------------------");
            input = "\t\t\t\t\t\t-------------------";
            AddPayrollReview(input);
            input = "GROSS INCOME: \t\t\t\t\t\tPhp. " + grossIncome + "\n";
            AddPayrollReview(input);

            Console.WriteLine("\n                   *** D E D U C T I O N S ***");

            Console.Write("\nTax: ");
            var taxDeduction = Convert.ToInt32(Console.ReadLine());
            input = "Tax: \t\t\t\t\t\t\tPhp. " + taxDeduction;
            AddPayrollReview(input);

            Console.Write("\nSSS: ");
            var sssDeduction = Convert.ToInt32(Console.ReadLine());
            input = "SSS: \t\t\t\t\t\t\tPhp. " + sssDeduction;
            AddPayrollReview(input);

            Console.Write("\nPhilHealth: ");
            var philHealthDeduction = Convert.ToInt32(Console.ReadLine());
            input = "PhilHealth: \t\t\t\t\t\tPhp. " + philHealthDeduction;
            AddPayrollReview(input);

            Console.Write("\nPag Ibig: ");
            var pagIbigDeduction = Convert.ToInt32(Console.ReadLine());
            input = "Pag Ibig: \t\t\t\t\t\tPhp. " + pagIbigDeduction;
            AddPayrollReview(input);

            Console.Write("\nCash Advance: ");
            var cashAdvanceDeduction = Convert.ToInt32(Console.ReadLine());
            input = "Cash Advance: \t\t\t\t\t\tPhp. " + cashAdvanceDeduction;
            AddPayrollReview(input);

            Console.Write("\nSalary Loan: ");
            var salaryLoanDeduction = Convert.ToInt32(Console.ReadLine());
            input = "Salary Loan: \t\t\t\t\t\tPhp. " + salaryLoanDeduction;
            AddPayrollReview(input);

            Console.Write("\nPag Ibig Loan: ");
            var pagIbigLoanDeduction = Convert.ToInt32(Console.ReadLine());
            input = "Pag Ibig Loan: \t\t\t\t\tPhp. " + pagIbigLoanDeduction;
            AddPayrollReview(input);

            Console.Write("\nOthers: ");
            var otherDeduction = Convert.ToInt32(Console.ReadLine());
            input = "Others: \t\t\t\t\t\tPhp. " + otherDeduction;
            AddPayrollReview(input);

            var allDeductions = calculate.AddAllDeductions(taxDeduction, sssDeduction, philHealthDeduction, pagIbigDeduction, cashAdvanceDeduction, salaryLoanDeduction, pagIbigLoanDeduction, otherDeduction);
            var netIncome = calculate.NetIncome(grossIncome, allDeductions);
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.WriteLine("Net Income: " + netIncome);
            Console.WriteLine("-------------------------------------------------------------------");
            input = "\t\t\t\t\t\t-------------------";
            AddPayrollReview(input);
            input = "NET INCOME: \t\t\t\t\t\tPhp. " + netIncome + "\n";
            AddPayrollReview(input);

            DisplayPayrollProcessing();
        }

        static void DisplayPayrollProcessing()
        {
            for (var processingInput = GetPayrollProcessingIndexValue();
                processingInput != payrollOptions.IndexOf('c');
                processingInput = GetPayrollProcessingIndexValue())
            {
                var message = String.Empty;
                if (processingInput.Equals(payrollOptions.IndexOf('a')))
                {
                    Console.WriteLine("\n-------------------------------------------------------------------");
                    Console.WriteLine("      P A Y R O L L   P R O C E S S I N G   C O M P L E T E D");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("YOU HAVE SUCCESSFULLY COMPLETED PROCESSING THE PAYROLL");
                    Console.WriteLine("");
                    Console.WriteLine("PRESS ANY KEY TO RETURN TO PAYROLL SYSTEM.");
                    Console.ReadKey();
                    Console.Clear();
                    DisplaySuccessfulLogin();
                    break;
                }

                else if (processingInput.Equals(payrollOptions.IndexOf('b')))
                {
                    ShowPayrollReview();
                    DisplayPayrollProcessing2();
                    break;

                }
            }

        }
        static void ShowPayrollProcessingOptions()
        {
            Console.WriteLine("PLEASE INPUT ANY OF THE FOLLOWING OPTIONS.");

            foreach (var Options in payrollProcessingOptions)
            {
                Console.WriteLine(Options);
            }
        }

        static int GetPayrollProcessingIndexValue()
        {
            ShowPayrollProcessingOptions();
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.Write("INPUT: ");
            var payrollOption = (Convert.ToChar(Console.ReadLine().ToLower()));
            Console.WriteLine("-------------------------------------------------------------------");
            var payrollOptionIndex = payrollOptions.IndexOf(payrollOption);

            if (payrollOptionIndex != -1)
            {
                return payrollOptionIndex;
            }

            else
            {
                Console.WriteLine("\n-------------------------------------------------------------------");
                var message = "INVALID INPUT. PLEASE TRY AGAIN.";
                Console.WriteLine(message);
                return GetPayrollProcessingIndexValue();
            }
        }

        static void DisplayPayrollProcessing2()
        {
            for (var processingInput2 = GetPayrollProcessingIndexValue2();
                processingInput2 != payrollOptions2.IndexOf('b');
                processingInput2 = GetPayrollProcessingIndexValue2())
            {
                var message = String.Empty;
                if (processingInput2.Equals(payrollOptions2.IndexOf('a')))
                {
                    Console.WriteLine("\n-------------------------------------------------------------------");
                    Console.WriteLine("      P A Y R O L L   P R O C E S S I N G   C O M P L E T E D");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("YOU HAVE SUCCESSFULLY COMPLETED PROCESSING THE PAYROLL");
                    Console.WriteLine("");
                    Console.WriteLine("PRESS ANY KEY TO RETURN TO PAYROLL SYSTEM.");
                    Console.ReadKey();
                    Console.Clear();
                    DisplaySuccessfulLogin();

                }
            }
        }

        static void ShowPayrollProcessingOptions2()
        {
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.WriteLine("PLEASE INPUT ANY OF THE FOLLOWING OPTIONS.");

            foreach (var Options2 in payrollProcessingOptions2)
            {
                Console.WriteLine(Options2);
            }
        }

        static int GetPayrollProcessingIndexValue2()
        {
            ShowPayrollProcessingOptions2();
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.Write("INPUT: ");
            var payrollOption2 = (Convert.ToChar(Console.ReadLine().ToLower()));
            Console.WriteLine("-------------------------------------------------------------------");
            var payrollOptionIndex2 = payrollOptions2.IndexOf(payrollOption2);

            if (payrollOptionIndex2 != -1)
            {
                return payrollOptionIndex2;
            }

            else
            {
                Console.WriteLine("\n-------------------------------------------------------------------");
                var message = "INVALID INPUT. PLEASE TRY AGAIN LATER.";
                Console.WriteLine(message);
                return GetPayrollProcessingIndexValue2();
            }
        }


        static void AddPayrollReview(string input)
        {
            reviews.Add($"{input}");
        }

        static void ShowPayrollReview()
        {
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.WriteLine("           R E V I E W   P A Y R O L L   D E T A I L S");
            Console.WriteLine("-------------------------------------------------------------------");
            foreach (var review in reviews)
            {
                Console.WriteLine($"\n {review}");
            }
        }

        static void DisplayEmployeeManagement()
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("              E M P L O Y E E   M A N A G E M E N T");
            Console.WriteLine("-------------------------------------------------------------------");

            ShowEmployeeManagement();


        }

        static void ShowEmployeeManagement()
        {
            for (var managementInput = GetEmployeeManagementIndexValue();
                managementInput != managementOptions.IndexOf('c');
                managementInput = GetEmployeeManagementIndexValue())
            {
                var message = String.Empty;
                if (managementInput.Equals(managementOptions.IndexOf('a')))
                {
                    DisplayAddEmployee();
                    ShowEmployeeManagement();
                    //ShowEmployeeNames();

                }

                else if (managementInput.Equals(managementOptions.IndexOf('b')))
                {
                    DisplayDefaultEmployeeInformations();
                    ShowEmployeeManagement();


                }

            }
            ShowEmployeeManagement();
        }

        static void ShowEmployeeManagementOptions()
        {
            Console.WriteLine("PLEASE INPUT ANY OF THE FOLLOWING OPTIONS.");

            foreach (var Options in employeeManagementOptions)
            {
                Console.WriteLine(Options);
            }
        }

        static int GetEmployeeManagementIndexValue()
        {
            ShowEmployeeManagementOptions();
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.Write("INPUT: ");
            var managementOption = (Convert.ToChar(Console.ReadLine().ToLower()));
            Console.WriteLine("-------------------------------------------------------------------");
            var managementOptionIndex = managementOptions.IndexOf(managementOption);

            if (managementOptionIndex != -1)
            {
                return managementOptionIndex;
            }

            else
            {
                Console.WriteLine("\n-------------------------------------------------------------------");
                var message = "INVALID INPUT. PLEASE TRY AGAIN LATER.";
                Console.WriteLine(message);
                return GetEmployeeManagementIndexValue();
            }
        }

        static void DisplayAddEmployee()
        {
            Console.Clear();
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.WriteLine("                     A D D   E M P L O Y E E");
            Console.WriteLine("-------------------------------------------------------------------");

            Console.Write("Name: ");
            var newEmployeeName = Console.ReadLine();
            employeeNames.Add(newEmployeeName);

            Console.Write("\nDepartment: ");
            var newEmployeeDepartment = Console.ReadLine();
            EmployeeInformations.Add(newEmployeeDepartment);

            Console.Write("\nPosition: ");
            var newEmployeePosition = Console.ReadLine();
            EmployeeInformations.Add(newEmployeePosition);

            Console.Write("\nDate of Employement: ");
            var newEmployeeEmploymentDate = Console.ReadLine();
            EmployeeInformations.Add(newEmployeeEmploymentDate);

            Console.WriteLine("\n\nDATA HAS BEEN ADDED TO THE LIST.");

            DisplayAddEmployeeOption();



        }

        static void DisplayDefaultEmployeeInformations()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("             E M P L O Y E E   I N F O R M A T I O N");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("Name\t\tDepartment\tPosition\tDate Of Employement");

            Console.WriteLine(employeeNames[0] + "\t" + EmployeeInformations[0] + "\t" + EmployeeInformations[1] + "\t" + EmployeeInformations[2]);
        }

        static void DisplayEmployeeInformations()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("             E M P L O Y E E   I N F O R M A T I O N");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("Name\t\tDepartment\tPosition\tDate Of Employement");

            Console.WriteLine(employeeNames[0] + "\t" + EmployeeInformations[0] + "\t" + EmployeeInformations[1] + "\t" + EmployeeInformations[2]);
            Console.WriteLine(employeeNames[1] + "\t" + EmployeeInformations[3] + "\t" + EmployeeInformations[4] + "\t" + EmployeeInformations[5]);

            Console.WriteLine("PRESS ANY KEY TO RETURN TO PAYROLL SYSTEM OPTIONS.");
            Console.ReadKey();
            Console.Clear();
            DisplaySuccessfulLogin();


        }

        static void DisplayAddEmployeeOption()
        {
            for (var employeeInput = GetAddEmployeeIndexValue();
                employeeInput != addOptions.IndexOf('b');
                employeeInput = GetAddEmployeeIndexValue())
            {
                var message = String.Empty;
                if (employeeInput.Equals(addOptions.IndexOf('a')))
                {
                    DisplayEmployeeInformations();

                    break;
                }
            }
        }
        static void ShowAddEmployeeOptions()
        {
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.WriteLine("PLEASE INPUT ANY OF THE FOLLOWING OPTIONS.");

            foreach (var Options in addEmployeeOptions)
            {
                Console.WriteLine(Options);
            }
        }

        static int GetAddEmployeeIndexValue()
        {
            ShowAddEmployeeOptions();
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.Write("INPUT: ");
            var employeeOption = (Convert.ToChar(Console.ReadLine().ToLower()));
            Console.WriteLine("-------------------------------------------------------------------");
            var employeeOptionIndex = addOptions.IndexOf(employeeOption);

            if (employeeOptionIndex != -1)
            {
                return employeeOptionIndex;
            }

            else
            {
                Console.WriteLine("\n-------------------------------------------------------------------");
                var message = "INVALID INPUT. PLEASE TRY AGAIN LATER.";
                Console.WriteLine(message);
                return GetAddEmployeeIndexValue();
            }
        }
    }
}

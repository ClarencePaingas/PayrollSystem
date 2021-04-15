using System;

namespace PayrollSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            String adminUsername = "admin1234";
            String adminPassword = "password";

            String optionSelected;
            String choiceSelected;
            String answerSelected;

            String employeeID = "AD1234";
            String employeeName = "Mary Clarence Dolores M. Paingas";
            String employeeDepartment = "Accounting Department";
            String employeePosition = "Bookkeeper";
            String ratePerDay = "400";
            int hourlyRate = 50;
            int otRate = 470;
            String ratePerOT = "480";
            String employeeStatus = "Active";
            String payType;
            int workDays;
            int workHours;
            int workOT;
            int salaryBonus;
            int grossIncome;
            int deductionTax;
            int deductionSSS;
            int deductionPhilHealth;
            int deductionPagIbig;
            int deductionCashAdvance;
            int deductionSalaryLoan;
            int deductionPagIbigLoan;
            int deductionOthers;
            int netIncome;
            int loginAttempts = 0;
            String adminUsernameInput;
            String adminPasswordInput;

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                           L O G   I N");
            Console.WriteLine("-------------------------------------------------------------------");

            do
            {

                Console.Write("Username: ");
                adminUsernameInput = Console.ReadLine();
                Console.Write("Password: ");
                adminPasswordInput = Console.ReadLine();

                Console.WriteLine("");

                loginAttempts++;

            } while (!adminUsernameInput.Equals(adminUsername) && !adminPasswordInput.Equals(adminPassword) && loginAttempts != 5);

            if (adminUsernameInput.Equals(adminUsername) && adminPasswordInput.Equals(adminPassword))
            {
                Console.WriteLine("     *** P R O C E S S I N G   L O G   I N   D E T A I L S ***");
                Console.WriteLine("LOG IN COMPLETE");
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("                    P A Y R O L L   S Y S T E M");
                Console.WriteLine("-------------------------------------------------------------------");
                Console.Write("Employee ID: ");
                employeeID = Console.ReadLine().ToUpper();

                if (employeeID.Equals("AD1234"))
                {
                    Console.WriteLine("Employee Name   :   " + employeeName);
                    Console.WriteLine("Department      :   " + employeeDepartment);
                    Console.WriteLine("Position        :   " + employeePosition);
                    Console.WriteLine("Rate per Day    :   " + ratePerDay);
                    Console.WriteLine("Rate per OT     :   " + ratePerOT);
                    Console.WriteLine("Status          :   " + employeeStatus);

                    Console.WriteLine("");
                    Console.WriteLine("DO YOU WANT TO PROCEED WITH THE PAYROLL?");
                    Console.WriteLine("              Y - YES                   N - NO");
                    choiceSelected = Console.ReadLine().ToUpper();
                    Console.WriteLine("");

                    if (choiceSelected.Equals("Y"))
                    {
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("                 C R E A T I N G   P A Y R O L L");
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.Write("Pay Type (Monthly or Bi-Monthly): ");
                        payType = Console.ReadLine();

                        if (payType.Equals("monthly") || payType.Equals("Monthly"))
                        {
                            Console.Write("Total Days Present: ");
                            workDays = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Total Hours Worked: ");
                            workHours = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Total Over Time Hours Worked: ");
                            workOT = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Bonus: ");
                            salaryBonus = Convert.ToInt32(Console.ReadLine());

                            int salaryperHour = workHours * hourlyRate;
                            int salaryperOT = workOT * otRate;
                            grossIncome = salaryperHour + salaryperOT + salaryBonus;

                            Console.WriteLine(" ");
                            Console.WriteLine("Gross Income: " + grossIncome);
                            Console.WriteLine("");

                            Console.WriteLine("                   *** D E D U C T I O N S ***");
                            Console.Write("Tax: ");
                            deductionTax = Convert.ToInt32(Console.ReadLine());
                            Console.Write("SSS: ");
                            deductionSSS = Convert.ToInt32(Console.ReadLine());
                            Console.Write("PhilHealth: ");
                            deductionPhilHealth = Convert.ToInt32(Console.ReadLine());
                            Console.Write("PagIbig: ");
                            deductionPagIbig = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Cash Advance: ");
                            deductionCashAdvance = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Salary Loan: ");
                            deductionSalaryLoan = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Pagibig Loan: ");
                            deductionPagIbigLoan = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Others: ");
                            deductionOthers = Convert.ToInt32(Console.ReadLine());

                            int allDeductions = deductionTax + deductionSSS + deductionSalaryLoan + deductionPhilHealth + deductionPagIbigLoan + deductionPagIbig + deductionOthers + deductionCashAdvance;
                            netIncome = grossIncome - allDeductions;

                            Console.WriteLine("");
                            Console.WriteLine("Net Income: " + netIncome);
                            Console.WriteLine("");

                            Console.WriteLine("DO YOU WANT TO PROCESS PAYROLL?");
                            Console.WriteLine("              Y - YES                   N - NO");
                            answerSelected = Console.ReadLine().ToUpper();
                            Console.WriteLine();

                            if (answerSelected.Equals("Y"))
                            {
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.WriteLine("                 P R O C E S S I N G   P A Y R O L L");
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.WriteLine("PAYROLL PROCESSING COMPLETE");
                                Console.WriteLine("");
                                Console.WriteLine("            V - TO VIEW PAYROLL DETAILS     E - EXIT");
                                optionSelected = Console.ReadLine().ToUpper();

                                if (optionSelected.Equals("V"))
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("              *** E M P L O Y E E   D E T A I L S ***");
                                    Console.WriteLine("Employee ID ----------------------- " + employeeID);
                                    Console.WriteLine("Employee Name --------------------- " + employeeName);
                                    Console.WriteLine("Department ------------------------ " + employeeDepartment);
                                    Console.WriteLine("Position -------------------------- " + employeePosition);
                                    Console.WriteLine("Rate per Day ---------------------- " + ratePerDay);
                                    Console.WriteLine("Rate per OT ----------------------- " + ratePerOT);
                                    Console.WriteLine("Status ---------------------------- " + employeeStatus);
                                    Console.WriteLine("");

                                    Console.WriteLine("                 *** I N C O M E   D E T A I L S ***");
                                    Console.WriteLine("Pay Type -------------------------- " + payType);
                                    Console.WriteLine("Total Days Present ---------------- " + workDays);
                                    Console.WriteLine("Total Hours Worked ---------------- " + workHours);
                                    Console.WriteLine("Total Over Time Hours Worked ------ " + workOT);
                                    Console.WriteLine("Bonus ----------------------------- " + salaryBonus);
                                    Console.WriteLine("Gross Income ---------------------- " + grossIncome);
                                    Console.WriteLine("");

                                    Console.WriteLine("             *** D E D U C T I O N   D E T A I L S ***");
                                    Console.WriteLine("Tax ------------------------------- " + deductionTax);
                                    Console.WriteLine("SSS ------------------------------- " + deductionSSS);
                                    Console.WriteLine("PhilHealth ------------------------ " + deductionPhilHealth);
                                    Console.WriteLine("PagIbig --------------------------- " + deductionPagIbig);
                                    Console.WriteLine("Cash Advance ---------------------- " + deductionCashAdvance);
                                    Console.WriteLine("Salary Loan ----------------------- " + deductionSalaryLoan);
                                    Console.WriteLine("PagIbig Loan ---------------------- " + deductionPagIbigLoan);
                                    Console.WriteLine("Others ---------------------------- " + deductionOthers);
                                    Console.WriteLine("");

                                    Console.WriteLine("Net Income ------------------------ " + netIncome);

                                }
                                else if (optionSelected.Equals("E"))
                                {
                                    Console.WriteLine("                     *** P R O C E S S I N G ***");
                                    Console.WriteLine("EXITING PAYROLL SYSTEM");
                                }

                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("                        E R R O R");
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("PLEASE SELECT A VALID ANSWER");
                                    Console.WriteLine("TRY AGAIN LATER");
                                }

                            }
                            else if (answerSelected.Equals("N"))
                            {
                                Console.WriteLine("                    *** P R O C E S S I N G ***");
                                Console.WriteLine("PAYROLL PROCESSING TERMINATED");
                            }
                            else
                            {
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.WriteLine("                           E R R O R");
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.WriteLine("PLEASE SELECT A VALID ANSWER");
                                Console.WriteLine("TRY AGAIN LATER");
                            }
                        }

                        else if (payType.Equals("bi-monthly") || payType.Equals("Bi-monthly") || payType.Equals("Bi-Monthly") || payType.Equals("bi-Monthly"))
                        {

                            Console.Write("Total Days Present: ");
                            workDays = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Total Hours Worked: ");
                            workHours = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Total Over Time Hours Worked: ");
                            workOT = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Bonus: ");
                            salaryBonus = Convert.ToInt32(Console.ReadLine());

                            int salaryperHour = workHours * hourlyRate;
                            int salaryperOT = workOT * otRate;
                            grossIncome = salaryperHour + salaryperOT + salaryBonus;

                            Console.WriteLine(" ");
                            Console.WriteLine("Gross Income: " + grossIncome);
                            Console.WriteLine("");

                            Console.WriteLine("                   *** D E D U C T I O N S ***");
                            Console.Write("Tax: ");
                            deductionTax = Convert.ToInt32(Console.ReadLine());
                            Console.Write("SSS: ");
                            deductionSSS = Convert.ToInt32(Console.ReadLine());
                            Console.Write("PhilHealth: ");
                            deductionPhilHealth = Convert.ToInt32(Console.ReadLine());
                            Console.Write("PagIbig: ");
                            deductionPagIbig = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Cash Advance: ");
                            deductionCashAdvance = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Salary Loan: ");
                            deductionSalaryLoan = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Pagibig Loan: ");
                            deductionPagIbigLoan = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Others: ");
                            deductionOthers = Convert.ToInt32(Console.ReadLine());

                            int allDeductions = deductionTax + deductionSSS + deductionSalaryLoan + deductionPhilHealth + deductionPagIbigLoan + deductionPagIbig + deductionOthers + deductionCashAdvance;
                            netIncome = grossIncome - allDeductions;

                            Console.WriteLine("");
                            Console.WriteLine("Net Income: " + netIncome);
                            Console.WriteLine("");

                            Console.WriteLine("DO YOU WANT TO PROCESS PAYROLL?");
                            Console.WriteLine("              Y - YES                   N - NO");
                            answerSelected = Console.ReadLine().ToUpper();
                            Console.WriteLine();

                            if (answerSelected.Equals("Y"))
                            {
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.WriteLine("                 P R O C E S S I N G   P A Y R O L L");
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.WriteLine("PAYROLL PROCESSING COMPLETE");
                                Console.WriteLine("");
                                Console.WriteLine("            V - TO VIEW PAYROLL DETAILS     E - EXIT");
                                optionSelected = Console.ReadLine().ToUpper();

                                if (optionSelected.Equals("V"))
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("              *** E M P L O Y E E   D E T A I L S ***");
                                    Console.WriteLine("Employee ID ----------------------- " + employeeID);
                                    Console.WriteLine("Employee Name --------------------- " + employeeName);
                                    Console.WriteLine("Department ------------------------ " + employeeDepartment);
                                    Console.WriteLine("Position -------------------------- " + employeePosition);
                                    Console.WriteLine("Rate per Day ---------------------- " + ratePerDay);
                                    Console.WriteLine("Rate per OT ----------------------- " + ratePerOT);
                                    Console.WriteLine("Status ---------------------------- " + employeeStatus);
                                    Console.WriteLine("");

                                    Console.WriteLine("                *** I N C O M E   D E T A I L S ***");
                                    Console.WriteLine("Pay Type -------------------------- " + payType);
                                    Console.WriteLine("Total Days Present ---------------- " + workDays);
                                    Console.WriteLine("Total Hours Worked ---------------- " + workHours);
                                    Console.WriteLine("Total Over Time Hours Worked ------ " + workOT);
                                    Console.WriteLine("Bonus ----------------------------- " + salaryBonus);
                                    Console.WriteLine("Gross Income ---------------------- " + grossIncome);
                                    Console.WriteLine("");

                                    Console.WriteLine("             *** D E D U C T I O N   D E T A I L S ***");
                                    Console.WriteLine("Tax ------------------------------- " + deductionTax);
                                    Console.WriteLine("SSS ------------------------------- " + deductionSSS);
                                    Console.WriteLine("PhilHealth ------------------------ " + deductionPhilHealth);
                                    Console.WriteLine("PagIbig --------------------------- " + deductionPagIbig);
                                    Console.WriteLine("Cash Advance ---------------------- " + deductionCashAdvance);
                                    Console.WriteLine("Salary Loan ----------------------- " + deductionSalaryLoan);
                                    Console.WriteLine("PagIbig Loan ---------------------- " + deductionPagIbigLoan);
                                    Console.WriteLine("Others ---------------------------- " + deductionOthers);
                                    Console.WriteLine("");

                                    Console.WriteLine("Net Income ------------------------ " + netIncome);

                                }
                                else if (optionSelected.Equals("E"))
                                {
                                    Console.WriteLine("                    *** P R O C E S S I N G ***");
                                    Console.WriteLine("PAYROLL PROCESSING TERMINATED");
                                }

                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("                           E R R O R");
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("PLEASE SELECT A VALID ANSWER");
                                    Console.WriteLine("TRY AGAIN LATER");
                                }

                            }
                            else if (answerSelected.Equals("N"))
                            {
                                Console.WriteLine("                    *** P R O C E S S I N G ***");
                                Console.WriteLine("PAYROLL PROCESSING TERMINATED");
                            }
                            else
                            {
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.WriteLine("                           E R R O R");
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.WriteLine("PLEASE SELECT A VALID ANSWER");
                                Console.WriteLine("TRY AGAIN LATER");
                            }

                        }

                        else
                        {

                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine("                           E R R O R");
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine("PLEASE SELECT A VALID ANSWER");
                            Console.WriteLine("TRY AGAIN LATER");

                        }

                    }
                    else if (choiceSelected.Equals("N"))
                    {
                        Console.WriteLine("                    *** P R O C E S S I N G ***");
                        Console.WriteLine("PAYROLL PROCESSING TERMINATED");
                    }
                    else
                    {
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("                           E R R O R");
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("PLEASE SELECT A VALID ANSWER");
                        Console.WriteLine("TRY AGAIN LATER");
                    }
                }

                else
                {
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                           E R R O R");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("EMPLOYEE ID DOES NOT EXIST");
                    Console.WriteLine("PLEASE TRY AGAIN LATER");
                }
            }
            else if (adminUsernameInput.Equals(adminUsername))
            {
                /*---------------------------------------------------------------------------------------------------------*/
                do
                {
                    Console.WriteLine("  *** I N V A L I D   P A S S W O R D ***");
                    Console.WriteLine("PLEASE ENTER A VALID PASSWORD");
                    Console.WriteLine("Username: " + adminUsernameInput);

                    Console.Write("Password: ");
                    adminPasswordInput = Console.ReadLine();

                    Console.WriteLine("");


                    loginAttempts++;
                } while (!adminPasswordInput.Equals(adminPassword) && loginAttempts != 5);

                if (adminPasswordInput.Equals(adminPassword))
                {
                    Console.WriteLine("     *** P R O C E S S I N G   L O G   I N   D E T A I L S ***");
                    Console.WriteLine("LOG IN COMPLETE");
                    Console.WriteLine("");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                    P A Y R O L L   S Y S T E M");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.Write("Employee ID: ");
                    employeeID = Console.ReadLine().ToUpper();

                    if (employeeID.Equals("AD1234"))
                    {
                        Console.WriteLine("Employee Name   :   " + employeeName);
                        Console.WriteLine("Department      :   " + employeeDepartment);
                        Console.WriteLine("Position        :   " + employeePosition);
                        Console.WriteLine("Rate per Day    :   " + ratePerDay);
                        Console.WriteLine("Rate per OT     :   " + ratePerOT);
                        Console.WriteLine("Status          :   " + employeeStatus);

                        Console.WriteLine("");
                        Console.WriteLine("DO YOU WANT TO PROCEED WITH THE PAYROLL?");
                        Console.WriteLine("              Y - YES                   N - NO");
                        choiceSelected = Console.ReadLine().ToUpper();
                        Console.WriteLine("");

                        if (choiceSelected.Equals("Y"))
                        {
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine("                 C R E A T I N G   P A Y R O L L");
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.Write("Pay Type (Monthly or Bi-Monthly): ");
                            payType = Console.ReadLine();

                            if (payType.Equals("monthly") || payType.Equals("Monthly"))
                            {
                                Console.Write("Total Days Present: ");
                                workDays = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Total Hours Worked: ");
                                workHours = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Total Over Time Hours Worked: ");
                                workOT = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Bonus: ");
                                salaryBonus = Convert.ToInt32(Console.ReadLine());

                                int salaryperHour = workHours * hourlyRate;
                                int salaryperOT = workOT * otRate;
                                grossIncome = salaryperHour + salaryperOT + salaryBonus;

                                Console.WriteLine(" ");
                                Console.WriteLine("Gross Income: " + grossIncome);
                                Console.WriteLine("");

                                Console.WriteLine("                   *** D E D U C T I O N S ***");
                                Console.Write("Tax: ");
                                deductionTax = Convert.ToInt32(Console.ReadLine());
                                Console.Write("SSS: ");
                                deductionSSS = Convert.ToInt32(Console.ReadLine());
                                Console.Write("PhilHealth: ");
                                deductionPhilHealth = Convert.ToInt32(Console.ReadLine());
                                Console.Write("PagIbig: ");
                                deductionPagIbig = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Cash Advance: ");
                                deductionCashAdvance = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Salary Loan: ");
                                deductionSalaryLoan = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Pagibig Loan: ");
                                deductionPagIbigLoan = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Others: ");
                                deductionOthers = Convert.ToInt32(Console.ReadLine());

                                int allDeductions = deductionTax + deductionSSS + deductionSalaryLoan + deductionPhilHealth + deductionPagIbigLoan + deductionPagIbig + deductionOthers + deductionCashAdvance;
                                netIncome = grossIncome - allDeductions;

                                Console.WriteLine("");
                                Console.WriteLine("Net Income: " + netIncome);
                                Console.WriteLine("");

                                Console.WriteLine("DO YOU WANT TO PROCESS PAYROLL?");
                                Console.WriteLine("              Y - YES                   N - NO");
                                answerSelected = Console.ReadLine().ToUpper();
                                Console.WriteLine();

                                if (answerSelected.Equals("Y"))
                                {
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("                 P R O C E S S I N G   P A Y R O L L");
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("PAYROLL PROCESSING COMPLETE");
                                    Console.WriteLine("");
                                    Console.WriteLine("            V - TO VIEW PAYROLL DETAILS     E - EXIT");
                                    optionSelected = Console.ReadLine().ToUpper();

                                    if (optionSelected.Equals("V"))
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("              *** E M P L O Y E E   D E T A I L S ***");
                                        Console.WriteLine("Employee ID ----------------------- " + employeeID);
                                        Console.WriteLine("Employee Name --------------------- " + employeeName);
                                        Console.WriteLine("Department ------------------------ " + employeeDepartment);
                                        Console.WriteLine("Position -------------------------- " + employeePosition);
                                        Console.WriteLine("Rate per Day ---------------------- " + ratePerDay);
                                        Console.WriteLine("Rate per OT ----------------------- " + ratePerOT);
                                        Console.WriteLine("Status ---------------------------- " + employeeStatus);
                                        Console.WriteLine("");

                                        Console.WriteLine("                 *** I N C O M E   D E T A I L S ***");
                                        Console.WriteLine("Pay Type -------------------------- " + payType);
                                        Console.WriteLine("Total Days Present ---------------- " + workDays);
                                        Console.WriteLine("Total Hours Worked ---------------- " + workHours);
                                        Console.WriteLine("Total Over Time Hours Worked ------ " + workOT);
                                        Console.WriteLine("Bonus ----------------------------- " + salaryBonus);
                                        Console.WriteLine("Gross Income ---------------------- " + grossIncome);
                                        Console.WriteLine("");

                                        Console.WriteLine("             *** D E D U C T I O N   D E T A I L S ***");
                                        Console.WriteLine("Tax ------------------------------- " + deductionTax);
                                        Console.WriteLine("SSS ------------------------------- " + deductionSSS);
                                        Console.WriteLine("PhilHealth ------------------------ " + deductionPhilHealth);
                                        Console.WriteLine("PagIbig --------------------------- " + deductionPagIbig);
                                        Console.WriteLine("Cash Advance ---------------------- " + deductionCashAdvance);
                                        Console.WriteLine("Salary Loan ----------------------- " + deductionSalaryLoan);
                                        Console.WriteLine("PagIbig Loan ---------------------- " + deductionPagIbigLoan);
                                        Console.WriteLine("Others ---------------------------- " + deductionOthers);
                                        Console.WriteLine("");

                                        Console.WriteLine("Net Income ------------------------ " + netIncome);

                                    }
                                    else if (optionSelected.Equals("E"))
                                    {
                                        Console.WriteLine("                     *** P R O C E S S I N G ***");
                                        Console.WriteLine("EXITING PAYROLL SYSTEM");
                                    }

                                    else
                                    {
                                        Console.WriteLine("-------------------------------------------------------------------");
                                        Console.WriteLine("                        E R R O R");
                                        Console.WriteLine("-------------------------------------------------------------------");
                                        Console.WriteLine("PLEASE SELECT A VALID ANSWER");
                                        Console.WriteLine("TRY AGAIN LATER");
                                    }

                                }
                                else if (answerSelected.Equals("N"))
                                {
                                    Console.WriteLine("                    *** P R O C E S S I N G ***");
                                    Console.WriteLine("PAYROLL PROCESSING TERMINATED");
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("                           E R R O R");
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("PLEASE SELECT A VALID ANSWER");
                                    Console.WriteLine("TRY AGAIN LATER");
                                }
                            }

                            else if (payType.Equals("bi-monthly") || payType.Equals("Bi-monthly") || payType.Equals("Bi-Monthly") || payType.Equals("bi-Monthly"))
                            {

                                Console.Write("Total Days Present: ");
                                workDays = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Total Hours Worked: ");
                                workHours = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Total Over Time Hours Worked: ");
                                workOT = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Bonus: ");
                                salaryBonus = Convert.ToInt32(Console.ReadLine());

                                int salaryperHour = workHours * hourlyRate;
                                int salaryperOT = workOT * otRate;
                                grossIncome = salaryperHour + salaryperOT + salaryBonus;

                                Console.WriteLine(" ");
                                Console.WriteLine("Gross Income: " + grossIncome);
                                Console.WriteLine("");

                                Console.WriteLine("                   *** D E D U C T I O N S ***");
                                Console.Write("Tax: ");
                                deductionTax = Convert.ToInt32(Console.ReadLine());
                                Console.Write("SSS: ");
                                deductionSSS = Convert.ToInt32(Console.ReadLine());
                                Console.Write("PhilHealth: ");
                                deductionPhilHealth = Convert.ToInt32(Console.ReadLine());
                                Console.Write("PagIbig: ");
                                deductionPagIbig = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Cash Advance: ");
                                deductionCashAdvance = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Salary Loan: ");
                                deductionSalaryLoan = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Pagibig Loan: ");
                                deductionPagIbigLoan = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Others: ");
                                deductionOthers = Convert.ToInt32(Console.ReadLine());

                                int allDeductions = deductionTax + deductionSSS + deductionSalaryLoan + deductionPhilHealth + deductionPagIbigLoan + deductionPagIbig + deductionOthers + deductionCashAdvance;
                                netIncome = grossIncome - allDeductions;

                                Console.WriteLine("");
                                Console.WriteLine("Net Income: " + netIncome);
                                Console.WriteLine("");

                                Console.WriteLine("DO YOU WANT TO PROCESS PAYROLL?");
                                Console.WriteLine("              Y - YES                   N - NO");
                                answerSelected = Console.ReadLine().ToUpper();
                                Console.WriteLine();

                                if (answerSelected.Equals("Y"))
                                {
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("                 P R O C E S S I N G   P A Y R O L L");
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("PAYROLL PROCESSING COMPLETE");
                                    Console.WriteLine("");
                                    Console.WriteLine("            V - TO VIEW PAYROLL DETAILS     E - EXIT");
                                    optionSelected = Console.ReadLine().ToUpper();

                                    if (optionSelected.Equals("V"))
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("              *** E M P L O Y E E   D E T A I L S ***");
                                        Console.WriteLine("Employee ID ----------------------- " + employeeID);
                                        Console.WriteLine("Employee Name --------------------- " + employeeName);
                                        Console.WriteLine("Department ------------------------ " + employeeDepartment);
                                        Console.WriteLine("Position -------------------------- " + employeePosition);
                                        Console.WriteLine("Rate per Day ---------------------- " + ratePerDay);
                                        Console.WriteLine("Rate per OT ----------------------- " + ratePerOT);
                                        Console.WriteLine("Status ---------------------------- " + employeeStatus);
                                        Console.WriteLine("");

                                        Console.WriteLine("                *** I N C O M E   D E T A I L S ***");
                                        Console.WriteLine("Pay Type -------------------------- " + payType);
                                        Console.WriteLine("Total Days Present ---------------- " + workDays);
                                        Console.WriteLine("Total Hours Worked ---------------- " + workHours);
                                        Console.WriteLine("Total Over Time Hours Worked ------ " + workOT);
                                        Console.WriteLine("Bonus ----------------------------- " + salaryBonus);
                                        Console.WriteLine("Gross Income ---------------------- " + grossIncome);
                                        Console.WriteLine("");

                                        Console.WriteLine("             *** D E D U C T I O N   D E T A I L S ***");
                                        Console.WriteLine("Tax ------------------------------- " + deductionTax);
                                        Console.WriteLine("SSS ------------------------------- " + deductionSSS);
                                        Console.WriteLine("PhilHealth ------------------------ " + deductionPhilHealth);
                                        Console.WriteLine("PagIbig --------------------------- " + deductionPagIbig);
                                        Console.WriteLine("Cash Advance ---------------------- " + deductionCashAdvance);
                                        Console.WriteLine("Salary Loan ----------------------- " + deductionSalaryLoan);
                                        Console.WriteLine("PagIbig Loan ---------------------- " + deductionPagIbigLoan);
                                        Console.WriteLine("Others ---------------------------- " + deductionOthers);
                                        Console.WriteLine("");

                                        Console.WriteLine("Net Income ------------------------ " + netIncome);

                                    }
                                    else if (optionSelected.Equals("E"))
                                    {
                                        Console.WriteLine("                    *** P R O C E S S I N G ***");
                                        Console.WriteLine("PAYROLL PROCESSING TERMINATED");
                                    }

                                    else
                                    {
                                        Console.WriteLine("-------------------------------------------------------------------");
                                        Console.WriteLine("                           E R R O R");
                                        Console.WriteLine("-------------------------------------------------------------------");
                                        Console.WriteLine("PLEASE SELECT A VALID ANSWER");
                                        Console.WriteLine("TRY AGAIN LATER");
                                    }

                                }
                                else if (answerSelected.Equals("N"))
                                {
                                    Console.WriteLine("                    *** P R O C E S S I N G ***");
                                    Console.WriteLine("PAYROLL PROCESSING TERMINATED");
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("                           E R R O R");
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("PLEASE SELECT A VALID ANSWER");
                                    Console.WriteLine("TRY AGAIN LATER");
                                }

                            }

                            else
                            {

                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.WriteLine("                           E R R O R");
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.WriteLine("PLEASE SELECT A VALID ANSWER");
                                Console.WriteLine("TRY AGAIN LATER");

                            }

                        }
                        else if (choiceSelected.Equals("N"))
                        {
                            Console.WriteLine("                    *** P R O C E S S I N G ***");
                            Console.WriteLine("PAYROLL PROCESSING TERMINATED");
                        }
                        else
                        {
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine("                           E R R O R");
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine("PLEASE SELECT A VALID ANSWER");
                            Console.WriteLine("TRY AGAIN LATER");
                        }
                    }

                    else
                    {
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("                           E R R O R");
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("EMPLOYEE ID DOES NOT EXIST");
                        Console.WriteLine("PLEASE TRY AGAIN LATER");
                    }
                }


                /*------------------------------------------------------------------------------------------------------------------*/

                else if (loginAttempts == 5)
                {
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                           E R R O R");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("YOU HAVE REACHED THE MAXIMUM NUMBER OR RETRIES POSSIBLE");
                    Console.WriteLine("PLEASE TRY AGAIN LATER");
                }

            }

            else if (adminPasswordInput.Equals(adminPassword))
            {
                do
                {
                    Console.WriteLine("  *** I N V A L I D   U S E R N A M E ***");
                    Console.WriteLine("PLEASE ENTER A VALID USERNAME");

                    Console.Write("Username: ");
                    adminUsernameInput = Console.ReadLine();

                    Console.Write("Password: ");
                    adminPasswordInput = Console.ReadLine();

                    Console.WriteLine("");


                    loginAttempts++;
                } while (!adminUsernameInput.Equals(adminUsername) && loginAttempts != 5);
                /*------------------------------------------------------------------------------------------------------------------*/
                if (adminUsernameInput.Equals(adminUsername))
                {
                    Console.WriteLine("     *** P R O C E S S I N G   L O G   I N   D E T A I L S ***");
                    Console.WriteLine("LOG IN COMPLETE");
                    Console.WriteLine("");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                    P A Y R O L L   S Y S T E M");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.Write("Employee ID: ");
                    employeeID = Console.ReadLine().ToUpper();

                    if (employeeID.Equals("AD1234"))
                    {
                        Console.WriteLine("Employee Name   :   " + employeeName);
                        Console.WriteLine("Department      :   " + employeeDepartment);
                        Console.WriteLine("Position        :   " + employeePosition);
                        Console.WriteLine("Rate per Day    :   " + ratePerDay);
                        Console.WriteLine("Rate per OT     :   " + ratePerOT);
                        Console.WriteLine("Status          :   " + employeeStatus);

                        Console.WriteLine("");
                        Console.WriteLine("DO YOU WANT TO PROCEED WITH THE PAYROLL?");
                        Console.WriteLine("              Y - YES                   N - NO");
                        choiceSelected = Console.ReadLine().ToUpper();
                        Console.WriteLine("");

                        if (choiceSelected.Equals("Y"))
                        {
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine("                 C R E A T I N G   P A Y R O L L");
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.Write("Pay Type (Monthly or Bi-Monthly): ");
                            payType = Console.ReadLine();

                            if (payType.Equals("monthly") || payType.Equals("Monthly"))
                            {
                                Console.Write("Total Days Present: ");
                                workDays = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Total Hours Worked: ");
                                workHours = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Total Over Time Hours Worked: ");
                                workOT = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Bonus: ");
                                salaryBonus = Convert.ToInt32(Console.ReadLine());

                                int salaryperHour = workHours * hourlyRate;
                                int salaryperOT = workOT * otRate;
                                grossIncome = salaryperHour + salaryperOT + salaryBonus;

                                Console.WriteLine(" ");
                                Console.WriteLine("Gross Income: " + grossIncome);
                                Console.WriteLine("");

                                Console.WriteLine("                   *** D E D U C T I O N S ***");
                                Console.Write("Tax: ");
                                deductionTax = Convert.ToInt32(Console.ReadLine());
                                Console.Write("SSS: ");
                                deductionSSS = Convert.ToInt32(Console.ReadLine());
                                Console.Write("PhilHealth: ");
                                deductionPhilHealth = Convert.ToInt32(Console.ReadLine());
                                Console.Write("PagIbig: ");
                                deductionPagIbig = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Cash Advance: ");
                                deductionCashAdvance = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Salary Loan: ");
                                deductionSalaryLoan = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Pagibig Loan: ");
                                deductionPagIbigLoan = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Others: ");
                                deductionOthers = Convert.ToInt32(Console.ReadLine());

                                int allDeductions = deductionTax + deductionSSS + deductionSalaryLoan + deductionPhilHealth + deductionPagIbigLoan + deductionPagIbig + deductionOthers + deductionCashAdvance;
                                netIncome = grossIncome - allDeductions;

                                Console.WriteLine("");
                                Console.WriteLine("Net Income: " + netIncome);
                                Console.WriteLine("");

                                Console.WriteLine("DO YOU WANT TO PROCESS PAYROLL?");
                                Console.WriteLine("              Y - YES                   N - NO");
                                answerSelected = Console.ReadLine().ToUpper();
                                Console.WriteLine();

                                if (answerSelected.Equals("Y"))
                                {
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("                 P R O C E S S I N G   P A Y R O L L");
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("PAYROLL PROCESSING COMPLETE");
                                    Console.WriteLine("");
                                    Console.WriteLine("            V - TO VIEW PAYROLL DETAILS     E - EXIT");
                                    optionSelected = Console.ReadLine().ToUpper();

                                    if (optionSelected.Equals("V"))
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("              *** E M P L O Y E E   D E T A I L S ***");
                                        Console.WriteLine("Employee ID ----------------------- " + employeeID);
                                        Console.WriteLine("Employee Name --------------------- " + employeeName);
                                        Console.WriteLine("Department ------------------------ " + employeeDepartment);
                                        Console.WriteLine("Position -------------------------- " + employeePosition);
                                        Console.WriteLine("Rate per Day ---------------------- " + ratePerDay);
                                        Console.WriteLine("Rate per OT ----------------------- " + ratePerOT);
                                        Console.WriteLine("Status ---------------------------- " + employeeStatus);
                                        Console.WriteLine("");

                                        Console.WriteLine("                 *** I N C O M E   D E T A I L S ***");
                                        Console.WriteLine("Pay Type -------------------------- " + payType);
                                        Console.WriteLine("Total Days Present ---------------- " + workDays);
                                        Console.WriteLine("Total Hours Worked ---------------- " + workHours);
                                        Console.WriteLine("Total Over Time Hours Worked ------ " + workOT);
                                        Console.WriteLine("Bonus ----------------------------- " + salaryBonus);
                                        Console.WriteLine("Gross Income ---------------------- " + grossIncome);
                                        Console.WriteLine("");

                                        Console.WriteLine("             *** D E D U C T I O N   D E T A I L S ***");
                                        Console.WriteLine("Tax ------------------------------- " + deductionTax);
                                        Console.WriteLine("SSS ------------------------------- " + deductionSSS);
                                        Console.WriteLine("PhilHealth ------------------------ " + deductionPhilHealth);
                                        Console.WriteLine("PagIbig --------------------------- " + deductionPagIbig);
                                        Console.WriteLine("Cash Advance ---------------------- " + deductionCashAdvance);
                                        Console.WriteLine("Salary Loan ----------------------- " + deductionSalaryLoan);
                                        Console.WriteLine("PagIbig Loan ---------------------- " + deductionPagIbigLoan);
                                        Console.WriteLine("Others ---------------------------- " + deductionOthers);
                                        Console.WriteLine("");

                                        Console.WriteLine("Net Income ------------------------ " + netIncome);

                                    }
                                    else if (optionSelected.Equals("E"))
                                    {
                                        Console.WriteLine("                     *** P R O C E S S I N G ***");
                                        Console.WriteLine("EXITING PAYROLL SYSTEM");
                                    }

                                    else
                                    {
                                        Console.WriteLine("-------------------------------------------------------------------");
                                        Console.WriteLine("                        E R R O R");
                                        Console.WriteLine("-------------------------------------------------------------------");
                                        Console.WriteLine("PLEASE SELECT A VALID ANSWER");
                                        Console.WriteLine("TRY AGAIN LATER");
                                    }

                                }
                                else if (answerSelected.Equals("N"))
                                {
                                    Console.WriteLine("                    *** P R O C E S S I N G ***");
                                    Console.WriteLine("PAYROLL PROCESSING TERMINATED");
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("                           E R R O R");
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("PLEASE SELECT A VALID ANSWER");
                                    Console.WriteLine("TRY AGAIN LATER");
                                }
                            }

                            else if (payType.Equals("bi-monthly") || payType.Equals("Bi-monthly") || payType.Equals("Bi-Monthly") || payType.Equals("bi-Monthly"))
                            {

                                Console.Write("Total Days Present: ");
                                workDays = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Total Hours Worked: ");
                                workHours = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Total Over Time Hours Worked: ");
                                workOT = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Bonus: ");
                                salaryBonus = Convert.ToInt32(Console.ReadLine());

                                int salaryperHour = workHours * hourlyRate;
                                int salaryperOT = workOT * otRate;
                                grossIncome = salaryperHour + salaryperOT + salaryBonus;

                                Console.WriteLine(" ");
                                Console.WriteLine("Gross Income: " + grossIncome);
                                Console.WriteLine("");

                                Console.WriteLine("                   *** D E D U C T I O N S ***");
                                Console.Write("Tax: ");
                                deductionTax = Convert.ToInt32(Console.ReadLine());
                                Console.Write("SSS: ");
                                deductionSSS = Convert.ToInt32(Console.ReadLine());
                                Console.Write("PhilHealth: ");
                                deductionPhilHealth = Convert.ToInt32(Console.ReadLine());
                                Console.Write("PagIbig: ");
                                deductionPagIbig = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Cash Advance: ");
                                deductionCashAdvance = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Salary Loan: ");
                                deductionSalaryLoan = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Pagibig Loan: ");
                                deductionPagIbigLoan = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Others: ");
                                deductionOthers = Convert.ToInt32(Console.ReadLine());

                                int allDeductions = deductionTax + deductionSSS + deductionSalaryLoan + deductionPhilHealth + deductionPagIbigLoan + deductionPagIbig + deductionOthers + deductionCashAdvance;
                                netIncome = grossIncome - allDeductions;

                                Console.WriteLine("");
                                Console.WriteLine("Net Income: " + netIncome);
                                Console.WriteLine("");

                                Console.WriteLine("DO YOU WANT TO PROCESS PAYROLL?");
                                Console.WriteLine("              Y - YES                   N - NO");
                                answerSelected = Console.ReadLine().ToUpper();
                                Console.WriteLine();

                                if (answerSelected.Equals("Y"))
                                {
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("                 P R O C E S S I N G   P A Y R O L L");
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("PAYROLL PROCESSING COMPLETE");
                                    Console.WriteLine("");
                                    Console.WriteLine("            V - TO VIEW PAYROLL DETAILS     E - EXIT");
                                    optionSelected = Console.ReadLine().ToUpper();

                                    if (optionSelected.Equals("V"))
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("              *** E M P L O Y E E   D E T A I L S ***");
                                        Console.WriteLine("Employee ID ----------------------- " + employeeID);
                                        Console.WriteLine("Employee Name --------------------- " + employeeName);
                                        Console.WriteLine("Department ------------------------ " + employeeDepartment);
                                        Console.WriteLine("Position -------------------------- " + employeePosition);
                                        Console.WriteLine("Rate per Day ---------------------- " + ratePerDay);
                                        Console.WriteLine("Rate per OT ----------------------- " + ratePerOT);
                                        Console.WriteLine("Status ---------------------------- " + employeeStatus);
                                        Console.WriteLine("");

                                        Console.WriteLine("                *** I N C O M E   D E T A I L S ***");
                                        Console.WriteLine("Pay Type -------------------------- " + payType);
                                        Console.WriteLine("Total Days Present ---------------- " + workDays);
                                        Console.WriteLine("Total Hours Worked ---------------- " + workHours);
                                        Console.WriteLine("Total Over Time Hours Worked ------ " + workOT);
                                        Console.WriteLine("Bonus ----------------------------- " + salaryBonus);
                                        Console.WriteLine("Gross Income ---------------------- " + grossIncome);
                                        Console.WriteLine("");

                                        Console.WriteLine("             *** D E D U C T I O N   D E T A I L S ***");
                                        Console.WriteLine("Tax ------------------------------- " + deductionTax);
                                        Console.WriteLine("SSS ------------------------------- " + deductionSSS);
                                        Console.WriteLine("PhilHealth ------------------------ " + deductionPhilHealth);
                                        Console.WriteLine("PagIbig --------------------------- " + deductionPagIbig);
                                        Console.WriteLine("Cash Advance ---------------------- " + deductionCashAdvance);
                                        Console.WriteLine("Salary Loan ----------------------- " + deductionSalaryLoan);
                                        Console.WriteLine("PagIbig Loan ---------------------- " + deductionPagIbigLoan);
                                        Console.WriteLine("Others ---------------------------- " + deductionOthers);
                                        Console.WriteLine("");

                                        Console.WriteLine("Net Income ------------------------ " + netIncome);

                                    }
                                    else if (optionSelected.Equals("E"))
                                    {
                                        Console.WriteLine("                    *** P R O C E S S I N G ***");
                                        Console.WriteLine("PAYROLL PROCESSING TERMINATED");
                                    }

                                    else
                                    {
                                        Console.WriteLine("-------------------------------------------------------------------");
                                        Console.WriteLine("                           E R R O R");
                                        Console.WriteLine("-------------------------------------------------------------------");
                                        Console.WriteLine("PLEASE SELECT A VALID ANSWER");
                                        Console.WriteLine("TRY AGAIN LATER");
                                    }

                                }
                                else if (answerSelected.Equals("N"))
                                {
                                    Console.WriteLine("                    *** P R O C E S S I N G ***");
                                    Console.WriteLine("PAYROLL PROCESSING TERMINATED");
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("                           E R R O R");
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("PLEASE SELECT A VALID ANSWER");
                                    Console.WriteLine("TRY AGAIN LATER");
                                }

                            }

                            else
                            {

                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.WriteLine("                           E R R O R");
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.WriteLine("PLEASE SELECT A VALID ANSWER");
                                Console.WriteLine("TRY AGAIN LATER");

                            }

                        }
                        else if (choiceSelected.Equals("N"))
                        {
                            Console.WriteLine("                    *** P R O C E S S I N G ***");
                            Console.WriteLine("PAYROLL PROCESSING TERMINATED");
                        }
                        else
                        {
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine("                           E R R O R");
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine("PLEASE SELECT A VALID ANSWER");
                            Console.WriteLine("TRY AGAIN LATER");
                        }
                    }

                    else
                    {
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("                           E R R O R");
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("EMPLOYEE ID DOES NOT EXIST");
                        Console.WriteLine("PLEASE TRY AGAIN LATER");
                    }
                }
                else if (loginAttempts == 5)
                {
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                           E R R O R");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("YOU HAVE REACHED THE MAXIMUM NUMBER OR RETRIES POSSIBLE");
                    Console.WriteLine("PLEASE TRY AGAIN LATER");
                }
            }

            else if (loginAttempts == 5)
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("                           E R R O R");
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("YOU HAVE REACHED THE MAXIMUM NUMBER OR RETRIES POSSIBLE");
                Console.WriteLine("PLEASE TRY AGAIN LATER");
            }



        
        }
    }
}

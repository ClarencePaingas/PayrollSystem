using System;
using System.Collections.Generic;
using System.Text;

namespace PS.BL
{
    public class EMPLOYEE
    {

        public static List<string> EmployeeNames = new List<string>()
        {

            "Mary Paingas",
            "Clarence Martin",
            "Dolores Lobrigo"

        };

        public static void ViewEMployeeName()
        {
            foreach (var name in EmployeeNames)
            {
                Console.WriteLine($"\t{name}");
            }

            //Console.WriteLine("name: " + EmployeeNames[0]);
        }

        public static List<string> Employee1Profile = new List<string>()
        {
            "Assistant Manager",
            "Marketing",
            "Executive",
            "2019, 08, 04",
            "Active",
            "Full Time"
        };

        public static List<string> Employee2Profile = new List<string>()
        {
            "Department Head",
            "IT Support",
            "Executive",
            "2015, 07, 17",
            "Active",
            "Full Time"
        };

        public static List<string> Employee3Profile = new List<string>()
        {
            "Consultant",
            "Finance Department",
            "Executive",
            "2018, 11, 27",
            "Active",
            "Full Time"
        };
        
        public static List<string> Employee1Attendance = new List<string>()
        {
            "    2020-06-30              07:59 AM            04:50 PM",
            "    2020-06-29              07:30 AM            04:54 PM",
            "    2020-06-28              07:35 AM            04:57 PM",
            "    2020-06-26              07:57 AM            04:56 PM",
            "    2020-06-25              07:27 AM            04:55 PM",
            "    2020-06-24              07:46 AM            04:51 PM",
            "    2020-06-23              07:47 AM            04:52 PM",
            "    2020-06-22              07:34 AM            04:53 PM",  
            "    2020-06-21              07:41 AM            04:54 PM",
            "    2020-06-19              07:23 AM            04:56 PM",
            "    2020-06-18              07:34 AM            04:57 PM",
            "    2020-06-17              07:55 AM            04:58 PM",
            "    2020-06-16              07:44 AM            04:59 PM",
            "    2020-06-15              07:33 AM            05:00 PM",
            "    2020-06-14              07:22 AM            04:40 PM",
            "    2020-06-12              07:00 AM            04:56 PM",
            "    2020-06-11              07:11 AM            04:50 PM",
            "    2020-06-10              07:22 AM            04:59 PM",
            "    2020-06-09              07:33 AM            04:58 PM",
            "    2020-06-08              07:44 AM            04:57 PM",
            "    2020-06-07              07:55 AM            04:56 PM",
            "    2020-06-05              07:50 AM            04:54 PM",
            "    2020-06-04              07:45 AM            04:53 PM",
            "    2020-06-03              07:40 AM            04:52 PM",
            "    2020-06-02              07:35 AM            04:51 PM",
            "    2020-06-01              07:30 AM            04:50 PM",
        };

        public static List<string> Employee2Attendance = new List<string>()
        {
            "    2020-06-30              07:59 AM            04:50 PM",
            "    2020-06-29              07:30 AM            04:54 PM",
            "    2020-06-24              07:46 AM            04:51 PM",
            "    2020-06-23              07:47 AM            04:52 PM",
            "    2020-06-22              07:34 AM            04:53 PM",
            "    2020-06-21              07:41 AM            04:54 PM",
            "    2020-06-18              07:34 AM            04:57 PM",
            "    2020-06-17              07:55 AM            04:58 PM",
            "    2020-06-16              07:44 AM            04:59 PM",
            "    2020-06-15              07:33 AM            05:00 PM",
            "    2020-06-11              07:11 AM            04:50 PM",
            "    2020-06-10              07:22 AM            04:59 PM",
            "    2020-06-09              07:33 AM            04:58 PM",
            "    2020-06-08              07:44 AM            04:57 PM",
            "    2020-06-07              07:55 AM            04:56 PM",
            "    2020-06-04              07:45 AM            04:53 PM",
            "    2020-06-03              07:40 AM            04:52 PM",
        };

        public static List<string> Employee3Attendance = new List<string>()
        {
            "    2020-06-30              07:59 AM            04:50 PM",
            "    2020-06-29              07:30 AM            04:54 PM",
            "    2020-06-28              07:35 AM            04:57 PM",
            "    2020-06-25              07:27 AM            04:55 PM",
            "    2020-06-24              07:46 AM            04:51 PM",
            "    2020-06-23              07:47 AM            04:52 PM",
            "    2020-06-22              07:34 AM            04:53 PM",
            "    2020-06-21              07:41 AM            04:54 PM",
            "    2020-06-18              07:34 AM            04:57 PM",
            "    2020-06-17              07:55 AM            04:58 PM",
            "    2020-06-16              07:44 AM            04:59 PM",
            "    2020-06-15              07:33 AM            05:00 PM",
            "    2020-06-14              07:22 AM            04:40 PM",
            "    2020-06-11              07:11 AM            04:50 PM",
            "    2020-06-10              07:22 AM            04:59 PM",
            "    2020-06-09              07:33 AM            04:58 PM",
            "    2020-06-08              07:44 AM            04:57 PM",
            "    2020-06-07              07:55 AM            04:56 PM",
            "    2020-06-04              07:45 AM            04:53 PM",
            "    2020-06-03              07:40 AM            04:52 PM",
            "    2020-06-02              07:35 AM            04:51 PM",
            "    2020-06-01              07:30 AM            04:50 PM"
        };

        public static void ViewEmployee1Attendance()
        {
            foreach (var day in Employee1Attendance)
            {
                Console.WriteLine(day);
            }
        }

        public static void ViewEmployee2Attendance()
        {
            foreach (var day in Employee2Attendance)
            {
                Console.WriteLine(day);
            }
        }

        public static void ViewEmployee3Attendance()
        {
            foreach (var day in Employee3Attendance)
            {
                Console.WriteLine(day);
            }
        }

        public static int TotalDaysWorkedOTE1
        {
            get { return GetTotalDaysWorkedOTE1(); }
        }
        private static int GetTotalDaysWorkedOTE1()
        {
            var total = 0;
            if (Employee1Attendance.Count >= SALARY.StandardWorkingDays)
            {
                total = Employee1Attendance.Count - SALARY.StandardWorkingDays;
            }

            else
            {
                return total;
            }

            return total;
        }

        public static int TotalDaysWorkedOTE2
        {
            get { return GetTotalDaysWorkedOTE2(); }
        }
        private static int GetTotalDaysWorkedOTE2()
        {
            var total = 0;
            if (Employee2Attendance.Count >= SALARY.StandardWorkingDays)
            {
                total = Employee2Attendance.Count - SALARY.StandardWorkingDays;
            }

            else
            {
                return total;
            }

            return total;
        }

        public static int TotalDaysWorkedOTE3
        {
            get { return GetTotalDaysWorkedOTE3(); }
        }
        private static int GetTotalDaysWorkedOTE3()
        {
            var total = 0;
            if (Employee3Attendance.Count >= SALARY.StandardWorkingDays)
            {
                total = Employee3Attendance.Count - SALARY.StandardWorkingDays;
            }

            else
            {
                return total;
            }

            return total;
        }
    }
}


//EDUCATION

//2019-2021           College
//                    Expected to graduate in 2023
//                    Bachelor of Science in Information Technology
//                    Polytechnic University of the Philippines
//                    Binan Laguna

//2017-2019           Senior High School
//                    Science, Technology, Engineering, and Mathematics (STEM) Strand
//                    Bulalacao National High School
//                    Bulalacao Oriental Mindoro

//2013-2017           Junior High School
//                    Bulalacao National High School
//                    Bulalacao Oriental Mindoro

//2013-2017           Elementary
//                    Bulalacao Central School
//                    Bulalacao Oriental Mindoro
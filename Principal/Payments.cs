using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Payroll
{
    internal class Payments
    {
        Employee myEmployee = new Employee();
        public void CalculatePayroll()
        {
            try
            {
                Console.WriteLine("Enter ID of the employee");
                myEmployee.DocumentD1 = Console.ReadLine();
                Console.WriteLine("Enter name of the employee");
                myEmployee.Names1 = Console.ReadLine();
                Console.WriteLine("Enter last name of the employee");
                myEmployee.Last_Name1 = Console.ReadLine();
                Console.WriteLine("Enter the salary of the employee");
                myEmployee.Salary1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter days worked of the employee ");
                myEmployee.Days_Worked1 = double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid data.\nEnter numeric value", e);
                Console.ReadKey();
            }

            myEmployee.TotalAccrued1 = myEmployee.Salary1 / 30;
            myEmployee.TotalAccrued1 = myEmployee.TotalAccrued1 * myEmployee.Days_Worked1;


            myEmployee.AuxTransport1 = 117172 / 30;
            myEmployee.AuxTransport1 = myEmployee.AuxTransport1 * myEmployee.Days_Worked1;

            myEmployee.Health1 = myEmployee.TotalAccrued1 * 0.04;
            myEmployee.Pensions1 = myEmployee.TotalAccrued1 * 0.04;

            if (myEmployee.Salary1 <= 2000000)
            {
                myEmployee.TotalAccrued1 = myEmployee.TotalAccrued1 + myEmployee.AuxTransport1;
            }
            else
            {
                myEmployee.TotalAccrued1 = myEmployee.TotalAccrued1;
            }

            myEmployee.TotalSalary1 = myEmployee.TotalAccrued1 - myEmployee.Health1 - myEmployee.Pensions1;

        }
        public void PrintData()
        {
            Console.WriteLine($"Number of ID: {myEmployee.DocumentD1} ");
            Console.WriteLine($"Name: {myEmployee.Names1}");
            Console.WriteLine($"Last_Name: {myEmployee.Last_Name1}");
            Console.WriteLine($"Salary: {myEmployee.Salary1}");
            Console.WriteLine($"Days worked: {myEmployee.Days_Worked1}");
            Console.WriteLine($"Total accrued: {myEmployee.TotalAccrued1}");
            Console.WriteLine($"Pay health: {myEmployee.Health1}");
            Console.WriteLine($"Pay Pensions: {myEmployee.Pensions1}");
            Console.WriteLine($"Total pay:  {myEmployee.TotalSalary1}");

        }
        public void FileData()

        {



            StreamWriter File = new StreamWriter("C:\\Payroll.txt", true);

            File.WriteLine($"\nNew Employee");
            File.WriteLine($"Document: {myEmployee.DocumentD1}");
            File.WriteLine($"Name: {myEmployee.Names1}");
            File.WriteLine($"Last Name: {myEmployee.Last_Name1}");
            File.WriteLine("The salary is: " + myEmployee.Salary1);
            File.WriteLine($"Worked days: {myEmployee.Days_Worked1}");
            if (myEmployee.Salary1 <= 2000000)
            {
                File.WriteLine($"The Transport subsidy is : {myEmployee.AuxTransport1}");
            }
            File.WriteLine("The Total Accrued is:  " + myEmployee.Salary1);
            File.WriteLine("The Health discount is: " + myEmployee.Health1);
            File.WriteLine("The Pension discount is: " + myEmployee.Pensions1);
            File.WriteLine("The total pay is: " + myEmployee.TotalSalary1);

            File.Close();
        }
    }
}

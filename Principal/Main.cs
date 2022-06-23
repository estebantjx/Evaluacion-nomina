using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Payroll
{
    internal class Principal
    {

        public static void Main(string[] args)
        {
            Payments invoice = new Payments();
            Console.WriteLine("Welcome to the program payroll");
            Console.WriteLine("1. If you decide agree the employee");
            Console.WriteLine("2. Exit to the program ");
            int opc = int.Parse(Console.ReadLine());
            int Opc1 = 1;
            switch (opc)
            {
                case 1:
                    do
                    {

                        invoice.CalculatePayroll();
                        invoice.PrintData();
                        Console.WriteLine("1 If you decide agree the employee");
                        Console.WriteLine("2 Exit the program");

                        Opc1 = int.Parse(Console.ReadLine());


                        Console.WriteLine("Invalid data");



                        Console.Clear();
                    } while (Opc1 != 2);
                    break;
                case 2:
                    Console.WriteLine("Exit to the program");
                    break;
                default:
                    Console.WriteLine("Invalid opcion, please write another opcion");
                    break;
            }

        }
    }
}
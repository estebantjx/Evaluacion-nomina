
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Payroll
{
    internal class Employee
    {
        private string DocumentID;
        private string Names;
        private string Last_Name;
        private double Salary;
        private double Days_Worked;
        private double TotalAccrued;
        private double AuxTransport;
        private double Health;
        private double Pensions;
        private double TotalSalary;
        public Employee()
        {

        }

        public string DocumentD1 { get => DocumentID; set => DocumentID = value; }
        public string Names1 { get => Names; set => Names = value; }
        public string Last_Name1 { get => Last_Name; set => Last_Name = value; }
        public double Salary1 { get => Salary; set => Salary = value; }
        public double Days_Worked1 { get => Days_Worked; set => Days_Worked = value; }
        public double TotalAccrued1 { get => TotalAccrued; set => TotalAccrued = value; }
        public double AuxTransport1 { get => AuxTransport; set => AuxTransport = value; }
        public double Health1 { get => Health; set => Health = value; }
        public double Pensions1 { get => Pensions; set => Pensions = value; }
        public double TotalSalary1 { get => TotalSalary; set => TotalSalary = value; }
    }
}

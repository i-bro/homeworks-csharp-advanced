using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.model
{
    public class Programmer : Employee
    {
        public double MonthlyRate {get; set;}
        public double TechAllowance {get; set;}

        public Programmer(string name, int id, double monthlyRate, double techAllowance): base(name, id)
        {
            MonthlyRate = monthlyRate;
            TechAllowance = techAllowance;
        }
        public override double CalculateSalary()
        {
            return MonthlyRate + TechAllowance;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Programmer] ID: {Id} | Name: {Name}");
            Console.WriteLine($"Total Compensation: ${CalculateSalary()} (Includes ${TechAllowance} tech allowance)");
    }
    }
}

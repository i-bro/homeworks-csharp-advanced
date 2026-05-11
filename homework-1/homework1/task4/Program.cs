// See https://aka.ms/new-console-template for more information
using task4.model;

Console.WriteLine("Hello, World!");
List<Employee> team = new List<Employee>
 {
   new Manager("Alice Johnson", 101, 8000, 1500),
   new Programmer("Bob Smith", 102, 6000, 500)
};

Console.WriteLine("--- Employee Payroll Report ---");
foreach (var employee in team)
{
    employee.DisplayInfo();
    Console.WriteLine("-------------------------------");
}
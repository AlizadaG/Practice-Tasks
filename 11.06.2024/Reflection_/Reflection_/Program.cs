using Reflection_.Models;

namespace Reflection_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee h1 = new HourlyEmployee()
            {
                Name = "Gozal",
                Surname = "Alizada",
                Age = 5,
                HourlyRate = 5.5,
                HoursWorked = 8
            };
            HourlyEmployee h2 = new HourlyEmployee()
            {
                Name = "Gozal",
                Surname = "Alizada",
                Age = 5,
                HourlyRate = 6.4,
                HoursWorked = 16
            };

            SalariedEmployee s1 = new SalariedEmployee()
            {
                Name = "Shabnam",
                Surname = "Sadikhzada",
                Age = 5,
                MonthlySalary = 500
            };

            Console.WriteLine("Saatlik calisan salary: " + h1.CalculateSalary());
            h1.DisplayDetails();
            Console.WriteLine("Saatlik calisan salary: " + h2.CalculateSalary());
            h2.DisplayDetails();
            Console.WriteLine("Maasli calisan salary: " + s1.CalculateSalary());
            s1.DisplayDetails();
        }
    }
}

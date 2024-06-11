using System.Reflection;

namespace Reflection_.Models
{
    public class HourlyEmployee : IEmployee
    {
        private static int _id = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }
        public HourlyEmployee()
        {
            Id = _id;
            _id++;
        }
        public double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
        public void DisplayDetails()
        {
            if (this.GetType().GetInterface("IEmployee") != null)
            {
                PropertyInfo[] properties = (this).GetType().GetProperties();
                int propertyLength = properties
                    .Select(p => p.Name)
                    .OrderByDescending(name => name.Length)
                    .FirstOrDefault()
                    .Length;

                foreach (PropertyInfo property in properties)
                {
                    Console.WriteLine($"{property.Name.PadRight(propertyLength + 10)}: {property.GetValue(this)}");
                }
                Console.WriteLine(new String('-', 30));
            }
        }
    }
}

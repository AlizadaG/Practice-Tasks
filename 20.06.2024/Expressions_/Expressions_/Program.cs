
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using Expressions_.Models;

namespace Expressions_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string mail = $"{}.{lastName.ToUpper().Replace("A", "E")}@{domain}".Replace("?", "").Replace("+", "");
            //Console.WriteLine(mail);

            var employees = new List<Employees> {
                new Employees{ FirstName = "nancy",    LastName="Davo@lio",   Age = 16 },
                new Employees{ FirstName = "a-ndrew",   LastName="Fuller",    Age = 12 },
                new Employees{ FirstName = "Janet",    LastName="Leverling", Age = 61 },
                new Employees{ FirstName = "Margaret", LastName="Peacock",   Age = 87 },
                new Employees{ FirstName = "Steven",   LastName="Buchanan",  Age = 69 },
                new Employees{ FirstName = "Michael",  LastName="Suyama",    Age = 61 },
                new Employees{ FirstName = "Robert",   LastName="King",      Age = 64 },
                new Employees{ FirstName = "Laura",    LastName="Callahan",  Age = 66 },
                new Employees{ FirstName = "Anne",     LastName="Dodsworth", Age = 58 },
            };

            Expression<Func<string, string>> deleteSpecialCharacters = s => s.ToLower().Replace(" ", "").Replace("-", "").Replace("'", "").Replace("!", "").Replace("&", "").Replace("@", "");
            Expression<Func<string, string>> firstName = s => System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(deleteSpecialCharacters.Compile()(s));
            Expression<Func<Employees, string>> email = str => firstName.Compile()(str.FirstName) + deleteSpecialCharacters.Compile()(str.LastName) + "@hotmail.com";

            var retVal = employees
                .AsQueryable()
                .Select(x => new
                {
                    FirstName = firstName.Compile()(x.FirstName),
                    LastName = deleteSpecialCharacters.Compile()(x.LastName),
                    Email = email.Compile()(x),
                    x.Age
                }).ToList();

            foreach (var item in retVal)
            {
                Console.WriteLine(item);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_.Models
{
    public class Employee
    {
        private static int _id = 0;
        public Employee()
        {
            Id = _id;
            _id++;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }

}

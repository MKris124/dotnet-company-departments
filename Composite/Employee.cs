using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cegreszlegek1.Composite
{
    public class Employee : IName
    {
        private string Name { get; set; }
        private DateTime StartDate { get; set; }
        public Employee(string name, DateTime startDate)
        {
            Name = name;
            StartDate = startDate;
        }
        public string GetName()
        {
 
            return $"Employee  {Name}";
        }

        public string JustName()
        {
            return Name;
        }
    }
}

using Cegreszlegek1.Composite;
using Cegreszlegek1.Observer.FailedtToAdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cegreszlegek1
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            DateTime date = DateTime.Now;
            
            var e1 = new Employee("David Smith", date);
            var e2 = new Employee("Jennifer Brown", date);
            var e5 = new Employee("Michael Davis", date);
            var e6 = new Employee("Emily Wilson", date);
            Department d = new Department("Product Development", 3);
            List<IName> names1 = new List<IName>();
            names1.Add(e1);
            names1.Add(e2);
            names1.Add(e6);
            names1.Add(e5);
            d.Add(names1);
            var fname = new FailedName(d, names1);

            var e3 = new Employee("Amanda Miller", date);
            var e4 = new Employee("Elizabeth White", date);
           
            var d2 = new Department("Customer Support", 1);
            var d3 = new Department("Marketing and Communications", 2);
            List<IName> names2 = new List<IName>();
            names2.Add(d3);
            names2.Add(e3);
            names2.Add(e4);
            names2.Add(e5);
            
            d2.Add(names2);


            Console.WriteLine(d.GetName());
            Console.WriteLine();
            var fcount = new FailedCount(d2, names2);
            Console.WriteLine(d2.GetName()); 
        }
        
    }
}

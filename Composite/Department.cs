using Cegreszlegek1.Observer;
using Cegreszlegek1.Observer.FailedtToAdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Cegreszlegek1.Composite
{
    public class Department :Subject, IName
    {
        public List<IName> names = new List<IName>();
        public string Name { get; set; }   
        public int maxNumber { get; set; }
        public Department(string name, int maxNumber)
        {
            this.Name = name;
            this.maxNumber = maxNumber;
        }
        public void Add(List<IName> name) 
        {
            
            foreach (var item in name)
            {
                if (names.Count==maxNumber)
                {
                    Notify();
                }
                else
                {
                    names.Add(item);
                  
                }
               
            }
            
        }

        public void Remove(IName name)
        {
            names.Remove(name);            
        }
        public string GetName()
        {
            foreach (var i in names)
            {
                Console.WriteLine(i.GetName()); 
            }
            return $"Department  {Name}";
        }

        public string JustName()
        {
            return Name;
        }
    }
}

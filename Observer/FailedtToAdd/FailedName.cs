using Cegreszlegek1.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cegreszlegek1.Observer.FailedtToAdd
{
    public class FailedName : FailedObs
    {
        public FailedName(Department dep, List<IName> fail) : base(dep,fail)
        {
        }
        public override void Update()
        {
            var list = failed.Except(department.names).ToList();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Akiket nem sikerült hozzáadni: \n{string.Join(", ", list.Select(x => x.JustName()))}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------");
        }
    }
}

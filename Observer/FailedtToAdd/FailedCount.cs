using Cegreszlegek1.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cegreszlegek1.Observer.FailedtToAdd
{
    public class FailedCount : FailedObs
    {
        public FailedCount(Department dep, List<IName> fail) : base(dep,fail)
        {
        }
        public override void Update()
        {
            var list = failed.Except(department.names).ToList();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Amennyien nem fértek bele: {list.Count}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------");
        }
    }
}

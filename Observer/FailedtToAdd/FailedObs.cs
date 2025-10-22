using Cegreszlegek1.Composite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cegreszlegek1.Observer.FailedtToAdd
{
    public class FailedObs : IObserver
    {
        protected readonly Department department;
        public List<IName> failed;
        public FailedObs(Department dep, List<IName> fail)
        {
            department = dep;
            failed = fail;
            dep.Attach(this);
            Update();
        }
        public virtual void Update()
        {

        }
    }
}

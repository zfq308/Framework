using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Executor.Interface
{

    public partial interface IScheduler
    {
        bool Check();
    }

}
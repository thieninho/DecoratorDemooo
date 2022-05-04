using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern_Demo
{
    public class MilkTea : IMilkTea
    {
        public double Cost()
        {
            return 20000d;
        }
    }
}

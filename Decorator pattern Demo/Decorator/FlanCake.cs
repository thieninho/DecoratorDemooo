using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern_Demo.Decorator
{
    public class FlanCake : MilkTeaDecorator
    {
        public FlanCake(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 10000d + base.Cost();
        }
    }
}

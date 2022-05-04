using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern_Demo.Decorator
{
    public class Jelly : MilkTeaDecorator
    {
        public Jelly(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 15000d + base.Cost();
        }
    }
}

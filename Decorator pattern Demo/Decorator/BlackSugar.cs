using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern_Demo.Decorator
{
    public class BlackSugar : MilkTeaDecorator
    {
        public BlackSugar(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 5000d + base.Cost();
        }
    }
}

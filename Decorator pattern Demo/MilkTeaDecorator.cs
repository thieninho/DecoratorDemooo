using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern_Demo
{
    public abstract class MilkTeaDecorator : IMilkTea
    {
        private IMilkTea _milkTea;
        protected MilkTeaDecorator(IMilkTea inner)
        {
            _milkTea = inner;
        }

        public virtual double Cost()
        {
           return _milkTea.Cost();
        }
    }
}

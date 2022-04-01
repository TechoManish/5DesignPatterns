using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class DecoratorAbstractClass : AbstractClass
    {
        protected ConcreteClass1 _concrete;

        protected DecoratorAbstractClass(ConcreteClass1 concrete)
        {
            _concrete = concrete;
        }

        public override int MyMethod()
        {
            return _concrete.MyMethod();
        }
    }
}

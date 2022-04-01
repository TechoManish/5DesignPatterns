using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteDecorator:DecoratorAbstractClass
    {
        public ConcreteDecorator(ConcreteClass1 c)
            :base(c)
        {

        }

        public override int MyMethod()
        {
          int x = base.MyMethod();
            return x + 2;
        }
    }
}

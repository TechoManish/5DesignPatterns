using System;
using Microsoft.Extensions.DependencyInjection;

namespace FactoryPattern
{
    public class FactoryTest
    {
		public void TestFactoryPattern()
		{
			// declare two creators
			Creator creator1 = new ConcreteCreatorA();
			Creator creator2 = new ConcreteCreatorB();

			// create the products
			Product product1 = creator1.FactoryMethod();
			Product product2 = creator2.FactoryMethod();
		}
	}
}

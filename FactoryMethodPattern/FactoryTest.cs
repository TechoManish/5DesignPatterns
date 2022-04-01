using System;

namespace FactoryMethodPattern
{
	/// <summary>
	/// The main program class.
	/// </summary>
	public class FactoryTest
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public  void TestFactoryPattern ()
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

using System;

namespace Patterns.AbstractFactory
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Client
	{
		
		static void Main(string[] args)
		{
            RadiatorFactory factoryOne = new BriscoeRadiatorFactory();
			WorkOrder workOne = new WorkOrder();
			workOne.AssembleRadiator(factoryOne);
		    
			//With the Abstract Factory pattern, The Model T domain can easily
			//switch suppliers. It simply stops calling the Briscoe Radiator
			//factory, and commences calling the Detroit and McCord Radiator 
			//factories, to supply radiators. For each new supplier, respective
			//Radiator, Cap and Factory classes need to be added. Which is a good
			//thing, because shortly after changing from Briscoe, The Model T
			//domain made a further change and begun to fit only Ford radiators.

            RadiatorFactory factoryTwo = new DetroitRadiatorFactory();
			WorkOrder workTwo = new WorkOrder();
			workTwo.AssembleRadiator(factoryTwo);

            RadiatorFactory factoryThree = new McCordRadiatorFactory();
			WorkOrder workThree = new WorkOrder();
			workThree.AssembleRadiator(factoryThree);

		}
		
	}
}

using System;

namespace Patterns.AbstractFactory
{
	/// <summary>
	/// Summary description for WorksOrder.
	/// </summary>
	public class WorkOrder
	{

        public void AssembleRadiator(RadiatorFactory fact)
		{
			Radiator rad = fact.BuildRadiator();
			RadiatorCap cap = fact.BuildRadiatorCap();
			this.Assemble();
		}
		
		private void Assemble()
		{
			Console.WriteLine ("Assembling Radiator and cap.");
			Console.WriteLine();
		}
		
		public WorkOrder(){;}

	}
}

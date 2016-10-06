using System;

namespace Patterns.AbstractFactory
{
	/// <summary>
	/// Summary description for BriscoeRadiatorCap.
	/// </summary>
	public class BriscoeRadiatorCap: RadiatorCap
	{
		
		public override void RadiatorCapBrand()
		{
			Console.WriteLine("Briscoe Radiator cap.");
		}


		public BriscoeRadiatorCap(){;}

	}
}

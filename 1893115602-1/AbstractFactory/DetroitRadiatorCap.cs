using System;

namespace Patterns.AbstractFactory
{
	/// <summary>
	/// Summary description for DetroitRadiatorCap.
	/// </summary>
	public class DetroitRadiatorCap: RadiatorCap
	{
			
		public override void RadiatorCapBrand()
		{
			Console.WriteLine("Detroit Radiator cap.");
		}

		public DetroitRadiatorCap(){;}

	}
}

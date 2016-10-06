using System;

namespace Patterns.AbstractFactory
{
	/// <summary>
	/// Summary description for McCordRadiatorCap.
	/// </summary>
	public class McCordRadiatorCap: RadiatorCap
	{
		
		public override void RadiatorCapBrand()
		{
			Console.WriteLine("McCord Radiator cap.");
		}
		
		public McCordRadiatorCap(){;}
	}
}

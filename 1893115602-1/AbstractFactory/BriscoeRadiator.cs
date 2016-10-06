using System;

namespace Patterns.AbstractFactory
{
	/// <summary>
	/// Summary description for BriscoeRadiator.
	/// </summary>
	public class BriscoeRadiator: Radiator
	{
		
		public override void RadiatorBrand()
		{
			Console.WriteLine ("Briscoe Radiator.");
		}

			
		public BriscoeRadiator(){;}

	}
}

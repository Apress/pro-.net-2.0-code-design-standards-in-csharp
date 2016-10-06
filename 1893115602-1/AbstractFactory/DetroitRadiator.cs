using System;

namespace Patterns.AbstractFactory
{
	/// <summary>
	/// Summary description for DetroitRadiator.
	/// </summary>
	public class DetroitRadiator:Radiator
	{
		
		public override void RadiatorBrand()
		{
			Console.WriteLine ("Detroit Radiator.");
		}
		
		
		public DetroitRadiator(){;}

	}
}

using System;

namespace Patterns.AbstractFactory
{
	/// <summary>
	/// Summary description for McCordRadiator.
	/// </summary>
	public class McCordRadiator: Radiator
	{
		
		public override void RadiatorBrand()
		{
			Console.WriteLine ("McCord Radiator.");
		}
	
		public McCordRadiator() {;}

	}
}

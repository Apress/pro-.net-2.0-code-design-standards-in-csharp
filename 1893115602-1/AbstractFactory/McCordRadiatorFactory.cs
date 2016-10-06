using System;

namespace Patterns.AbstractFactory
{
	/// <summary>
	/// Summary description for McCordRadiatorFactory.
	/// </summary>
    public class McCordRadiatorFactory : RadiatorFactory
	{
		
		public override Radiator BuildRadiator()
		{
			Radiator rad = new  McCordRadiator();
			rad.RadiatorBrand();
			return rad;
		}

		public override RadiatorCap BuildRadiatorCap()
		{
			RadiatorCap cap = new McCordRadiatorCap();
			cap.RadiatorCapBrand();
			return cap;
		}
		
		public McCordRadiatorFactory(){;}

	}
}

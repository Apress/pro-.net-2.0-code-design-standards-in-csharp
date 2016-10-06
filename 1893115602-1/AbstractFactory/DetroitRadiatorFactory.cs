using System;

namespace Patterns.AbstractFactory
{
	/// <summary>
	/// Summary description for DetroitRadiatorFactory.
	/// </summary>
	public class DetroitRadiatorFactory: RadiatorFactory
	{
		
		public override Radiator BuildRadiator()
		{
			Radiator rad = new  DetroitRadiator();
			rad.RadiatorBrand();
			return rad;
		}

		public override RadiatorCap BuildRadiatorCap()
		{
			RadiatorCap cap = new DetroitRadiatorCap();
			cap.RadiatorCapBrand();
			return cap;
		}

		
		public DetroitRadiatorFactory(){;}

	}
}

using System;

namespace Patterns.AbstractFactory
{
	/// <summary>
	/// Summary description for EnginePartsFactory.
	/// </summary>
	public class BriscoeRadiatorFactory: RadiatorFactory
	{
				
		public override Radiator BuildRadiator()
		{
			Radiator rad = new BriscoeRadiator();
			rad.RadiatorBrand();
			return rad;
		}

		public override RadiatorCap BuildRadiatorCap()
		{
			RadiatorCap cap = new BriscoeRadiatorCap();
			cap.RadiatorCapBrand();
			return cap;
		}
				
		public BriscoeRadiatorFactory(){;}

	}
}

using System;

namespace Patterns.AbstractFactory
{
	/// <summary>
	/// Summary description for RadiatorFactory.
	/// </summary>
	public abstract class RadiatorFactory
	{
        public abstract Radiator BuildRadiator();
		public abstract RadiatorCap BuildRadiatorCap();
	}
}

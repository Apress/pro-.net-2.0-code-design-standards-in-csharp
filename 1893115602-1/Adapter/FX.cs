using System;

namespace Patterns.Adapter
{
	
	
	public class FX
	{
		private Adapter adapt;
				
		public string FX_USD_GBP()
		{
      return this.adapt.USD_GBP();
			
		}

		public string FX_USD_CND()
		{

      return this.adapt.USD_CND();
		}

		public string FX_USD_AUD()
		{
      return this.adapt.USD_AUD();
		}
		
		
		
		public FX()
		{
      adapt = new Adapter();
		}
	}
}

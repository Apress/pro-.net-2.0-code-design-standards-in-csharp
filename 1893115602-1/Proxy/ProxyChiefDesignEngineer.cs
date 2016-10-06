using System;

namespace Patterns.ProxySurrogate
{
	/// <summary>
	/// Summary description for ProxyChiefDesignEngineer.
	/// </summary>
	public class ProxyChiefDesignEngineer: IDesignEngineer
	{
		
		private ChiefDesignEngineer chief;

	
		public  string DesignKnowledge()
		{
			return this.chief.DesignKnowledge();
		}
		
				
		public  string StressTestKnowledge()
		{
			return this.chief.StressTestKnowledge();
		}
					
		//The proxy can also be used to save "over-use" of the principal, 
		//by encapsulating a means to handle queries internally.
		public  string MechanicalKnowledge()
		{
			return "A supplement has been added to the mechanical manual.";

		}
				 
		public  string PerformanceKnowledge()
		{
			return "Performance information is in the manual.";

		}
        		
		//constructor - instantiates local copy of ChiefDesignEngineer.
		public ProxyChiefDesignEngineer()
		{
			this.chief = new  ChiefDesignEngineer();
		}

	}
}

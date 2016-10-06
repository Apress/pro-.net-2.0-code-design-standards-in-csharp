using System;

namespace Patterns.ProxySurrogate
{
	/// <summary>
	/// Summary description for ChiefCarDesigner.
	/// </summary>
	
		
	
	public class ChiefDesignEngineer: IDesignEngineer
	{
		
		public  string DesignKnowledge()
		{
			return "The Model T is designed to...";
		}
		
		public  string StressTestKnowledge()
		{
			return "We found in stress-testing, the...";
		}
		
		public  string MechanicalKnowledge()
		{
			return "The mechanical features include...";
			
		}

		public  string PerformanceKnowledge()
		{
			return "The performance characteristics include...";

		}
	
				
		public ChiefDesignEngineer(){;}
	}
}

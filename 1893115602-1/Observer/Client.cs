using System;

namespace Patterns.Observer
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Client
	{
		
		static void Main(string[] args)
		{
			Subject observedAssemblyLine = new Subject();
			Observer observerCarDealer = new Observer("CarDealer Observer");
			Observer observerDelivery = new Observer("Delivery Observer");
			
			observerCarDealer.ObservedObject = observedAssemblyLine;
			observerDelivery.ObservedObject = observedAssemblyLine;

			observerCarDealer.Attach();
			observerDelivery.Attach();
			observedAssemblyLine.InterestingData = "# 001 is now finished!";
			observerCarDealer.Detach();
			observedAssemblyLine.InterestingData = "# 002 is now finished!";

		}
	}
}

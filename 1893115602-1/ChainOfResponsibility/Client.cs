using System;

namespace Patterns.ChainOfResponsibility
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Client
	{
		
		static void Main(string[] args)
		{
			//Build the links 
			Link staff = new StaffLink();
			Link manager = new ManagerLink();
			Link seniorManager = new SeniorManagerLink();
			
			//Assign chain hierarchy
			staff.NextInChain(manager);
			manager.NextInChain(seniorManager);

			//submit four requirements to be dealt with by the chain
			staff.DealWithRequirement("Not For Profit Corporates");
			staff.DealWithRequirement("Commercial Corporates");
			staff.DealWithRequirement("Dealers");
			staff.DealWithRequirement("Government Agency");
					

		}
	}
}

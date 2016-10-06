using System;

namespace Patterns.ChainOfResponsibility
{
	/// <summary>
	/// Summary description for StaffLink.
	/// </summary>
	public class StaffLink: Link
	{
				
		public override void DealWithRequirement(string requirement)
		{
			switch (requirement)
			{
				case "Commercial Corporates":
					Console.WriteLine ("{0} has managed the Commercial Corporate requirement." ,
						this);
					break;
				default:
					if (theNextInChain != null)
						theNextInChain.DealWithRequirement(requirement);
					break;
			}
							
		}

		public StaffLink(){;}
	}
}

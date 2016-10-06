using System;

namespace Patterns.ChainOfResponsibility
{
	/// <summary>
	/// Summary description for ManagerLink.
	/// </summary>
	public class ManagerLink: Link
	{
		
		public override void DealWithRequirement(string requirement)
		{
			switch (requirement)
			{
				case "Dealers":
					Console.WriteLine ("{0} has managed the Dealer requirement." ,
						this);
					break;
				default:
					if (theNextInChain != null)
						theNextInChain.DealWithRequirement(requirement);
					break;
			}
							
		}
		
		public ManagerLink(){;}
	}
}

using System;

namespace Patterns.ChainOfResponsibility
{
	/// <summary>
	/// Summary description for SupervisorLink.
	/// </summary>
	public class SeniorManagerLink: Link
	{
		
		
		public override void DealWithRequirement(string requirement)
		{
			switch (requirement)
			{
				default:
					Console.WriteLine("{0} has managed the " + requirement + " requirement." ,
						this); 
					break;
			}
							
		}
		
		public SeniorManagerLink(){;}
	}
}

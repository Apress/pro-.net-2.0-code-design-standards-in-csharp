using System;

namespace Patterns.ChainOfResponsibility
{
	/// <summary>
	/// Summary description for Link.
	/// </summary>
	public abstract class Link
	{
		
		protected Link theNextInChain;

		public abstract void DealWithRequirement(string requirement);

		public void NextInChain(Link next)
		{
			this.theNextInChain = next;
		}
		
	}
}

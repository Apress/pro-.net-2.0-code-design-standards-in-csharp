using System;

namespace Patterns.Strategy
{
	/// <summary>
	/// Summary description for DealerStrategy.
	/// </summary>
	public class DealerStrategy: Strategy
	{
		
		public override void CreditBusinessRule()
		{
			Console.WriteLine("Dealers: Allow 90 days credit.");
		}
		
		public DealerStrategy(){;}
	}
}

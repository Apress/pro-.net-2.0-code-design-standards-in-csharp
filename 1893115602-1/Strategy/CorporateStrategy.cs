using System;

namespace Patterns.Strategy
{
	/// <summary>
	/// Summary description for CorprateStrategy.
	/// </summary>
	public class CorporateStrategy: Strategy
	{
		
		public override void CreditBusinessRule()
		{
			Console.WriteLine("Corporates: Allow 30 days credit.");
		}

		public CorporateStrategy(){;}
	}
}

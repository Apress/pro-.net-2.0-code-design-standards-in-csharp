using System;

namespace Patterns.Strategy
{
	/// <summary>
	/// Summary description for ContextCreditSales.
	/// </summary>
	public class CreditSalesContext
	{
		Strategy aStrategy;
		
		public CreditSalesContext (Strategy crStrategy)
		{
			this.aStrategy = crStrategy;
		}

		public void BusinessRule()
		{
			this.aStrategy.CreditBusinessRule();
		}

	}
}

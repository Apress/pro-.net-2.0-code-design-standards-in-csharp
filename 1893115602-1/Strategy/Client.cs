using System;

namespace Patterns.Strategy
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Client
	{
		
		static void Main(string[] args)
		{
			//Client makes choice to call the Corporate Strategy - there
			//is an inquiry from a potential corporate customer regarding
			//the credit terms.
			CreditSalesContext cr = new CreditSalesContext(new CorporateStrategy());
			cr.BusinessRule();
		}
	}
}

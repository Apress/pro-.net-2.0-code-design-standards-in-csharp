using System;

namespace Patterns.Strategy
{
	/// <summary>
	/// Summary description for Strategy.
	/// </summary>
	public abstract class Strategy
	{
		
		//abstract method which sub classes will
		//implement to enable access to the strategy functionality
		public abstract void CreditBusinessRule();


		public Strategy(){;}
	}
}

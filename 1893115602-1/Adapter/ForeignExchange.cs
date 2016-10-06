using System;

namespace Patterns.Adapter
{
	/// <summary>
	/// Summary description for ForeignExhange
	/// </summary>
	public sealed class ForeignExchange
	{
							
		public string  UStoUK()
		{
			return "USD to GBP is...";  						
		}

		public string  UStoCND()
		{
			return "USD to CND is...";
		}

		public ForeignExchange(){;}
	}
}

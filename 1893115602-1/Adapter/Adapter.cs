using System;

namespace Patterns.Adapter
{
	/// <summary>
	/// Summary description for Adapter.
	/// </summary>
	public class Adapter
	{
		private ForeignExchange sourceCode;
				
	
		public string USD_GBP ()
		{
      return "Conversion " + this.sourceCode.UStoUK();
            			
		}

		public string  USD_CND()
		{
      return "Conversion " + this.sourceCode.UStoCND();
		}

		public string  USD_AUD()
		{
			return "Conversion USD to AUD is...";
		}

		public string USD_JPY()
		{
			return "Conversion USD to JNY is...";
		}

		public Adapter()
		{
      sourceCode = new ForeignExchange();
		}
	}
}

using System;

namespace Patterns.Adapter
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class Client
	{
		
		static void Main(string[] args)
		{
			FX afx = new FX();
			Console.WriteLine(afx.FX_USD_GBP());
			Console.WriteLine(afx.FX_USD_CND());
			Console.WriteLine(afx.FX_USD_AUD());
		
		}
	}
}

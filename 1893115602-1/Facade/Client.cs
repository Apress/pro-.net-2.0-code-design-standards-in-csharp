using System;

namespace Patterns.Facade
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class Client
	{
		
		[STAThread]
		static void Main(string[] args)
		{
			DealerRepresentative gopher = new DealerRepresentative();
			gopher.GetCarUpdate();

		}
	}
}

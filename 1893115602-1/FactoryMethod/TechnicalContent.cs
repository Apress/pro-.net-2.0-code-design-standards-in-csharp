using System;

namespace Patterns.FactoryMethod
{
	/// <summary>
	/// Summary description for ProductB.
	/// </summary>
	public class TechnicalContent: Content
	{
		
		public override void SomeContent()
		{
			Console.WriteLine("Technical content.");
        }
						
		public TechnicalContent(){;}

	}
}

using System;

namespace Patterns.FactoryMethod
{
	/// <summary>
	/// Summary description for FeaturesPage.
	/// </summary>
	public class FeaturesContent: Content
	{
		
		public override void SomeContent()
		{
			Console.WriteLine("Technical content.");
		}	
				
		public FeaturesContent(){;}
		
	}

}

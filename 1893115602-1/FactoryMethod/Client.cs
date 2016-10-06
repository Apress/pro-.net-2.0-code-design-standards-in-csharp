using System;

namespace Patterns.FactoryMethod
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Client
	{
	
		static void Main(string[] args)
		{
			//1. Compose content on a page of a Catalog
			Page p = new  CatalogPage();
			p.AddContent(); //calling the Factory method
			p.DisplayPage();
	
			//2. Compose content on a page of a Manual
			p = new ManualPage();
			p.AddContent(); //calling the Factory method
			p.DisplayPage();
			
		}

	}
}

using System;

namespace Patterns.FactoryMethod
{
	/// <summary>
	/// Summary description for CreatorA.
	/// </summary>
	public class CatalogPage: Page
	{
		
		//This is the Factory method
		public override void AddContent()
		{
			this.pageCompositor.Clear();
			this.pageCompositor.Add(new FeaturesContent());
			this.pageCompositor.Add(new PictureContent());
		}
		
		//Method to display page content
		public override void DisplayPage()
		{
			Console.WriteLine("Catalog page contains:");
			foreach(Content c in this.pageCompositor)
				c.SomeContent();
			Console.WriteLine();
		}
	

		public CatalogPage()
		{
			this.AddContent();
		}

	}

}

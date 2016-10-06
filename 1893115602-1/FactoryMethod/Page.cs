using System;
using System.Collections;

namespace Patterns.FactoryMethod
{
	/// <summary>
	/// Summary description for Creator.
	/// </summary>
	public abstract class Page
	{
		
		//A page compositor arranges the content on the page
		protected ArrayList pageCompositor = new ArrayList();

		//This is the Factory method
		public abstract void AddContent();
		
		//Method to display page content
		public abstract void DisplayPage();
		
	}

}

using System;

namespace Patterns.FactoryMethod
{
	/// <summary>
	/// Summary description for CreatorB.
	/// </summary>
	public class ManualPage: Page
	{
		
		
		//This is the Factory method
		public override void AddContent()
		{
			this.pageCompositor.Clear();
			this.pageCompositor.Add(new TechnicalContent());
			this.pageCompositor.Add(new PictureContent());
			this.pageCompositor.Add(new InstructionContent());

		}
		
		//Method to display page content
		public override void DisplayPage()
		{
			Console.WriteLine("Manual page contains:");
				foreach(Content c in this.pageCompositor)
					c.SomeContent();
			Console.WriteLine();
		}

		
		public ManualPage(){;}

	}

}

using System;

namespace Patterns.FactoryMethod
{
	/// <summary>
	/// Summary description for InstructionalPage.
	/// </summary>
	public class InstructionContent: Content
	{

		public override void SomeContent()
		{
			Console.WriteLine("Instruction content.");
		}
		
		public InstructionContent(){;}

	}

}

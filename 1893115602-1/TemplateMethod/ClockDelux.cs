using System;

namespace Patterns.TemplateMethod
{
	/// <summary>
	/// Summary description for Clock.
	/// </summary>
	public class ClockDeluxe: Clock
	{
		
		public override void  PositionLabel()
		{Console.WriteLine("Deluxe clock, position the label bottom center.");}
		
		public ClockDeluxe(){;}
		
	}
}

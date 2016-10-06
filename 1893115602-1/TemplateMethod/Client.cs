using System;

namespace Patterns.TemplateMethod
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Client
	{
		
		static void Main(string[] args)
		{
			
			//create an instance of the deluxe clock
			//and setup the clockface
			Console.WriteLine("** A DELUXE CLOCK **");
			Clock delClock = new ClockDeluxe();
			delClock.SetupClockFace();

			//create an instance of the standard clock
			//and setup the clockface
			Console.WriteLine("** A STANDARD CLOCK **");
			Clock stdClock = new ClockStandard();
			stdClock.SetupClockFace();
		
				
		}

	}
}

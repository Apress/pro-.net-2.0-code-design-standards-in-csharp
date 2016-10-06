using System;

namespace Patterns.TemplateMethod
{
	/// <summary>
	/// Summary description for Clock.
	/// </summary>
	public abstract class Clock
	{
			
		// an abstract method that all sub-classes need to code a full
		// implementation of functionality
		public abstract void  PositionLabel();
			
		//the template method
		public void SetupClockFace()
		{
			//step 1. set hands to 7 o'clock - this could be represented 
			//as a method
			Console.WriteLine("Clock hands set at 7 o'clock");
			//step 2. position the label on the clockface
			this.PositionLabel();

		}

		public Clock(){;}
		
	}
}

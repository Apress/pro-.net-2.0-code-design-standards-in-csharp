using System;

namespace Patterns.TemplateMethod
{
	/// <summary>
	/// Summary description for Clock 
	/// </summary>
	public class ClockStandard:Clock
	{
		
		//A Standard clock has no label, so there code that 
		//positions a label is not required
		public override void PositionLabel(){;}
		
		public ClockStandard()	{;}
		
	}
}
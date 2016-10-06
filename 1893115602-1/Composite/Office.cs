using System;
using System.Text;
using System.Collections;

namespace Patterns.Composite
{
	/// <summary>
	/// Summary description for Child.
	/// </summary>
	public class Office: Entity
	{
		
		public override void Add (Entity c)
		{
			Console.WriteLine("Can't use 'Add' in Office!");
		}

		public override void Remove (Entity e)
		{
			Console.WriteLine("Can't use 'Remove' in Office! ");
		}
		
		public override void GetChild (int level)
		{
			
			Console.WriteLine(new string ( '*', level) + this.name);
		}

					
		public Office(string name):  base (name){;}

		
	}
}

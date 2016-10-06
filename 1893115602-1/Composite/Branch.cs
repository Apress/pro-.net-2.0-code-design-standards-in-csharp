using System;
using System.Text;
using System.Collections;

namespace Patterns.Composite
{
	/// <summary>
	/// Summary description for Composite.
	/// </summary>
	public class Branch: Entity
	{
		
		private ArrayList node = new ArrayList();

		public override void Add (Entity e)
		{
      node.Add(e);
		}
		
		public override void Remove (Entity e)
		{
      node.Remove(e);
		}

		public override void GetChild (int level)
		{
			Console.WriteLine(new String ( '#', level) + this.name);
			foreach (Entity e in this.node)
				e.GetChild(level + 1);
		}

	

		public Branch (string name) : base (name){;}		
	}
}

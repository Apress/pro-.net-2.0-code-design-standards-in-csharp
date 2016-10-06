using System;
using System.Text;
using System.Collections;

namespace Patterns.Composite
{
	/// <summary>
	/// Summary description for Component.
	/// </summary>
	public abstract class Entity
	{
		protected string name;
	
	  public abstract void Add(Entity e);
		public abstract void Remove(Entity e);
		public abstract void GetChild(int level);
				
		public Entity(string name)
		{
			this.name = name;
		}
	}
}

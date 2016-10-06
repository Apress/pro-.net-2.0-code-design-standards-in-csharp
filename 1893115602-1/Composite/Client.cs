using System;

namespace Patterns.Composite
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class Client
	{
		
		
		static void Main(string[] args)
		{
			//build a hierarchy from a root
			Branch root = new Branch ("US (Root)");
			
			Office ny = new Office("New York Office (Entity)");
			Office ca = new Office("California Office (Entity)");
			//add an entity, in the same way as a branch
			root.Add(ny);
			root.Add(ca);

			//add a branch to the root, in the same was as an entity 
			Branch rootHawaii = new Branch ("Hawaii Branch (Branch)");
			root.Add(rootHawaii);

			//build and add another branch and add to offices (entities)
			Branch branchUK = new Branch ("UK Branch  (Branch)");
			Office ldnc = new Office("London City Office (Entity)");
			Office ldnw = (new Office("London West Office (Entity)"));
			branchUK.Add(ldnc);
			branchUK.Add(ldnw);
			//add branch to the root
			root.Add(branchUK);

			//we now try to add an dummy office to another office - which is 
			//illogical so we should get a warning message.
			Office dummy = new Office ("Dummy Office - we should not see this!");
			ldnc.Add(dummy);

			//get root level and all branches and offices
			root.GetChild(0); 

			//remove a branch in the same way as a entity 
			root.Remove(rootHawaii);
			//remove a entity in the same way as a branch
			branchUK.Remove(ldnc);
			Console.WriteLine();
			Console.WriteLine("Remove Hawaii branch and London City office");
			Console.WriteLine();
			root.GetChild(0); //get first level
		}
	}
}

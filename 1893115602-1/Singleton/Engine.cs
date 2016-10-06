using System;

namespace Patterns.Singleton
{
	//note: sealed - prevent cloning
	sealed class Engine
	{
		//flag used in constructor: set to false when constructor
		//has not been called then set to true when called first time.
		private static bool instanceFlag = false;

		
		//Uses 'if' to set instanceFlag to truefirst time getEngine()
		//called. Subsequent calls, fail to return an engine as InstanceFlag 
		//been re-set from false to true. 
		public static Engine GetEngine()
		{
			if (!instanceFlag)
			{	
				instanceFlag = true;
				return new Engine();
			}
			else
			{
				throw new Exception("An engine has already been created!");
			}
		}

		private Engine()
		{
			Console.WriteLine("An Engine");
		}

	}
}

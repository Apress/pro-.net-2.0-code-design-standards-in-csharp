using System;

namespace Patterns.ProxySurrogate
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Client
	{
		
		static void Main(string[] args)
		{
						
			//Create a proxy ChiefDesignEngineer
			//to handle Californian State technical queries
			ProxyChiefDesignEngineer caProxyChief = new ProxyChiefDesignEngineer();
			//Setup the console
			Console.WriteLine("*** Answer(s) for CA State ***");
			//Ask a stress-test question of the ProxyChief
			Console.WriteLine(caProxyChief.StressTestKnowledge());
			//Ask a performance question of the ProxyChief
			Console.WriteLine(caProxyChief.PerformanceKnowledge());
				
			//Create a proxy ChiefDesignEngineer
			//to handle NewYork State technical queries
			ProxyChiefDesignEngineer nyProxyChief = new ProxyChiefDesignEngineer();
			//Setup console
			Console.WriteLine();
			Console.WriteLine("*** Answer(s) for NY State ***");
			//Ask a mechnical question of the ProxyChief
			Console.WriteLine(nyProxyChief.MechanicalKnowledge());
		
		}
	}
}

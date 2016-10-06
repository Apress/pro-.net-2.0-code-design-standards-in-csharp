using System;

namespace Patterns.Singleton
{
	
	class Client
	{
			
		static void Main(string[] args)
		{
			// 1st attempt to get an engine
			Console.WriteLine("Attempting to get first engine");
			try
			{
				Engine eng = Engine.GetEngine();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			
			// 2nd attempt to get an engine
			Console.WriteLine("Attempting to get second engine");
			try
			{
				Engine eng = Engine.GetEngine();
				
			}

			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

		}
	}
}

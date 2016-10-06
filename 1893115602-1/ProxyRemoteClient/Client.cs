using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Patterns.ProxyRemoteServer;


namespace Patterns.ProxyRemoteServer
{
	//
	using System;
	using System.Runtime.Remoting;
	using System.Runtime.Remoting.Channels;
	using System.Runtime.Remoting.Channels.Tcp;



		public class Client
		{
		
			static void Main(string[] args)
			{
			
			
				TcpClientChannel channel = new TcpClientChannel ();
				ChannelServices.RegisterChannel (channel);

				RemotingConfiguration.RegisterWellKnownClientType
					(typeof (ProxyChiefDesignEngineer), "tcp://localhost:1234/RemoteProxy"); 

				ProxyChiefDesignEngineer ukProxyChief =  new ProxyChiefDesignEngineer();
		
				Console.WriteLine("*** Answer for UK Dealers from US Chief Design Engineer ***");
				Console.WriteLine("Question: Not on an advanced topic - filtered to Proxy US Chief Design Engineer");
				Console.WriteLine("Answer: " + ukProxyChief.PerformanceKnowledge());
				Console.WriteLine("Question: Was on an advanced topic - answered by the US Chief Design Engineer");
				Console.WriteLine("Answer: " + ukProxyChief.DesignKnowledge());
				Console.WriteLine("Press [Enter] to terminate client.");
				Console.ReadLine();					

			}
		}

	}






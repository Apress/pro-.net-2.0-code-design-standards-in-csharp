using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Patterns.ProxyRemoteServer; 



namespace Patterns.ProxyRemoteServer
{
	/// <summary>
	/// Summary description for Server.
	/// </summary>
	public class Server
	{
		
		static void Main(string[] args)
		{
			
			
			TcpServerChannel channel = new TcpServerChannel (1234);
			ChannelServices.RegisterChannel (channel);

			RemotingConfiguration.RegisterWellKnownServiceType
				(typeof (ProxyChiefDesignEngineer), "RemoteProxy", WellKnownObjectMode.SingleCall); 

			Console.WriteLine ("Press [Enter] to terminate server...");
			Console.ReadLine();
					

		}
	}


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Stream.Base;
using Stream.Runtime;
using Stream.Pivot;
using System.ServiceModel;
using Stream.RPC;
using System.ServiceModel.Description;
using Stream.Pivot.Master;

namespace Stream
{
	class Program
	{
		static void Main(string[] args)
		{
			using (ServiceHost host = new ServiceHost(typeof(Master)))
			{
				//host.AddServiceEndpoint(typeof(IServer), new WSHttpBinding(),
				//    "http://localhost:9998/master");

				host.AddServiceEndpoint(typeof(IServer), new NetTcpBinding(),
					"net.tcp://localhost:9998/master");

				if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
				{
					ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
					behavior.HttpGetEnabled = true;
					behavior.HttpGetUrl = new Uri("http://localhost:9999/master/metadata");

					host.Description.Behaviors.Add(behavior);
				}

				host.Opened += delegate
				{
					Console.WriteLine("Master started!");
				};

				host.Open();
				Console.ReadKey();
			}

			//MasterService.ServerClient client = new MasterService.ServerClient();
			//MasterService.Package pkg = new MasterService.Package();
			//pkg.From = "HHHH";
			//pkg.Data = "abcedfg";
			//client.Send(pkg);

		}
	}
}

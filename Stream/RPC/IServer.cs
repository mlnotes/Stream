using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Stream.RPC
{
	[ServiceContract]
	interface IServer
	{
		[OperationContract]
		Package Send(Package pkg);
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stream.RPC;

namespace Stream.Pivot.Master
{
	/// <summary>
	/// Master of the entire cluster, only one instance per cluster
	/// </summary>
	class Master: IServer
	{
		public Package Send(Package pkg)
		{
			//throw new NotImplementedException();
			Console.WriteLine(pkg.From);
			Console.WriteLine(pkg.Data);
			return null;
		}
	}
}

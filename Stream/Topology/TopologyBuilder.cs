using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stream.Base;

namespace Stream.Topology
{
	class TopologyBuilder
	{


		public SpoutBuilder SetSpout(string name, Spout spout)
		{
			// TODO
			return new SpoutBuilder(spout);
		}

		public BoltBuilder SetBolt(string name, Bolt bolt)
		{
			// TODO

			return new BoltBuilder(bolt);
		}

		public Topology BuildTopology()
		{
			// TODO
			return null;
		}
	}
}

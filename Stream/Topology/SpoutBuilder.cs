using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stream.Base;

namespace Stream.Topology
{
	class SpoutBuilder
	{
		private Spout spout;
		private int maxNum;

		public SpoutBuilder(Spout spout)
		{
			this.spout = spout;
		}

		public SpoutBuilder SetMaxNum(int num)
		{
			this.maxNum = num;
			return this;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stream.Base;

namespace Stream.Topology
{
	class BoltBuilder
	{
		private Bolt bolt;
		private int maxNum;
		public List<string> shuffleUpper;
		public List<string> fieldUpper;
		public List<Fields> fieldUpperFields;

		public BoltBuilder(Bolt bolt)
		{
			this.bolt = bolt;
			shuffleUpper = new List<string>();
			fieldUpper = new List<string>();
			fieldUpperFields = new List<Fields>();
		}

		public BoltBuilder ShuffleGroup(string upstream)
		{
			shuffleUpper.Add(upstream);
			return this;
		}

		public BoltBuilder FieldGroup(string upstream, Fields fields)
		{
			this.fieldUpper.Add(upstream);
			this.fieldUpperFields.Add(fields);
			return this;
		}

		public BoltBuilder SetMaxNum(int num)
		{
			this.maxNum = num;
			return this;
		}
	}
}

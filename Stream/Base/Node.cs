using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stream.Runtime;

namespace Stream.Base
{
	abstract class Node
	{
		protected Fields outputFields;
		protected Values emittedValues;


		public abstract void Prepare(OutputDeclarer declarer, OutputCollector collector);

		protected abstract Fields DeclareOutput();
		public Tuple GetTuple()
		{
			// TODO
			return null;
		}

		protected void Declare(Fields fields)
		{
			this.outputFields = fields;
		}
	}
}

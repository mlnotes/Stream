using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stream.Base;

namespace Stream.Runtime
{
	class OutputDeclarer
	{
		private Executor executor;

		public OutputDeclarer(Executor executor)
		{
			this.executor = executor;
		}

		public void Declare(Fields fields)
		{
			executor.Declarer(fields);
		}
	}
}

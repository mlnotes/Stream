using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stream.Base;

namespace Stream.Runtime
{
	class OutputCollector
	{
		private Executor executor;

		public OutputCollector(Executor executor)
		{
			this.executor = executor;
		}

		public void Emit(Values values)
		{
			if (executor != null && values != null)
			{
				executor.Write(values);
			}
		}
	}
}

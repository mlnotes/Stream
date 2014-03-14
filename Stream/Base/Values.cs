using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stream.Base
{
	class Values: List<object>
	{
		public Values(params object[] values)
		{
			for (int i = 0; i < values.Length; ++i)
			{
				this.Add(values[i]);
			}
		}
	}
}

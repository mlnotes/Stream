using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stream.Base
{
	class Fields: List<string>
	{
		public Fields(params string[] fields)
		{
			for (int i = 0; i < fields.Length; ++i)
			{
				this.Add(fields[i]);
			}
		}
	}
}

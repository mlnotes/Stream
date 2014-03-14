using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stream.Base;

namespace Stream.Runtime
{
	class Message
	{
		private Stream.Base.Tuple tuple;

		public Stream.Base.Tuple Tuple { get { return tuple; } }

		public Message(Stream.Base.Tuple tuple)
		{
			this.tuple = tuple;
		}
	}
}

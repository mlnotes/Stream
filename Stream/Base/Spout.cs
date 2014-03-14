using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stream.Base
{
	abstract class Spout:Node
	{
		public abstract void SetUp();
		public abstract void NextTuple();
		public abstract void CleanUp();
	}
}

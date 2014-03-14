using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stream.Base;

namespace Stream.Runtime
{
	class BoltExecutor<T>: Executor
		where T:Bolt, new()
	{
		List<Bolt> bolts = new List<Bolt>();

		public override void Run()
		{
			Stream.Base.Tuple tuple;
			if (TryRead(out tuple))
			{
				// TODO how to dispatch tuple ?
				// basing on grouping method ?
			}
		}

		public override int SetTaskCnt(int cnt)
		{
			while (bolts.Count < cnt)
			{
				T bolt = new T();
				bolt.Prepare(declarer, collector);
				bolts.Add(bolt);
			}
			return bolts.Count;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stream.Base;

namespace Stream.Runtime
{
	class SpoutExecutor<T>: Executor
		where T:Spout, new()
	{
		List<T> spouts = new List<T>();

		public override void Run()
		{
			foreach (Spout spout in spouts)
			{
				spout.NextTuple();
			}
		}

		public override int SetTaskCnt(int cnt)
		{
			while (spouts.Count < cnt)
			{
				T spout = new T();
				spout.Prepare(declarer, collector);
				spouts.Add(spout);
			}

			return spouts.Count;
		}
	}
}

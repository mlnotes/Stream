using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stream.Base;

namespace Stream.Runtime
{
	abstract class Executor
	{
		protected Queue<Message> inQueue = new Queue<Message>();
//		protected Queue<Message> outQueue = new Queue<Message>();
		protected OutputCollector collector;
		protected OutputDeclarer declarer;
		protected Fields fields;
		protected Action<Message> writeMsg;

		public Action<Message> WriteMsg { set { writeMsg = value; } }

		public Executor()
		{
			collector = new OutputCollector(this);
			declarer = new OutputDeclarer(this);
		}

		public void Write(Values values)
		{
			// TODO convert values to message
			// save into out queue
			// when & where to send the message out ?
			Stream.Base.Tuple tuple = new Base.Tuple(fields, values);
//			outQueue.Enqueue(new Message(tuple));
			if (writeMsg != null)
			{
				writeMsg(new Message(tuple));
			}
		}

		public bool TryRead(out Stream.Base.Tuple tuple)
		{
			// TODO get tuple from in queue
			tuple = null;
			return false;
		}

		public void Declarer(Fields fields)
		{
			this.fields = fields;
		}

		public abstract int SetTaskCnt(int cnt);
		public abstract void Run();
	}
}

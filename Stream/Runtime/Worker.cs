using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections.Concurrent;

namespace Stream.Runtime
{
	class Worker
	{
		static Queue<Message> inQueue = new Queue<Message>();
		static ConcurrentQueue<Message> outQueue = new ConcurrentQueue<Message>();
		

		Thread readThread = new Thread(new ThreadStart(Read));
		Thread writeThread = new Thread(new ThreadStart(Send));
		List<Thread> threads = new List<Thread>();
		List<Executor> executors = new List<Executor>();

		// TODO how to recive message from other worker
		static void Receive()
		{
			// TODO need rpc support
		}


		// read the in queue and dispatch message to executor
		static void Read()
		{
			if (inQueue.Count > 0)
			{
				Message msg = inQueue.Dequeue();
				// TODO how to dispatch the message
				// where & how ?
			}
		}

		// read the out queue and send the message to other worker
		static void Send()
		{
			Message msg;
			if (outQueue.TryDequeue(out msg))
			{
				// TODO send msg out according to what ?
				// where & how ?
			}
		}

		// write message to out queue
		static void Write(Message msg)
		{
			outQueue.Enqueue(msg);
		}

		public void AddExecutor(Executor executor)
		{
			executor.WriteMsg = Write;
			executors.Add(executor);
			Thread thread = new Thread(new ThreadStart(() => executor.Run()));
			threads.Add(thread);
			thread.Start();
		}
	}
}

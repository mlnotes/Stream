using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stream.Base
{
	abstract class Bolt: Node
	{
		protected List<Node> upper = new List<Node>();

		/// <summary>
		/// logic of this bolt should be implemented here
		/// </summary>
		/// <param name="tuple"></param>
		/// <returns></returns>
		public abstract void Execute(Tuple tuple);

		public void Run()
		{
			while (true)
			{
				foreach (Node node in upper)
				{
					Tuple tuple = node.GetTuple();
					this.Execute(tuple);
				}
			}
		}
		
	}
}

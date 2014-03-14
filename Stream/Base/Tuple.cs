using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stream.Base
{
	class Tuple
	{
		private Fields fields;
		private Values values;

		private Dictionary<string, int> fieldIndex;

		public Tuple(Fields fields, Values values)
		{
			this.fields = fields;
			this.values = values;
			fieldIndex = new Dictionary<string, int>();

			for (int i = 0; i < fields.Count; ++i)
			{
				fieldIndex[fields[i]] = i;
			}
		}


		public object GetObjectByField(string field)
		{
			if (!fieldIndex.ContainsKey(field))
			{
				throw new IndexOutOfRangeException(string.Format(
					"No such field: [{0}]", field));
			}

			return GetObjectByIndex(fieldIndex[field]);
		}

		public object GetObjectByIndex(int index)
		{
			if (index < 0 || index > values.Count)
			{
				throw new IndexOutOfRangeException();
			}
			return values[index];
		}
	}
}

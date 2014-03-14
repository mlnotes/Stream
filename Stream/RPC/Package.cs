
using System.Runtime.Serialization;
namespace Stream.RPC
{
	[DataContract]
	class Package
	{
		[DataMember]
		public string From { get; set; }

		[DataMember]
		public object Data { get; set; }
	}
}

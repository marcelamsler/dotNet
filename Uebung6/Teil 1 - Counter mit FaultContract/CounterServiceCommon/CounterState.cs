using System.Runtime.Serialization;

namespace CounterServiceCommon
{
    [DataContract]
    public class CounterState
    {

        [DataMember]
        public int CountValue{get;set;}
        [DataMember]
        public int MaxCountValue{get;set;}
        [DataMember]
        public string CounterId { get; set; }
    }
}

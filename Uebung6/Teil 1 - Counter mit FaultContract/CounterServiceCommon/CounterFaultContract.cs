using System;
using System.Runtime.Serialization;

namespace CounterServiceCommon
{
    [DataContract]
    public class CounterFaultContract
    {
        public CounterFaultContract(CounterState counterState)
        {
            CountValue = counterState.CountValue;
            Message = String.Format("The max-value of {0} has been reached", CountValue);
        }
        [DataMember]
        int CountValue { get; set; }
        [DataMember]
        string Message { get; set; }

    }
}

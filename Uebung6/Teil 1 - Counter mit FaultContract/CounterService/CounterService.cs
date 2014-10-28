using System;
using System.ServiceModel;
using CounterServiceCommon;

namespace CounterService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class CounterService : ICounterService
    {

        CounterState counterState;

        public int CountValue { get {return counterState.CountValue; } set {counterState.CountValue = value; }}
        public int MaxCountValue { get { return counterState.MaxCountValue; } set { counterState.MaxCountValue = value; } }
        public string CounterId { get { return counterState.CounterId; } set { counterState.CounterId = value; } }

        public CounterState CounterState
        {
            get
            {
                return counterState;
            }
            set
            {
                counterState = value;
            }
        }

        public void increment()
        {
            if (counterState.CountValue + 1 > counterState.MaxCountValue)
            { 
                throw new FaultException<CounterFaultContract>(new CounterFaultContract(counterState)); 
            }
                
            counterState.CountValue++;
        }

        public void decrement()
        {
            counterState.CountValue--;
        }
    }

}


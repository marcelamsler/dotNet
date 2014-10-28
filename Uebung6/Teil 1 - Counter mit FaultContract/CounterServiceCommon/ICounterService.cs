using System.ServiceModel;

namespace CounterServiceCommon
{
   
[ServiceContract]
    public interface ICounterService
    {


    int CountValue { [OperationContract]get; [OperationContract]set; }

    int MaxCountValue { [OperationContract]get; [OperationContract] set; }

    string CounterId { [OperationContract] get; [OperationContract]set; }

    CounterState CounterState { [OperationContract]get; [OperationContract]set; }

        [OperationContract][FaultContractAttribute(typeof(CounterFaultContract))]
        void increment();
        [OperationContract]
        void decrement();

    }
}

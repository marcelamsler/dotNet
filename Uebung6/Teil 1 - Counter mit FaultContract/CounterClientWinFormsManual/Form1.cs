using System;
using System.ServiceModel;
using System.Windows.Forms;
using CounterServiceCommon;

namespace CounterClientWinFormsManual
{
    public partial class Form1 : Form
    {

        private ICounterService counterService;
        private ChannelFactory<ICounterService> channelFactory;

        public Form1()
        {
            InitializeComponent();
            InitializeCounter();
        }

        private void InitializeCounter()
        {
            channelFactory = new ChannelFactory<ICounterService>("CounterService");
            counterService = channelFactory.CreateChannel();
            counterService.CounterState = new CounterState();
            counterService.CounterState.MaxCountValue = 5;
        }

        private void IncBtnClick(object sender, EventArgs e)
        {
            counterService.increment();
            SafeUpdate(counterService.CounterState.CountValue);
        }

        private void DecBtnClick(object sender, EventArgs e)
        {
            counterService.decrement();
            SafeUpdate(counterService.CounterState.CountValue);

        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            if (channelFactory.State != CommunicationState.Closed)
            {
                channelFactory.Close();
            }
        }

        delegate void UpdateDel(int result);
        private void SafeUpdate(int result)
        {
            if (textBox1.InvokeRequired)
            {
                UpdateDel del = SafeUpdate;
                textBox1.Invoke(del, new object[] { result });
            }
            else
            {
                textBox1.Text = result.ToString();
            }
        }
    }
}
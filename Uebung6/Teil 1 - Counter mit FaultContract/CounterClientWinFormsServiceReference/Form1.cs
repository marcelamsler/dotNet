using CounterClientWinFormsServiceReference.ServiceReference1;
using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace CounterClientWinFormsServiceReference
{
    public partial class Form1 : Form
    {
        CounterServiceClient counterService;
        public Form1()
        {
            InitializeComponent();
            InitializeCounter();
        }

        private void InitializeCounter()
        {

            counterService = new CounterServiceClient();
            var state = new CounterState();
            state.MaxCountValue = 5;
            
            counterService.set_CounterState(state);
            SafeUpdate(counterService.get_CountValue());
            

        }

        private void IncBtnClick(object sender, EventArgs e)
        {
            try
            {
                counterService.increment();
            }
            catch (FaultException<CounterFaultContract> except) 
            {
                MessageBox.Show(except.Detail.Message);
            }
            
            SafeUpdate(counterService.get_CountValue());
            

        }

        private void DecBtnClick(object sender, EventArgs e)
        {
            counterService.decrement();
            SafeUpdate(counterService.get_CountValue());
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {

            if (counterService.State != CommunicationState.Closed)
            {
               counterService.Close();
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
using LemonWayTest.WinFormApp.ServiceReferenceLemonWay;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LemonWayTest.WinFormApp
{
    public partial class Form1 : Form
    {
        private BusyForm busyForm = new BusyForm();
        private ILog log = LogManager.GetLogger(typeof(Form1));
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log.Info("Form load");
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            log.Info("Button1 click");
            busyForm.Show();
            this.Enabled = false;
            LemonWayServiceSoapClient lemonWayServiceSoap = new LemonWayServiceSoapClient();

            try
            {
                log.Info("Calling FibonacciWithSleep(10,2000)");
                int result = await lemonWayServiceSoap.FibonacciWithSleepAsync(10, 2000);
                busyForm.Hide();
                this.Enabled = true;
                log.Info($"Result: {result}");
                MessageBox.Show($"Result: {result}");
            }
            catch (Exception exc)
            {
                busyForm.Hide();
                this.Enabled = true;
                log.Error($"An error occurred: {exc.ToString()}");
                MessageBox.Show($"An error occurred: {exc.ToString()}");
            }
        }
    }
}

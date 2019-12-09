using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using LemonWayTest.Consumer.ServiceReferenceLemonWay;
using log4net;

namespace LemonWayTest.Consumer
{
    class Program
    {
        private static ILog log;

        private static void Init()
        {
            log4net.Config.XmlConfigurator.Configure();
            log = LogManager.GetLogger("LemonWayTest.Consumer");
        }

        static void Main(string[] args)
        {
            try
            {
                Init();
                log.Info("Calling Fibonacci(10)...");
                LemonWayServiceSoapClient lemonWayServiceSoap = new LemonWayServiceSoapClient();
                int result = lemonWayServiceSoap.Fibonacci(10);

                log.Info($"Result : {result}");
            }
            catch (Exception e)
            {
                log.Error($"An error happened: {e.ToString()}");
            }
            finally
            {
                Console.WriteLine("Press any key to exit...");
                Console.Read();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace LemonWayTest.Consumer
{
    class Program
    {
        private static ILog log;
        private static string localUrl;
        private static string resource;
        private static string query;

        private static void Init()
        {
            log4net.Config.XmlConfigurator.Configure();
            log = LogManager.GetLogger("LemonWayTest.Consumer");

            localUrl = ConfigurationManager.AppSettings["ApiUrl"];
            resource = ConfigurationManager.AppSettings["ResourceUrl"];
            query = ConfigurationManager.AppSettings["Query"];
        }

        static void Main(string[] args)
        {
            Init();
            try
            {
                log.Info($"Creating WebRequest on url : {localUrl}{resource}{query}");
                WebRequest request = WebRequest.Create($"{localUrl}{resource}{query}");
                request.Method = "GET";

                log.Info("Calling...");
                WebResponse response = request.GetResponse();
                log.Info("Response received !");
                string responseContent = null;
                using (Stream data = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(data))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                }

                log.Info($"Response content: {responseContent}");
            }
            catch (Exception e)
            {
                log.Error($"An error happened: {e.ToString()}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}

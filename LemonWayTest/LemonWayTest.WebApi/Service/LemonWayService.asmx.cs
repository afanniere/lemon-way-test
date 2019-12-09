using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using log4net;
using System.Threading;

namespace LemonWayTest.WebApi.Service
{
    /// <summary>
    /// Summary description for LemonWayService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LemonWayService : System.Web.Services.WebService
    {
        private ILog log = LogManager.GetLogger(typeof(LemonWayService));

        /// <summary>
        /// Takes a integer N and returns and returns the Nth value in the Fibonacci sequence
        /// Fibonacci method strongly inspired from https://www.dotnetperls.com/fibonacci
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        [WebMethod]
        public int Fibonacci(int n)
        {
            log.Info($"Fibonacci: received n={n}");
            if (n < 1 || n > 100)
            {
                log.Error($"Fibonacci: {n} is not between 1 and 100");
                return -1;
            }
            int a = 0;
            int b = 1;
            try
            {
                // In N steps compute Fibonacci sequence iteratively.
                // Note: if n >= 47 we have overflow issues. To remedy this problem, we could use double instead of int.
                for (int i = 0; i < n; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                log.Info($"Fibonacci: returned {a}");
                return a;
            }
            catch (Exception e)
            {
                log.Error($"Fibonacci: an error occurred. {e.ToString()}");
                return -1;
            }
        }

        /// <summary>
        /// Same as above, but with a sleep time (delay)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="sleep"></param>
        /// <returns></returns>
        [WebMethod]
        public int FibonacciWithSleep(int n, int sleep)
        {
            log.Info($"Fibonacci: received n={n}, sleep={sleep}");
            if (n < 1 || n > 100)
            {
                log.Error($"Fibonacci: {n} is not between 1 and 100");
                return -1;
            }
            log.Info($"Fibonacci: Sleeping for {sleep} ms....");
            Thread.Sleep(sleep);

            int a = 0;
            int b = 1;
            try
            {
                // In N steps compute Fibonacci sequence iteratively.
                // Note: if n >= 47 we have overflow issues. To remedy this problem, we could use double instead of int.
                for (int i = 0; i < n; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                log.Info($"Fibonacci: returned {a}");
                return a;
            }
            catch (Exception e)
            {
                log.Error($"Fibonacci: an error occurred. {e.ToString()}");
                return -1;
            }
        }

        /// <summary>
        /// Takes as input a xml string and returns the json form of the xml string
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        [WebMethod]
        public string XmlToJson(string xml)
        {
            string badFormat = "Bad Xml format";
            log.Info($"XmlToJson: received {xml}");
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                string jsonText = JsonConvert.SerializeXmlNode(doc);
                log.Info($"XmlToJson: returned {jsonText}");
                return jsonText;
            }
            catch (Exception e)
            {
                log.Error($"XmlToJson: an error occurred. {e.ToString()}");
                log.Info($"XmlToJson: returned {badFormat}");
                return badFormat;
            }
        }
    }
}

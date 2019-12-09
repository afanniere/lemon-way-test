using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml;
using log4net;
using Newtonsoft.Json;

namespace LemonWayTest.Controllers
{
    public class ServiceController : ApiController
    {
        private ILog log = LogManager.GetLogger(typeof(ServiceController));

        /// <summary>
        /// Takes a integer N and returns and returns the Nth value in the Fibonacci sequence
        /// Fibonacci method strongly inspired from https://www.dotnetperls.com/fibonacci
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        [HttpGet]
        public double Fibonacci(int n)
        {
            log.Info($"Fibonacci: received {n}");
            if (n < 1 || n > 100)
            {
                log.Error($"Fibonacci: {n} is not between 1 and 100");
                return -1;
            }
            double a = 0;
            double b = 1;
            try
            {
                // In N steps compute Fibonacci sequence iteratively.
                for (int i = 0; i < n; i++)
                {
                    double temp = a;
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
        [HttpGet]
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

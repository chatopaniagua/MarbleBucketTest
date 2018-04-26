using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MarbleBucketAveragingAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseUrl = "http://localhost:9000/";

            bool isService = true;

            if(Debugger.IsAttached || args.Contains("--console"))
            {
                isService = false;
            }

            if (isService)
            {
                ServiceBase.Run(new WebApiService(baseUrl));
            }
            else
            {
                using (WebApp.Start<Startup>(url: baseUrl))
                {
                    Console.WriteLine("Started API server. Listening on {0}", baseUrl );
                    Console.ReadLine();
                }
            }

        }
    }
}

using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MarbleBucketAveragingAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseUrl = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseUrl))
            {
                Console.WriteLine("Started API server. Listening on {0}", baseUrl );
                Console.ReadLine();
            }
        }
    }
}

using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MarbleBucketAveragingAPI
{
    partial class WebApiService : ServiceBase
    {
        private string _url;
        private IDisposable _webapp;

        public WebApiService(string url)
        {
            _url = url;
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _webapp = WebApp.Start<Startup>(_url);
        }

        protected override void OnStop()
        {
            _webapp.Dispose();
        }
    }
}

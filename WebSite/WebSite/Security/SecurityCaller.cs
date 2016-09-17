using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using IsolationHost;

namespace WebSite.Security
{
    public static class SecurityCaller
    {
        private static Lazy<IsolationProxy> Proxy { get; } = new Lazy<IsolationProxy>(()=> new IsolationProxy());
        private static IsolationProxy IsolationProxy => Proxy.Value;

      
        public static void Start()
        {
            string file = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);// + "\\" + Parts[0].Trim() + ".dll";


            Process.Start("explorer.exe", file);


            IsolationProxy.Start();
        
        }
        private static void Stop()
        {

        }
    }
}
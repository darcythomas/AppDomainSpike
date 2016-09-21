using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using Common.Interfaces;
using IsolationHost;

namespace WebSite.Security
{
    public static class SecurityCaller
    {
        private static Lazy<IsolationProxy> Proxy { get; } = new Lazy<IsolationProxy>(() => new IsolationProxy(HttpContext.Current));
        private static IsolationProxy IsolationProxy => Proxy.Value;


        public static IHasAccess GetSecurityModule()
        {
            return new HasAccessProxy(IsolationProxy);
        }
        private static void Stop()
        {
            IsolationProxy.Dispose();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace IsolationHost
{
    public class IsolationProxy: IDisposable
    {
        private readonly HttpContext _httpContext;
        private readonly AppDomain _appDomain;

       // string _dllFolder = @"C:\temp\isolation\";
        string _dllFolder = "~/App_Data/dlls/";

        public AppDomain AppDomain => _appDomain;
        public String DllFolder => _httpContext == null?_dllFolder:_httpContext.Server.MapPath(_dllFolder);

        public IsolationProxy(HttpContext httpContext) : this()
        {
            _httpContext = httpContext;
        }

        public IsolationProxy()
        {
            String name = "New Domain";
            AppDomainSetup domainSetup = new AppDomainSetup
            {
                ApplicationName = name,
                ApplicationBase = _dllFolder
            };


            _appDomain = AppDomain.CreateDomain(name, null, domainSetup);
        }


        public void Dispose()
        {
            //Close Appdomain
            AppDomain.Unload(_appDomain);
        }

       
    }
}

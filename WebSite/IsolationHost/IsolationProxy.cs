using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IsolationHost
{
    public class IsolationProxy: IDisposable
    {
        private readonly AppDomain _appDomain;
        
        public IsolationProxy()
        {
            String name = "New Domain";
            string dllFolder = @"C:\temp\isolation";
            AppDomainSetup domainSetup = new AppDomainSetup();
            domainSetup.ApplicationName = name;
            
            domainSetup.ApplicationBase = dllFolder;

            _appDomain = AppDomain.CreateDomain(name,null,domainSetup);

          //  string file = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);// + "\\" + Parts[0].Trim() + ".dll";


          //  Process.Start("explorer.exe", file);
          
          dynamic myObject =  _appDomain.CreateInstanceFromAndUnwrap(dllFolder + @"\IsolationWrapper.dll", "IsolationWrapper.StartUp");



            //  var path = typeof(IsolationWrapper.StartUp).Assembly.Location;
            //    _appDomain.ExecuteAssembly(path);
            //   Type t = typeof(IsolationWrapper.StartUp);
            //  IsolationWrapper.StartUp myObject = (IsolationWrapper.StartUp)_appDomain.CreateInstanceFromAndUnwrap(path, t.FullName);

             var q = myObject.CallMe();
            //  _appDomain.DoCallBack(new CrossAppDomainDelegate(SayHello));

        }


        public void Dispose()
        {
            //Close Appdomain
            AppDomain.Unload(_appDomain);
        }

        public void Start()
        {
          
        }
    }
}

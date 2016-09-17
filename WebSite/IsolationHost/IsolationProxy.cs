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
            _appDomain = AppDomain.CreateDomain("New Domain");

            string file = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);// + "\\" + Parts[0].Trim() + ".dll";


            Process.Start("explorer.exe", file);


            //   _appDomain.ExecuteAssembly(@"c:\HelloWorld.exe");


            //  appDomain.DoCallBack(new CrossAppDomainDelegate(SayHello));

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

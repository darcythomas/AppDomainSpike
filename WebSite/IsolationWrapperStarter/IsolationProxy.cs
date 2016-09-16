using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IsolationWrapperStarter
{
    public class IsolationProxy: IDisposable
    {
        private AppDomain appDomain;
        
        public IsolationProxy()
        {
            appDomain = AppDomain.CreateDomain("New Domain");

            string File = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);// + "\\" + Parts[0].Trim() + ".dll";

            appDomain.ExecuteAssembly(@"c:\HelloWorld.exe");


            //  appDomain.DoCallBack(new CrossAppDomainDelegate(SayHello));

        }


        public void Dispose()
        {
            //Close Appdomain
            AppDomain.Unload(appDomain);
        }
    }
}

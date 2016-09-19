using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;

namespace IsolationHost
{

    [Serializable]
    public class UserAction : IUserAction
    {
        public string UserName { get; set; }
        public string Action { get; set; }
    }

    public class HasAccessProxy : IHasAccess
    {
        private readonly IsolationProxy _isolationProxy;

        public HasAccessProxy(IsolationProxy isolationProxy)
        {
            _isolationProxy = isolationProxy;
        }

        public bool IsAbleTo(IUserAction userAction)
        {
            string dllFolder = _isolationProxy.DllFolder;

            string dllPath = $"{dllFolder}IsolationWrapper.dll";
            string typeName = "IsolationWrapper.StartUp";
             dynamic myObject = _isolationProxy.AppDomain.CreateInstanceFromAndUnwrap(dllPath, typeName);
            // string call = myObject.CallMe();

            // return call == String.Empty;

           // object[] parameters = new object[2];  
           // parameters[0] = userAction.UserName;  
            //parameters[1] = userAction.Action;
           // dynamic myObject = _isolationProxy.AppDomain.CreateInstanceFromAndUnwrap($"{dllFolder}IsolationWrapper.dll", "IsolationWrapper.StartUp", true, BindingFlags.Default, null, parameters, null, null);

            return    myObject.CallSecurity(new UserAction() {Action = userAction.Action,   UserName = userAction.UserName});



            //  return hasAccess;
            //  IsolationWrapper.StartUp myObject = (IsolationWrapper.StartUp)_appDomain.CreateInstanceFromAndUnwrap(path, t.FullName);

            //_isolationProxy.AppDomain.SetData("userName", userName);
            //_isolationProxy.AppDomain.SetData("action",action);

            // _isolationProxy.AppDomain.DoCallBack(new CrossAppDomainDelegate(SayHello));
        }
    }
}

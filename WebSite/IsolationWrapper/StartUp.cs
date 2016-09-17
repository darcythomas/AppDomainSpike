using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using SecurityModule;

namespace IsolationWrapper
{
    [Serializable]
    public class StartUp
    {
        
        public string CallMe()
        {
            return "You called me";
        }

        public bool CallSecurity(IUserAction userAction)
        {
            var securityModule = new SecurityAccessModule();
            return securityModule.IsAbleTo(userAction);
        }
    }
}

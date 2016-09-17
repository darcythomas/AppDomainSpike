using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsolationWrapper
{
    [Serializable]
    public class StartUp
    {
        public string CallMe()
        {
            return "You called me";
        }
    }
}

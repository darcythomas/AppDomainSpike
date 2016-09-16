using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsolationHost;
using NUnit.Framework;

namespace WebSite.Tests
{
    [TestFixture]
   public class IsolationProxyTests
    {
        [Test]
        public void StartupTest()
        {
            using (IsolationProxy isolation = new IsolationProxy())
            {

                Console.WriteLine("here");


            }
            
        }
    }
}

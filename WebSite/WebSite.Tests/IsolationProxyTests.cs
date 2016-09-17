using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using IsolationHost;
using NUnit.Framework;
using WebSite.Security;

namespace WebSite.Tests
{
    [TestFixture]
    public class IsolationProxyTests
    {
        [Test]
        public void StartupTest()
        {

            //    SecurityCaller.Start();
            using (IsolationProxy isolation = new IsolationProxy())
            {


                var security = new HasAccessProxy(isolation);

                security.IsAbleTo(new UserAction()
                {
                    UserName = "Dude",
                    Action = "Launch Nukes"
                }).Should().BeFalse();

                security.IsAbleTo(new UserAction() { UserName = "Lady", Action = "Be Awesome" }).Should().BeTrue();

            }

        }
    }
}

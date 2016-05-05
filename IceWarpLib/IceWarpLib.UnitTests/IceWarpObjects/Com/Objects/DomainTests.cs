using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IceWarpLib.Objects.Com.Objects;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Com.Objects
{
    [TestFixture]
    public class DomainTests
    {
        [Test]
        public void PropertyNames()
        {
            var domain = new Domain();
            var properties = domain.PropertyNames();

            Assert.NotNull(properties);
            Assert.AreEqual(88, properties.Count);
        }
    }
}

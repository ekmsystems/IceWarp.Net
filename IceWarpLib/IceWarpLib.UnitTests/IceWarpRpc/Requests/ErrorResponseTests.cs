using System.IO;
using System.Xml;
using IceWarpRpc.Exceptions;
using IceWarpRpc.Responses;
using IceWarpRpc.Utilities;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpRpc.Requests
{
    [TestFixture]
    public class ErrorResponseTests
    {
        [TestFixtureSetUp]
        public void FixtureSetup() { }

        [SetUp]
        public void TestSetup() { }

        [TearDown]
        public void TestTearDown() { }

        [TestFixtureTearDown]
        public void FixtureTearDown() { }

        #region Received Error

        [Test]
        public void Test_Throws_ProcessResponseException_When_HttpRequestResult_Null()
        {
            Assert.Throws<ProcessResponseException>(() => new SuccessResponse(null));
        }

        [Test]
        public void Test_Throws_ProcessResponseException_When_Response_Empty()
        {
            Assert.Throws<ProcessResponseException>(() => new SuccessResponse(new HttpRequestResult()));
        }

        [Test]
        public void Test_Throws_ProcessResponseException_When_Response_Not_Xml()
        {
            Assert.Throws<ProcessResponseException>(() => new SuccessResponse(new HttpRequestResult { Response = "not xml" }));
        }

        [Test]
        public void Test_Throws_IceWarpErrorException_When_Response_Is_Type_Error()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(@"IceWarpRpc\Requests\ErrorResponse.xml"));
            var xml = doc.InnerXml;

            Assert.Throws<IceWarpErrorException>(() => new SuccessResponse(new HttpRequestResult { Response = xml }));
        }

        #endregion
    }
}

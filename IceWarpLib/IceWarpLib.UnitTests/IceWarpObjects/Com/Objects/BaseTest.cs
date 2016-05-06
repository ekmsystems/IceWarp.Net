using System.IO;
using System.Xml;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Com.Objects
{
    [TestFixture]
    public abstract class BaseTest
    {
        private readonly string _requestsTestDataPath = @"IceWarpObjects\Com\Objects\XmlFiles";

        protected XmlDocument BuildXmlDocument(string xml)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xml);
            return doc;
        }

        protected string LoadXmlFromFile(string fileName)
        {
            return File.ReadAllText(Path.Combine(_requestsTestDataPath, fileName));
        }

        protected TPropertyValueListResponse BuildTPropertyValueListResponseFromFile(string fileName)
        {
            return BuildTPropertyValueListResponseFromXml(LoadXmlFromFile(fileName));
        }

        protected TPropertyValueListResponse BuildTPropertyValueListResponseFromXml(string xml)
        {
            var doc = BuildXmlDocument(xml);
            return new TPropertyValueListResponse(new HttpRequestResult{ Response = doc.InnerXml });
        }
    }
}

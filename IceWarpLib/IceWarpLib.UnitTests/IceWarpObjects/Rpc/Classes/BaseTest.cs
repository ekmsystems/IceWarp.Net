using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes
{
    [TestFixture]
    public abstract class BaseTest
    {
        protected XmlDocument BuildXmlDocument(BaseClass testClass)
        {
            var doc = new XmlDocument();

            var custom = testClass.BuildXmlElement(doc, "custom");
            doc.AppendChild(custom);

            return doc;
        }

        protected string ToXml(BaseClass testClass)
        {
            return BuildXmlDocument(testClass).InnerXmlFormatted();
        }

        protected string ToFormattedXml(BaseClass testClass)
        {
            return BuildXmlDocument(testClass).InnerXmlFormatted(4);
        }

        protected XmlNode GetXmlNode(string xmlStr, string xPath = "custom")
        {
            var xml = new XmlDocument();
            xml.LoadXml(xmlStr);
            var documentElement = xml.DocumentElement.RemoveAllNamespaces();
            return documentElement.SelectSingleNode("/custom");
        }
    }
}

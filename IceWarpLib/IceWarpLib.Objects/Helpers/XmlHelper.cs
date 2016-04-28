using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace IceWarpLib.Objects.Helpers
{
    public static class XmlHelper
    {
        public const string Xmlns = "admin:iq:rpc";
        public const string IqTag = "iq";
        public const string TypeAttribute = "type";
        public const string TypeGetValue = "get";
        public const string SidAttribute = "sid";
        public const string QueryTag = "query";
        public const string CommandNameTag = "commandname";
        public const string CommandParamsTag = "commandparams";
        public const string ItemTag = "item";
        public const string ClassNameTag = "classname";

        public const string ResultXPath = "/iq/query/result";
        public const string ErrorXPath = "/iq/query/error";
        public const string ErrorIdAttribute = "uid";

        public static XmlElement CreateElement(XmlDocument doc, string qualifiedName)
        {
            return doc.CreateElement(qualifiedName.ToLower(), Xmlns);
        }

        public static XmlElement CreateElement(XmlDocument doc, string qualifiedName, string xmlns)
        {
            return doc.CreateElement(qualifiedName.ToLower(), xmlns);
        }

        public static void AppendTextElement(XmlElement containingElement, string qualifiedName, string value)
        {
            var element = CreateElement(containingElement.OwnerDocument, qualifiedName.ToLower());
            if (!String.IsNullOrEmpty(value))
                element.AppendChild(containingElement.OwnerDocument.CreateTextNode(value));
            containingElement.AppendChild(element);
        }

        public static void AppendTextElement(XmlElement containingElement, string qualifiedName, int value)
        {
            var element = CreateElement(containingElement.OwnerDocument, qualifiedName.ToLower());
            element.AppendChild(containingElement.OwnerDocument.CreateTextNode(value.ToString()));
            containingElement.AppendChild(element);
        }

        public static void AppendTextElement(XmlElement containingElement, string qualifiedName, int? value)
        {
            var element = CreateElement(containingElement.OwnerDocument, qualifiedName.ToLower());
            if (value.HasValue)
                element.AppendChild(containingElement.OwnerDocument.CreateTextNode(value.Value.ToString()));
            containingElement.AppendChild(element);
        }

        public static void AppendTextElement(XmlElement containingElement, string qualifiedName, long value)
        {
            var element = CreateElement(containingElement.OwnerDocument, qualifiedName.ToLower());
            element.AppendChild(containingElement.OwnerDocument.CreateTextNode(value.ToString()));
            containingElement.AppendChild(element);
        }

        public static void AppendTextElement(XmlElement containingElement, string qualifiedName, double value)
        {
            var element = CreateElement(containingElement.OwnerDocument, qualifiedName.ToLower());
            element.AppendChild(containingElement.OwnerDocument.CreateTextNode(value.ToString()));
            containingElement.AppendChild(element);
        }

        public static void AppendTextElement(XmlElement containingElement, string qualifiedName, float value)
        {
            var element = CreateElement(containingElement.OwnerDocument, qualifiedName.ToLower());
            element.AppendChild(containingElement.OwnerDocument.CreateTextNode(value.ToString()));
            containingElement.AppendChild(element);
        }

        public static void AppendTextElement(XmlElement containingElement, string qualifiedName, bool value)
        {
            var element = CreateElement(containingElement.OwnerDocument, qualifiedName.ToLower());
            element.AppendChild(containingElement.OwnerDocument.CreateTextNode(value.ToBitString()));
            containingElement.AppendChild(element);
        }

        public static void AppendTextElement(XmlElement containingElement, string qualifiedName, bool? value)
        {
            var element = CreateElement(containingElement.OwnerDocument, qualifiedName.ToLower());
            var strValue = value.ToBitString();
            if (!String.IsNullOrEmpty(strValue))
                element.AppendChild(containingElement.OwnerDocument.CreateTextNode(strValue));
            containingElement.AppendChild(element);
        }

        public static void AppendTextElement(XmlElement containingElement, string qualifiedName, Enum value)
        {
            var element = CreateElement(containingElement.OwnerDocument, qualifiedName.ToLower());
            var strValue = value.ToEnumIntString();
            if (!String.IsNullOrEmpty(strValue))
                element.AppendChild(containingElement.OwnerDocument.CreateTextNode(strValue));
            containingElement.AppendChild(element);
        }

        public static XmlNode GetSingleNode(this XmlNode node, string xPath)
        {
            return node.SelectSingleNode(xPath.ToLower());
        }

        public static XmlNodeList GetNodes(this XmlNode node, string xPath)
        {
            return node.SelectNodes(xPath.ToLower());
        }

        public static XmlNode RemoveAllNamespaces(this XmlNode documentElement)
        {
            var xmlnsPattern = "\\s+xmlns\\s*(:\\w)?\\s*=\\s*\\\"(?<url>[^\\\"]*)\\\"";
            var outerXml = documentElement.OuterXml;
            var matchCol = Regex.Matches(outerXml, xmlnsPattern);
            foreach (var match in matchCol)
                outerXml = outerXml.Replace(match.ToString(), "");

            var result = new XmlDocument();
            result.LoadXml(outerXml);

            return result;
        }

        public static string InnerXmlFormatted(this XmlDocument document, int indentation = 2)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            XmlTextWriter xtw = null;
            try
            {
                xtw = new XmlTextWriter(sw);
                xtw.Formatting = Formatting.Indented;
                xtw.Indentation = indentation;
                document.WriteTo(xtw);
            }
            finally
            {
                if (xtw != null)
                    xtw.Close();
            }
            return sb.ToString();
        }
    }
}

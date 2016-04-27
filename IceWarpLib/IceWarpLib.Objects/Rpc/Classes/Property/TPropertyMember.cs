using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Represents the account member( mailing list, group ).
    /// <para><see href="https://www.icewarp.co.uk/api/#TPropertyMember">https://www.icewarp.co.uk/api/#TPropertyMember</see></para>
    /// </summary>
    public class TPropertyMember : TPropertyVal
    {
        /// <summary>
        /// Name of the member
        /// </summary>
        public string Val { get; set; }
        /// <summary>
        /// Mailing list - Member will have default rights as defined within the Mailing List – Security tab of mailing list settings.
        /// </summary>
        public bool Default { get; set; }
        /// <summary>
        /// Mailing list - Member will receive all messages sent to the list and cannot post messages to the list.
        /// </summary>
        public bool Recieve { get; set; }
        /// <summary>
        /// Mailing list - Member can post message to the mailing list.
        /// </summary>
        public bool Post { get; set; }
        /// <summary>
        /// Mailing list - Member will receive all messages sent to the list, in a single "digest" message, and cannot post messages to the list.
        /// </summary>
        public bool Digest { get; set; }

        /// <inheritdoc />
        public TPropertyMember()
        {
        }

        /// <inheritdoc />
        public TPropertyMember(XmlNode node)
        {
            if (node != null)
            {
                Val = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Val)));
                Default = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Default)));
                Recieve = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Recieve)));
                Post = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Post)));
                Digest = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Digest)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, XmlHelper.ClassNameTag, ClassName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Val), Val);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Default), Default);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Recieve), Recieve);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Post), Post);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Digest), Digest);

            return element;
        }
    }
}

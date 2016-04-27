using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// vCard data structure of IceWarp account.
    /// <para><see href="https://www.icewarp.co.uk/api/#TAccountCard">https://www.icewarp.co.uk/api/#TAccountCard</see></para>
    /// </summary>
    public class TAccountCard : TPropertyVal
    {
        public string Body { get; set; }
        public string Anniversary { get; set; }
        public string BirthDay { get; set; }
        public string AssistantName { get; set; }
        public string CompanyName { get; set; }
        public string Department { get; set; }
        public string FileAs { get; set; }
        public string FirstName { get; set; }
        public string JobTitle { get; set; }
        public string LastName { get; set; }
        public string ManagerName { get; set; }
        public string MiddleName { get; set; }
        public string Nickname { get; set; }
        public string OfficeLocation { get; set; }
        public string Spouse { get; set; }
        public string Suffix { get; set; }
        public string Title { get; set; }
        public string WebPage { get; set; }
        public string Certificate { get; set; }
        public string FreeBusyURL { get; set; }
        public string Profession { get; set; }
        public string Sensitivity { get; set; }
        public string Gender { get; set; }
        public string BusinessAddressCity { get; set; }
        public string BusinessAddressCountry { get; set; }
        public string BusinessAddressPostalCode { get; set; }
        public string BusinessAddressState { get; set; }
        public string BusinessAddressStreet { get; set; }
        public string BusinessAddressPostOfficeBox { get; set; }
        public string HomeAddressCity { get; set; }
        public string HomeAddressCountry { get; set; }
        public string HomeAddressPostalCode { get; set; }
        public string HomeAddressState { get; set; }
        public string HomeAddressStreet { get; set; }
        public string HomeAddressPostOfficeBox { get; set; }
        public string Email1Address { get; set; }
        public string Email2Address { get; set; }
        public string Email3Address { get; set; }
        public string IMAddress { get; set; }
        public string HomePage { get; set; }
        public string HomePage2 { get; set; }
        public string AssistnameTelephoneNumber { get; set; }
        public string BusinessFaxNumber { get; set; }
        public string BusinessTelephoneNumber { get; set; }
        public string Business2TelephoneNumber { get; set; }
        public string CarTelephoneNumber { get; set; }
        public string CompanyMainTelephoneNumber { get; set; }
        public string HomeFaxNumber { get; set; }
        public string HomeTelephoneNumber { get; set; }
        public string Home2TelephoneNumber { get; set; }
        public string MobileTelephoneNumber { get; set; }
        public string PagerNumber { get; set; }
        public string RadioTelephoneNumber { get; set; }
        public string CallbackTelephoneNumber { get; set; }
        public string ISDNNumber { get; set; }
        public string OtherFaxNumber { get; set; }
        public string PrimaryTelephoneNumber { get; set; }
        public string TelexNumber { get; set; }
        public string HearingNumber { get; set; }
        public string OtherNumber { get; set; }
        public TPropertyStringList Categories { get; set; }

        /// <inheritdoc />
        public TAccountCard(){}

        /// <inheritdoc />
        public TAccountCard(XmlNode node)
        {
            if (node != null)
            {
                Body = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Body)));
                Anniversary = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Anniversary)));
                BirthDay = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => BirthDay)));
                AssistantName = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => AssistantName)));
                CompanyName = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => CompanyName)));
                Department = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Department)));
                FileAs = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => FileAs)));
                FirstName = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => FirstName)));
                JobTitle = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => JobTitle)));
                LastName = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => LastName)));
                ManagerName = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => ManagerName)));
                MiddleName = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => MiddleName)));
                Nickname = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Nickname)));
                OfficeLocation = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => OfficeLocation)));
                Spouse = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Spouse)));
                Suffix = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Suffix)));
                Title = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Title)));
                WebPage = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => WebPage)));
                Certificate = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Certificate)));
                FreeBusyURL = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => FreeBusyURL)));
                Profession = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Profession)));
                Sensitivity = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Sensitivity)));
                Gender = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Gender)));
                BusinessAddressCity = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => BusinessAddressCity)));
                BusinessAddressCountry = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => BusinessAddressCountry)));
                BusinessAddressPostalCode = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => BusinessAddressPostalCode)));
                BusinessAddressState = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => BusinessAddressState)));
                BusinessAddressStreet = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => BusinessAddressStreet)));
                BusinessAddressPostOfficeBox = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => BusinessAddressPostOfficeBox)));
                HomeAddressCity = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => HomeAddressCity)));
                HomeAddressCountry = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => HomeAddressCountry)));
                HomeAddressPostalCode = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => HomeAddressPostalCode)));
                HomeAddressState = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => HomeAddressState)));
                HomeAddressStreet = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => HomeAddressStreet)));
                HomeAddressPostOfficeBox = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => HomeAddressPostOfficeBox)));
                Email1Address = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Email1Address)));
                Email2Address = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Email2Address)));
                Email3Address = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Email3Address)));
                IMAddress = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => IMAddress)));
                HomePage = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => HomePage)));
                HomePage2 = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => HomePage2)));
                AssistnameTelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => AssistnameTelephoneNumber)));
                BusinessFaxNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => BusinessFaxNumber)));
                BusinessTelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => BusinessTelephoneNumber)));
                Business2TelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Business2TelephoneNumber)));
                CarTelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => CarTelephoneNumber)));
                CompanyMainTelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => CompanyMainTelephoneNumber)));
                HomeFaxNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => HomeFaxNumber)));
                HomeTelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => HomeTelephoneNumber)));
                Home2TelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Home2TelephoneNumber)));
                MobileTelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => MobileTelephoneNumber)));
                PagerNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => PagerNumber)));
                RadioTelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => RadioTelephoneNumber)));
                CallbackTelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => CallbackTelephoneNumber)));
                ISDNNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => ISDNNumber)));
                OtherFaxNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => OtherFaxNumber)));
                PrimaryTelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => PrimaryTelephoneNumber)));
                TelexNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => TelexNumber)));
                HearingNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => HearingNumber)));
                OtherNumber = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => OtherNumber)));
                Categories = new TPropertyStringList(node.GetSingleNode(ClassHelper.GetMemberName(() => Categories)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, XmlHelper.ClassNameTag, ClassName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Body), Body);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Anniversary), Anniversary);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => BirthDay), BirthDay);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => AssistantName), AssistantName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => CompanyName), CompanyName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Department), Department);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => FileAs), FileAs);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => FirstName), FirstName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => JobTitle), JobTitle);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => LastName), LastName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ManagerName), ManagerName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MiddleName), MiddleName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Nickname), Nickname);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => OfficeLocation), OfficeLocation);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Spouse), Spouse);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Suffix), Suffix);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Title), Title);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => WebPage), WebPage);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Certificate), Certificate);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => FreeBusyURL), FreeBusyURL);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Profession), Profession);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Sensitivity), Sensitivity);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Gender), Gender);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => BusinessAddressCity), BusinessAddressCity);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => BusinessAddressCountry), BusinessAddressCountry);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => BusinessAddressPostalCode), BusinessAddressPostalCode);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => BusinessAddressState), BusinessAddressState);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => BusinessAddressStreet), BusinessAddressStreet);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => BusinessAddressPostOfficeBox), BusinessAddressPostOfficeBox);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => HomeAddressCity), HomeAddressCity);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => HomeAddressCountry), HomeAddressCountry);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => HomeAddressPostalCode), HomeAddressPostalCode);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => HomeAddressState), HomeAddressState);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => HomeAddressStreet), HomeAddressStreet);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => HomeAddressPostOfficeBox), HomeAddressPostOfficeBox);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Email1Address), Email1Address);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Email2Address), Email2Address);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Email3Address), Email3Address);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => IMAddress), IMAddress);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => HomePage), HomePage);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => HomePage2), HomePage2);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => AssistnameTelephoneNumber), AssistnameTelephoneNumber);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => BusinessFaxNumber), BusinessFaxNumber);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => BusinessTelephoneNumber), BusinessTelephoneNumber);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Business2TelephoneNumber), Business2TelephoneNumber);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => CarTelephoneNumber), CarTelephoneNumber);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => CompanyMainTelephoneNumber), CompanyMainTelephoneNumber);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => HomeFaxNumber), HomeFaxNumber);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => HomeTelephoneNumber), HomeTelephoneNumber);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Home2TelephoneNumber), Home2TelephoneNumber);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MobileTelephoneNumber), MobileTelephoneNumber);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => PagerNumber), PagerNumber);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => RadioTelephoneNumber), RadioTelephoneNumber);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => CallbackTelephoneNumber), CallbackTelephoneNumber);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ISDNNumber), ISDNNumber);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => OtherFaxNumber), OtherFaxNumber);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => PrimaryTelephoneNumber), PrimaryTelephoneNumber);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => TelexNumber), TelexNumber);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => HearingNumber), HearingNumber);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => OtherNumber), OtherNumber);
            element.AppendChild(Categories.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Categories)));

            return element;
        }
    }
}

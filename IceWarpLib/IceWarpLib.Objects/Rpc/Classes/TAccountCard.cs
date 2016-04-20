using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes
{
    /// <summary>
    /// vCard data structure of IceWarp account
    /// </summary>
    public class TAccountCard : BaseClass
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
        
        public TAccountCard(){}

        public TAccountCard(XmlNode node)
        {
            if (node != null)
            {
                Body = Extensions.GetNodeInnerText(node.GetSingleNode("Body"));
                Anniversary = Extensions.GetNodeInnerText(node.GetSingleNode("Anniversary"));
                BirthDay = Extensions.GetNodeInnerText(node.GetSingleNode("Birthday"));
                AssistantName = Extensions.GetNodeInnerText(node.GetSingleNode("AssistantName"));
                CompanyName = Extensions.GetNodeInnerText(node.GetSingleNode("CompanyName"));
                Department = Extensions.GetNodeInnerText(node.GetSingleNode("Department"));
                FileAs = Extensions.GetNodeInnerText(node.GetSingleNode("FileAs"));
                FirstName = Extensions.GetNodeInnerText(node.GetSingleNode("FirstName"));
                JobTitle = Extensions.GetNodeInnerText(node.GetSingleNode("JobTitle"));
                LastName = Extensions.GetNodeInnerText(node.GetSingleNode("LastName"));
                ManagerName = Extensions.GetNodeInnerText(node.GetSingleNode("ManagerName"));
                MiddleName = Extensions.GetNodeInnerText(node.GetSingleNode("MiddleName"));
                Nickname = Extensions.GetNodeInnerText(node.GetSingleNode("Nickname"));
                OfficeLocation = Extensions.GetNodeInnerText(node.GetSingleNode("OfficeLocation"));
                Spouse = Extensions.GetNodeInnerText(node.GetSingleNode("Spouse"));
                Suffix = Extensions.GetNodeInnerText(node.GetSingleNode("Suffix"));
                Title = Extensions.GetNodeInnerText(node.GetSingleNode("Title"));
                WebPage = Extensions.GetNodeInnerText(node.GetSingleNode("WebPage"));
                Certificate = Extensions.GetNodeInnerText(node.GetSingleNode("Certificate"));
                FreeBusyURL = Extensions.GetNodeInnerText(node.GetSingleNode("FreeBusyURL"));
                Profession = Extensions.GetNodeInnerText(node.GetSingleNode("Profession"));
                Sensitivity = Extensions.GetNodeInnerText(node.GetSingleNode("Sensitivity"));
                Gender = Extensions.GetNodeInnerText(node.GetSingleNode("Gender"));
                BusinessAddressCity = Extensions.GetNodeInnerText(node.GetSingleNode("BusinessAddressCity"));
                BusinessAddressCountry = Extensions.GetNodeInnerText(node.GetSingleNode("BusinessAddressCountry"));
                BusinessAddressPostalCode = Extensions.GetNodeInnerText(node.GetSingleNode("BusinessAddressPostalCode"));
                BusinessAddressState = Extensions.GetNodeInnerText(node.GetSingleNode("BusinessAddressState"));
                BusinessAddressStreet = Extensions.GetNodeInnerText(node.GetSingleNode("BusinessAddressStreet"));
                BusinessAddressPostOfficeBox = Extensions.GetNodeInnerText(node.GetSingleNode("BusinessAddressPostOfficeBox"));
                HomeAddressCity = Extensions.GetNodeInnerText(node.GetSingleNode("HomeAddressCity"));
                HomeAddressCountry = Extensions.GetNodeInnerText(node.GetSingleNode("HomeAddressCountry"));
                HomeAddressPostalCode = Extensions.GetNodeInnerText(node.GetSingleNode("HomeAddressPostalCode"));
                HomeAddressState = Extensions.GetNodeInnerText(node.GetSingleNode("HomeAddressState"));
                HomeAddressStreet = Extensions.GetNodeInnerText(node.GetSingleNode("HomeAddressStreet"));
                HomeAddressPostOfficeBox = Extensions.GetNodeInnerText(node.GetSingleNode("HomeAddressPostOfficeBox"));
                Email1Address = Extensions.GetNodeInnerText(node.GetSingleNode("Email1Address"));
                Email2Address = Extensions.GetNodeInnerText(node.GetSingleNode("Email2Address"));
                Email3Address = Extensions.GetNodeInnerText(node.GetSingleNode("Email3Address"));
                IMAddress = Extensions.GetNodeInnerText(node.GetSingleNode("IMAddress"));
                HomePage = Extensions.GetNodeInnerText(node.GetSingleNode("HomePage"));
                HomePage2 = Extensions.GetNodeInnerText(node.GetSingleNode("HomePage2"));
                AssistnameTelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode("AssistnameTelephoneNumber"));
                BusinessFaxNumber = Extensions.GetNodeInnerText(node.GetSingleNode("BusinessFaxNumber"));
                BusinessTelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode("BusinessTelephoneNumber"));
                Business2TelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode("Business2TelephoneNumber"));
                CarTelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode("CarTelephoneNumber"));
                CompanyMainTelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode("CompanyMainTelephoneNumber"));
                HomeFaxNumber = Extensions.GetNodeInnerText(node.GetSingleNode("HomeFaxNumber"));
                HomeTelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode("HomeTelephoneNumber"));
                Home2TelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode("Home2TelephoneNumber"));
                MobileTelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode("MobileTelephoneNumber"));
                PagerNumber = Extensions.GetNodeInnerText(node.GetSingleNode("PagerNumber"));
                RadioTelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode("RadioTelephoneNumber"));
                CallbackTelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode("CallbackTelephoneNumber"));
                ISDNNumber = Extensions.GetNodeInnerText(node.GetSingleNode("ISDNNumber"));
                OtherFaxNumber = Extensions.GetNodeInnerText(node.GetSingleNode("OtherFaxNumber"));
                PrimaryTelephoneNumber = Extensions.GetNodeInnerText(node.GetSingleNode("PrimaryTelephoneNumber"));
                TelexNumber = Extensions.GetNodeInnerText(node.GetSingleNode("TelexNumber"));
                HearingNumber = Extensions.GetNodeInnerText(node.GetSingleNode("HearingNumber"));
                OtherNumber = Extensions.GetNodeInnerText(node.GetSingleNode("OtherNumber"));
                Categories = new TPropertyStringList(node.GetSingleNode("Categories"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, "ClassName", ClassName);
            XmlHelper.AppendTextElement(element, "Body", Body);
            XmlHelper.AppendTextElement(element, "Anniversary", Anniversary);
            XmlHelper.AppendTextElement(element, "BirthDay", BirthDay);
            XmlHelper.AppendTextElement(element, "AssistantName", AssistantName);
            XmlHelper.AppendTextElement(element, "CompanyName", CompanyName);
            XmlHelper.AppendTextElement(element, "Department", Department);
            XmlHelper.AppendTextElement(element, "FileAs", FileAs);
            XmlHelper.AppendTextElement(element, "FirstName", FirstName);
            XmlHelper.AppendTextElement(element, "JobTitle", JobTitle);
            XmlHelper.AppendTextElement(element, "LastName", LastName);
            XmlHelper.AppendTextElement(element, "ManagerName", ManagerName);
            XmlHelper.AppendTextElement(element, "MiddleName", MiddleName);
            XmlHelper.AppendTextElement(element, "Nickname", Nickname);
            XmlHelper.AppendTextElement(element, "OfficeLocation", OfficeLocation);
            XmlHelper.AppendTextElement(element, "Spouse", Spouse);
            XmlHelper.AppendTextElement(element, "Suffix", Suffix);
            XmlHelper.AppendTextElement(element, "Title", Title);
            XmlHelper.AppendTextElement(element, "WebPage", WebPage);
            XmlHelper.AppendTextElement(element, "Certificate", Certificate);
            XmlHelper.AppendTextElement(element, "FreeBusyURL", FreeBusyURL);
            XmlHelper.AppendTextElement(element, "Profession", Profession);
            XmlHelper.AppendTextElement(element, "Sensitivity", Sensitivity);
            XmlHelper.AppendTextElement(element, "Gender", Gender);
            XmlHelper.AppendTextElement(element, "BusinessAddressCity", BusinessAddressCity);
            XmlHelper.AppendTextElement(element, "BusinessAddressCountry", BusinessAddressCountry);
            XmlHelper.AppendTextElement(element, "BusinessAddressPostalCode", BusinessAddressPostalCode);
            XmlHelper.AppendTextElement(element, "BusinessAddressState", BusinessAddressState);
            XmlHelper.AppendTextElement(element, "BusinessAddressStreet", BusinessAddressStreet);
            XmlHelper.AppendTextElement(element, "BusinessAddressPostOfficeBox", BusinessAddressPostOfficeBox);
            XmlHelper.AppendTextElement(element, "HomeAddressCity", HomeAddressCity);
            XmlHelper.AppendTextElement(element, "HomeAddressCountry", HomeAddressCountry);
            XmlHelper.AppendTextElement(element, "HomeAddressPostalCode", HomeAddressPostalCode);
            XmlHelper.AppendTextElement(element, "HomeAddressState", HomeAddressState);
            XmlHelper.AppendTextElement(element, "HomeAddressStreet", HomeAddressStreet);
            XmlHelper.AppendTextElement(element, "HomeAddressPostOfficeBox", HomeAddressPostOfficeBox);
            XmlHelper.AppendTextElement(element, "Email1Address", Email1Address);
            XmlHelper.AppendTextElement(element, "Email2Address", Email2Address);
            XmlHelper.AppendTextElement(element, "Email3Address", Email3Address);
            XmlHelper.AppendTextElement(element, "IMAddress", IMAddress);
            XmlHelper.AppendTextElement(element, "HomePage", HomePage);
            XmlHelper.AppendTextElement(element, "HomePage2", HomePage2);
            XmlHelper.AppendTextElement(element, "AssistnameTelephoneNumber", AssistnameTelephoneNumber);
            XmlHelper.AppendTextElement(element, "BusinessFaxNumber", BusinessFaxNumber);
            XmlHelper.AppendTextElement(element, "BusinessTelephoneNumber", BusinessTelephoneNumber);
            XmlHelper.AppendTextElement(element, "Business2TelephoneNumber", Business2TelephoneNumber);
            XmlHelper.AppendTextElement(element, "CarTelephoneNumber", CarTelephoneNumber);
            XmlHelper.AppendTextElement(element, "CompanyMainTelephoneNumber", CompanyMainTelephoneNumber);
            XmlHelper.AppendTextElement(element, "HomeFaxNumber", HomeFaxNumber);
            XmlHelper.AppendTextElement(element, "HomeTelephoneNumber", HomeTelephoneNumber);
            XmlHelper.AppendTextElement(element, "Home2TelephoneNumber", Home2TelephoneNumber);
            XmlHelper.AppendTextElement(element, "MobileTelephoneNumber", MobileTelephoneNumber);
            XmlHelper.AppendTextElement(element, "PagerNumber", PagerNumber);
            XmlHelper.AppendTextElement(element, "RadioTelephoneNumber", RadioTelephoneNumber);
            XmlHelper.AppendTextElement(element, "CallbackTelephoneNumber", CallbackTelephoneNumber);
            XmlHelper.AppendTextElement(element, "ISDNNumber", ISDNNumber);
            XmlHelper.AppendTextElement(element, "OtherFaxNumber", OtherFaxNumber);
            XmlHelper.AppendTextElement(element, "PrimaryTelephoneNumber", PrimaryTelephoneNumber);
            XmlHelper.AppendTextElement(element, "TelexNumber", TelexNumber);
            XmlHelper.AppendTextElement(element, "HearingNumber", HearingNumber);
            XmlHelper.AppendTextElement(element, "OtherNumber", OtherNumber);
            element.AppendChild(Categories.BuildXmlElement(doc, "Categories"));

            return element;
        }
    }
}

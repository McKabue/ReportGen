using System.Xml.Serialization;

namespace AutoDocx.Tools
{
    [XmlRoot("AutoDocumentCustomXML", Namespace = "AutoDocumentCustomXML", IsNullable = false)]
    public class AutoDocumentCustomXML
    {
        public string AutoDocumentID { get; set; }

        public string AutoDocumentName { get; set; }
    }

    [XmlRoot("TemplateCustomXML", Namespace = "TemplateCustomXML", IsNullable = false)]
    public class TemplateCustomXML
    {
        public string TemplateID { get; set; }

        public string TemplateName { get; set; }
    }
}

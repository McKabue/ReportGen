//using Microsoft.VisualStudio.Tools.Applications.Runtime;
//using Office = Microsoft.Office.Core;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace AutoDocx.Tools
//{
//    public class XMLCustomParts
//    {
//        [Cached()]
//        public string employeeXMLPartID = string.Empty;
//        private Office.CustomXMLPart _customXMLPart;
//        private const string prefix = "xmlns:ns='http://schemas.microsoft.com/vsto/samples'";
//        private string GetXmlFromResource()
//        {
//           // System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();System.IO.Stream stream1 = asm.GetManifestResourceStream("EmployeeControls.employees.xml");

//            using (System.IO.StreamReader resourceReader = new System.IO.StreamReader(stream1))
//            {
//                if (resourceReader != null)
//                {
//                    return resourceReader.ReadToEnd();
//                }
//            }

//            return null;
//        }
//        private void AddCustomXmlPart(string xmlData)
//        {
//            if (xmlData != null)
//            {
//                _customXMLPart = Globals.ThisAddIn.Application.ActiveDocument.CustomXMLParts.SelectByID(employeeXMLPartID);
//                if (_customXMLPart == null)
//                {
//                    _customXMLPart = Globals.ThisAddIn.Application.ActiveDocument.CustomXMLParts.Add(xmlData);
//                    _customXMLPart.NamespaceManager.AddNamespace("ns",
//                        @"http://schemas.microsoft.com/vsto/samples");
//                    employeeXMLPartID = _customXMLPart.Id;
//                }
//            }
//        }

//        private void BindControlsToCustomXmlPart()
//        {
//            string xPathName = "ns:employees/ns:employee/ns:name";
//            this.plainTextContentControl1.XMLMapping.SetMapping(xPathName,
//                prefix, _customXMLPart);

//            string xPathDate = "ns:employees/ns:employee/ns:hireDate";
//            this.datePickerContentControl1.DateDisplayFormat = "MMMM d, yyyy";
//            this.datePickerContentControl1.XMLMapping.SetMapping(xPathDate,
//                prefix, _customXMLPart);

//            string xPathTitle = "ns:employees/ns:employee/ns:title";
//            this.dropDownListContentControl1.XMLMapping.SetMapping(xPathTitle,
//                prefix, _customXMLPart);
//        }
//    }
//}

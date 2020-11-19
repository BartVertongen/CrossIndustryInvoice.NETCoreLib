
using System;
using System.Xml.Serialization;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:100")]
	public class TextType
	{
		[XmlAttribute(DataType = "token")]
		public string languageID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string languageLocaleID { get; set; }

		[XmlText()]
		public string Value { get; set; }
	}
}

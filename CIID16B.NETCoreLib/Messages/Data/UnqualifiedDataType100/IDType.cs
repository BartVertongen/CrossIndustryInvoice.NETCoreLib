
using System;
using System.Xml.Serialization;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:100")]
	public class IDType
	{
		[XmlAttribute(DataType = "token")]
		public string schemeID { get; set; }

		[XmlAttribute()]
		public string schemeName { get; set; }

		[XmlAttribute(DataType = "token")]
		public string schemeAgencyID { get; set; }

		[XmlAttribute()]
		public string schemeAgencyName { get; set; }

		[XmlAttribute(DataType = "token")]
		public string schemeVersionID { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string schemeDataURI { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string schemeURI { get; set; }

		[XmlText(DataType = "token")]
		public string Value { get; set; }
	}
}

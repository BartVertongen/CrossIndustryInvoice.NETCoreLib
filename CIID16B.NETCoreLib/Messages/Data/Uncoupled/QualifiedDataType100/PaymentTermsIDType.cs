
using System;
using System.Xml.Serialization;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:QualifiedDataType:100")]
	public class PaymentTermsIDType
	{
		[XmlAttribute(DataType = "token")]
		public string schemeID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string schemeAgencyID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string schemeVersionID { get; set; }

		[XmlText(DataType = "token")]
		public string Value { get; set; }
	}
}

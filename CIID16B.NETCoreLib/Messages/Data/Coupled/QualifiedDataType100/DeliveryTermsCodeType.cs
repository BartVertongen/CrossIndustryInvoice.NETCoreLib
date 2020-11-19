
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Codelists.Coupled;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:QualifiedDataType:100")]
	public class DeliveryTermsCodeType
	{
		public DeliveryTermsCodeType()
		{
			this.listID = "4053";
			this.listAgencyID = DeliveryTermsCodeListAgencyIDContentType.Item6;
			this.listVersionID = "2010";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public DeliveryTermsCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlText()]
		public DeliveryTermsCodeContentType Value { get; set; }
	}
}

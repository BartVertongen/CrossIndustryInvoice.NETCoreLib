
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Codelists.Coupled;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:QualifiedDataType:100")]
	public class PriceTypeCodeType
	{
		public PriceTypeCodeType()
		{
			this.listID = "5375";
			this.listAgencyID = PriceTypeCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D16A";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public PriceTypeCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlText()]
		public PriceTypeCodeContentType Value { get; set; }
	}
}

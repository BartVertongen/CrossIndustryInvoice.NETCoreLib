
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Codelists.Coupled;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:QualifiedDataType:100")]
	public class PackageTypeCodeType
	{
		public PackageTypeCodeType()
		{
			this.listID = "7065";
			this.listAgencyID = PackageTypeCodeListAgencyIDContentType.Item6;
			this.listVersionID = "2006";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public PackageTypeCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute()]
		public string name { get; set; }

		[XmlText()]
		public PackageTypeCodeContentType Value { get; set; }
	}
}

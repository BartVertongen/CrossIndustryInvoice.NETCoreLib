
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Codelists.Coupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.Invoice13;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType20
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:20")]
	public class FileSizeUnitMeasureType
	{
		[XmlAttribute()]
		public MeasurementUnitCommonCodeFileSizeContentType unitCode { get; set; }

		[XmlIgnore()]
		public bool unitCodeSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string unitCodeListVersionID { get; set; }

		[XmlText()]
		public decimal Value { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:20")]
	public class MIMECodeType
	{
		[XmlAttribute()]
		public MIMECodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute()]
		public string listName { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		[XmlText(DataType = "token")]
		public string Value { get; set; }
	}


	[System.Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:20")]
	public enum MIMECodeListAgencyIDContentType
	{
		[XmlEnum("379")]
		Item379,
	}
}

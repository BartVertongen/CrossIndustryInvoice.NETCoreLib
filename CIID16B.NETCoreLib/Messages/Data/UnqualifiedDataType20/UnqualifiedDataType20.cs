
using System;
using System.Xml.Serialization;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType20
{
	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:20")]
	public class IDType
	{
		[XmlAttribute(DataType = "token")]
		public string schemeID { get; set; }

		[XmlAttribute()]
		public string schemeName { get; set; }

		[XmlAttributeAttribute(DataType = "token")]
		public string schemeAgencyID { get; set; }

		[XmlAttributeAttribute()]
		public string schemeAgencyName { get; set; }

		[XmlAttributeAttribute(DataType = "token")]
		public string schemeVersionID { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string schemeDataURI { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string schemeURI { get; set; }

		[XmlText(DataType = "token")]
		public string Value { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:20")]
	public partial class DateTimeType
	{
		[XmlElement("DateTime", typeof(System.DateTime))]
		[XmlElement("DateTimeString", typeof(DateTimeTypeDateTimeString))]
		public object Item { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:20")]
	public class DateTimeTypeDateTimeString
	{
		[XmlAttribute()]
		public string format { get; set; }

		[XmlText()]
		public string Value { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:20")]
	public class MeasureType
	{
		[XmlAttribute(DataType = "token")]
		public string unitCode { get; set; }

		[XmlAttribute(DataType = "token")]
		public string unitCodeListVersionID { get; set; }

		[XmlText()]
		public decimal Value { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:20")]
	public class TextType
	{
		[XmlAttribute(DataType = "token")]
		public string languageID { get; set; }

		[XmlAttributeAttribute(DataType = "token")]
		public string languageLocaleID { get; set; }

		[XmlText()]
		public string Value { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:20")]
	public class CodeType
	{
		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listAgencyID { get; set; }

		[XmlAttribute()]
		public string listAgencyName { get; set; }

		[XmlAttributeAttribute()]
		public string listName { get; set; }

		[XmlAttributeAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute()]
		public string name { get; set; }

		[XmlAttributeAttribute(DataType = "token")]
		public string languageID { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string listSchemeURI { get; set; }

		[XmlText(DataType = "token")]
		public string Value { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:20")]
	public class BinaryObjectType
	{
		[XmlAttributeAttribute()]
		public string format { get; set; }

		[XmlAttributeAttribute(DataType = "token")]
		public string mimeCode { get; set; }

		[XmlAttributeAttribute(DataType = "token")]
		public string encodingCode { get; set; }

		[XmlAttributeAttribute(DataType = "token")]
		public string characterSetCode { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string uri { get; set; }

		[XmlAttribute()]
		public string filename { get; set; }

		[XmlText(DataType = "base64Binary")]
		public byte[] Value { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:20")]
	public class QuantityType
	{
		[XmlAttribute(DataType = "token")]
		public string unitCode { get; set; }

		[XmlAttribute(DataType = "token")]
		public string unitCodeListID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string unitCodeListAgencyID { get; set; }

		[XmlAttribute()]
		public string unitCodeListAgencyName { get; set; }

		[XmlText()]
		public decimal Value { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:20")]
	public class PercentType
	{
		[XmlAttribute()]
		public string format { get; set; }

		[XmlText()]
		public decimal Value { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:20")]
	public class RateType
	{
		[XmlAttribute()]
		public string format { get; set; }

		[XmlText()]
		public decimal Value { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:20")]
	public partial class DateType
	{

		[XmlElement("Date", typeof(System.DateTime), DataType = "date")]
		[XmlElement("DateString", typeof(DateTypeDateString))]
		public object Item { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:20")]
	public class DateTypeDateString
	{
		[XmlAttribute()]
		public string format { get; set; }

		[XmlText()]
		public string Value { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:20")]
	public partial class IndicatorType
	{
		[XmlElement("Indicator", typeof(bool))]
		[XmlElement("IndicatorString", typeof(IndicatorTypeIndicatorString))]
		public object Item { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:20")]
	public partial class IndicatorTypeIndicatorString
	{

		[XmlAttribute()]
		public string format { get; set; }

		[XmlText()]
		public string Value { get; set; }
	}



}

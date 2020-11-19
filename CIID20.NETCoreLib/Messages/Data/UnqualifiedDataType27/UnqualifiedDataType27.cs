
using System.Xml.Serialization;
using System;


namespace VertSoft.CrossIndustryInvoice.D20.Messages.Data.UnqualifiedDataType27
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:27")]
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


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:27")]
	public class TextType
	{
		[XmlAttribute(DataType = "token")]
		public string languageID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string languageLocaleID { get; set; }

		[XmlText()]
		public string Value { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:27")]
	public class CodeType
	{
		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listAgencyID { get; set; }

		[XmlAttribute()]
		public string listAgencyName { get; set; }

		[XmlAttribute()]
		public string listName { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute()]
		public string name { get; set; }

		[XmlAttribute(DataType = "token")]
		public string languageID { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string listSchemeURI { get; set; }

		[XmlText(DataType = "token")]
		public string Value { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:27")]
	public class BinaryObjectType
	{
		[XmlAttribute()]
		public string format { get; set; }

		[XmlAttribute(DataType = "token")]
		public string mimeCode { get; set; }

		[XmlAttribute(DataType = "token")]
		public string encodingCode { get; set; }

		[XmlAttribute(DataType = "token")]
		public string characterSetCode { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string uri { get; set; }

		[XmlAttribute()]
		public string filename { get; set; }

		[XmlText(DataType = "base64Binary")]
		public byte[] Value { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:27")]
	public class DateTimeType
	{
		[XmlElement("DateTime", typeof(System.DateTime))]
		[XmlElement("DateTimeString", typeof(DateTimeTypeDateTimeString))]
		public object Item { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:27")]
	public class DateTimeTypeDateTimeString
	{
		[XmlAttribute()]
		public string format { get; set; }

		[XmlText()]
		public string Value { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:27")]
	public class MeasureType
	{
		[XmlAttribute(DataType = "token")]
		public string unitCode { get; set; }

		[XmlAttribute(DataType = "token")]
		public string unitCodeListVersionID { get; set; }

		[XmlText()]
		public decimal Value { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:27")]
	public class ValueType
	{
		[XmlAttribute()]
		public string format { get; set; }

		[XmlText()]
		public decimal Value { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:27")]
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


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:27")]
	public class PercentType
	{
		[XmlAttribute()]
		public string format { get; set; }

		[XmlText()]
		public decimal Value { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:27")]
	public class AmountType
	{
		[XmlAttribute(DataType = "token")]
		public string currencyID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string currencyCodeListVersionID { get; set; }

		[XmlText()]
		public decimal Value { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:27")]
	public class IndicatorType
	{
		[XmlElement("Indicator", typeof(bool))]
		[XmlElement("IndicatorString", typeof(IndicatorTypeIndicatorString))]
		public object Item { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:27")]
	public class IndicatorTypeIndicatorString
	{
		[XmlAttribute()]
		public string format { get; set; }

		[XmlText()]
		public string Value { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:27")]
	public class RateType
	{
		[XmlAttribute()]
		public string format { get; set; }

		[XmlText()]
		public decimal Value { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:27")]
	public class DateType
	{
		[XmlElement("Date", typeof(System.DateTime), DataType = "date")]
		[XmlElement("DateString", typeof(DateTypeDateString))]
		public object Item { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:27")]
	public class DateTypeDateString
	{

		[XmlAttribute()]
		public string format { get; set; }

		[XmlText()]
		public string Value { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:27")]
	public class NumericType
	{
		[XmlAttribute()]
		public string format { get; set; }

		[XmlText()]
		public decimal Value { get; set; }
	}


}

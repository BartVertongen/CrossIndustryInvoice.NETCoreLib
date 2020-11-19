
using System.Xml.Serialization;
using System;
using VertSoft.CrossIndustryInvoice.D20.Messages.Codelists;
using VertSoft.CrossIndustryInvoice.D20.Messages.CrossIndustryInvoice19;


namespace VertSoft.CrossIndustryInvoice.D20.Messages.Data.QualifiedDataType27
{


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class TransportMovementStageCodeType
	{
		public TransportMovementStageCodeType()
		{
			this.listID = "8051";
			this.listAgencyID = TransportMovementStageCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public TransportMovementStageCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute()]
		public string name { get; set; }

		[XmlText()]
		public TransportMovementStageCodeContentType Value { get; set; }
	}



	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum TransportMovementStageCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}



	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
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


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
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


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum MIMECodeListAgencyIDContentType
	{
		[XmlEnumAttribute("379")]
		Item379,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class CurrencyCodeType
	{
		public CurrencyCodeType()
		{
			this.listID = "ISO 4217 3A";
			this.listAgencyID = CurrencyCodeListAgencyIDContentType.Item5;
			this.listVersionID = "2012-08-31";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public CurrencyCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		[XmlText()]
		public ISO3AlphaCurrencyCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum CurrencyCodeListAgencyIDContentType
	{
		[XmlEnum("5")]
		Item5,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class TaxTypeCodeType
	{
		public TaxTypeCodeType()
		{
			this.listID = "5153";
			this.listAgencyID = TaxTypeCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public TaxTypeCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		[XmlText()]
		public DutyTaxFeeTypeCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum TaxTypeCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class TaxCategoryCodeType
	{
		public TaxCategoryCodeType()
		{
			this.listID = "5305";
			this.listAgencyID = TaxCategoryCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public TaxCategoryCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		[XmlText()]
		public DutyorTaxorFeeCategoryCodeContentType Value { get; set; }

	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum TaxCategoryCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class TimeReferenceCodeType
	{
		public TimeReferenceCodeType()
		{
			this.listID = "2475";
			this.listAgencyID = TimeReferenceCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public TimeReferenceCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute()]
		public string name { get; set; }

		[XmlText()]
		public EventTimeReferenceCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum TimeReferenceCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:EventTimeReferenceCode:D19B")]
	[XmlRoot("EventTimeReferenceCode", Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:EventTimeReferenceCode:D19B", IsNullable = false)]
	public enum EventTimeReferenceCodeContentType
	{
		[XmlEnum("1")]
		Item1,
		[XmlEnum("2")]
		Item2,
		[XmlEnum("3")]
		Item3,
		[XmlEnum("4")]
		Item4,
		[XmlEnum("5")]
		Item5,
		[XmlEnum("6")]
		Item6,
		[XmlEnum("7")]
		Item7,
		[XmlEnum("8")]
		Item8,
		[XmlEnum("9")]
		Item9,
		[XmlEnum("10")]
		Item10,
		[XmlEnum("11")]
		Item11,
		[XmlEnum("12")]
		Item12,
		[XmlEnum("13")]
		Item13,
		[XmlEnum("14")]
		Item14,
		[XmlEnum("21")]
		Item21,
		[XmlEnum("22")]
		Item22,
		[XmlEnum("23")]
		Item23,
		[XmlEnum("24")]
		Item24,
		[XmlEnum("25")]
		Item25,
		[XmlEnum("26")]
		Item26,
		[XmlEnum("27")]
		Item27,
		[XmlEnum("28")]
		Item28,
		[XmlEnum("29")]
		Item29,
		[XmlEnum("31")]
		Item31,
		[XmlEnum("32")]
		Item32,
		[XmlEnum("33")]
		Item33,
		[XmlEnum("41")]
		Item41,
		[XmlEnum("42")]
		Item42,
		[XmlEnum("43")]
		Item43,
		[XmlEnum("44")]
		Item44,
		[XmlEnum("45")]
		Item45,
		[XmlEnum("46")]
		Item46,
		[XmlEnum("47")]
		Item47,
		[XmlEnum("48")]
		Item48,
		[XmlEnum("52")]
		Item52,
		[XmlEnum("53")]
		Item53,
		[XmlEnum("54")]
		Item54,
		[XmlEnum("55")]
		Item55,
		[XmlEnum("56")]
		Item56,
		[XmlEnum("57")]
		Item57,
		[XmlEnum("60")]
		Item60,
		[XmlEnum("61")]
		Item61,
		[XmlEnum("62")]
		Item62,
		[XmlEnum("63")]
		Item63,
		[XmlEnum("64")]
		Item64,
		[XmlEnum("65")]
		Item65,
		[XmlEnum("66")]
		Item66,
		[XmlEnum("67")]
		Item67,
		[XmlEnum("68")]
		Item68,
		[XmlEnum("69")]
		Item69,
		[XmlEnum("70")]
		Item70,
		[XmlEnum("71")]
		Item71,
		[XmlEnum("72")]
		Item72,
		[XmlEnum("73")]
		Item73,
		[XmlEnum("74")]
		Item74,
		[XmlEnum("75")]
		Item75,
		[XmlEnum("76")]
		Item76,
		[XmlEnum("77")]
		Item77,
		[XmlEnum("78")]
		Item78,
		[XmlEnum("79")]
		Item79,
		[XmlEnum("80")]
		Item80,
		[XmlEnum("81")]
		Item81,
		[XmlEnum("82")]
		Item82,
		[XmlEnum("83")]
		Item83,
		ZZZ,
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class AccountingDocumentCodeType
	{
		public AccountingDocumentCodeType()
		{
			this.listID = "1001_Accounting";
			this.listAgencyID = AccountingDocumentCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public AccountingDocumentCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		[XmlText()]
		public DocumentNameCodeAccountingContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum AccountingDocumentCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class AccountingAccountTypeCodeType
	{
		public AccountingAccountTypeCodeType()
		{
			this.listID = "AccountingE501";
			this.listAgencyID = "210";
			this.listVersionID = "D11A";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listAgencyID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		[XmlText()]
		public AccountingAccountTypeContentType Value { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class AccountingAmountTypeCodeType
	{
		public AccountingAmountTypeCodeType()
		{
			this.listID = "AccountingE601";
			this.listAgencyID = "210";
			this.listVersionID = "D11A";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listAgencyID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		[XmlText()]
		public AccountingAmountTypeContentType Value { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class CountryIDType
	{
		public CountryIDType()
		{
			this.schemeVersionID = "second edition 2006";
		}

		[XmlAttribute(DataType = "token")]
		public string schemeID { get; set; }

		[XmlAttribute()]
		public CountryIDSchemeAgencyIDContentType schemeAgencyID { get; set; }

		[XmlIgnore()]
		public bool schemeAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string schemeVersionID { get; set; }

		[XmlText()]
		public ISOTwoletterCountryCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum CountryIDSchemeAgencyIDContentType
	{
		[XmlEnum("5")]
		Item5,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
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


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum PackageTypeCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class WeightUnitMeasureType
	{
		[XmlAttribute()]
		public MeasurementUnitCommonCodeWeightContentType unitCode { get; set; }

		[XmlIgnore()]
		public bool unitCodeSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string unitCodeListVersionID { get; set; }

		[XmlText()]
		public decimal Value { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class DimensionTypeCodeType
	{
		public DimensionTypeCodeType()
		{
			this.listID = "6145";
			this.listAgencyID = DimensionTypeCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public DimensionTypeCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute()]
		public string name { get; set; }

		[XmlText()]
		public DimensionTypeCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum DimensionTypeCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class LinearUnitMeasureType
	{
		[XmlAttribute()]
		public MeasurementUnitCommonCodeLinearContentType unitCode { get; set; }

		[XmlIgnore()]
		public bool unitCodeSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string unitCodeListVersionID { get; set; }

		[XmlText()]
		public decimal Value { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class PackagingMarkingCodeType
	{
		public PackagingMarkingCodeType()
		{
			this.listID = "7233_PackagingMarkingCode";
			this.listAgencyID = PackagingMarkingCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public PackagingMarkingCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		[XmlText()]
		public PackagingMarkingCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum PackagingMarkingCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class AutomaticDataCaptureMethodCodeType
	{
		public AutomaticDataCaptureMethodCodeType()
		{
			this.listID = "7233_AutomaticDataCaptureMethodCode";
			this.listAgencyID = AutomaticDataCaptureMethodCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public AutomaticDataCaptureMethodCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		[XmlText()]
		public AutomaticDataCaptureMethodCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum AutomaticDataCaptureMethodCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class DocumentStatusCodeType
	{
		public DocumentStatusCodeType()
		{
			this.listID = "1373";
			this.listAgencyID = DocumentStatusCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public DocumentStatusCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute()]
		public string name { get; set; }

		[XmlText()]
		public DocumentStatusCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum DocumentStatusCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class ReferenceCodeType
	{
		public ReferenceCodeType()
		{
			this.listID = "1153_ReferenceTypeCode";
			this.listAgencyID = ReferenceCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public ReferenceCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute()]
		public string name { get; set; }

		[XmlText()]
		public ReferenceTypeCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum ReferenceCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class DocumentCodeType
	{
		public DocumentCodeType()
		{
			this.listID = "1001";
			this.listAgencyID = DocumentCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public DocumentCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute()]
		public string name { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		[XmlText()]
		public DocumentNameCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum DocumentCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class MessageFunctionCodeType
	{
		public MessageFunctionCodeType()
		{
			this.listID = "1225_MessageFunctionTypeCode";
			this.listAgencyID = MessageFunctionCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public MessageFunctionCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		[XmlText()]
		public MessageFunctionCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum MessageFunctionCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class PartyRoleCodeType
	{
		public PartyRoleCodeType()
		{
			this.listID = "3035";
			this.listAgencyID = PartyRoleCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public PartyRoleCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute()]
		public string name { get; set; }

		[XmlText()]
		public PartyRoleCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum PartyRoleCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class ContactTypeCodeType
	{
		public ContactTypeCodeType()
		{
			this.listID = "3139_ContactTypeCode";
			this.listAgencyID = ContactTypeCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		/// <remarks/>
		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		/// <remarks/>
		[XmlAttribute()]
		public ContactTypeCodeListAgencyIDContentType listAgencyID { get; set; }

		/// <remarks/>
		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		/// <remarks/>
		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		/// <remarks/>
		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		/// <remarks/>
		[XmlText()]
		public ContactFunctionCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum ContactTypeCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class CommunicationChannelCodeType
	{
		public CommunicationChannelCodeType()
		{
			this.listID = "3155_CommunicationChannelCode";
			this.listAgencyID = CommunicationChannelCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		/// <remarks/>
		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		/// <remarks/>
		[XmlAttribute()]
		public CommunicationChannelCodeListAgencyIDContentType listAgencyID { get; set; }

		/// <remarks/>
		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		/// <remarks/>
		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		/// <remarks/>
		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		/// <remarks/>
		[XmlText()]
		public CommunicationMeansTypeCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum CommunicationChannelCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class SubjectCodeType
	{
		public SubjectCodeType()
		{
			this.listID = "4451";
			this.listAgencyID = SubjectCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D10A";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public SubjectCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		[XmlText(DataType = "token")]
		public string Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum SubjectCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class LocationFunctionCodeType
	{
		public LocationFunctionCodeType()
		{
			this.listID = "3227";
			this.listAgencyID = LocationFunctionCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public LocationFunctionCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute()]
		public string name { get; set; }

		[XmlText()]
		public LocationFunctionCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum LocationFunctionCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class PriceTypeCodeType
	{
		public PriceTypeCodeType()
		{
			this.listID = "5375";
			this.listAgencyID = PriceTypeCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
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


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum PriceTypeCodeListAgencyIDContentType
	{

		[XmlEnum("6")]
		Item6,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class AllowanceChargeReasonCodeType
	{
		public AllowanceChargeReasonCodeType()
		{
			this.listID = "4465_AllowanceChargeReasonCode";
			this.listAgencyID = AllowanceChargeReasonCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public AllowanceChargeReasonCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		[XmlText()]
		public AllowanceChargeReasonCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum AllowanceChargeReasonCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class AllowanceChargeIdentificationCodeType
	{
		public AllowanceChargeIdentificationCodeType()
		{
			this.listID = "5189_AllowanceChargeID";
			this.listAgencyID = "6";
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listAgencyID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		[XmlText()]
		public AllowanceChargeIdentificationCodeContentType Value { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class TimeOnlyFormattedDateTimeType
	{
		public TimeOnlyFormattedDateTimeTypeDateTimeString DateTimeString { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class TimeOnlyFormattedDateTimeTypeDateTimeString
	{
		[XmlAttribute()]
		public TimeOnlyFormatCodeContentType format { get; set; }

		[XmlIgnore()]
		public bool formatSpecified { get; set; }

		[XmlText()]
		public string Value { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class FreightChargeTypeIDType
	{
		[XmlAttribute(DataType = "token")]
		public string schemeID { get; set; }

		[XmlAttribute()]
		public FreightChargeTypeIDSchemeAgencyIDContentType schemeAgencyID { get; set; }

		/// <remarks/>
		[XmlIgnore()]
		public bool schemeAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string schemeVersionID { get; set; }

		[XmlText()]
		public FreightCostCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum FreightChargeTypeIDSchemeAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class TransportServicePaymentArrangementCodeType
	{
		public TransportServicePaymentArrangementCodeType()
		{
			this.listID = "4237_TransportPaymentArrangementCode";
			this.listAgencyID = TransportServicePaymentArrangementCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public TransportServicePaymentArrangementCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute()]
		public string name { get; set; }

		[XmlText()]
		public TransportPaymentArrangementCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum TransportServicePaymentArrangementCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class FreightChargeTariffClassCodeType
	{
		public FreightChargeTariffClassCodeType()
		{
			this.listID = "5243";
			this.listAgencyID = FreightChargeTariffClassCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public FreightChargeTariffClassCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute()]
		public string name { get; set; }

		[XmlText()]
		public FreightChargeTariffCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum FreightChargeTariffClassCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class ChargePayingPartyRoleCodeType
	{
		public ChargePayingPartyRoleCodeType()
		{
			this.listID = "3035_Charge Paying";
			this.listAgencyID = ChargePayingPartyRoleCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public ChargePayingPartyRoleCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute()]
		public string name { get; set; }

		[XmlText()]
		public PartyRoleCodeChargePayingContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum ChargePayingPartyRoleCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class LogisticsChargeCalculationBasisCodeType
	{
		public LogisticsChargeCalculationBasisCodeType()
		{
			this.listID = "6131";
			this.listAgencyID = "6";
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listAgencyID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute()]
		public string name { get; set; }

		[XmlText()]
		public FreightChargeQuantityUnitBasisCodeContentType Value { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class PaymentTermsIDType
	{
		[XmlAttribute(DataType = "token")]
		public string schemeID { get; set; }

		[XmlAttribute()]
		public PaymentTermsIDSchemeAgencyIDContentType schemeAgencyID { get; set; }

		[XmlIgnore()]
		public bool schemeAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string schemeVersionID { get; set; }

		[XmlText()]
		public PaymentTermsDescriptionIdentifierContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum PaymentTermsIDSchemeAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class PaymentTermsEventTimeReferenceCodeType
	{
		public PaymentTermsEventTimeReferenceCodeType()
		{
			this.listID = "2475_Payment Terms Event";
			this.listAgencyID = PaymentTermsEventTimeReferenceCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		/// <remarks/>
		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		/// <remarks/>
		[XmlAttribute()]
		public PaymentTermsEventTimeReferenceCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlText()]
		public EventTimeReferenceCodePaymentTermsEventContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum PaymentTermsEventTimeReferenceCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class PaymentTermsTypeCodeType
	{
		public PaymentTermsTypeCodeType()
		{
			this.listID = "4279";
			this.listAgencyID = PaymentTermsTypeCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public PaymentTermsTypeCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute()]
		public string name { get; set; }

		[XmlText()]
		public PaymentTermsTypeCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum PaymentTermsTypeCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class FinancialAdjustmentReasonCodeType
	{
		public FinancialAdjustmentReasonCodeType()
		{
			this.listID = "4465_AdjustmentReasonCode_Financial";
			this.listAgencyID = FinancialAdjustmentReasonCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		/// <remarks/>
		[XmlAttribute()]
		public FinancialAdjustmentReasonCodeListAgencyIDContentType listAgencyID { get; set; }

		/// <remarks/>
		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlText()]
		public AdjustmentReasonDescriptionCodeFinancialContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum FinancialAdjustmentReasonCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class AdjustmentReasonCodeType
	{
		public AdjustmentReasonCodeType()
		{
			this.listID = "4465";
			this.listAgencyID = AdjustmentReasonCodeListAgencyIDContentType.Item6;
			this.listVersionID = "D19B";
		}

		/// <remarks/>
		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		/// <remarks/>
		[XmlAttribute()]
		public AdjustmentReasonCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlText()]
		public AdjustmentReasonDescriptionCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum AdjustmentReasonCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class VolumeUnitMeasureType
	{
		[XmlAttribute()]
		public MeasurementUnitCommonCodeVolumeContentType unitCode { get; set; }

		[XmlIgnore()]
		public bool unitCodeSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string unitCodeListVersionID { get; set; }

		[XmlText()]
		public decimal Value { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public class TransportModeCodeType
	{
		public TransportModeCodeType()
		{
			this.listID = "Recommendation 19";
			this.listAgencyID = TransportModeCodeListAgencyIDContentType.Item6;
			this.listVersionID = "2";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute()]
		public TransportModeCodeListAgencyIDContentType listAgencyID { get; set; }

		[XmlIgnore()]
		public bool listAgencyIDSpecified { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlAttribute()]
		public string name { get; set; }

		[XmlText()]
		public TransportModeCodeContentType Value { get; set; }
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:Standard:QualifiedDataType:27")]
	public enum TransportModeCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}
}

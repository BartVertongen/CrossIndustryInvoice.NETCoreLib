
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.Invoice13;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType20;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType20;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity20
{

	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:20")]
	[XmlRoot("CIExchangedDocumentContext", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:20", IsNullable = false)]
	public class CIExchangedDocumentContextType
	{
		public IDType SpecifiedTransactionID { get; set; }

		[XmlElement("BusinessProcessSpecifiedCIDocumentContextParameter")]
		public CIDocumentContextParameterType[] BusinessProcessSpecifiedCIDocumentContextParameter { get; set; }


		[XmlElement("BIMSpecifiedCIDocumentContextParameter")]
		public CIDocumentContextParameterType[] BIMSpecifiedCIDocumentContextParameter { get; set; }


		[XmlElement("ScenarioSpecifiedCIDocumentContextParameter")]
		public CIDocumentContextParameterType[] ScenarioSpecifiedCIDocumentContextParameter { get; set; }


		[XmlElement("ApplicationSpecifiedCIDocumentContextParameter")]
		public CIDocumentContextParameterType[] ApplicationSpecifiedCIDocumentContextParameter { get; set; }


		[XmlElement("GuidelineSpecifiedCIDocumentContextParameter")]
		public CIDocumentContextParameterType[] GuidelineSpecifiedCIDocumentContextParameter { get; set; }


		[XmlElement("SubsetSpecifiedCIDocumentContextParameter")]
		public CIDocumentContextParameterType[] SubsetSpecifiedCIDocumentContextParameter { get; set; }

		public CIDocumentContextParameterType MessageStandardSpecifiedCIDocumentContextParameter { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:20")]
	[XmlRoot("SpecificationResponse", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:20", IsNullable = false)]
	public class SpecificationResponseType
	{
		public IDType ID { get; set; }

		public IDType QueryID { get; set; }

		public CodeType TypeCode { get; set; }

		public TextType Content { get; set; }

		public CodeType ContractualLanguageCode { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:20")]
	[XmlRoot("SpecificationQuery", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:20", IsNullable = false)]
	public class SpecificationQueryType
	{
		public IDType ID { get; set; }

		public CodeType TypeCode { get; set; }

		public TextType Content { get; set; }

		public CodeType ContractualLanguageCode { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:20")]
	[XmlRoot("WorkItemComplexDescription", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:20", IsNullable = false)]
	public class WorkItemComplexDescriptionType
	{

		[XmlElement("Abstract")]
		public TextType[] Abstract { get; set; }

		[XmlElement("Content")]
		public TextType[] Content { get; set; }

		public CodeType ContractualLanguageCode { get; set; }

		[XmlElement("RequestingSpecificationQuery")]
		public SpecificationQueryType[] RequestingSpecificationQuery { get; set; }

		[XmlElement("RespondingSpecificationResponse")]
		public SpecificationResponseType[] RespondingSpecificationResponse { get; set; }

		public WorkItemComplexDescriptionType SubsetWorkItemComplexDescription { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:20")]
	[XmlRoot("DelimitedPeriod", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:20", IsNullable = false)]
	public class DelimitedPeriodType
	{
		public DateTimeType StartDateTime { get; set; }

		public DateTimeType EndDateTime { get; set; }

		public MeasureType DurationMeasure { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:20")]
	[XmlRoot("IdentifiedBinaryFile", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:20", IsNullable = false)]
	public class IdentifiedBinaryFileType
	{
		[XmlElement("ID")]
		public IDType[] ID { get; set; }

		[XmlElement("Title")]
		public TextType[] Title { get; set; }

		[XmlElement("AuthorName")]
		public TextType[] AuthorName { get; set; }

		[XmlElement("VersionID")]
		public IDType[] VersionID { get; set; }

		public TextType FileName { get; set; }

		[XmlElement("URIID")]
		public IDType[] URIID { get; set; }

		public MIMECodeType MIMECode { get; set; }

		public CodeType EncodingCode { get; set; }

		public CodeType CharacterSetCode { get; set; }

		public BinaryObjectType IncludedBinaryObject { get; set; }

		[XmlElement("Access")]
		public TextType[] Access { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		public FileSizeUnitMeasureType SizeMeasure { get; set; }

		[XmlElement("AccessAvailabilityDelimitedPeriod")]
		public DelimitedPeriodType[] AccessAvailabilityDelimitedPeriod { get; set; }
	}





	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:20")]
	[XmlRoot("RecordedStatus", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:20", IsNullable = false)]
	public class RecordedStatusType
	{
		public CodeType ConditionCode { get; set; }

		public TextType ChangerName { get; set; }

		public DateTimeType ChangedDateTime { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:20")]
	[XmlRoot("WorkItemDimension", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:20" +
		"", IsNullable = false)]
	public class WorkItemDimensionType
	{
		public IDType ID { get; set; }

		public MeasureType ValueMeasure { get; set; }

		public TextType Description { get; set; }

		public CodeType TypeCode { get; set; }

		public CodeType ContractualLanguageCode { get; set; }

		[XmlElement("ComponentWorkItemDimension")]
		public WorkItemDimensionType[] ComponentWorkItemDimension { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:20" +
		"")]
	[XmlRootAttribute("WorkItemQuantityAnalysis", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:20" +
		"", IsNullable = false)]
	public class WorkItemQuantityAnalysisType
	{
		public IDType ID { get; set; }

		public QuantityType ActualQuantity { get; set; }

		public TextType Description { get; set; }

		public PercentType ActualQuantityPercent { get; set; }

		public CodeType StatusCode { get; set; }

		public CodeType TypeCode { get; set; }

		[XmlElement("PrimaryClassificationCode")]
		public CodeType[] PrimaryClassificationCode { get; set; }

		[XmlElement("AlternativeClassificationCode")]
		public CodeType[] AlternativeClassificationCode { get; set; }

		public CodeType ContractualLanguageCode { get; set; }

		[XmlElement("ActualQuantityWorkItemDimension")]
		public WorkItemDimensionType[] ActualQuantityWorkItemDimension { get; set; }

		[XmlElement("BreakdownWorkItemQuantityAnalysis")]
		public WorkItemQuantityAnalysisType[] BreakdownWorkItemQuantityAnalysis { get; set; }


		[XmlElement("ChangedRecordedStatus")]
		public RecordedStatusType[] ChangedRecordedStatus { get; set; }
	}



}
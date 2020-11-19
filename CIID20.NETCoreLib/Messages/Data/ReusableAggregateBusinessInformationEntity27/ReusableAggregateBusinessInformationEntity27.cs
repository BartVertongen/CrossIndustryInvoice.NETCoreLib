
using System.Xml.Serialization;
using System;
using VertSoft.CrossIndustryInvoice.D20.Messages.CrossIndustryInvoice19;
using VertSoft.CrossIndustryInvoice.D20.Messages.Data.QualifiedDataType27;
using VertSoft.CrossIndustryInvoice.D20.Messages.Data.UnqualifiedDataType27;
using ciiValueType = VertSoft.CrossIndustryInvoice.D20.Messages.Data.UnqualifiedDataType27.ValueType;


namespace VertSoft.CrossIndustryInvoice.D20.Messages.Data.ReusableAggregateBusinessInformationEntity27
{

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIExchangedDocumentContext", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIExchangedDocumentContextType
	{
		public IDType SpecifiedTransactionID { get; set; }


		public DateTimeType ProcessingTransactionDateTime { get; set; }


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


		[XmlElement("UserSpecifiedCIDocumentContextParameter")]
		public CIDocumentContextParameterType[] UserSpecifiedCIDocumentContextParameter { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("IdentifiedBinaryFile", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
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


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("DelimitedPeriod", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class DelimitedPeriodType
	{
		public DateTimeType StartDateTime { get; set; }

		public DateTimeType EndDateTime { get; set; }

		public MeasureType DurationMeasure { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("RecordedStatus", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class RecordedStatusType
	{
		public CodeType ConditionCode { get; set; }

		public TextType ChangerName { get; set; }

		public DateTimeType ChangedDateTime { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("WorkItemDimension", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
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


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("WorkItemQuantityAnalysis", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
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


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("WorkItemComplexDescription", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
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
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("BasicWorkItem", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class BasicWorkItemType
	{
		public IDType ID { get; set; }

		public IDType ReferenceID { get; set; }

		[XmlElement("PrimaryClassificationCode")]
		public CodeType[] PrimaryClassificationCode { get; set; }

		[XmlElement("AlternativeClassificationCode")]
		public CodeType[] AlternativeClassificationCode { get; set; }

		[XmlElement("TypeCode")]
		public CodeType[] TypeCode { get; set; }

		[XmlElement("Comment")]
		public TextType[] Comment { get; set; }

		public QuantityType TotalQuantity { get; set; }

		public CodeType TotalQuantityClassificationCode { get; set; }

		public ciiValueType IndexValue { get; set; }

		[XmlElement("StatusCode")]
		public CodeType[] StatusCode { get; set; }

		[XmlElement("ReferenceFileBinaryObject")]
		public BinaryObjectType[] ReferenceFileBinaryObject { get; set; }

		public TextType Index { get; set; }

		[XmlElement("RequestedActionCode")]
		public CodeType[] RequestedActionCode { get; set; }

		public IDType PriceListItemID { get; set; }

		public CodeType ContractualLanguageCode { get; set; }

		[XmlElement("ActualWorkItemComplexDescription")]
		public WorkItemComplexDescriptionType[] ActualWorkItemComplexDescription { get; set; }

		[XmlElement("TotalQuantityWorkItemQuantityAnalysis")]
		public WorkItemQuantityAnalysisType[] TotalQuantityWorkItemQuantityAnalysis { get; set; }

		[XmlElement("UnitCalculatedPrice")]
		public CalculatedPriceType[] UnitCalculatedPrice { get; set; }

		[XmlElement("TotalCalculatedPrice")]
		public CalculatedPriceType[] TotalCalculatedPrice { get; set; }

		[XmlElement("SubordinateBasicWorkItem")]
		public BasicWorkItemType[] SubordinateBasicWorkItem { get; set; }

		[XmlElement("ChangedRecordedStatus")]
		public RecordedStatusType[] ChangedRecordedStatus { get; set; }

		[XmlElement("ReferencedIdentifiedBinaryFile")]
		public IdentifiedBinaryFileType[] ReferencedIdentifiedBinaryFile { get; set; }

		[XmlElement("ItemBasicWorkItem")]
		public BasicWorkItemType[] ItemBasicWorkItem { get; set; }

		[XmlElement("ReferencedSpecifiedBinaryFile")]
		public SpecifiedBinaryFileType[] ReferencedSpecifiedBinaryFile { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CalculatedPrice", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CalculatedPriceType
	{
		[XmlElement("TypeCode")]
		public CodeType[] TypeCode { get; set; }

		[XmlElement("ChargeAmount")]
		public AmountType[] ChargeAmount { get; set; }

		[XmlElement("RelatedAppliedAllowanceCharge")]
		public AppliedAllowanceChargeType[] RelatedAppliedAllowanceCharge { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("SpecificationResponse", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class SpecificationResponseType
	{
		public IDType ID { get; set; }

		public IDType QueryID { get; set; }

		public CodeType TypeCode { get; set; }

		public TextType Content { get; set; }

		public CodeType ContractualLanguageCode { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("SpecificationQuery", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class SpecificationQueryType
	{
		public IDType ID { get; set; }

		public CodeType TypeCode { get; set; }

		public TextType Content { get; set; }

		public CodeType ContractualLanguageCode { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("AppliedAllowanceCharge", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class AppliedAllowanceChargeType
	{
		public AmountType ActualAmount { get; set; }

		public TextType Description { get; set; }

		public CodeType ReasonCode { get; set; }

		public PercentType CalculationPercent { get; set; }

		public AmountType BasisAmount { get; set; }

		public IndicatorType ChargeIndicator { get; set; }

		public AppliedTaxType CategoryAppliedTax { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("AppliedTax", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class AppliedTaxType
	{
		public AmountType CalculatedAmount { get; set; }

		public CodeType TypeCode { get; set; }

		public RateType CalculatedRate { get; set; }

		public AmountType BasisAmount { get; set; }

		public DateType TaxPointDate { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("SpecifiedBinaryFile", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class SpecifiedBinaryFileType
	{
		[XmlElement("ID")]
		public IDType[] ID { get; set; }

		[XmlElement("Title")]
		public TextType[] Title { get; set; }

		[XmlElement("AuthorName")]
		public TextType[] AuthorName { get; set; }

		public IDType VersionID { get; set; }

		public TextType FileName { get; set; }

		public IDType URIID { get; set; }

		public CodeType MIMECode { get; set; }

		public CodeType EncodingCode { get; set; }

		public CodeType CharacterSetCode { get; set; }

		[XmlElement("IncludedBinaryObject")]
		public BinaryObjectType[] IncludedBinaryObject { get; set; }

		[XmlElement("Access")]
		public TextType[] Access { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		public MeasureType SizeMeasure { get; set; }

		public SpecifiedPeriodType AccessAvailabilitySpecifiedPeriod { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("SpecifiedPeriod", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class SpecifiedPeriodType
	{
		[XmlElement("DurationMeasure")]
		public MeasureType[] DurationMeasure { get; set; }

		public IndicatorType InclusiveIndicator { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		public DateTimeType StartDateTime { get; set; }

		public DateTimeType EndDateTime { get; set; }

		public DateTimeType CompleteDateTime { get; set; }

		public IndicatorType OpenIndicator { get; set; }

		public CodeType SeasonCode { get; set; }

		public IDType ID { get; set; }

		[XmlElement("Name")]
		public TextType[] Name { get; set; }

		[XmlElement("SequenceNumeric")]
		public NumericType[] SequenceNumeric { get; set; }

		public CodeType StartDateFlexibilityCode { get; set; }

		public IndicatorType ContinuousIndicator { get; set; }

		public CodeType PurposeCode { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("GroupedWorkItem", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class GroupedWorkItemType
	{
		public IDType ID { get; set; }

		[XmlElement("PrimaryClassificationCode")]
		public CodeType[] PrimaryClassificationCode { get; set; }

		[XmlElement("AlternativeClassificationCode")]
		public CodeType[] AlternativeClassificationCode { get; set; }

		[XmlElement("TypeCode")]
		public CodeType[] TypeCode { get; set; }

		[XmlElement("Comment")]
		public TextType[] Comment { get; set; }

		public QuantityType TotalQuantity { get; set; }

		public TextType Index { get; set; }

		[XmlElement("RequestedActionCode")]
		public CodeType[] RequestedActionCode { get; set; }

		public IDType PriceListItemID { get; set; }

		public CodeType ContractualLanguageCode { get; set; }

		[XmlElement("TotalCalculatedPrice")]
		public CalculatedPriceType[] TotalCalculatedPrice { get; set; }

		[XmlElement("ItemGroupedWorkItem")]
		public GroupedWorkItemType[] ItemGroupedWorkItem { get; set; }

		[XmlElement("ItemBasicWorkItem")]
		public BasicWorkItemType[] ItemBasicWorkItem { get; set; }

		[XmlElement("ChangedRecordedStatus")]
		public RecordedStatusType[] ChangedRecordedStatus { get; set; }

		[XmlElement("ReferencedIdentifiedBinaryFile")]
		public IdentifiedBinaryFileType[] ReferencedIdentifiedBinaryFile { get; set; }

		[XmlElement("ActualWorkItemComplexDescription")]
		public WorkItemComplexDescriptionType[] ActualWorkItemComplexDescription { get; set; }

		[XmlElement("ReferencedSpecifiedBinaryFile")]
		public SpecifiedBinaryFileType[] ReferencedSpecifiedBinaryFile { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("ValuationBreakdownStatement", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class ValuationBreakdownStatementType
	{
		public IDType ID { get; set; }

		public TextType Name { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		[XmlElement("MeasurementMethodID")]
		public IDType[] MeasurementMethodID { get; set; }

		public DateTimeType CreationDateTime { get; set; }

		public CurrencyCodeType DefaultCurrencyCode { get; set; }

		public CodeType DefaultLanguageCode { get; set; }

		[XmlElement("Comment")]
		public TextType[] Comment { get; set; }

		[XmlElement("TypeCode")]
		public CodeType[] TypeCode { get; set; }

		[XmlElement("RequestedActionCode")]
		public CodeType[] RequestedActionCode { get; set; }

		public IDType PriceListID { get; set; }

		public CodeType ContractualLanguageCode { get; set; }

		[XmlElement("ItemGroupedWorkItem")]
		public GroupedWorkItemType[] ItemGroupedWorkItem { get; set; }

		[XmlElement("ItemBasicWorkItem")]
		public BasicWorkItemType[] ItemBasicWorkItem { get; set; }

		[XmlElement("TotalCalculatedPrice")]
		public CalculatedPriceType[] TotalCalculatedPrice { get; set; }

		[XmlElement("CreationIdentifiedBinaryFile")]
		public IdentifiedBinaryFileType[] CreationIdentifiedBinaryFile { get; set; }

		[XmlElement("ReaderIdentifiedBinaryFile")]
		public IdentifiedBinaryFileType[] ReaderIdentifiedBinaryFile { get; set; }

		[XmlElement("ChangedRecordedStatus")]
		public RecordedStatusType[] ChangedRecordedStatus { get; set; }

		[XmlElement("ReferencedIdentifiedBinaryFile")]
		public IdentifiedBinaryFileType[] ReferencedIdentifiedBinaryFile { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIILBSupplyChainTradeSettlement", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIILBSupplyChainTradeSettlementType
	{
		public CITradeTaxType ApplicableCITradeTax { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CITradeTax", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CITradeTaxType
	{
		[XmlElement("CalculatedAmount")]
		public AmountType[] CalculatedAmount { get; set; }

		public TaxTypeCodeType TypeCode { get; set; }

		public TextType ExemptionReason { get; set; }

		public RateType CalculatedRate { get; set; }

		public NumericType CalculationSequenceNumeric { get; set; }

		public QuantityType BasisQuantity { get; set; }

		[XmlElement("BasisAmount")]
		public AmountType[] BasisAmount { get; set; }

		[XmlElement("UnitBasisAmount")]
		public AmountType[] UnitBasisAmount { get; set; }

		public TaxCategoryCodeType CategoryCode { get; set; }

		public CurrencyCodeType CurrencyCode { get; set; }

		[XmlElement("Jurisdiction")]
		public TextType[] Jurisdiction { get; set; }

		public IndicatorType CustomsDutyIndicator { get; set; }

		public CodeType ExemptionReasonCode { get; set; }

		public RateType TaxBasisAllowanceRate { get; set; }

		public DateType TaxPointDate { get; set; }

		public TextType Type { get; set; }

		[XmlElement("InformationAmount")]
		public AmountType[] InformationAmount { get; set; }

		[XmlElement("CategoryName")]
		public TextType[] CategoryName { get; set; }

		public TimeReferenceCodeType DueDateTypeCode { get; set; }

		public PercentType RateApplicablePercent { get; set; }

		public AmountType GrandTotalAmount { get; set; }

		public CodeType CalculationMethodCode { get; set; }

		[XmlElement("SpecifiedCITradeAccountingAccount")]
		public CITradeAccountingAccountType[] SpecifiedCITradeAccountingAccount { get; set; }

		public CITradeAccountingAccountType BuyerDeductibleTaxSpecifiedCITradeAccountingAccount { get; set; }

		public CITradeAccountingAccountType BuyerNonDeductibleTaxSpecifiedCITradeAccountingAccount { get; set; }

		public CITradeAccountingAccountType BuyerRepayableTaxSpecifiedCITradeAccountingAccount { get; set; }

		public CITradeAccountingAccountType SellerPayableTaxSpecifiedCITradeAccountingAccount { get; set; }

		public CITradeAccountingAccountType SellerRefundableTaxSpecifiedCITradeAccountingAccount { get; set; }

		public CITradeCountryType ServiceSupplyCITradeCountry { get; set; }

		[XmlElement("PlaceApplicableCITradeLocation")]
		public CITradeLocationType[] PlaceApplicableCITradeLocation { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CITradeAccountingAccount", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CITradeAccountingAccountType
	{
		public IDType ID { get; set; }

		public AccountingDocumentCodeType SetTriggerCode { get; set; }

		public AccountingAccountTypeCodeType TypeCode { get; set; }

		public AccountingAmountTypeCodeType AmountTypeCode { get; set; }

		public TextType Name { get; set; }

		public TextType CostReferenceDimensionPattern { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CITradeCountry", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CITradeCountryType
	{
		public CountryIDType ID { get; set; }

		[XmlElement("Name")]
		public TextType[] Name { get; set; }

		[XmlElement("SubordinateCITradeCountrySubDivision")]
		public CITradeCountrySubDivisionType[] SubordinateCITradeCountrySubDivision { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CITradeCountrySubDivision", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CITradeCountrySubDivisionType
	{
		public IDType ID { get; set; }

		[XmlElement("Name")]
		public TextType[] Name { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CITradeLocation", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CITradeLocationType
	{
		public CountryIDType CountryID { get; set; }

		public TextType CountryName { get; set; }

		public IDType ID { get; set; }

		public TextType Name { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIILBSupplyChainTradeDelivery", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIILBSupplyChainTradeDeliveryType
	{
		public QuantityType PackageQuantity { get; set; }

		public QuantityType ProductUnitQuantity { get; set; }

		public QuantityType PerPackageUnitQuantity { get; set; }

		[XmlElement("IncludedCISupplyChainPackaging")]
		public CISupplyChainPackagingType[] IncludedCISupplyChainPackaging { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CISupplyChainPackaging", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CISupplyChainPackagingType
	{
		public PackageTypeCodeType TypeCode { get; set; }

		public TextType Type { get; set; }

		public CodeType ConditionCode { get; set; }

		[XmlElement("DisposalMethodCode")]
		public CodeType[] DisposalMethodCode { get; set; }

		[XmlElement("WeightMeasure")]
		public MeasureType[] WeightMeasure { get; set; }

		public QuantityType MaximumStackabilityQuantity { get; set; }

		public WeightUnitMeasureType MaximumStackabilityWeightMeasure { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		public QuantityType CustomerFacingTotalUnitQuantity { get; set; }

		public QuantityType LayerTotalUnitQuantity { get; set; }

		public QuantityType ContentLayerQuantity { get; set; }

		public CodeType AdditionalInstructionCode { get; set; }

		public CodeType InstructionCode { get; set; }

		public IndicatorType AdditionalInstructionIndicator { get; set; }

		public CISpatialDimensionType LinearCISpatialDimension { get; set; }

		public CISpatialDimensionType MinimumLinearCISpatialDimension { get; set; }

		public CISpatialDimensionType MaximumLinearCISpatialDimension { get; set; }

		[XmlElement("SpecifiedCIPackagingMarking")]
		public CIPackagingMarkingType[] SpecifiedCIPackagingMarking { get; set; }

		[XmlElement("ApplicableCIMaterialGoodsCharacteristic")]
		public CIMaterialGoodsCharacteristicType[] ApplicableCIMaterialGoodsCharacteristic { get; set; }

		[XmlElement("ApplicableCIDisposalInstructions")]
		public CIDisposalInstructionsType[] ApplicableCIDisposalInstructions { get; set; }

		[XmlElement("ApplicableCIReturnableAssetInstructions")]
		public CIReturnableAssetInstructionsType[] ApplicableCIReturnableAssetInstructions { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CISpatialDimension", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CISpatialDimensionType
	{
		public MeasureType ValueMeasure { get; set; }

		public DimensionTypeCodeType TypeCode { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		public MeasureType WidthMeasure { get; set; }

		public MeasureType LengthMeasure { get; set; }

		public MeasureType HeightMeasure { get; set; }

		public IDType ID { get; set; }

		public LinearUnitMeasureType DiameterMeasure { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIPackagingMarking", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIPackagingMarkingType
	{
		[XmlElement("TypeCode")]
		public PackagingMarkingCodeType[] TypeCode { get; set; }

		[XmlElement("Content")]
		public TextType[] Content { get; set; }

		public DateTimeType ContentDateTime { get; set; }

		[XmlElement("ContentAmount")]
		public AmountType[] ContentAmount { get; set; }

		[XmlElement("BarcodeTypeCode")]
		public CodeType[] BarcodeTypeCode { get; set; }

		[XmlElement("ContentCode")]
		public CodeType[] ContentCode { get; set; }

		[XmlElement("AutomaticDataCaptureMethodTypeCode")]
		public AutomaticDataCaptureMethodCodeType[] AutomaticDataCaptureMethodTypeCode { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIMaterialGoodsCharacteristic", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIMaterialGoodsCharacteristicType
	{
		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		public CodeType TypeCode { get; set; }

		public PercentType ProportionalConstituentPercent { get; set; }

		public MeasureType AbsolutePresenceWeightMeasure { get; set; }

		public MeasureType AbsolutePresenceVolumeMeasure { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIDisposalInstructions", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIDisposalInstructionsType
	{
		public IDType MaterialID { get; set; }

		[XmlElement("RecyclingDescriptionCode")]
		public CodeType[] RecyclingDescriptionCode { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		[XmlElement("RecyclingProcedure")]
		public TextType[] RecyclingProcedure { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIReturnableAssetInstructions", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIReturnableAssetInstructionsType
	{
		[XmlElement("MaterialID")]
		public IDType[] MaterialID { get; set; }

		[XmlElement("TermsAndConditionsDescription")]
		public TextType[] TermsAndConditionsDescription { get; set; }

		public CodeType TermsAndConditionsDescriptionCode { get; set; }

		[XmlElement("DepositValueSpecifiedAmount")]
		public AmountType[] DepositValueSpecifiedAmount { get; set; }

		public CISpecifiedPeriodType DepositValueValidityCISpecifiedPeriod { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CISpecifiedPeriod", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CISpecifiedPeriodType
	{
		[XmlElement("DurationMeasure")]
		public MeasureType[] DurationMeasure { get; set; }

		public IndicatorType InclusiveIndicator { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		public DateTimeType StartDateTime { get; set; }

		public DateTimeType EndDateTime { get; set; }

		public DateTimeType CompleteDateTime { get; set; }

		public CodeType SeasonCode { get; set; }

		public IDType ID { get; set; }

		[XmlElement("Name")]
		public TextType[] Name { get; set; }

		public NumericType SequenceNumeric { get; set; }

		public CodeType StartDateFlexibilityCode { get; set; }

		public IndicatorType ContinuousIndicator { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIILBSupplyChainTradeAgreement", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIILBSupplyChainTradeAgreementType
	{
		public CIReferencedDocumentType SellerOrderReferencedCIReferencedDocument { get; set; }

		public CIReferencedDocumentType BuyerOrderReferencedCIReferencedDocument { get; set; }

		[XmlElement("AdditionalReferencedCIReferencedDocument")]
		public CIReferencedDocumentType[] AdditionalReferencedCIReferencedDocument { get; set; }

		[XmlElement("GrossPriceProductCITradePrice")]
		public CITradePriceType[] GrossPriceProductCITradePrice { get; set; }

		[XmlElement("NetPriceProductCITradePrice")]
		public CITradePriceType[] NetPriceProductCITradePrice { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIReferencedDocument", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIReferencedDocumentType
	{
		public IDType IssuerAssignedID { get; set; }

		public IDType URIID { get; set; }

		public string IssueDateTime { get; set; }

		public DocumentStatusCodeType StatusCode { get; set; }

		public IndicatorType CopyIndicator { get; set; }

		public IDType LineID { get; set; }

		public ReferenceCodeType ReferenceTypeCode { get; set; }

		public IDType GlobalID { get; set; }

		public IDType RevisionID { get; set; }

		[XmlElement("Name")]
		public TextType[] Name { get; set; }

		[XmlElement("Information")]
		public TextType[] Information { get; set; }

		[XmlElement("PreviousRevisionID")]
		public IDType[] PreviousRevisionID { get; set; }

		[XmlElement("SectionName")]
		public TextType[] SectionName { get; set; }

		public DocumentCodeType TypeCode { get; set; }

		[XmlElement("AttachmentBinaryObject")]
		public BinaryObjectType[] AttachmentBinaryObject { get; set; }

		public IDType PageID { get; set; }

		public DateTimeType ReceiptDateTime { get; set; }

		public IDType SubordinateLineID { get; set; }

		public MessageFunctionCodeType PurposeCode { get; set; }

		public CodeType CategoryCode { get; set; }

		public IDType RequisitionerAssignedID { get; set; }

		public CITradePartyType IssuerCITradeParty { get; set; }

		[XmlElement("AttachedSpecifiedBinaryFile")]
		public SpecifiedBinaryFileType[] AttachedSpecifiedBinaryFile { get; set; }

		public CISpecifiedPeriodType EffectiveCISpecifiedPeriod { get; set; }

		[XmlElement("IncludedCINote")]
		public CINoteType[] IncludedCINote { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CILegalOrganization", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CILegalOrganizationType
	{
		public CodeType LegalClassificationCode { get; set; }

		public TextType Name { get; set; }

		public IDType ID { get; set; }

		public TextType TradingBusinessName { get; set; }

		public CITradeAddressType PostalCITradeAddress { get; set; }

		[XmlElement("AuthorizedCILegalRegistration")]
		public CILegalRegistrationType[] AuthorizedCILegalRegistration { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CITradeAddress", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CITradeAddressType
	{
		public IDType ID { get; set; }

		public CodeType PostcodeCode { get; set; }

		public TextType PostOfficeBox { get; set; }

		public TextType BuildingName { get; set; }

		public TextType LineOne { get; set; }

		public TextType LineTwo { get; set; }

		public TextType LineThree { get; set; }

		public TextType LineFour { get; set; }

		public TextType LineFive { get; set; }

		public TextType StreetName { get; set; }

		public TextType CityName { get; set; }

		public TextType CitySubDivisionName { get; set; }

		public CountryIDType CountryID { get; set; }

		[XmlElement("CountryName")]
		public TextType[] CountryName { get; set; }

		public IDType CountrySubDivisionID { get; set; }

		[XmlElement("CountrySubDivisionName")]
		public TextType[] CountrySubDivisionName { get; set; }

		public TextType AttentionOf { get; set; }

		public TextType CareOf { get; set; }

		public TextType BuildingNumber { get; set; }

		public TextType AdditionalStreetName { get; set; }

		public TextType DepartmentName { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CILegalRegistration", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CILegalRegistrationType
	{
		public CodeType TypeCode { get; set; }

		public IDType ID { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CITradeContact", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CITradeContactType
	{
		public IDType ID { get; set; }

		/// <remarks/>
		public TextType PersonName { get; set; }

		/// <remarks/>
		public TextType DepartmentName { get; set; }

		/// <remarks/>
		public ContactTypeCodeType TypeCode { get; set; }

		/// <remarks/>
		public TextType JobTitle { get; set; }

		/// <remarks/>
		public TextType Responsibility { get; set; }

		/// <remarks/>
		[XmlElement("PersonID")]
		public IDType[] PersonID { get; set; }

		/// <remarks/>
		public TextType AuthorizedPersonName { get; set; }

		/// <remarks/>
		public CIUniversalCommunicationType TelephoneCIUniversalCommunication { get; set; }

		public CIUniversalCommunicationType DirectTelephoneCIUniversalCommunication { get; set; }

		public CIUniversalCommunicationType MobileTelephoneCIUniversalCommunication { get; set; }

		public CIUniversalCommunicationType FaxCIUniversalCommunication { get; set; }

		public CIUniversalCommunicationType EmailURICIUniversalCommunication { get; set; }

		public CIUniversalCommunicationType TelexCIUniversalCommunication { get; set; }

		public CIUniversalCommunicationType VOIPCIUniversalCommunication { get; set; }

		public CIUniversalCommunicationType InstantMessagingCIUniversalCommunication { get; set; }

		[XmlElement("SpecifiedCINote")]
		public CINoteType[] SpecifiedCINote { get; set; }

		public CIContactPersonType SpecifiedCIContactPerson { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIUniversalCommunication", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIUniversalCommunicationType
	{
		public IDType URIID { get; set; }
		public CommunicationChannelCodeType ChannelCode { get; set; }
		public TextType CompleteNumber { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CITradeParty", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CITradePartyType
	{
		[XmlElement("ID")]
		public IDType[] ID { get; set; }

		[XmlElement("GlobalID")]
		public IDType[] GlobalID { get; set; }

		public TextType Name { get; set; }

		[XmlElement("RoleCode")]
		public PartyRoleCodeType[] RoleCode { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		public IDType RegisteredID { get; set; }

		public IDType DUNSID { get; set; }

		[XmlElement("TypeCode")]
		public CodeType[] TypeCode { get; set; }

		public CILegalOrganizationType SpecifiedCILegalOrganization { get; set; }

		[XmlElement("DefinedCITradeContact")]
		public CITradeContactType[] DefinedCITradeContact { get; set; }

		public CITradeAddressType PostalCITradeAddress { get; set; }

		[XmlElement("URICIUniversalCommunication")]
		public CIUniversalCommunicationType[] URICIUniversalCommunication { get; set; }

		[XmlElement("SpecifiedCITaxRegistration")]
		public CITaxRegistrationType[] SpecifiedCITaxRegistration { get; set; }

		public CIUniversalCommunicationType EndPointURICIUniversalCommunication { get; set; }

		[XmlElement("LogoAssociatedSpecifiedBinaryFile")]
		public SpecifiedBinaryFileType[] LogoAssociatedSpecifiedBinaryFile { get; set; }

		public CILogisticsLocationType SpecifiedCILogisticsLocation { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CINote", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CINoteType
	{
		public TextType Subject { get; set; }

		public CodeType ContentCode { get; set; }

		[XmlElement("Content")]
		public TextType[] Content { get; set; }

		public SubjectCodeType SubjectCode { get; set; }

		public IDType ID { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIContactPerson", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIContactPersonType
	{
		public TextType FamilyName { get; set; }

		public TextType GivenName { get; set; }

		public TextType MiddleName { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CITaxRegistration", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CITaxRegistrationType
	{
		public IDType ID { get; set; }

		public CIRegisteredTaxType AssociatedCIRegisteredTax { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIRegisteredTax", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIRegisteredTaxType
	{
		public TaxTypeCodeType TypeCode { get; set; }

		public CodeType ExemptionReasonCode { get; set; }

		[XmlElement("ExemptionReason")]
		public TextType[] ExemptionReason { get; set; }

		public CurrencyCodeType CurrencyCode { get; set; }

		[XmlElement("Jurisdiction")]
		public TextType[] Jurisdiction { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		public IndicatorType CustomsDutyIndicator { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CILogisticsLocation", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CILogisticsLocationType
	{
		public IDType ID { get; set; }

		[XmlElement("Name")]
		public TextType[] Name { get; set; }

		public LocationFunctionCodeType TypeCode { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		public IDType CountrySubDivisionID { get; set; }

		public CITradeAddressType PostalCITradeAddress { get; set; }

		public CIGeographicalCoordinateType PhysicalCIGeographicalCoordinate { get; set; }
	}

	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIGeographicalCoordinate", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIGeographicalCoordinateType
	{
		public MeasureType AltitudeMeasure { get; set; }

		public MeasureType LatitudeMeasure { get; set; }

		public MeasureType LongitudeMeasure { get; set; }

		public IDType SystemID { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CITradePrice", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CITradePriceType
	{
		public PriceTypeCodeType TypeCode { get; set; }

		[XmlElement("ChargeAmount")]
		public AmountType[] ChargeAmount { get; set; }

		public QuantityType BasisQuantity { get; set; }

		public NumericType OrderUnitConversionFactorNumeric { get; set; }

		[XmlElement("ChangeReason")]
		public TextType[] ChangeReason { get; set; }

		public QuantityType MinimumQuantity { get; set; }

		public QuantityType MaximumQuantity { get; set; }

		[XmlElement("Type")]
		public TextType[] Type { get; set; }

		[XmlElement("AppliedCITradeAllowanceCharge")]
		public CITradeAllowanceChargeType[] AppliedCITradeAllowanceCharge { get; set; }

		public CISpecifiedPeriodType ValidityCISpecifiedPeriod { get; set; }

		[XmlElement("ReferencedCIReferencedDocument")]
		public CIReferencedDocumentType[] ReferencedCIReferencedDocument { get; set; }

		[XmlElement("DeliveryCITradeLocation")]
		public CITradeLocationType[] DeliveryCITradeLocation { get; set; }

		[XmlElement("TradeComparisonReferencePrice")]
		public ReferencePriceType[] TradeComparisonReferencePrice { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CITradeAllowanceCharge", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CITradeAllowanceChargeType
	{
		public IndicatorType ChargeIndicator { get; set; }

		public IDType ID { get; set; }

		public NumericType SequenceNumeric { get; set; }

		public PercentType CalculationPercent { get; set; }

		public QuantityType BasisQuantity { get; set; }

		public IndicatorType PrepaidIndicator { get; set; }

		[XmlElement("ActualAmount")]
		public AmountType[] ActualAmount { get; set; }

		public AllowanceChargeReasonCodeType ReasonCode { get; set; }

		public TextType Reason { get; set; }

		public AllowanceChargeIdentificationCodeType TypeCode { get; set; }

		public AmountType BasisAmount { get; set; }

		public AmountType UnitBasisAmount { get; set; }

		[XmlElement("CategoryCITradeTax")]
		public CITradeTaxType[] CategoryCITradeTax { get; set; }

		public CITradeCurrencyExchangeType ActualCITradeCurrencyExchange { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CITradeCurrencyExchange", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CITradeCurrencyExchangeType
	{
		public CurrencyCodeType SourceCurrencyCode { get; set; }

		public NumericType SourceUnitBasisNumeric { get; set; }

		public CurrencyCodeType TargetCurrencyCode { get; set; }

		public NumericType TargetUnitBaseNumeric { get; set; }

		public IDType MarketID { get; set; }

		public RateType ConversionRate { get; set; }

		public DateTimeType ConversionRateDateTime { get; set; }

		public CIReferencedDocumentType ReferencedCIReferencedDocument { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("ReferencePrice", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class ReferencePriceType
	{
		public AmountType ChargeAmount { get; set; }

		/// <remarks/>
		[XmlElement("BasisQuantity")]
		public QuantityType[] BasisQuantity { get; set; }

		/// <remarks/>
		[XmlElement("NetPriceIndicator")]
		public IndicatorType[] NetPriceIndicator { get; set; }

		public CodeType ComparisonMethodCode { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("ReferencedProduct", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class ReferencedProductType
	{
		[XmlElement("ID")]
		public IDType[] ID { get; set; }

		/// <remarks/>
		[XmlElement("GlobalID")]
		public IDType[] GlobalID { get; set; }

		/// <remarks/>
		public IDType SellerAssignedID { get; set; }

		public IDType BuyerAssignedID { get; set; }

		[XmlElement("ManufacturerAssignedID")]
		public IDType[] ManufacturerAssignedID { get; set; }

		[XmlElement("IndustryAssignedID")]
		public IDType[] IndustryAssignedID { get; set; }

		[XmlElement("Name")]
		public TextType[] Name { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		[XmlElement("RelationshipTypeCode")]
		public CodeType[] RelationshipTypeCode { get; set; }

		/// <remarks/>
		[XmlElement("UnitQuantity")]
		public QuantityType[] UnitQuantity { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIILBSubordinateTradeLineItem", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIILBSubordinateTradeLineItemType
	{
		[XmlElement("ID")]
		public IDType[] ID { get; set; }

		/// <remarks/>
		public ReferencedProductType SpecifiedReferencedProduct { get; set; }

		/// <remarks/>
		[XmlElement("ApplicableCITradeProduct")]
		public CITradeProductType[] ApplicableCITradeProduct { get; set; }

		/// <remarks/>
		public CIILBSupplyChainTradeAgreementType SpecifiedCIILBSupplyChainTradeAgreement { get; set; }

		/// <remarks/>
		public CIILBSupplyChainTradeDeliveryType SpecifiedCIILBSupplyChainTradeDelivery { get; set; }

		/// <remarks/>
		public CIILBSupplyChainTradeSettlementType SpecifiedCIILBSupplyChainTradeSettlement { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CITradeProduct", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CITradeProductType
	{
		public IDType ID { get; set; }

		/// <remarks/>
		public IDType GlobalID { get; set; }

		/// <remarks/>
		public IDType SellerAssignedID { get; set; }

		/// <remarks/>
		public IDType BuyerAssignedID { get; set; }

		/// <remarks/>
		public IDType ManufacturerAssignedID { get; set; }

		/// <remarks/>
		[XmlElement("Name")]
		public TextType[] Name { get; set; }

		/// <remarks/>
		public TextType TradeName { get; set; }

		/// <remarks/>
		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		/// <remarks/>
		public CodeType TypeCode { get; set; }

		/// <remarks/>
		public MeasureType NetWeightMeasure { get; set; }

		/// <remarks/>
		public MeasureType GrossWeightMeasure { get; set; }

		/// <remarks/>
		public MeasureType DrainedNetWeightMeasure { get; set; }

		/// <remarks/>
		public TextType BrandName { get; set; }

		/// <remarks/>
		public TextType SubBrandName { get; set; }

		/// <remarks/>
		[XmlElement("ProductGroupID")]
		public IDType[] ProductGroupID { get; set; }

		/// <remarks/>
		public MeasureType AreaDensityMeasure { get; set; }

		/// <remarks/>
		public CodeType ColourCode { get; set; }

		/// <remarks/>
		[XmlElement("ColourDescription")]
		public TextType[] ColourDescription { get; set; }

		/// <remarks/>
		[XmlElement("UseDescription")]
		public TextType[] UseDescription { get; set; }

		/// <remarks/>
		[XmlElement("Designation")]
		public TextType[] Designation { get; set; }

		/// <remarks/>
		[XmlElement("EndItemName")]
		public TextType[] EndItemName { get; set; }

		/// <remarks/>
		public string LatestProductDataChangeDateTime { get; set; }

		/// <remarks/>
		[XmlElement("EndItemTypeCode")]
		public CodeType[] EndItemTypeCode { get; set; }

		/// <remarks/>
		public IndicatorType VariableMeasureIndicator { get; set; }

		/// <remarks/>
		[XmlElement("AdditionalDescription")]
		public TextType[] AdditionalDescription { get; set; }

		/// <remarks/>
		[XmlElement("BatchID")]
		public IDType[] BatchID { get; set; }

		/// <remarks/>
		[XmlElement("CommonName")]
		public TextType[] CommonName { get; set; }

		/// <remarks/>
		[XmlElement("ConciseDescription")]
		public TextType[] ConciseDescription { get; set; }

		/// <remarks/>
		public IndicatorType ConfigurableIndicator { get; set; }

		/// <remarks/>
		public QuantityType ContentUnitQuantity { get; set; }

		/// <remarks/>
		[XmlElement("CustomerAssignedID")]
		public IDType[] CustomerAssignedID { get; set; }

		/// <remarks/>
		[XmlElement("GrossVolumeMeasure")]
		public MeasureType[] GrossVolumeMeasure { get; set; }

		/// <remarks/>
		[XmlElement("IndustryAssignedID")]
		public IDType[] IndustryAssignedID { get; set; }

		/// <remarks/>
		[XmlElement("ModelID")]
		public IDType[] ModelID { get; set; }

		/// <remarks/>
		[XmlElement("NetVolumeMeasure")]
		public MeasureType[] NetVolumeMeasure { get; set; }

		/// <remarks/>
		public CodeType RecyclingTypeCode { get; set; }

		/// <remarks/>
		[XmlElement("StatusCode")]
		public CodeType[] StatusCode { get; set; }

		/// <remarks/>
		[XmlElement("UnitTypeCode")]
		public CodeType[] UnitTypeCode { get; set; }

		/// <remarks/>
		public IndicatorType ExportIndicator { get; set; }

		/// <remarks/>
		[XmlElement("ApplicableCIProductCharacteristic")]
		public CIProductCharacteristicType[] ApplicableCIProductCharacteristic { get; set; }

		/// <remarks/>
		[XmlElement("ApplicableCIMaterialGoodsCharacteristic")]
		public CIMaterialGoodsCharacteristicType[] ApplicableCIMaterialGoodsCharacteristic { get; set; }

		/// <remarks/>
		[XmlElement("DesignatedCIProductClassification")]
		public CIProductClassificationType[] DesignatedCIProductClassification { get; set; }

		/// <remarks/>
		[XmlElement("IndividualCITradeProductInstance")]
		public CITradeProductInstanceType[] IndividualCITradeProductInstance { get; set; }

		/// <remarks/>
		[XmlElement("CertificationEvidenceReferenceCIReferencedDocument")]
		public CIReferencedDocumentType[] CertificationEvidenceReferenceCIReferencedDocument { get; set; }

		/// <remarks/>
		[XmlElement("InspectionReferenceCIReferencedDocument")]
		public CIReferencedDocumentType[] InspectionReferenceCIReferencedDocument { get; set; }

		/// <remarks/>
		public CITradeCountryType OriginCITradeCountry { get; set; }

		/// <remarks/>
		public CISpatialDimensionType LinearCISpatialDimension { get; set; }

		/// <remarks/>
		public CISpatialDimensionType MinimumLinearCISpatialDimension { get; set; }

		/// <remarks/>
		public CISpatialDimensionType MaximumLinearCISpatialDimension { get; set; }

		/// <remarks/>
		public CITradePartyType ManufacturerCITradeParty { get; set; }

		/// <remarks/>
		public CIReferencedDocumentType MSDSReferenceCIReferencedDocument { get; set; }

		/// <remarks/>
		[XmlElement("AdditionalReferenceCIReferencedDocument")]
		public CIReferencedDocumentType[] AdditionalReferenceCIReferencedDocument { get; set; }

		/// <remarks/>
		[XmlElement("InformationCINote")]
		public CINoteType[] InformationCINote { get; set; }

		/// <remarks/>
		public CITradePartyType BrandOwnerCITradeParty { get; set; }

		/// <remarks/>
		public CITradePartyType LegalRightsOwnerCITradeParty { get; set; }

		/// <remarks/>
		[XmlElement("PresentationSpecifiedBinaryFile")]
		public SpecifiedBinaryFileType[] PresentationSpecifiedBinaryFile { get; set; }

		/// <remarks/>
		[XmlElement("BuyerSuppliedPartsReferenceCIReferencedDocument")]
		public CIReferencedDocumentType[] BuyerSuppliedPartsReferenceCIReferencedDocument { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIProductCharacteristic", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIProductCharacteristicType
	{
		[XmlElement("ID")]
		public IDType[] ID { get; set; }

		/// <remarks/>
		public CodeType TypeCode { get; set; }

		/// <remarks/>
		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		/// <remarks/>
		public MeasureType ValueMeasure { get; set; }

		/// <remarks/>
		public CodeType MeasurementMethodCode { get; set; }

		/// <remarks/>
		public CodeType ContentTypeCode { get; set; }

		/// <remarks/>
		public CodeType ValueCode { get; set; }

		/// <remarks/>
		public DateTimeType ValueDateTime { get; set; }

		/// <remarks/>
		public IndicatorType ValueIndicator { get; set; }

		/// <remarks/>
		[XmlElement("Value")]
		public TextType[] Value { get; set; }

		/// <remarks/>
		public ReferencedStandardType ApplicableReferencedStandard { get; set; }

		/// <remarks/>
		[XmlElement("ApplicableProductCharacteristicCondition")]
		public ProductCharacteristicConditionType[] ApplicableProductCharacteristicCondition { get; set; }

		/// <remarks/>
		public SpecifiedBinaryFileType ValueSpecifiedBinaryFile { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("ReferencedStandard", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class ReferencedStandardType
	{
		public IDType ID { get; set; }

		/// <remarks/>
		public IDType VersionID { get; set; }

		/// <remarks/>
		public IDType ElementVersionID { get; set; }

		/// <remarks/>
		public IDType URIID { get; set; }

		/// <remarks/>
		public IDType PartID { get; set; }

		/// <remarks/>
		public IDType AgencyID { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("ProductCharacteristicCondition", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class ProductCharacteristicConditionType
	{
		public CodeType TypeCode { get; set; }

		/// <remarks/>
		[XmlElement("Name")]
		public TextType[] Name { get; set; }

		/// <remarks/>
		public MeasureType ValueMeasure { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIProductClassification", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIProductClassificationType
	{
		public IDType SystemID { get; set; }

		/// <remarks/>
		[XmlElement("SystemName")]
		public TextType[] SystemName { get; set; }

		/// <remarks/>
		public CodeType ClassCode { get; set; }

		/// <remarks/>
		[XmlElement("ClassName")]
		public TextType[] ClassName { get; set; }

		/// <remarks/>
		public CodeType SubClassCode { get; set; }

		/// <remarks/>
		[XmlElement("ClassCIProductCharacteristic")]
		public CIProductCharacteristicType[] ClassCIProductCharacteristic { get; set; }

		/// <remarks/>
		public ReferencedStandardType ApplicableReferencedStandard { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CITradeProductInstance", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CITradeProductInstanceType
	{
		public IDType GlobalSerialID { get; set; }

		/// <remarks/>
		public IDType BatchID { get; set; }

		/// <remarks/>
		public IDType KanbanID { get; set; }

		/// <remarks/>
		public IDType SupplierAssignedSerialID { get; set; }

		/// <remarks/>
		public DateTimeType BestBeforeDateTime { get; set; }

		/// <remarks/>
		public DateTimeType ExpiryDateTime { get; set; }

		/// <remarks/>
		public DateTimeType SellByDateTime { get; set; }

		/// <remarks/>
		[XmlElement("SerialID")]
		public IDType[] SerialID { get; set; }

		/// <remarks/>
		[XmlElement("RegistrationID")]
		public IDType[] RegistrationID { get; set; }

		/// <remarks/>
		[XmlElement("ProductCIProductCharacteristic")]
		public CIProductCharacteristicType[] ProductCIProductCharacteristic { get; set; }

		/// <remarks/>
		public CISupplyChainEventType ProductionCISupplyChainEvent { get; set; }

		/// <remarks/>
		public CISupplyChainEventType PackagingCISupplyChainEvent { get; set; }

		/// <remarks/>
		[XmlElement("ApplicableCIMaterialGoodsCharacteristic")]
		public CIMaterialGoodsCharacteristicType[] ApplicableCIMaterialGoodsCharacteristic { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CISupplyChainEvent", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CISupplyChainEventType
	{
		public IDType ID { get; set; }

		/// <remarks/>
		public DateTimeType OccurrenceDateTime { get; set; }

		/// <remarks/>
		public CodeType TypeCode { get; set; }

		/// <remarks/>
		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		/// <remarks/>
		[XmlElement("DescriptionBinaryObject")]
		public BinaryObjectType[] DescriptionBinaryObject { get; set; }

		/// <remarks/>
		public QuantityType UnitQuantity { get; set; }

		/// <remarks/>
		public DateTimeType LatestOccurrenceDateTime { get; set; }

		/// <remarks/>
		public DateTimeType EarliestOccurrenceDateTime { get; set; }

		/// <remarks/>
		public TimeOnlyFormattedDateTimeType TimeOccurrenceDateTime { get; set; }

		/// <remarks/>
		public DateTimeType DueDateTime { get; set; }

		/// <remarks/>
		public CISpecifiedPeriodType OccurrenceCISpecifiedPeriod { get; set; }

		/// <remarks/>
		public CILogisticsLocationType OccurrenceCILogisticsLocation { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIILTradeSettlementMonetarySummation", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIILTradeSettlementMonetarySummationType
	{
		[XmlElement("LineTotalAmount")]
		public AmountType[] LineTotalAmount { get; set; }

		/// <remarks/>
		[XmlElement("ChargeTotalAmount")]
		public AmountType[] ChargeTotalAmount { get; set; }

		/// <remarks/>
		[XmlElement("AllowanceTotalAmount")]
		public AmountType[] AllowanceTotalAmount { get; set; }

		/// <remarks/>
		[XmlElement("TaxBasisTotalAmount")]
		public AmountType[] TaxBasisTotalAmount { get; set; }

		/// <remarks/>
		[XmlElement("TaxTotalAmount")]
		public AmountType[] TaxTotalAmount { get; set; }

		/// <remarks/>
		[XmlElement("InformationAmount")]
		public AmountType[] InformationAmount { get; set; }

		/// <remarks/>
		[XmlElement("TotalAllowanceChargeAmount")]
		public AmountType[] TotalAllowanceChargeAmount { get; set; }

		/// <remarks/>
		[XmlElement("ProductWeightLossInformationAmount")]
		public AmountType[] ProductWeightLossInformationAmount { get; set; }

		/// <remarks/>
		[XmlElement("TotalRetailValueInformationAmount")]
		public AmountType[] TotalRetailValueInformationAmount { get; set; }

		/// <remarks/>
		[XmlElement("GrossLineTotalAmount")]
		public AmountType[] GrossLineTotalAmount { get; set; }

		/// <remarks/>
		[XmlElement("NetLineTotalAmount")]
		public AmountType[] NetLineTotalAmount { get; set; }

		/// <remarks/>
		[XmlElement("NetIncludingTaxesLineTotalAmount")]
		public AmountType[] NetIncludingTaxesLineTotalAmount { get; set; }

		/// <remarks/>
		public AmountType GrandTotalAmount { get; set; }

		/// <remarks/>
		public AmountType IncludingTaxesLineTotalAmount { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIILSupplyChainTradeSettlement", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIILSupplyChainTradeSettlementType
	{
		[XmlElement("PaymentReference")]
		public TextType[] PaymentReference { get; set; }

		/// <remarks/>
		public TextType InvoiceIssuerReference { get; set; }

		/// <remarks/>
		public DateTimeType InvoiceDateTime { get; set; }

		/// <remarks/>
		[XmlElement("ApplicableCITradeTax")]
		public CITradeTaxType[] ApplicableCITradeTax { get; set; }

		/// <remarks/>
		public CISpecifiedPeriodType BillingCISpecifiedPeriod { get; set; }

		/// <remarks/>
		[XmlElement("SpecifiedCITradeAllowanceCharge")]
		public CITradeAllowanceChargeType[] SpecifiedCITradeAllowanceCharge { get; set; }

		/// <remarks/>
		[XmlElement("SubtotalCalculatedCITradeTax")]
		public CITradeTaxType[] SubtotalCalculatedCITradeTax { get; set; }

		/// <remarks/>
		[XmlElement("SpecifiedCILogisticsServiceCharge")]
		public CILogisticsServiceChargeType[] SpecifiedCILogisticsServiceCharge { get; set; }

		/// <remarks/>
		[XmlElement("SpecifiedCITradePaymentTerms")]
		public CITradePaymentTermsType[] SpecifiedCITradePaymentTerms { get; set; }

		/// <remarks/>
		public CIILTradeSettlementMonetarySummationType SpecifiedCIILTradeSettlementMonetarySummation { get; set; }

		/// <remarks/>
		[XmlElement("SpecifiedCIFinancialAdjustment")]
		public CIFinancialAdjustmentType[] SpecifiedCIFinancialAdjustment { get; set; }

		/// <remarks/>
		public CIReferencedDocumentType InvoiceReferencedCIReferencedDocument { get; set; }

		/// <remarks/>
		[XmlElement("AdditionalReferencedCIReferencedDocument")]
		public CIReferencedDocumentType[] AdditionalReferencedCIReferencedDocument { get; set; }

		/// <remarks/>
		public TradeSettlementFinancialCardType SpecifiedTradeSettlementFinancialCard { get; set; }

		/// <remarks/>
		[XmlElement("PayableSpecifiedCITradeAccountingAccount")]
		public CITradeAccountingAccountType[] PayableSpecifiedCITradeAccountingAccount { get; set; }

		/// <remarks/>
		[XmlElement("ReceivableSpecifiedCITradeAccountingAccount")]
		public CITradeAccountingAccountType[] ReceivableSpecifiedCITradeAccountingAccount { get; set; }

		/// <remarks/>
		[XmlElement("PurchaseSpecifiedCITradeAccountingAccount")]
		public CITradeAccountingAccountType[] PurchaseSpecifiedCITradeAccountingAccount { get; set; }

		/// <remarks/>
		[XmlElement("SalesSpecifiedCITradeAccountingAccount")]
		public CITradeAccountingAccountType[] SalesSpecifiedCITradeAccountingAccount { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CILogisticsServiceCharge", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CILogisticsServiceChargeType
	{
		public FreightChargeTypeIDType ID { get; set; }

		/// <remarks/>
		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		/// <remarks/>
		public TransportServicePaymentArrangementCodeType PaymentArrangementCode { get; set; }

		/// <remarks/>
		public FreightChargeTariffClassCodeType TariffClassCode { get; set; }

		/// <remarks/>
		public CodeType ChargeCategoryCode { get; set; }

		/// <remarks/>
		public CodeType ServiceCategoryCode { get; set; }

		/// <remarks/>
		[XmlElement("DisbursementAmount")]
		public AmountType[] DisbursementAmount { get; set; }

		/// <remarks/>
		[XmlElement("AppliedAmount")]
		public AmountType[] AppliedAmount { get; set; }

		/// <remarks/>
		public TextType AllowanceCharge { get; set; }

		/// <remarks/>
		public ChargePayingPartyRoleCodeType PayingPartyRoleCode { get; set; }

		/// <remarks/>
		public LogisticsChargeCalculationBasisCodeType CalculationBasisCode { get; set; }

		/// <remarks/>
		public TextType CalculationBasis { get; set; }

		/// <remarks/>
		public CodeType TransportPaymentMethodCode { get; set; }

		/// <remarks/>
		public CILogisticsLocationType PaymentPlaceCILogisticsLocation { get; set; }

		/// <remarks/>
		public CILogisticsLocationType AppliedFromCILogisticsLocation { get; set; }

		/// <remarks/>
		public CILogisticsLocationType AppliedToCILogisticsLocation { get; set; }

		/// <remarks/>
		[XmlElement("AppliedCITradeTax")]
		public CITradeTaxType[] AppliedCITradeTax { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CITradePaymentTerms", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CITradePaymentTermsType
	{
		public PaymentTermsIDType ID { get; set; }

		/// <remarks/>
		public PaymentTermsEventTimeReferenceCodeType FromEventCode { get; set; }

		/// <remarks/>
		public MeasureType SettlementPeriodMeasure { get; set; }

		/// <remarks/>
		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		/// <remarks/>
		public DateTimeType DueDateDateTime { get; set; }

		/// <remarks/>
		public CodeType InstructionTypeCode { get; set; }

		/// <remarks/>
		[XmlElement("PaymentMeansID")]
		public IDType[] PaymentMeansID { get; set; }

		public PercentType PartialPaymentPercent { get; set; }

		[XmlElement("DirectDebitMandateID")]
		public IDType[] DirectDebitMandateID { get; set; }

		public PaymentTermsTypeCodeType TypeCode { get; set; }

		[XmlElement("PartialPaymentAmount")]
		public AmountType[] PartialPaymentAmount { get; set; }

		public CITradePaymentPenaltyTermsType ApplicableCITradePaymentPenaltyTerms { get; set; }

		public CITradePaymentDiscountTermsType ApplicableCITradePaymentDiscountTerms { get; set; }

		[XmlElement("PayeeCITradeParty")]
		public CITradePartyType[] PayeeCITradeParty { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CITradePaymentPenaltyTerms", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CITradePaymentPenaltyTermsType
	{
		public DateTimeType BasisDateTime { get; set; }

		public MeasureType BasisPeriodMeasure { get; set; }

		public AmountType BasisAmount { get; set; }

		public PercentType CalculationPercent { get; set; }

		public AmountType ActualPenaltyAmount { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CITradePaymentDiscountTerms", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CITradePaymentDiscountTermsType
	{
		public DateTimeType BasisDateTime { get; set; }

		public MeasureType BasisPeriodMeasure { get; set; }

		public AmountType BasisAmount { get; set; }

		public PercentType CalculationPercent { get; set; }

		public AmountType ActualDiscountAmount { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIFinancialAdjustment", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIFinancialAdjustmentType
	{
		public FinancialAdjustmentReasonCodeType ReasonCode { get; set; }

		[XmlElement("Reason")]
		public TextType[] Reason { get; set; }

		[XmlElement("ActualAmount")]
		public AmountType[] ActualAmount { get; set; }

		public QuantityType ActualQuantity { get; set; }

		public DateTimeType ActualDateTime { get; set; }

		public CITradePartyType ClaimRelatedCITradeParty { get; set; }

		public CIReferencedDocumentType InvoiceReferenceCIReferencedDocument { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("TradeSettlementFinancialCard", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class TradeSettlementFinancialCardType
	{
		public IndicatorType MicrochipIndicator { get; set; }

		public IDType ID { get; set; }

		public CodeType TypeCode { get; set; }

		public TextType CardholderName { get; set; }

		public DateType ExpiryDate { get; set; }

		/// <remarks/>
		public NumericType VerificationNumeric { get; set; }

		/// <remarks/>
		public DateTimeType ValidFromDateTime { get; set; }

		[XmlElement("CreditLimitAmount")]
		public AmountType[] CreditLimitAmount { get; set; }

		[XmlElement("CreditAvailableAmount")]
		public AmountType[] CreditAvailableAmount { get; set; }

		public PercentType InterestRatePercent { get; set; }

		public TextType IssuingCompanyName { get; set; }

		public TextType Description { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIDeliveryAdjustment", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIDeliveryAdjustmentType
	{
		public AdjustmentReasonCodeType ReasonCode { get; set; }

		[XmlElement("Reason")]
		public TextType[] Reason { get; set; }

		[XmlElement("ActualAmount")]
		public AmountType[] ActualAmount { get; set; }

		public QuantityType ActualQuantity { get; set; }

		public DateTimeType ActualDateTime { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CIILSupplyChainTradeDelivery", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CIILSupplyChainTradeDeliveryType
	{
		public QuantityType BilledQuantity { get; set; }

		public QuantityType ChargeFreeQuantity { get; set; }

		public QuantityType PackageQuantity { get; set; }

		public QuantityType ProductUnitQuantity { get; set; }

		public QuantityType PerPackageUnitQuantity { get; set; }

		public MeasureType NetWeightMeasure { get; set; }

		public MeasureType GrossWeightMeasure { get; set; }

		public MeasureType TheoreticalWeightMeasure { get; set; }

		public QuantityType RequestedQuantity { get; set; }

		public QuantityType ReceivedQuantity { get; set; }

		[XmlElement("SpecifiedCIDeliveryAdjustment")]
		public CIDeliveryAdjustmentType[] SpecifiedCIDeliveryAdjustment { get; set; }

		[XmlElement("IncludedCISupplyChainPackaging")]
		public CISupplyChainPackagingType[] IncludedCISupplyChainPackaging { get; set; }

		public CISupplyChainConsignmentType RelatedCISupplyChainConsignment { get; set; }

		public CITradePartyType ShipToCITradeParty { get; set; }

		public CITradePartyType UltimateShipToCITradeParty { get; set; }

		public CITradePartyType ShipFromCITradeParty { get; set; }

		public CISupplyChainEventType ActualDespatchCISupplyChainEvent { get; set; }

		public CISupplyChainEventType ActualPickUpCISupplyChainEvent { get; set; }

		public CISupplyChainEventType RequestedDeliveryCISupplyChainEvent { get; set; }

		public CISupplyChainEventType ActualDeliveryCISupplyChainEvent { get; set; }

		public CISupplyChainEventType ActualReceiptCISupplyChainEvent { get; set; }

		public CIReferencedDocumentType DespatchAdviceReferencedCIReferencedDocument { get; set; }

		public CIReferencedDocumentType ReceivingAdviceReferencedCIReferencedDocument { get; set; }

		public CIReferencedDocumentType DeliveryNoteReferencedCIReferencedDocument { get; set; }

		[XmlElement("AdditionalReferencedCIReferencedDocument")]
		public CIReferencedDocumentType[] AdditionalReferencedCIReferencedDocument { get; set; }

		public CIReferencedDocumentType ConsumptionReportReferencedCIReferencedDocument { get; set; }
	}


	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CISupplyChainConsignment", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CISupplyChainConsignmentType
	{
		[XmlElement("AssociatedInvoiceAmount")]
		public AmountType[] AssociatedInvoiceAmount { get; set; }

		public AmountType DeclaredValueForCustomsAmount { get; set; }

		public AmountType TotalChargeAmount { get; set; }

		public QuantityType PackageQuantity { get; set; }

		[XmlElement("GrossWeightMeasure")]
		public WeightUnitMeasureType[] GrossWeightMeasure { get; set; }

		[XmlElement("NetWeightMeasure")]
		public WeightUnitMeasureType[] NetWeightMeasure { get; set; }

		[XmlElement("GrossVolumeMeasure")]
		public VolumeUnitMeasureType[] GrossVolumeMeasure { get; set; }

		public VolumeUnitMeasureType NetVolumeMeasure { get; set; }

		[XmlElement("ChargeableWeightMeasure")]
		public WeightUnitMeasureType[] ChargeableWeightMeasure { get; set; }

		public CITradePartyType ConsignorCITradeParty { get; set; }

		public CITradePartyType ConsigneeCITradeParty { get; set; }

		public CITradePartyType DeliveryCITradeParty { get; set; }

		[XmlElement("SpecifiedCILogisticsTransportMovement")]
		public CILogisticsTransportMovementType[] SpecifiedCILogisticsTransportMovement { get; set; }

		public CITradePartyType CustomsImportAgentCITradeParty { get; set; }

		public CITradePartyType CustomsExportAgentCITradeParty { get; set; }

		public CITradePartyType CarrierCITradeParty { get; set; }

		public CIReferencedDocumentType TransportContractCIReferencedDocument { get; set; }

		[XmlElement("UtilizedCILogisticsTransportEquipment")]
		public CILogisticsTransportEquipmentType[] UtilizedCILogisticsTransportEquipment { get; set; }

		public CITradePartyType FreightForwarderCITradeParty { get; set; }

		[XmlElement("GroupingCentreCITradeParty")]
		public CITradePartyType[] GroupingCentreCITradeParty { get; set; }

		[XmlElement("IncludedCISupplyChainConsignmentItem")]
		public CISupplyChainConsignmentItemType[] IncludedCISupplyChainConsignmentItem { get; set; }

		[XmlElement("AssociatedCIReferencedDocument")]
		public CIReferencedDocumentType[] AssociatedCIReferencedDocument { get; set; }

		public CITransportCargoInsuranceType ApplicableCITransportCargoInsurance { get; set; }

		public CICrossBorderCustomsValuationType ApplicableCICrossBorderCustomsValuation { get; set; }

		[XmlElement("ApplicableCICrossBorderRegulatoryProcedure")]
		public CICrossBorderRegulatoryProcedureType[] ApplicableCICrossBorderRegulatoryProcedure { get; set; }

		public CILogisticsLocationType TransitCILogisticsLocation { get; set; }
	}



	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27")]
	[XmlRoot("CILogisticsTransportMovement", Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:27", IsNullable = false)]
	public class CILogisticsTransportMovementType
	{
		public TransportModeCodeType ModeCode { get; set; }

		/// <remarks/>
		public TextType Mode { get; set; }

		/// <remarks/>
		public TransportMovementStageCodeType StageCode { get; set; }

		/// <remarks/>
		public CodeType ServiceCode { get; set; }

		/// <remarks/>
		public TextType Service { get; set; }

		/// <remarks/>
		public IDType ID { get; set; }

		/// <remarks/>
		public TextType Type { get; set; }

		/// <remarks/>
		public TextType Cycle { get; set; }

		/// <remarks/>
		public CILogisticsTransportMeansType UsedCILogisticsTransportMeans { get; set; }
	}



}

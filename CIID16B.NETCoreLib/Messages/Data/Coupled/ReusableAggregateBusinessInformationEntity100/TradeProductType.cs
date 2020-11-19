
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Coupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class TradeProductType
	{
		public IDType ID { get; set; }

		public IDType GlobalID { get; set; }

		public IDType SellerAssignedID { get; set; }

		public IDType BuyerAssignedID { get; set; }

		public IDType ManufacturerAssignedID { get; set; }

		[XmlElement("Name")]
		public TextType[] Name { get; set; }

		public TextType TradeName { get; set; }

		public TextType Description { get; set; }

		public CodeType TypeCode { get; set; }

		public MeasureType NetWeightMeasure { get; set; }

		public MeasureType GrossWeightMeasure { get; set; }

		[XmlElement("ProductGroupID")]
		public IDType[] ProductGroupID { get; set; }

		[XmlElement("EndItemTypeCode")]
		public CodeType[] EndItemTypeCode { get; set; }

		[XmlElement("EndItemName")]
		public TextType[] EndItemName { get; set; }

		public MeasureType AreaDensityMeasure { get; set; }

		[XmlElement("UseDescription")]
		public TextType[] UseDescription { get; set; }

		public TextType BrandName { get; set; }

		public TextType SubBrandName { get; set; }

		public MeasureType DrainedNetWeightMeasure { get; set; }

		public IndicatorType VariableMeasureIndicator { get; set; }

		public CodeType ColourCode { get; set; }

		[XmlElement("ColourDescription")]
		public TextType[] ColourDescription { get; set; }

		[XmlElement("Designation")]
		public TextType[] Designation { get; set; }

		public FormattedDateTimeType FormattedCancellationAnnouncedLaunchDateTime { get; set; }

		public FormattedDateTimeType FormattedLatestProductDataChangeDateTime { get; set; }

		[XmlElement("ApplicableProductCharacteristic")]
		public ProductCharacteristicType[] ApplicableProductCharacteristic { get; set; }

		[XmlElement("ApplicableMaterialGoodsCharacteristic")]
		public MaterialGoodsCharacteristicType[] ApplicableMaterialGoodsCharacteristic { get; set; }

		[XmlElement("DesignatedProductClassification")]
		public ProductClassificationType[] DesignatedProductClassification { get; set; }

		[XmlElement("IndividualTradeProductInstance")]
		public TradeProductInstanceType[] IndividualTradeProductInstance { get; set; }

		[XmlElement("CertificationEvidenceReferenceReferencedDocument")]
		public ReferencedDocumentType[] CertificationEvidenceReferenceReferencedDocument { get; set; }

		[XmlElement("InspectionReferenceReferencedDocument")]
		public ReferencedDocumentType[] InspectionReferenceReferencedDocument { get; set; }

		public TradeCountryType OriginTradeCountry { get; set; }

		public SpatialDimensionType LinearSpatialDimension { get; set; }

		public SpatialDimensionType MinimumLinearSpatialDimension { get; set; }

		public SpatialDimensionType MaximumLinearSpatialDimension { get; set; }

		public TradePartyType ManufacturerTradeParty { get; set; }

		[XmlElement("PresentationSpecifiedBinaryFile")]
		public SpecifiedBinaryFileType[] PresentationSpecifiedBinaryFile { get; set; }

		public ReferencedDocumentType MSDSReferenceReferencedDocument { get; set; }

		[XmlElement("AdditionalReferenceReferencedDocument")]
		public ReferencedDocumentType[] AdditionalReferenceReferencedDocument { get; set; }

		public TradePartyType LegalRightsOwnerTradeParty { get; set; }

		public TradePartyType BrandOwnerTradeParty { get; set; }

		[XmlElement("IncludedReferencedProduct")]
		public ReferencedProductType[] IncludedReferencedProduct { get; set; }

		[XmlElement("InformationNote")]
		public NoteType[] InformationNote { get; set; }
	}
}

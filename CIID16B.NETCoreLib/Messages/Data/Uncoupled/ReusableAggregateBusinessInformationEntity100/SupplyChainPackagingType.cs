
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Uncoupled;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class SupplyChainPackagingType
	{
		public PackageTypeCodeType TypeCode { get; set; }

		public TextType Type { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		public CodeType ConditionCode { get; set; }

		[XmlElement("DisposalMethodCode")]
		public CodeType[] DisposalMethodCode { get; set; }

		[XmlElement("WeightMeasure")]
		public MeasureType[] WeightMeasure { get; set; }

		public QuantityType MaximumStackabilityQuantity { get; set; }

		public MeasureType MaximumStackabilityWeightMeasure { get; set; }


		public QuantityType CustomerFacingTotalUnitQuantity { get; set; }

		public QuantityType LayerTotalUnitQuantity { get; set; }

		public QuantityType ContentLayerQuantity { get; set; }

		public SpatialDimensionType LinearSpatialDimension { get; set; }

		public SpatialDimensionType MinimumLinearSpatialDimension { get; set; }

		public SpatialDimensionType MaximumLinearSpatialDimension { get; set; }

		[XmlElement("SpecifiedPackagingMarking")]
		public PackagingMarkingType[] SpecifiedPackagingMarking { get; set; }

		[XmlElement("ApplicableMaterialGoodsCharacteristic")]
		public MaterialGoodsCharacteristicType[] ApplicableMaterialGoodsCharacteristic { get; set; }

		[XmlElement("ApplicableDisposalInstructions")]
		public DisposalInstructionsType[] ApplicableDisposalInstructions { get; set; }

		[XmlElement("ApplicableReturnableAssetInstructions")]
		public ReturnableAssetInstructionsType[] ApplicableReturnableAssetInstructions { get; set; }
	}
}


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
	public class LineTradeDeliveryType
	{
		public QuantityType RequestedQuantity { get; set; }

		public QuantityType ReceivedQuantity { get; set; }

		public QuantityType BilledQuantity { get; set; }

		public QuantityType ChargeFreeQuantity { get; set; }

		public QuantityType PackageQuantity { get; set; }

		public QuantityType ProductUnitQuantity { get; set; }

		public QuantityType PerPackageUnitQuantity { get; set; }

		public WeightUnitMeasureType NetWeightMeasure { get; set; }

		public WeightUnitMeasureType GrossWeightMeasure { get; set; }

		public WeightUnitMeasureType TheoreticalWeightMeasure { get; set; }

		public QuantityType DespatchedQuantity { get; set; }

		[XmlElement("SpecifiedDeliveryAdjustment")]
		public DeliveryAdjustmentType[] SpecifiedDeliveryAdjustment { get; set; }

		[XmlElement("IncludedSupplyChainPackaging")]
		public SupplyChainPackagingType[] IncludedSupplyChainPackaging { get; set; }

		public SupplyChainConsignmentType RelatedSupplyChainConsignment { get; set; }

		public TradePartyType ShipToTradeParty { get; set; }

		public TradePartyType UltimateShipToTradeParty { get; set; }

		public TradePartyType ShipFromTradeParty { get; set; }

		public SupplyChainEventType ActualDespatchSupplyChainEvent { get; set; }

		public SupplyChainEventType ActualPickUpSupplyChainEvent { get; set; }

		public SupplyChainEventType RequestedDeliverySupplyChainEvent { get; set; }

		public SupplyChainEventType ActualDeliverySupplyChainEvent { get; set; }

		public SupplyChainEventType ActualReceiptSupplyChainEvent { get; set; }

		[XmlElement("AdditionalReferencedDocument")]
		public ReferencedDocumentType[] AdditionalReferencedDocument { get; set; }

		public ReferencedDocumentType DespatchAdviceReferencedDocument { get; set; }

		public ReferencedDocumentType ReceivingAdviceReferencedDocument { get; set; }

		public ReferencedDocumentType DeliveryNoteReferencedDocument { get; set; }

		public ReferencedDocumentType ConsumptionReportReferencedDocument { get; set; }

		public ReferencedDocumentType PackingListReferencedDocument { get; set; }
	}
}

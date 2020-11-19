
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
    public class SupplyChainConsignmentType
    {
        [XmlElement("GrossWeightMeasure")]
        public WeightUnitMeasureType[] GrossWeightMeasure { get; set; }

        [XmlElement("NetWeightMeasure")]
        public MeasureType[] NetWeightMeasure { get; set; }

        [XmlElement("GrossVolumeMeasure")]
        public VolumeUnitMeasureType[] GrossVolumeMeasure { get; set; }

        public AmountType InsurancePremiumAmount { get; set; }

        [XmlElement("AssociatedInvoiceAmount")]
        public AmountType[] AssociatedInvoiceAmount { get; set; }

        public AmountType TotalChargeAmount { get; set; }

        public AmountType DeclaredValueForCustomsAmount { get; set; }

        public QuantityType PackageQuantity { get; set; }

        public TradePartyType ConsignorTradeParty { get; set; }

        public TradePartyType ConsigneeTradeParty { get; set; }

        public TradePartyType CarrierTradeParty { get; set; }

        public TradePartyType FreightForwarderTradeParty { get; set; }

        public TradePartyType DeliveryTradeParty { get; set; }

        public TradePartyType CustomsImportAgentTradeParty { get; set; }

        public TradePartyType CustomsExportAgentTradeParty { get; set; }

        [XmlElement("GroupingCentreTradeParty")]
        public TradePartyType[] GroupingCentreTradeParty { get; set; }

        public ReferencedDocumentType TransportContractReferencedDocument { get; set; }

        [XmlElement("AssociatedReferencedDocument")]
        public ReferencedDocumentType[] AssociatedReferencedDocument { get; set; }

        [XmlElement("IncludedSupplyChainConsignmentItem")]
        public SupplyChainConsignmentItemType[] IncludedSupplyChainConsignmentItem { get; set; }

        [XmlElement("UtilizedLogisticsTransportEquipment")]
        public LogisticsTransportEquipmentType[] UtilizedLogisticsTransportEquipment { get; set; }

        [XmlElement("SpecifiedLogisticsTransportMovement")]
        public LogisticsTransportMovementType[] SpecifiedLogisticsTransportMovement { get; set; }
    }
}

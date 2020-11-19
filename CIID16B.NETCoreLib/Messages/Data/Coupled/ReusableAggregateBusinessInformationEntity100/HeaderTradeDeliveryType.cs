
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
    public class HeaderTradeDeliveryType
    {
        public SupplyChainConsignmentType RelatedSupplyChainConsignment { get; set; }

        public TradePartyType ShipToTradeParty { get; set; }

        public TradePartyType UltimateShipToTradeParty { get; set; }

        public TradePartyType ShipFromTradeParty { get; set; }

        public SupplyChainEventType ActualDespatchSupplyChainEvent { get; set; }

        public SupplyChainEventType ActualPickUpSupplyChainEvent { get; set; }

        public SupplyChainEventType ActualDeliverySupplyChainEvent { get; set; }

        public SupplyChainEventType ActualReceiptSupplyChainEvent { get; set; }

        [XmlElement("AdditionalReferencedDocument")]
        public ReferencedDocumentType[] AdditionalReferencedDocument { get; set; }

        public ReferencedDocumentType DespatchAdviceReferencedDocument { get; set; }

        public ReferencedDocumentType ReceivingAdviceReferencedDocument { get; set; }

        public ReferencedDocumentType DeliveryNoteReferencedDocument { get; set; }

        public ReferencedDocumentType ConsumptionReportReferencedDocument { get; set; }

        [XmlElement("PreviousDeliverySupplyChainEvent")]
        public SupplyChainEventType[] PreviousDeliverySupplyChainEvent { get; set; }

        public ReferencedDocumentType PackingListReferencedDocument { get; set; }
    }
}

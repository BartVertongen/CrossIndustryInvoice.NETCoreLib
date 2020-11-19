
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
    public class FinancialAdjustmentType
    {
        public CodeType ReasonCode { get; set; }

        [XmlElement("Reason")]
        public TextType[] Reason { get; set; }

        [XmlElement("ActualAmount")]
        public AmountType[] ActualAmount { get; set; }

        public QuantityType ActualQuantity { get; set; }

        public DateTimeType ActualDateTime { get; set; }

        public TradePartyType ClaimRelatedTradeParty { get; set; }

        public ReferencedDocumentType InvoiceReferenceReferencedDocument { get; set; }
    }
}

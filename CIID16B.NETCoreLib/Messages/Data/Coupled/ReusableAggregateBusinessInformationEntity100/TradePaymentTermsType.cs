
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
    public class TradePaymentTermsType
    {
        public PaymentTermsIDType ID { get; set; }

        public PaymentTermsEventTimeReferenceCodeType FromEventCode { get; set; }

        public MeasureType SettlementPeriodMeasure { get; set; }

        [XmlElement("Description")]
        public TextType[] Description { get; set; }

        public DateTimeType DueDateDateTime { get; set; }

        public PaymentTermsTypeCodeType TypeCode { get; set; }

        public CodeType InstructionTypeCode { get; set; }

        [XmlElement("DirectDebitMandateID")]
        public IDType[] DirectDebitMandateID { get; set; }

        public PercentType PartialPaymentPercent { get; set; }

        [XmlElement("PaymentMeansID")]
        public IDType[] PaymentMeansID { get; set; }

        [XmlElement("PartialPaymentAmount")]
        public AmountType[] PartialPaymentAmount { get; set; }

        public TradePaymentPenaltyTermsType ApplicableTradePaymentPenaltyTerms { get; set; }

        public TradePaymentDiscountTermsType ApplicableTradePaymentDiscountTerms { get; set; }

        [XmlElement("PayeeTradeParty")]
        public TradePartyType[] PayeeTradeParty { get; set; }
    }
}

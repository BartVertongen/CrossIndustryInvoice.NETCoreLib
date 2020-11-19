
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;
using ciiValueType = VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100.ValueType;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Coupled
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
    public class TradeTaxType
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

        [XmlElement("LineTotalBasisAmount")]
        public AmountType[] LineTotalBasisAmount { get; set; }

        [XmlElement("AllowanceChargeBasisAmount")]
        public AmountType[] AllowanceChargeBasisAmount { get; set; }

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

        [XmlElement("SpecifiedTradeAccountingAccount")]
        public TradeAccountingAccountType[] SpecifiedTradeAccountingAccount { get; set; }

        public TradeCountryType ServiceSupplyTradeCountry { get; set; }

        public TradeAccountingAccountType BuyerRepayableTaxSpecifiedTradeAccountingAccount { get; set; }

        public TradeAccountingAccountType SellerPayableTaxSpecifiedTradeAccountingAccount { get; set; }

        public TradeAccountingAccountType SellerRefundableTaxSpecifiedTradeAccountingAccount { get; set; }

        public TradeAccountingAccountType BuyerDeductibleTaxSpecifiedTradeAccountingAccount { get; set; }

        public TradeAccountingAccountType BuyerNonDeductibleTaxSpecifiedTradeAccountingAccount { get; set; }

        [XmlElement("PlaceApplicableTradeLocation")]
        public TradeLocationType[] PlaceApplicableTradeLocation { get; set; }
    }
}

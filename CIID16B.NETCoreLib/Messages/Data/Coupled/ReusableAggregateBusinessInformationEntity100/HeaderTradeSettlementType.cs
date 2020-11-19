
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
    public class HeaderTradeSettlementType
    {
        [XmlElement("DuePayableAmount")]
        public AmountType[] DuePayableAmount { get; set; }

        [XmlElement("CreditorReferenceTypeCode")]
        public CodeType[] CreditorReferenceTypeCode { get; set; }

        [XmlElement("CreditorReferenceType")]
        public TextType[] CreditorReferenceType { get; set; }

        [XmlElement("CreditorReferenceIssuerID")]
        public IDType[] CreditorReferenceIssuerID { get; set; }

        public IDType CreditorReferenceID { get; set; }

        [XmlElement("PaymentReference")]
        public TextType[] PaymentReference { get; set; }

        public CurrencyCodeType TaxCurrencyCode { get; set; }

        public CurrencyCodeType InvoiceCurrencyCode { get; set; }

        public CurrencyCodeType PaymentCurrencyCode { get; set; }

        public TextType InvoiceIssuerReference { get; set; }

        public DateTimeType InvoiceDateTime { get; set; }

        [XmlElement("NextInvoiceDateTime")]
        public DateTimeType[] NextInvoiceDateTime { get; set; }

        public CodeType CreditReasonCode { get; set; }

        [XmlElement("CreditReason")]
        public TextType[] CreditReason { get; set; }

        public TradePartyType InvoicerTradeParty { get; set; }

        public TradePartyType InvoiceeTradeParty { get; set; }

        public TradePartyType PayeeTradeParty { get; set; }

        public TradePartyType PayerTradeParty { get; set; }

        public TradeCurrencyExchangeType TaxApplicableTradeCurrencyExchange { get; set; }

        public TradeCurrencyExchangeType InvoiceApplicableTradeCurrencyExchange { get; set; }

        public TradeCurrencyExchangeType PaymentApplicableTradeCurrencyExchange { get; set; }

        [XmlElement("SpecifiedTradeSettlementPaymentMeans")]
        public TradeSettlementPaymentMeansType[] SpecifiedTradeSettlementPaymentMeans { get; set; }

        [XmlElement("ApplicableTradeTax")]
        public TradeTaxType[] ApplicableTradeTax { get; set; }

        public SpecifiedPeriodType BillingSpecifiedPeriod { get; set; }

        [XmlElement("SpecifiedTradeAllowanceCharge")]
        public TradeAllowanceChargeType[] SpecifiedTradeAllowanceCharge { get; set; }

        [XmlElement("SubtotalCalculatedTradeTax")]
        public TradeTaxType[] SubtotalCalculatedTradeTax { get; set; }

        [XmlElement("SpecifiedLogisticsServiceCharge")]
        public LogisticsServiceChargeType[] SpecifiedLogisticsServiceCharge { get; set; }

        [XmlElement("SpecifiedTradePaymentTerms")]
        public TradePaymentTermsType[] SpecifiedTradePaymentTerms { get; set; }

        public TradeSettlementHeaderMonetarySummationType SpecifiedTradeSettlementHeaderMonetarySummation { get; set; }

        [XmlElement("SpecifiedFinancialAdjustment")]
        public FinancialAdjustmentType[] SpecifiedFinancialAdjustment { get; set; }

        public ReferencedDocumentType InvoiceReferencedDocument { get; set; }

        public ReferencedDocumentType ProFormaInvoiceReferencedDocument { get; set; }

        public ReferencedDocumentType LetterOfCreditReferencedDocument { get; set; }

        [XmlElement("FactoringAgreementReferencedDocument")]
        public ReferencedDocumentType[] FactoringAgreementReferencedDocument { get; set; }

        [XmlElement("FactoringListReferencedDocument")]
        public ReferencedDocumentType[] FactoringListReferencedDocument { get; set; }

        [XmlElement("PayableSpecifiedTradeAccountingAccount")]
        public TradeAccountingAccountType[] PayableSpecifiedTradeAccountingAccount { get; set; }

        [XmlElement("ReceivableSpecifiedTradeAccountingAccount")]
        public TradeAccountingAccountType[] ReceivableSpecifiedTradeAccountingAccount { get; set; }

        [XmlElement("PurchaseSpecifiedTradeAccountingAccount")]
        public TradeAccountingAccountType[] PurchaseSpecifiedTradeAccountingAccount { get; set; }

        [XmlElement("SalesSpecifiedTradeAccountingAccount")]
        public TradeAccountingAccountType[] SalesSpecifiedTradeAccountingAccount { get; set; }

        [XmlElement("SpecifiedTradeSettlementFinancialCard")]
        public TradeSettlementFinancialCardType[] SpecifiedTradeSettlementFinancialCard { get; set; }

        [XmlElement("SpecifiedAdvancePayment")]
        public AdvancePaymentType[] SpecifiedAdvancePayment { get; set; }

        public TradePartyType UltimatePayeeTradeParty { get; set; }
    }
}

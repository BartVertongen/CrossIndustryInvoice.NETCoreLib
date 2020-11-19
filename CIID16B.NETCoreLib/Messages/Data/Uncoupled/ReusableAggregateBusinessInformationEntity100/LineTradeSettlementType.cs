
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class LineTradeSettlementType
	{
		[XmlElement("PaymentReference")]
		public TextType[] PaymentReference { get; set; }

		public TextType InvoiceIssuerReference { get; set; }

		public AmountType TotalAdjustmentAmount { get; set; }

		public IndicatorType DiscountIndicator { get; set; }


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

		public TradeSettlementLineMonetarySummationType SpecifiedTradeSettlementLineMonetarySummation { get; set; }

		[XmlElement("SpecifiedFinancialAdjustment")]
		public FinancialAdjustmentType[] SpecifiedFinancialAdjustment { get; set; }

		public ReferencedDocumentType InvoiceReferencedDocument { get; set; }

		[XmlElement("AdditionalReferencedDocument")]
		public ReferencedDocumentType[] AdditionalReferencedDocument { get; set; }

		[XmlElement("PayableSpecifiedTradeAccountingAccount")]
		public TradeAccountingAccountType[] PayableSpecifiedTradeAccountingAccount { get; set; }

		[XmlElement("ReceivableSpecifiedTradeAccountingAccount")]
		public TradeAccountingAccountType[] ReceivableSpecifiedTradeAccountingAccount { get; set; }

		[XmlElement("PurchaseSpecifiedTradeAccountingAccount")]
		public TradeAccountingAccountType[] PurchaseSpecifiedTradeAccountingAccount { get; set; }

		[XmlElement("SalesSpecifiedTradeAccountingAccount")]
		public TradeAccountingAccountType[] SalesSpecifiedTradeAccountingAccount { get; set; }

		public TradeSettlementFinancialCardType SpecifiedTradeSettlementFinancialCard { get; set; }
	}
}

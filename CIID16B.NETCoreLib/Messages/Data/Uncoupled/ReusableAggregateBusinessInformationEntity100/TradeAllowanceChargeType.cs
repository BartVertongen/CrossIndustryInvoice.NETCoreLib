
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
	public class TradeAllowanceChargeType
	{
		public IndicatorType ChargeIndicator { get; set; }

		public IDType ID { get; set; }

		public NumericType SequenceNumeric { get; set; }

		public PercentType CalculationPercent { get; set; }

		public AmountType BasisAmount { get; set; }

		public QuantityType BasisQuantity { get; set; }

		public IndicatorType PrepaidIndicator { get; set; }

		[XmlElement("ActualAmount")]
		public AmountType[] ActualAmount { get; set; }

		public AmountType UnitBasisAmount { get; set; }

		public AllowanceChargeReasonCodeType ReasonCode { get; set; }

		public TextType Reason { get; set; }

		public AllowanceChargeIdentificationCodeType TypeCode { get; set; }

		[XmlElement("CategoryTradeTax")]
		public TradeTaxType[] CategoryTradeTax { get; set; }

		public TradeCurrencyExchangeType ActualTradeCurrencyExchange { get; set; }
	}
}

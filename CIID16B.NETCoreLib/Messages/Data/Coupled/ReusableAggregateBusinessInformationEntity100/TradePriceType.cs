
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
	public class TradePriceType
	{
		public PriceTypeCodeType TypeCode { get; set; }

		[XmlElement("ChargeAmount")]
		public AmountType[] ChargeAmount { get; set; }

		public QuantityType BasisQuantity { get; set; }

		public QuantityType MinimumQuantity { get; set; }

		public QuantityType MaximumQuantity { get; set; }

		[XmlElement("ChangeReason")]
		public TextType[] ChangeReason { get; set; }

		public NumericType OrderUnitConversionFactorNumeric { get; set; }

		[XmlElement("AppliedTradeAllowanceCharge")]
		public TradeAllowanceChargeType[] AppliedTradeAllowanceCharge { get; set; }

		public SpecifiedPeriodType ValiditySpecifiedPeriod { get; set; }

		[XmlElement("IncludedTradeTax")]
		public TradeTaxType[] IncludedTradeTax { get; set; }

		[XmlElement("DeliveryTradeLocation")]
		public TradeLocationType[] DeliveryTradeLocation { get; set; }

		[XmlElement("TradeComparisonReferencePrice")]
		public ReferencePriceType[] TradeComparisonReferencePrice { get; set; }

		[XmlElement("AssociatedReferencedDocument")]
		public ReferencedDocumentType[] AssociatedReferencedDocument { get; set; }
	}
}

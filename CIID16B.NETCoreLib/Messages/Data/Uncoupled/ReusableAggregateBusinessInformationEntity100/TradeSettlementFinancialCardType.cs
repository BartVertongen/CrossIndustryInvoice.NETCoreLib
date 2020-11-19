
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class TradeSettlementFinancialCardType
	{
		public IndicatorType MicrochipIndicator { get; set; }

		public IDType ID { get; set; }

		public CodeType TypeCode { get; set; }

		public TextType CardholderName { get; set; }

		public DateType ExpiryDate { get; set; }

		public NumericType VerificationNumeric { get; set; }

		public DateTimeType ValidFromDateTime { get; set; }


		[XmlElement("CreditLimitAmount")]
		public AmountType[] CreditLimitAmount { get; set; }

		[XmlElement("CreditAvailableAmount")]
		public AmountType[] CreditAvailableAmount { get; set; }

		public PercentType InterestRatePercent { get; set; }

		public TextType IssuingCompanyName { get; set; }

		public TextType Description { get; set; }
	}
}

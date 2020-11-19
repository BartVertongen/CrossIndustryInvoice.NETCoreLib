
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
	public class TradeSettlementPaymentMeansType
	{
		public PaymentMeansChannelCodeType PaymentChannelCode { get; set; }

		public PaymentMeansCodeType TypeCode { get; set; }

		public PaymentGuaranteeMeansCodeType GuaranteeMethodCode { get; set; }

		public CodeType PaymentMethodCode { get; set; }

		[XmlElement("Information")]
		public TextType[] Information { get; set; }

		[XmlElement("ID")]
		public IDType[] ID { get; set; }

		public TradeSettlementFinancialCardType ApplicableTradeSettlementFinancialCard { get; set; }

		public DebtorFinancialAccountType PayerPartyDebtorFinancialAccount { get; set; }

		public CreditorFinancialAccountType PayeePartyCreditorFinancialAccount { get; set; }

		public DebtorFinancialInstitutionType PayerSpecifiedDebtorFinancialInstitution { get; set; }

		public CreditorFinancialInstitutionType PayeeSpecifiedCreditorFinancialInstitution { get; set; }
	}
}

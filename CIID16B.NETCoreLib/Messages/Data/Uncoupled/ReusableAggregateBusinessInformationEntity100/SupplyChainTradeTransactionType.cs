
using System;
using System.Xml.Serialization;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class SupplyChainTradeTransactionType
	{
		[XmlElement("IncludedSupplyChainTradeLineItem")]
		public SupplyChainTradeLineItemType[] IncludedSupplyChainTradeLineItem { get; set; }

		public HeaderTradeAgreementType ApplicableHeaderTradeAgreement { get; set; }

		public HeaderTradeDeliveryType ApplicableHeaderTradeDelivery { get; set; }

		public HeaderTradeSettlementType ApplicableHeaderTradeSettlement { get; set; }
	}
}

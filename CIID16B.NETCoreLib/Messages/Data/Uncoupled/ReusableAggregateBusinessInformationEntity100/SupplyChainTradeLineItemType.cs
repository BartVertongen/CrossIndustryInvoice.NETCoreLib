
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class SupplyChainTradeLineItemType
	{
		public CodeType DescriptionCode { get; set; }

		public DocumentLineDocumentType AssociatedDocumentLineDocument { get; set; }

		public TradeProductType SpecifiedTradeProduct { get; set; }

		public LineTradeAgreementType SpecifiedLineTradeAgreement { get; set; }

		public LineTradeDeliveryType SpecifiedLineTradeDelivery { get; set; }

		public LineTradeSettlementType SpecifiedLineTradeSettlement { get; set; }

		[XmlElement("IncludedSubordinateTradeLineItem")]
		public SubordinateTradeLineItemType[] IncludedSubordinateTradeLineItem { get; set; }
	}
}

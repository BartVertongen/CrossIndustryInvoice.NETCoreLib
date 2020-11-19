
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class LineTradeAgreementType
	{
		public TextType BuyerReference { get; set; }

		[XmlElement("BuyerRequisitionerTradeParty")]
		public TradePartyType[] BuyerRequisitionerTradeParty { get; set; }

		public TradeDeliveryTermsType ApplicableTradeDeliveryTerms { get; set; }

		public ReferencedDocumentType SellerOrderReferencedDocument { get; set; }

		public ReferencedDocumentType BuyerOrderReferencedDocument { get; set; }

		public ReferencedDocumentType QuotationReferencedDocument { get; set; }

		public ReferencedDocumentType ContractReferencedDocument { get; set; }

		public ReferencedDocumentType DemandForecastReferencedDocument { get; set; }

		public ReferencedDocumentType PromotionalDealReferencedDocument { get; set; }

		[XmlElement("AdditionalReferencedDocument")]
		public ReferencedDocumentType[] AdditionalReferencedDocument { get; set; }

		public TradePriceType GrossPriceProductTradePrice { get; set; }

		public TradePriceType NetPriceProductTradePrice { get; set; }

		[XmlElement("RequisitionerReferencedDocument")]
		public ReferencedDocumentType[] RequisitionerReferencedDocument { get; set; }

		public TradePartyType ItemSellerTradeParty { get; set; }

		public TradePartyType ItemBuyerTradeParty { get; set; }

		public SpecifiedMarketplaceType IncludedSpecifiedMarketplace { get; set; }

		[XmlElement("UltimateCustomerOrderReferencedDocument")]
		public ReferencedDocumentType[] UltimateCustomerOrderReferencedDocument { get; set; }
	}
}


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
	public class HeaderTradeAgreementType
	{
		[XmlElement("Reference")]
		public TextType[] Reference { get; set; }

		public TextType BuyerReference { get; set; }

		public TradePartyType SellerTradeParty { get; set; }

		public TradePartyType BuyerTradeParty { get; set; }

		public TradePartyType SalesAgentTradeParty { get; set; }

		[XmlElement("BuyerRequisitionerTradeParty")]
		public TradePartyType[] BuyerRequisitionerTradeParty { get; set; }

		public TradePartyType BuyerAssignedAccountantTradeParty { get; set; }

		public TradePartyType SellerAssignedAccountantTradeParty { get; set; }

		public TradePartyType BuyerTaxRepresentativeTradeParty { get; set; }

		public TradePartyType SellerTaxRepresentativeTradeParty { get; set; }

		public TradePartyType ProductEndUserTradeParty { get; set; }

		public TradeDeliveryTermsType ApplicableTradeDeliveryTerms { get; set; }

		public ReferencedDocumentType SellerOrderReferencedDocument { get; set; }

		public ReferencedDocumentType BuyerOrderReferencedDocument { get; set; }

		public ReferencedDocumentType QuotationReferencedDocument { get; set; }

		public ReferencedDocumentType OrderResponseReferencedDocument { get; set; }

		public ReferencedDocumentType ContractReferencedDocument { get; set; }

		public ReferencedDocumentType DemandForecastReferencedDocument { get; set; }

		public ReferencedDocumentType SupplyInstructionReferencedDocument { get; set; }

		public ReferencedDocumentType PromotionalDealReferencedDocument { get; set; }

		public ReferencedDocumentType PriceListReferencedDocument { get; set; }

		[XmlElement("AdditionalReferencedDocument")]
		public ReferencedDocumentType[] AdditionalReferencedDocument { get; set; }

		[XmlElement("RequisitionerReferencedDocument")]
		public ReferencedDocumentType[] RequisitionerReferencedDocument { get; set; }

		public TradePartyType BuyerAgentTradeParty { get; set; }

		[XmlElement("PurchaseConditionsReferencedDocument")]
		public ReferencedDocumentType[] PurchaseConditionsReferencedDocument { get; set; }

		public ProcuringProjectType SpecifiedProcuringProject { get; set; }

		[XmlElement("UltimateCustomerOrderReferencedDocument")]
		public ReferencedDocumentType[] UltimateCustomerOrderReferencedDocument { get; set; }
	}
}


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
	public class SubordinateLineTradeAgreementType
	{
		public ReferencedDocumentType SellerOrderReferencedDocument { get; set; }

		public ReferencedDocumentType BuyerOrderReferencedDocument { get; set; }

		[XmlElement("AdditionalReferencedDocument")]
		public ReferencedDocumentType[] AdditionalReferencedDocument { get; set; }

		public TradePriceType GrossPriceProductTradePrice { get; set; }

		public TradePriceType NetPriceProductTradePrice { get; set; }
	}
}

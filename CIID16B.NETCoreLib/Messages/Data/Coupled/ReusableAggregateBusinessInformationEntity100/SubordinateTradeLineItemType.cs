
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
	public class SubordinateTradeLineItemType
	{
		[XmlElement("ID")]
		public IDType[] ID { get; set; }

		public ReferencedProductType SpecifiedReferencedProduct { get; set; }

		[XmlElement("ApplicableTradeProduct")]
		public TradeProductType[] ApplicableTradeProduct { get; set; }

		public SubordinateLineTradeAgreementType SpecifiedSubordinateLineTradeAgreement { get; set; }

		public SubordinateLineTradeDeliveryType SpecifiedSubordinateLineTradeDelivery { get; set; }

		public SubordinateLineTradeSettlementType SpecifiedSubordinateLineTradeSettlement { get; set; }
	}
}

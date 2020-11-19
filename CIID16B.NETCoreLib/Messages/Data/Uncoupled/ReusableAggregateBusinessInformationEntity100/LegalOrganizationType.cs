
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class LegalOrganizationType
	{
		public CodeType LegalClassificationCode { get; set; }

		public TextType Name { get; set; }

		public IDType ID { get; set; }

		public TextType TradingBusinessName { get; set; }

		public TradeAddressType PostalTradeAddress { get; set; }

		[XmlElement("AuthorizedLegalRegistration")]
		public LegalRegistrationType[] AuthorizedLegalRegistration { get; set; }
	}
}
